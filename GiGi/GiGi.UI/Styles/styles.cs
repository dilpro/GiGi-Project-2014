using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GiGi.UI.Styles
{
    public class styles
    {
        public void textBoxGotFocus(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        public void textBoxLostFocus(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
    }
}
