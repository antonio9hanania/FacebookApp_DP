using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Facebook;
using C17_Ex02_Antonio_205707284_Yarden_204718738;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public partial class MainForm : Form
    {
        private const string k_AppID = "1010717822363871"; // or to replace it with desig patter app id - 1450160541956417
        private User m_LoggedInUser;
        private UserBestLikers m_UserBestLikers;
        private LoginResult m_LogginResult;
        private AppSettings m_AppSettings;
        private PictureLoader m_PictureLoader = null;
        private string m_Items;
        private List<Thread> m_AppThreads = new List<Thread>();
        private Thread m_MainThread = Thread.CurrentThread;
        private BestFriendItemsFinderFacade m_BestFriendItemsFinderFacade;

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            m_AppSettings = AppSettings.LoadFromFile();
            checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            abortAllThreads();
            base.OnFormClosing(e);

            m_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if (m_LogginResult != null)
            {
                if (m_AppSettings.RememberUser)
                {
                    m_AppSettings.LastAccessToken = m_LogginResult.AccessToken;
                    m_AppSettings.SaveToFile();
                }
                else
                {
                    m_AppSettings.LastAccessToken = null;
                    m_AppSettings.RememberUser = false;
                    m_AppSettings.SaveToFile();
                    FacebookService.Logout(null);
                }
            }
        }

        protected override void OnLoad(EventArgs e) 
        {
            base.OnLoad(e);
            m_AppSettings = AppSettings.LoadFromFile();
            checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
            if (checkBoxRememberMe.Checked)
            {
                m_LogginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                m_LoggedInUser = m_LogginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.sweechButton();
                buttonsEnable(true);
                m_BestFriendItemsFinderFacade = new BestFriendItemsFinderFacade() { LoggedInUser = m_LoggedInUser };
                m_BestFriendItemsFinderFacade.m_OnBestFriendFind += setFriendDetails;
                m_BestFriendItemsFinderFacade.m_OnItemsFind += setBestFriendItems;
            }
        }

        private void loginAndInit()
        {
            try
            {
                m_LogginResult = FacebookService.Login(
                    k_AppID,
                   "public_profile",
                    "user_education_history",
                    "user_birthday",
                    "user_actions.video",
                    "user_actions.news",
                    "user_actions.music",
                    "user_actions.fitness",
                    "user_actions.books",
                    "user_about_me",
                    "user_friends",
                    "publish_actions",
                    "user_events",
                    "user_games_activity",
                    "user_hometown",
                    "user_likes",
                    "user_location",
                    "user_managed_groups",
                    "user_photos",
                    "user_posts",
                    "user_relationships",
                    "user_relationship_details",
                    "user_religion_politics",
                    "user_tagged_places",
                    "user_videos",
                    "user_website",
                    "user_work_history",
                    "read_custom_friendlists",
                    "read_page_mailboxes",
                    "manage_pages",
                    "publish_pages",
                    "publish_actions",
                    "rsvp_event");

                if (!string.IsNullOrEmpty(m_LogginResult.AccessToken))
                {
                    m_LoggedInUser = m_LogginResult.LoggedInUser;
                    fetchUserInfo();
                    m_Items = "events";
                    labelBestFriendJoinedItems.Text = "Best friend joined " + m_Items;
                    buttonsEnable(true);
                    m_BestFriendItemsFinderFacade = new BestFriendItemsFinderFacade() { LoggedInUser = m_LoggedInUser };

                    m_BestFriendItemsFinderFacade.m_OnBestFriendFind += setFriendDetails;
                    m_BestFriendItemsFinderFacade.m_OnItemsFind += setBestFriendItems;
                }
                else
                {
                    MessageBox.Show(m_LogginResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchUserInfo()
        {
            Thread getCoverImageThread = new Thread(getCoverImage);
            getCoverImageThread.Start();
            m_AppThreads.Add(getCoverImageThread);
            Thread getProfilePictureThread = new Thread(getProfilePicture);
            getProfilePictureThread.Start();
            m_AppThreads.Add(getProfilePictureThread);
            Thread getEventsThread = new Thread(getEvents);
            getEventsThread.Start();
            m_AppThreads.Add(getEventsThread);
            Thread getLikedPagesThread = new Thread(getLikedPages);
            getLikedPagesThread.Start();
            m_AppThreads.Add(getLikedPagesThread);
            Thread getFriendsThread = new Thread(getFriends);
            getFriendsThread.Start();
            m_AppThreads.Add(getFriendsThread);

            Text = "Logged in as " + m_LoggedInUser.Name;
        }

        private void setBestFriendItems(FacebookObjectCollection<IPictureAndNameOwner> i_items)
        {
            labelBestFriendJoinedItems.Invoke(new Action(() => labelBestFriendJoinedItems.Text = "Best friend joined " + m_Items));
            Thread BestFriendItemsThread = new Thread(() => { listBoxBestFriendItems.Invoke(new Action(() => IPictureAndNameOwnerBindingSource.DataSource = i_items)); });
            m_AppThreads.Add(BestFriendItemsThread);
            BestFriendItemsThread.Start();
        }

        private void setFriendDetails(User i_friend)
        {
            if (i_friend != null)
            {
                if (i_friend.PictureNormalURL != null)
                {
                    labelBestFriendName.Invoke(new Action(() => labelBestFriendName.Text = i_friend.Name));
                    Thread pictureBoxBestFriendThread = new Thread(() => { pictureBoxBestFriend.Invoke(new Action(() => pictureBoxBestFriend.Image = i_friend.ImageNormal)); });
                    pictureBoxBestFriendThread.Start();
                    m_AppThreads.Add(pictureBoxBestFriendThread);
                }
            }
            else
            {
                labelError.Text = "No Friends to retrieve :(";
            }
        }

        private void getBestFriendProfilePicture()
        {
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Image = m_LoggedInUser.ImageNormal));
        }

        private void buttonShowBestFriendItems_Click(object sender, EventArgs e)
        {
            if (radioButtonByJoinedPhotos.Checked)
            {
                m_BestFriendItemsFinderFacade.SetLookByJoinedPhotos();
            }
            else
            {
                m_BestFriendItemsFinderFacade.SetLookByLikes();
            }

            if (radioButtonShowEvents.Checked)
            {
                m_BestFriendItemsFinderFacade.SetJoinedEventsFinder();
            }
            else
            {
                m_BestFriendItemsFinderFacade.SetJoinedPagesFinder();
            }

            pictureBoxBestFriend.Image = null;
            labelBestFriendName.Text = string.Empty;
            listBoxBestFriendItems.ClearSelected();
            Thread bestFriendItemsFinderFacadeThread = new Thread(m_BestFriendItemsFinderFacade.GetResults);
            bestFriendItemsFinderFacadeThread.Start();
            m_AppThreads.Add(bestFriendItemsFinderFacadeThread);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                loginAndInit();
            }
            else
            {
                if (m_LoggedInUser != null)
                {
                    OnLogout();
                }
            }
        }

        private void getEvents()
        {
            listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = m_LoggedInUser.Events));
        }

        private void getFriends()
        {
            listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = m_LoggedInUser.Friends));
        }

        private void getLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = m_LoggedInUser.LikedPages));
        }

        private void getCoverImage()
        {
            pictureBoxCoverPhoto.Invoke(new Action(() => pictureBoxCoverPhoto.ImageLocation = m_LoggedInUser.Cover.SourceURL));
        }

        private void getProfilePicture()
        {
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Image = m_LoggedInUser.ImageNormal));
        }

        private void OnLogout()
        {
            abortAllThreads();
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.RememberUser = false;
            m_AppSettings.SaveToFile();
            m_LoggedInUser = null;
            FacebookService.Logout(null);
            clearProfile();
            clearBestFriendFinderTab();
            clearLikersTab();
            buttonsEnable(false);
            checkBoxRememberMe.Checked = false;
        }

        private void clearBestFriendFinderTab()
        {
            IPictureAndNameOwnerBindingSource.Clear();
            pictureBoxBestFriend.Image = null;
            labelBestFriendName.Text = string.Empty;
        }

        private void clearProfile()
        {
            userBindingSource.Clear();
            eventBindingSource.Clear();
            pageBindingSource.Clear();
            pictureBoxCoverPhoto.Image = null;
            pictureBoxProfilePicture.Image = null;
        }

        private void clearLikersTab()
        {
            userProxyBindingSource.Clear();
        }

        private void buttonsEnable(bool i_Enabled)
        {
            buttonShowBestFriendItems.Enabled = i_Enabled;
            buttonShowFriendsWhoLikeMe.Enabled = i_Enabled;
            checkBoxRememberMe.Enabled = i_Enabled;
            checkBoxRememberMe.Enabled = i_Enabled;
            buttonSetStatus.Enabled = i_Enabled;
            buttonLoadPicture.Enabled = i_Enabled;
            buttonPostPicture.Enabled = i_Enabled;
            buttonSetStatus.Enabled = i_Enabled;
            textBoxStatus.Enabled = i_Enabled;
            textBoxTitle.Enabled = i_Enabled;
        }

        private void clearAllListBoxsFromMainForm()
        {
            listBoxBestFriendItems.Items.Clear();
            listBoxEvents.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxLikedFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
        }

        private void clearAllPicBoxesFromMainForm()
        {
            pictureBoxCoverPhoto.Image = null;
            pictureBoxProfilePicture.Image = null;
            pictureBoxBestFriend.Image = null;
            pictureBoxLoadedPic.Image = null;
        }

        private void ShowfriendLikingLvlToListBox(List<KeyValuePair<User, int>> i_friendSortedByLikingLvl)
        {
            int rate = 1;
            List<UserProxy> proxyUsersList = new List<UserProxy>();
            foreach (KeyValuePair<User, int> friend in i_friendSortedByLikingLvl)
            {
                proxyUsersList.Add(new UserProxy { Rate = rate, User = friend.Key });
                rate++;
            }

            listBoxLikedFriends.Invoke(new Action(() => userProxyBindingSource.DataSource = proxyUsersList));
        }

        private void buttonShowFriendsWhoLikeMe_Click(object sender, EventArgs e)
        {
            m_UserBestLikers = new UserBestLikers(m_LoggedInUser);
            m_UserBestLikers.m_OnBestLikersCalc += ShowfriendLikingLvlToListBox;
            Thread UserBestLikersThread = new Thread(m_UserBestLikers.Run);
            m_AppThreads.Add(UserBestLikersThread);
            UserBestLikersThread.Start();
        }

        private void buttonSetStatus_Click_1(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                if (!string.IsNullOrEmpty(textBoxStatus.Text))
                {
                    Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Status Posted!");
                }
                else
                {
                    MessageBox.Show("Error, You should enter a status to post!");
                }
            }
            else
            {
                MessageBox.Show("Error, You should be logged in for posting!");
            }
        }
    
        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            if (m_PictureLoader == null)
            {
                m_PictureLoader = new PictureLoader();

                m_PictureLoader.m_OnFriendToGuess += previewPictureThatUploaded;
            }

            m_PictureLoader.LoadPictureFromWin();
        }

        private void previewPictureThatUploaded(Bitmap i_btmp)
        {
            pictureBoxLoadedPic.Image = i_btmp;
        }

        private void buttonPostPicture_Click(object sender, EventArgs e)
        {
            bool ableToPost = false;
            if (m_LoggedInUser != null)
            {
                if (m_PictureLoader != null)
                {
                    if (!string.IsNullOrEmpty(m_PictureLoader.imagePath))
                    {
                        m_LoggedInUser.PostPhoto(m_PictureLoader.imagePath, textBoxTitle.Text, null, null);
                        MessageBox.Show("Picture Posted!");
                    }
                    else
                    {
                        MessageBox.Show("Error, You shold load a picture to post!");
                    }
                }

                if (!ableToPost)
                {
                    MessageBox.Show("Error, You shold be looged in for posting!");
                }
            }
        }

        private void radioButtonShowEvents_CheckedChanged(object sender, EventArgs e)
        {
            m_Items = "events";
        }

        private void radioButtonShowLikedPages_CheckedChanged(object sender, EventArgs e)
        {
            m_Items = "liked pages";
        }

        private void abortAllThreads()
        {
            foreach (Thread currentThread in m_AppThreads)
            {
                if (currentThread.IsAlive)
                {
                    currentThread.Abort();
                }
            }
        }
    }
}