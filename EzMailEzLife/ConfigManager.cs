using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EzMailEzLife
{
    public partial class ConfigManager : Form
    {
        public ConfigManager()
        {
            InitializeComponent();
        }

        private void ConfigManager_Load(object sender, EventArgs e)
        {
            userDataGrid.ColumnCount = 2;
            userDataGrid.Columns[0].Name = "Name";
            userDataGrid.Columns[1].Name = "Email";
            userDataGrid.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            userDataGrid.MultiSelect = false;
            foreach(var v in UserManager.Instance.GetAllApprovedUsers())
            {
                string[] row = { v.UserName, v.UserEmail };
                userDataGrid.Rows.Add(row);
            }
            userDataGrid.AutoSize = true;
            userDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { "Name Here", "email@address.here" };
            userDataGrid.Rows.Add(row);
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if(userDataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select just the one row to delete");
                return;
            }
            userDataGrid.Rows.Remove(userDataGrid.SelectedRows[0]);
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> kvpList = new List<KeyValuePair<string, string>>();
            for(int i=0; i< userDataGrid.Rows.Count-1; i++)
            {
                KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(userDataGrid.Rows[i].Cells[1].Value.ToString(), userDataGrid.Rows[i].Cells[0].Value.ToString());
                kvpList.Add(kvp);
            }
            UserManager.Instance.SetApprovedUsers(kvpList);
            Close();
        }
    }
}
