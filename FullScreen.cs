using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Surveillance
{
    public partial class FullScreen : Form
    {
        private MainForm _MAINFORM;
        public FullScreen(MainForm mainform)
        {
            InitializeComponent();
            _MAINFORM = mainform;
        }
        public void AddControlToPanel(Control control)
        {
            fullscreenpanel.Controls.Clear();
            fullscreenpanel.Controls.Add(control);
            control.Dock = DockStyle.Fill; 
        }

        private void FullScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            fullscreenpanel.Controls.Clear();
           // _MAINFORM.returnviews();
        }
        //public Panel MainPanel
        //{
        //    get { return fullscreenpanel; } 
        //}
    }
}
