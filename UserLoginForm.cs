﻿using Microsoft.Win32;
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
        public static List<string> Creds = new List<string>();

        public UserLoginForm()
        {
            InitializeComponent();
            if (CheckOrCreateRememberMeRegistryKey())
            {
                RetrieveCreds();
                savecredchkbx.Checked = true;
                usernametxt.Text = String.IsNullOrEmpty(Creds[0]) ? " " : Creds[0];
                passwordtxt.Text = String.IsNullOrEmpty(Creds[1]) ? " " : Creds[1];
            }
        }


        public static List<string> RetrieveCreds()
        {
            string keyPath = @"Software\ISurveillance\Settings";
            string rememberMe = "RememberMe";

            // Open the registry key
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    // Check if the boolean value is "True"
                    if (key.GetValue(rememberMe)?.ToString() == "true")
                    {
                        string username = key.GetValue("Username")?.ToString();
                        string password = key.GetValue("Password")?.ToString();

                        // Add credentials to the list
                        Creds.Add(username);
                        Creds.Add(password);

                        return Creds;
                    }
                }
            }

            return Creds;
        }

        public static void StoreCreds(string username, string password)
        {
            string keyPath = @"Software\ISurveillance\Settings";

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
            {
                if (key != null)
                {
                    key.SetValue("Username", username);
                    key.SetValue("Password", password);
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(Variables.AuthenticateUser(usernametxt.Text.Trim(), passwordtxt.Text.Trim()) && Variables.UserPrivilege != "None")
            {
                if (savecredchkbx.Checked)
                {
                    StoreCreds(usernametxt.Text.Trim(), passwordtxt.Text.Trim());
                }
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                //errorhandlinglabel.Text = "Username or Password are incorrect";
                usernametxt.ForeColor = System.Drawing.Color.Red;
                passwordtxt.ForeColor = System.Drawing.Color.Red;
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
            if (tableLayoutPanel1.ColumnCount == 2)
                return;
            this.Width = this.Width * 2;

            // Increase the column count of the TableLayoutPanel
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // First column takes 50% of the space
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Second column takes 50% of the space

            // Create and configure the Signup GroupBox
            signupGroupBox = new GroupBox();
            signupGroupBox.Text = "Signup";
            signupGroupBox.Dock = DockStyle.Fill;

            // Create and show the CreateUser form inside the Signup GroupBox
            CreateUser createUser = new CreateUser(this);
            createUser.TopLevel = false;  // Make CreateUser a non-top-level form
            createUser.FormBorderStyle = FormBorderStyle.None; // Remove the border
            createUser.Dock = DockStyle.Fill; // Fill the GroupBox
            signupGroupBox.Controls.Add(createUser);
            createUser.Show();

            // Add the Signup GroupBox to the second cell of the TableLayoutPanel
            tableLayoutPanel1.Controls.Add(signupGroupBox, 1, 0);
        }

        private void signupGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
