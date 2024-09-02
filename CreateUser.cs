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

namespace I_Surveillance
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        public List<string> GetLocalUsers()
        {
            List<string> userList = new List<string>();

            SelectQuery query = new SelectQuery("Win32_UserAccount", "LocalAccount=True");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (ManagementObject user in searcher.Get())
                {
                    userList.Add(user["Name"].ToString()); // Add the username to the list
                }
            }

            return userList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetLocalUsers();
        }
    }
}
