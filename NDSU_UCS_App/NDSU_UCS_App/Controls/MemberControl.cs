using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDSU_UCS_App.Classes;

namespace NDSU_UCS_App.Control
{
    public partial class MemberControl : UserControl
    {
        private int memberID;
        public MemberControl()
        {
            InitializeComponent();
        }
        public MemberControl(Member member)
        {
            InitializeComponent();

            //save memberID so we know who we're working with in the future
            this.memberID = member.ID;

            //set the nameLabel and balaceLabel
            nameLabel.Text = member.Name;
            balanceLabel.Text = string.Format("${0:0.00}", (((double)(member.CurrentBalance))/100) );
            //update balaceLabelColor
            if (member.CurrentBalance > 0)
                balanceLabel.BackColor = Color.Gold;
            else if (member.CurrentBalance < 0)
                balanceLabel.BackColor = Color.Red;
            else
                balanceLabel.BackColor = Color.Green;

            //not using updateGridView() here as member is already in this scope
            //for every transaction made by this member
            foreach (Transaction transaction in member.Transactions)
            {
                //display transaction in history
                    //create new row
                    DataGridViewRow newRow = new DataGridViewRow();
                    //add info to the new row
                    string[] values = new string[] { (((double) (transaction.Amount))/100).ToString(), transaction.Description, transaction.DateTime.ToString() };
                    newRow.CreateCells(dataGridView1, values);
                    //add row to gridView
                    dataGridView1.Rows.Add(newRow);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text != "")
            {
                //update the MembersList
                MemberTransactionsForm.Members.AddTransaction(memberID, (int)((amountNumericUpDown.Value) * 100), descriptionTextBox.Text);
                //save the transaction
                MemberTransactionsForm.Members.Save();
                //update the dataGridView
                updateGridView();
                //update the current balance
                updateBalance();
                //clear inputs
                descriptionTextBox.Text = "";
                amountNumericUpDown.Value = 0;
                descriptionErrorLabel.Visible = false;
            }
            else
            {
                //display error message
                descriptionErrorLabel.Visible = true;
            }
        }
        private void updateBalance()
        {

            //set the nameLabel and balaceLabel
            double memberBalance = (((double)(MemberTransactionsForm.Members.GetMember(memberID).CurrentBalance)) / 100);
            balanceLabel.Text = string.Format("${0:0.00}", memberBalance);
            //update balaceLabelColor
            if (memberBalance > 0)
            {
                balanceLabel.BackColor = Color.Gold;
            }
            else if (memberBalance == 0)
            {
                balanceLabel.BackColor = Color.Green;
            }
            else
            {
                balanceLabel.BackColor = Color.Red;
            }
        }
        private void updateGridView ()
        {
            //clear dataGridView to update all rows
            dataGridView1.Rows.Clear();
            //for every transaction made by this member
            foreach (Transaction transaction in MemberTransactionsForm.Members.GetMember(memberID).Transactions)
            {
                //display transaction in history
                //create new row
                DataGridViewRow newRow = new DataGridViewRow();
                //add info to the new row
                string[] values = new string[] { (((double)(transaction.Amount)) / 100).ToString(), transaction.Description, transaction.DateTime.ToString() };
                newRow.CreateCells(dataGridView1, values);
                //add row to gridView
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void MemberControl_Load(object sender, EventArgs e)
        {

        }
    }
}
