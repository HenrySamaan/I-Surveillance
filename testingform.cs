using Microsoft.Web.WebView2.WinForms;
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
    public partial class testingform : Form
    {
        public testingform()
        {
            InitializeComponent();

            WebView2 webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            // Add WebView2 to the form (or any container like GroupBox, Panel, etc.)
            cameraaccessgrpbx.Controls.Add(webView);  // Assuming you have a groupbox

            // Navigate to YouTube
            webView.Source = new Uri("https://www.youtube.com/watch?v=bvn_HYpix6s");



            //WebBrowser webBrowser = new WebBrowser
            //{
            //    Dock = DockStyle.Fill // Make the WebBrowser fill the GroupBox
            //};

            //// Add the WebBrowser to the GroupBox
            //cameraaccessgrpbx.Controls.Add(webBrowser);

            //// Load a webpage
            //webBrowser.Navigate("https://www.youtube.com/watch?v=bvn_HYpix6s");

        }

    }
}
