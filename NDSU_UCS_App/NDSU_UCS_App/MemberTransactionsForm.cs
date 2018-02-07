/*
 * Jordan Holleman (Treasurer) wrote this program to help keep track of transations made by members
 * of The University Chamber Singers of North Dakota State University .
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDSU_UCS_App.Control;
using NDSU_UCS_App.Classes;

namespace NDSU_UCS_App
{
    public partial class MemberTransactionsForm : Form
    {
        public static MembersList Members = new MembersList();
        public MemberTransactionsForm()
        {
            InitializeComponent();
        }
        
        private void updateFlowPanel ()
        {
            //disable buttons to prevent creating or deleting members too quickly
            addMemberButton.Enabled = false;
            removeMemberButton.Enabled = false;
            //order members by name to order MemberControls by name
            Members.Sort();
            //clear flowPanel to update all controls
            flowPanel.Controls.Clear();
            //for every member
            foreach (Member member in Members.MemberList)
            {
                //order transactions by date
                //this may be redundant because of the order transactions are added, but I am ok with a little more latency to be sure things are ordered.
                member.SortTransactions();
                //add a MemberControl for the current member with proper name and transaction history to the flowPanel
                flowPanel.Controls.Add(new MemberControl(member));
            }
            //re-enable buttons
            addMemberButton.Enabled = true;
            removeMemberButton.Enabled = true;
        }

        private void MemberTransactionsForm_Load(object sender, EventArgs e)
        {
            updateFlowPanel();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            new NewMemberForm().ShowDialog();
            Members.Save();
            updateFlowPanel();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            new DeleteMemberForm().ShowDialog();
            Members.Save();
            updateFlowPanel();
        }

        private void MemberTransactionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Members.Save();
        }
    }
}
