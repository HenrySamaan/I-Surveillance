using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Runtime.InteropServices;
using System.DirectoryServices;
using Tulpep.ActiveDirectoryObjectPicker;

namespace I_Surveillance
{
    public partial class CreateUser : Form
    {
        private UserLoginForm _parentform;
        public CreateUser(UserLoginForm parentForm)
        {
            InitializeComponent();
            _parentform = parentForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectUser();
        }
        [DllImport("activeds.dll", CharSet = CharSet.Auto)]
        public static extern int ADsGetObject(string path, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppObject);

        public void SelectUser()
        {
            DirectoryObjectPickerDialog dialog = new DirectoryObjectPickerDialog();
            dialog.MultiSelect = false; // Set to true if multiple user selection is required

            // Set the default scope and filters
            dialog.TargetComputer = Environment.MachineName; // To browse users on the local machine
            dialog.AllowedObjectTypes = ObjectTypes.Users;
            dialog.DefaultObjectTypes = ObjectTypes.Users;
            dialog.InitializeLifetimeService();
            // Show the dialog and capture the result
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the selected user
                DirectoryObject[] selectedObjects = dialog.SelectedObjects;

                if (selectedObjects.Length > 0)
                {
                    // Display the selected user (e.g., in a label or textbox)
                    string selectedUser = selectedObjects[0].Name;
                    MessageBox.Show("Selected User: " + selectedUser);
                }
            }
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            ReverseChangesFromCreateUser();
            _parentform.Width /= 2;
        }
        private void ReverseChangesFromCreateUser()
        {
            // Make the Signup GroupBox invisible from the parent form
            if (_parentform.signupGroupBox != null)
            {
                _parentform.signupGroupBox.Visible = false; // Hide the Signup GroupBox
            }

            // Check if there are more than one column in the TableLayoutPanel in the parent form
            if (_parentform.tableLayoutPanel1.ColumnCount > 1)
            {
                // Remove the second column from the TableLayoutPanel in the parent form
                _parentform.tableLayoutPanel1.ColumnCount = 1; // Set column count back to 1

                // Clear all column styles and reset the first column to 100% width
                _parentform.tableLayoutPanel1.ColumnStyles.Clear();
                _parentform.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // First column takes up 100% of the space

                // Optionally, remove the Signup GroupBox from the TableLayoutPanel in the parent form
                if (_parentform.signupGroupBox != null)
                {
                    _parentform.tableLayoutPanel1.Controls.Remove(_parentform.signupGroupBox); // Remove the Signup GroupBox
                }
            }
        }
    }
}
