using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDSU_UCS_App.Classes;

namespace NDSU_UCS_App
{
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() != "")
            {
                MemberTransactionsForm.Members.AddMember(nameTextBox.Text.Trim());
                this.Close();
            }
            else
            {
                nameErrorLabel.Visible = true;
                nameTextBox.Text = "";
            }
        }
    }
}
