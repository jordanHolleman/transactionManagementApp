using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NDSU_UCS_App.Classes;

namespace NDSU_UCS_App
{
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {
            populateGridView();
        }

        private void populateGridView()
        {
            foreach (Member member in MemberTransactionsForm.Members.MemberList)
            {
                dataGridView1.Rows.Add(new string[] {member.ID.ToString(), member.Name, ((double)(member.CurrentBalance)/100).ToString()});
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && MessageBox.Show("Are you sure you want to delete the selected member and all their transactions? This can not be undone.", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //for every selected member to delete
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    //get the memberToBeDeleted's Id
                    int memberID = Convert.ToInt32(selectedRow.Cells[0].Value);

                    //delete the selected Member
                    MemberTransactionsForm.Members.DeleteMember(memberID);
                }
                //close the form
                this.Close();

                /*code if we want to keep it the page open, but I want to close it
                //make them select another member to be sure they are sure
                deleteButton.Enabled = false;
                //update GridView
                dataGridView1.Rows.Clear();
                populateGridView();
                */
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*not necisary, there will always be a row selected
            if (dataGridView1.SelectedRows.Count != 0)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
