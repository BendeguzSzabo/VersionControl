using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            labelFullName.Text = Resource.LastName;
            button1.Text = Resource.Add;
            button2.Text = Resource.Write;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.OpenFile());

                for (int i = 0; i < users.Count; i++)
                {
                    writer.Write(users[i].ID);
                    writer.Write(',');
                    writer.WriteLine(users[i].FullName);

                }

                writer.Dispose();

                writer.Close();

            }
        }
    }
}
