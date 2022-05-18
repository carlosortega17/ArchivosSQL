using System;
using System.Windows.Forms;
using System.IO;
using ArchivosDB.Models;

namespace ArchivosDB
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            tbxUsername.Text = "";
            tbxPassword.Text = "";
            tbxEmail.Text = "";
            tbxAvatar.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            byte[] avatar = File.ReadAllBytes(tbxAvatar.Text);
            User user = new User
                (
                    tbxUsername.Text,
                    tbxPassword.Text,
                    tbxEmail.Text,
                    avatar
                );
            MessageBox.Show("Success added user");
            Clear();
        }

        private void tbxAvatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Avatar";
            open.Filter = "Images PNG | *.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                tbxAvatar.Text = open.FileName;
            }
            else
            {
                MessageBox.Show("Error, no avatar selected");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            new FrmUsers().ShowDialog();
        }
    }
}
