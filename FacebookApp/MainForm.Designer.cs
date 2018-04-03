using Facebook;
using C17_Ex02_Antonio_205707284_Yarden_204718738;
using FacebookWrapper;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label rateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageNormalPictureBox3 = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPostPicture = new System.Windows.Forms.Button();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxLoadedPic = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageNormalPictureBox2 = new System.Windows.Forms.PictureBox();
            this.userProxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.rateLabel1 = new System.Windows.Forms.Label();
            this.buttonShowFriendsWhoLikeMe = new System.Windows.Forms.Button();
            this.listBoxLikedFriends = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonByLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonByJoinedPhotos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonShowEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonShowLikedPages = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox4 = new System.Windows.Forms.PictureBox();
            this.IPictureAndNameOwnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBestFriendJoinedItems = new System.Windows.Forms.Label();
            this.pictureBoxBestFriend = new System.Windows.Forms.PictureBox();
            this.labelBestFriendName = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonShowBestFriendItems = new System.Windows.Forms.Button();
            this.listBoxBestFriendItems = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonLogin = new C17_Ex02_Antonio_205707284_Yarden_204718738.BlinkingLoginLogoutButton();
            imageNormalLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProxyBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPictureAndNameOwnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriend)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(331, 149);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(100, 17);
            imageNormalLabel.TabIndex = 5;
            imageNormalLabel.Text = "Profile Picture:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(331, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(331, 111);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(42, 17);
            rateLabel.TabIndex = 9;
            rateLabel.Text = "Rate:";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(71, 143);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(111, 97);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 10;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCoverPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(57, 15);
            this.pictureBoxCoverPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(853, 277);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 11;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(191, 252);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(117, 21);
            this.checkBoxRememberMe.TabIndex = 12;
            this.checkBoxRememberMe.Text = "remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.imageNormalPictureBox3);
            this.tabPage3.Controls.Add(this.imageNormalPictureBox1);
            this.tabPage3.Controls.Add(this.imageNormalPictureBox);
            this.tabPage3.Controls.Add(this.buttonPostPicture);
            this.tabPage3.Controls.Add(this.buttonSetStatus);
            this.tabPage3.Controls.Add(this.textBoxTitle);
            this.tabPage3.Controls.Add(this.textBoxStatus);
            this.tabPage3.Controls.Add(this.pictureBoxLoadedPic);
            this.tabPage3.Controls.Add(this.buttonLoadPicture);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.listBoxEvents);
            this.tabPage3.Controls.Add(this.listBoxLikedPages);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.listBoxFriends);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(859, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageNormalPictureBox3
            // 
            this.imageNormalPictureBox3.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox3.Location = new System.Drawing.Point(151, 114);
            this.imageNormalPictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox3.Name = "imageNormalPictureBox3";
            this.imageNormalPictureBox3.Size = new System.Drawing.Size(83, 84);
            this.imageNormalPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox3.TabIndex = 61;
            this.imageNormalPictureBox3.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(363, 114);
            this.imageNormalPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(88, 84);
            this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox1.TabIndex = 59;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(583, 118);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(81, 80);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 58;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // buttonPostPicture
            // 
            this.buttonPostPicture.Enabled = false;
            this.buttonPostPicture.Location = new System.Drawing.Point(707, 281);
            this.buttonPostPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostPicture.Name = "buttonPostPicture";
            this.buttonPostPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonPostPicture.TabIndex = 57;
            this.buttonPostPicture.Text = "Post";
            this.buttonPostPicture.UseVisualStyleBackColor = true;
            this.buttonPostPicture.Click += new System.EventHandler(this.buttonPostPicture_Click);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(609, 16);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(100, 31);
            this.buttonSetStatus.TabIndex = 49;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click_1);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(707, 238);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(111, 22);
            this.textBoxTitle.TabIndex = 56;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(241, 25);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(360, 22);
            this.textBoxStatus.TabIndex = 48;
            // 
            // pictureBoxLoadedPic
            // 
            this.pictureBoxLoadedPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxLoadedPic.Location = new System.Drawing.Point(707, 114);
            this.pictureBoxLoadedPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLoadedPic.Name = "pictureBoxLoadedPic";
            this.pictureBoxLoadedPic.Size = new System.Drawing.Size(111, 106);
            this.pictureBoxLoadedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadedPic.TabIndex = 55;
            this.pictureBoxLoadedPic.TabStop = false;
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Enabled = false;
            this.buttonLoadPicture.Location = new System.Drawing.Point(707, 82);
            this.buttonLoadPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(111, 23);
            this.buttonLoadPicture.TabIndex = 54;
            this.buttonLoadPicture.Text = "Load Picture";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Post Status:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(455, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Events";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(237, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liked Pages";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(459, 114);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(115, 212);
            this.listBoxEvents.TabIndex = 7;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(241, 112);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(113, 212);
            this.listBoxLikedPages.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(16, 112);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(125, 212);
            this.listBoxFriends.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(imageNormalLabel);
            this.tabPage2.Controls.Add(this.imageNormalPictureBox2);
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(this.nameLabel1);
            this.tabPage2.Controls.Add(rateLabel);
            this.tabPage2.Controls.Add(this.rateLabel1);
            this.tabPage2.Controls.Add(this.buttonShowFriendsWhoLikeMe);
            this.tabPage2.Controls.Add(this.listBoxLikedFriends);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(859, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friend\'s best likers finder";
            // 
            // imageNormalPictureBox2
            // 
            this.imageNormalPictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userProxyBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox2.Location = new System.Drawing.Point(439, 149);
            this.imageNormalPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageNormalPictureBox2.Name = "imageNormalPictureBox2";
            this.imageNormalPictureBox2.Size = new System.Drawing.Size(127, 116);
            this.imageNormalPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox2.TabIndex = 6;
            this.imageNormalPictureBox2.TabStop = false;
            // 
            // userProxyBindingSource
            // 
            this.userProxyBindingSource.DataSource = typeof(C17_Ex02_Antonio_205707284_Yarden_204718738.UserProxy);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProxyBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(436, 69);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(172, 23);
            this.nameLabel1.TabIndex = 8;
            this.nameLabel1.Text = "label4";
            // 
            // rateLabel1
            // 
            this.rateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProxyBindingSource, "Rate", true));
            this.rateLabel1.Location = new System.Drawing.Point(436, 111);
            this.rateLabel1.Name = "rateLabel1";
            this.rateLabel1.Size = new System.Drawing.Size(172, 23);
            this.rateLabel1.TabIndex = 10;
            this.rateLabel1.Text = "label4";
            // 
            // buttonShowFriendsWhoLikeMe
            // 
            this.buttonShowFriendsWhoLikeMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowFriendsWhoLikeMe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonShowFriendsWhoLikeMe.Enabled = false;
            this.buttonShowFriendsWhoLikeMe.Location = new System.Drawing.Point(9, 7);
            this.buttonShowFriendsWhoLikeMe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowFriendsWhoLikeMe.Name = "buttonShowFriendsWhoLikeMe";
            this.buttonShowFriendsWhoLikeMe.Size = new System.Drawing.Size(316, 53);
            this.buttonShowFriendsWhoLikeMe.TabIndex = 5;
            this.buttonShowFriendsWhoLikeMe.Text = "Show Friends Who Likes Me The Most";
            this.buttonShowFriendsWhoLikeMe.UseVisualStyleBackColor = false;
            this.buttonShowFriendsWhoLikeMe.Click += new System.EventHandler(this.buttonShowFriendsWhoLikeMe_Click);
            // 
            // listBoxLikedFriends
            // 
            this.listBoxLikedFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikedFriends.DataSource = this.userProxyBindingSource;
            this.listBoxLikedFriends.DisplayMember = "NameAndRate";
            this.listBoxLikedFriends.FormattingEnabled = true;
            this.listBoxLikedFriends.ItemHeight = 16;
            this.listBoxLikedFriends.Location = new System.Drawing.Point(8, 69);
            this.listBoxLikedFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLikedFriends.Name = "listBoxLikedFriends";
            this.listBoxLikedFriends.Size = new System.Drawing.Size(316, 196);
            this.listBoxLikedFriends.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.imageNormalPictureBox4);
            this.tabPage1.Controls.Add(this.labelBestFriendJoinedItems);
            this.tabPage1.Controls.Add(this.pictureBoxBestFriend);
            this.tabPage1.Controls.Add(this.labelBestFriendName);
            this.tabPage1.Controls.Add(this.labelError);
            this.tabPage1.Controls.Add(this.buttonShowBestFriendItems);
            this.tabPage1.Controls.Add(this.listBoxBestFriendItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(859, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Best friend joint events finder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonByLikes);
            this.panel2.Controls.Add(this.radioButtonByJoinedPhotos);
            this.panel2.Location = new System.Drawing.Point(180, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 68);
            this.panel2.TabIndex = 25;
            // 
            // radioButtonByLikes
            // 
            this.radioButtonByLikes.AutoSize = true;
            this.radioButtonByLikes.Location = new System.Drawing.Point(8, 32);
            this.radioButtonByLikes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonByLikes.Name = "radioButtonByLikes";
            this.radioButtonByLikes.Size = new System.Drawing.Size(76, 21);
            this.radioButtonByLikes.TabIndex = 22;
            this.radioButtonByLikes.Text = "by likes";
            this.radioButtonByLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonByJoinedPhotos
            // 
            this.radioButtonByJoinedPhotos.AutoSize = true;
            this.radioButtonByJoinedPhotos.Checked = true;
            this.radioButtonByJoinedPhotos.Location = new System.Drawing.Point(8, 4);
            this.radioButtonByJoinedPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonByJoinedPhotos.Name = "radioButtonByJoinedPhotos";
            this.radioButtonByJoinedPhotos.Size = new System.Drawing.Size(133, 21);
            this.radioButtonByJoinedPhotos.TabIndex = 23;
            this.radioButtonByJoinedPhotos.TabStop = true;
            this.radioButtonByJoinedPhotos.Text = "by joined photos";
            this.radioButtonByJoinedPhotos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonShowEvents);
            this.panel1.Controls.Add(this.radioButtonShowLikedPages);
            this.panel1.Location = new System.Drawing.Point(180, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 62);
            this.panel1.TabIndex = 24;
            // 
            // radioButtonShowEvents
            // 
            this.radioButtonShowEvents.AutoSize = true;
            this.radioButtonShowEvents.Checked = true;
            this.radioButtonShowEvents.Location = new System.Drawing.Point(8, 4);
            this.radioButtonShowEvents.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonShowEvents.Name = "radioButtonShowEvents";
            this.radioButtonShowEvents.Size = new System.Drawing.Size(109, 21);
            this.radioButtonShowEvents.TabIndex = 17;
            this.radioButtonShowEvents.TabStop = true;
            this.radioButtonShowEvents.Text = "Show events";
            this.radioButtonShowEvents.UseVisualStyleBackColor = true;
            this.radioButtonShowEvents.CheckedChanged += new System.EventHandler(this.radioButtonShowEvents_CheckedChanged);
            // 
            // radioButtonShowLikedPages
            // 
            this.radioButtonShowLikedPages.AutoSize = true;
            this.radioButtonShowLikedPages.Location = new System.Drawing.Point(8, 32);
            this.radioButtonShowLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonShowLikedPages.Name = "radioButtonShowLikedPages";
            this.radioButtonShowLikedPages.Size = new System.Drawing.Size(139, 21);
            this.radioButtonShowLikedPages.TabIndex = 18;
            this.radioButtonShowLikedPages.Text = "Show liked pages";
            this.radioButtonShowLikedPages.UseVisualStyleBackColor = true;
            this.radioButtonShowLikedPages.CheckedChanged += new System.EventHandler(this.radioButtonShowLikedPages_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "How to look for best friend:";
            // 
            // imageNormalPictureBox4
            // 
            this.imageNormalPictureBox4.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.IPictureAndNameOwnerBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox4.Location = new System.Drawing.Point(647, 69);
            this.imageNormalPictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox4.Name = "imageNormalPictureBox4";
            this.imageNormalPictureBox4.Size = new System.Drawing.Size(201, 139);
            this.imageNormalPictureBox4.TabIndex = 20;
            this.imageNormalPictureBox4.TabStop = false;
            // 
            // IPictureAndNameOwnerBindingSource
            // 
            this.IPictureAndNameOwnerBindingSource.DataSource = typeof(C17_Ex02_Antonio_205707284_Yarden_204718738.IPictureAndNameOwner);
            // 
            // labelBestFriendJoinedItems
            // 
            this.labelBestFriendJoinedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBestFriendJoinedItems.AutoSize = true;
            this.labelBestFriendJoinedItems.Location = new System.Drawing.Point(352, 26);
            this.labelBestFriendJoinedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBestFriendJoinedItems.Name = "labelBestFriendJoinedItems";
            this.labelBestFriendJoinedItems.Size = new System.Drawing.Size(164, 17);
            this.labelBestFriendJoinedItems.TabIndex = 15;
            this.labelBestFriendJoinedItems.Text = "Best friend joined events";
            // 
            // pictureBoxBestFriend
            // 
            this.pictureBoxBestFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBestFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxBestFriend.Location = new System.Drawing.Point(9, 69);
            this.pictureBoxBestFriend.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBestFriend.Name = "pictureBoxBestFriend";
            this.pictureBoxBestFriend.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxBestFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriend.TabIndex = 14;
            this.pictureBoxBestFriend.TabStop = false;
            // 
            // labelBestFriendName
            // 
            this.labelBestFriendName.AutoSize = true;
            this.labelBestFriendName.Location = new System.Drawing.Point(17, 236);
            this.labelBestFriendName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBestFriendName.Name = "labelBestFriendName";
            this.labelBestFriendName.Size = new System.Drawing.Size(0, 17);
            this.labelBestFriendName.TabIndex = 10;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(297, 247);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 9;
            // 
            // buttonShowBestFriendItems
            // 
            this.buttonShowBestFriendItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowBestFriendItems.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonShowBestFriendItems.Enabled = false;
            this.buttonShowBestFriendItems.Location = new System.Drawing.Point(9, 7);
            this.buttonShowBestFriendItems.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowBestFriendItems.Name = "buttonShowBestFriendItems";
            this.buttonShowBestFriendItems.Size = new System.Drawing.Size(316, 53);
            this.buttonShowBestFriendItems.TabIndex = 4;
            this.buttonShowBestFriendItems.Text = "Show Joint Events With My Best Friend";
            this.buttonShowBestFriendItems.UseVisualStyleBackColor = false;
            this.buttonShowBestFriendItems.Click += new System.EventHandler(this.buttonShowBestFriendItems_Click);
            // 
            // listBoxBestFriendItems
            // 
            this.listBoxBestFriendItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBestFriendItems.DataSource = this.IPictureAndNameOwnerBindingSource;
            this.listBoxBestFriendItems.DisplayMember = "Name";
            this.listBoxBestFriendItems.FormattingEnabled = true;
            this.listBoxBestFriendItems.ItemHeight = 16;
            this.listBoxBestFriendItems.Location = new System.Drawing.Point(355, 69);
            this.listBoxBestFriendItems.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxBestFriendItems.Name = "listBoxBestFriendItems";
            this.listBoxBestFriendItems.Size = new System.Drawing.Size(283, 180);
            this.listBoxBestFriendItems.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(57, 315);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 361);
            this.tabControl1.TabIndex = 13;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLogin.Location = new System.Drawing.Point(71, 247);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 28);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 727);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProxyBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPictureAndNameOwnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriend)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonPostPicture;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxLoadedPic;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonShowFriendsWhoLikeMe;
        private System.Windows.Forms.ListBox listBoxLikedFriends;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelBestFriendJoinedItems;
        private System.Windows.Forms.PictureBox pictureBoxBestFriend;
        private System.Windows.Forms.Label labelBestFriendName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonShowBestFriendItems;
        private System.Windows.Forms.ListBox listBoxBestFriendItems;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton radioButtonShowLikedPages;
        private System.Windows.Forms.RadioButton radioButtonShowEvents;
        private BlinkingLoginLogoutButton buttonLogin;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox3;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox4;
        private System.Windows.Forms.BindingSource IPictureAndNameOwnerBindingSource;
        private System.Windows.Forms.BindingSource userProxyBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label rateLabel1;
        private System.Windows.Forms.RadioButton radioButtonByJoinedPhotos;
        private System.Windows.Forms.RadioButton radioButtonByLikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
