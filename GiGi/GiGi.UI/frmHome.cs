using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiGi.UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            tmr1.Start();
            #region Cursor
            this.MouseMove += new MouseEventHandler(this.MousePos);
            this.pnl2.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile1.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile2.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile3.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile4.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile5.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile6.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile7.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile8.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile9.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile10.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile11.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile12.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile13.MouseMove += new MouseEventHandler(this.MousePos);
            this.btnTile14.MouseMove += new MouseEventHandler(this.MousePos);
            this.monthCalendar1.MouseMove += new MouseEventHandler(this.MousePos);
            this.lblTime.MouseMove += new MouseEventHandler(this.MousePos);
            #endregion
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            DateTime time=DateTime.Now;
           this.lblTime.Text=time.ToString("h:mm:ss tt");
        }

        private void MousePos(object sender, EventArgs e)
        {
            this.lblCursorPos.Text = "X: " + System.Windows.Forms.Cursor.Position.X.ToString() + ", Y: " + System.Windows.Forms.Cursor.Position.Y.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
