using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class BlinkingLoginLogoutButton : Button
    {
        private readonly System.Timers.Timer r_timer = new System.Timers.Timer();
        private string m_isBlinking = "T";

        public BlinkingLoginLogoutButton()
        {
            r_timer.Interval = 500;
            r_timer.Elapsed += blink;
            r_timer.Start();
            BackColor = System.Drawing.Color.Blue;
            Click += new System.EventHandler(stopOrBlink);
            Text = "Login";
        }

        private void stopOrBlink(object sender, EventArgs e)
        {
            sweechButton();
        }

        private void blink(object sender, EventArgs e)
        {
            if (m_isBlinking == "T")
            {
                if (BackColor == System.Drawing.Color.Blue)
                {
                    BackColor = System.Drawing.Color.LightBlue;
                }
                else
                {
                    BackColor = System.Drawing.Color.Blue;
                }
            }
        }

        public void sweechButton()
        {
            if (m_isBlinking == "T")
            {
                m_isBlinking = "F";
                Text = "Logout";
                BackColor = System.Drawing.Color.Red;
            }
            else
            {
                m_isBlinking = "T";
                Text = "Login";
                BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
