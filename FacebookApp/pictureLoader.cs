using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class PictureLoader
    {
        private Bitmap m_originalPicture;

        public event Action<Bitmap> m_OnFriendToGuess;

        public string imagePath { get; set; }

        public void LoadPictureFromWin()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);

                m_originalPicture = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                m_OnFriendToGuess.Invoke(m_originalPicture);
            }

            imagePath = ofd.FileName;
        }
    }
}
