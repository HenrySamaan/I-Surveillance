using Microsoft.Win32;
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
    public partial class UserLoginForm : Form
    {
        bool remembered = false;
        bool ischecked = false;
        public UserLoginForm()
        {
            InitializeComponent();
            savecredchkbx.Checked = CheckOrCreateRememberMeRegistryKey();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(Variables.AuthenticateUser(usernametxt.Text.Trim(), passwordtxt.Text.Trim()))
            {
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                errorhandlinglabel.Text = "Username or Password are incorrect";
            }
        }

        public bool CheckOrCreateRememberMeRegistryKey()
        {
            string keyPath = @"Software\ISurveillance\Settings";
            string valueName = "RememberMe";

            RegistryKey baseKey = Registry.CurrentUser;

            RegistryKey registryKey = baseKey.OpenSubKey(keyPath, writable: true);

            if (registryKey == null)
            {
                registryKey = baseKey.CreateSubKey(keyPath);
                registryKey.SetValue(valueName, "false", RegistryValueKind.String);
                return false;
            }
            else
            {
                object rememberMeValue = registryKey.GetValue(valueName);

                if (rememberMeValue == null)
                {
                    registryKey.SetValue(valueName, "false", RegistryValueKind.String);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void savecredchkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (savecredchkbx.Checked)
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\ISurveillance\Settings", true);
                registryKey?.SetValue("RememberMe", "true", RegistryValueKind.String);
                registryKey?.Close();
            }
            else
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\ISurveillance\Settings", true);
                registryKey?.SetValue("RememberMe", "false", RegistryValueKind.String);
                registryKey?.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
    }
}
