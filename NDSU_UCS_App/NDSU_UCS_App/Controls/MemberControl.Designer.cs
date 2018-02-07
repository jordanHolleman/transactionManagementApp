namespace NDSU_UCS_App.Control
{
    partial class MemberControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.FinalDescriptionLabel = new System.Windows.Forms.Label();
            this.FinalAmountLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.FinalBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(150, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "nameLabel";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(172, 75);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(509, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // FinalDescriptionLabel
            // 
            this.FinalDescriptionLabel.AutoSize = true;
            this.FinalDescriptionLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalDescriptionLabel.Location = new System.Drawing.Point(168, 52);
            this.FinalDescriptionLabel.Name = "FinalDescriptionLabel";
            this.FinalDescriptionLabel.Size = new System.Drawing.Size(92, 20);
            this.FinalDescriptionLabel.TabIndex = 2;
            this.FinalDescriptionLabel.Text = "Description:";
            // 
            // FinalAmountLabel
            // 
            this.FinalAmountLabel.AutoSize = true;
            this.FinalAmountLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAmountLabel.Location = new System.Drawing.Point(42, 52);
            this.FinalAmountLabel.Name = "FinalAmountLabel";
            this.FinalAmountLabel.Size = new System.Drawing.Size(69, 20);
            this.FinalAmountLabel.TabIndex = 3;
            this.FinalAmountLabel.Text = "Amount:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(46, 75);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.amountNumericUpDown.TabIndex = 0;
            this.amountNumericUpDown.ThousandsSeparator = true;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(245, 126);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(224, 29);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply Transaction";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmountColumn,
            this.DescriptionColumn,
            this.DateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(687, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 165);
            this.dataGridView1.TabIndex = 7;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 300;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 125;
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.descriptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.descriptionErrorLabel.Location = new System.Drawing.Point(266, 103);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(184, 20);
            this.descriptionErrorLabel.TabIndex = 9;
            this.descriptionErrorLabel.Text = "A description is required.";
            this.descriptionErrorLabel.Visible = false;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(586, 23);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Padding = new System.Windows.Forms.Padding(10);
            this.balanceLabel.Size = new System.Drawing.Size(75, 42);
            this.balanceLabel.TabIndex = 10;
            this.balanceLabel.Text = "$null";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalBalanceLabel
            // 
            this.FinalBalanceLabel.AutoSize = true;
            this.FinalBalanceLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalBalanceLabel.Location = new System.Drawing.Point(582, 3);
            this.FinalBalanceLabel.Name = "FinalBalanceLabel";
            this.FinalBalanceLabel.Size = new System.Drawing.Size(69, 20);
            this.FinalBalanceLabel.TabIndex = 11;
            this.FinalBalanceLabel.Text = "Balance:";
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.FinalBalanceLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.FinalAmountLabel);
            this.Controls.Add(this.FinalDescriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(1333, 171);
            this.Load += new System.EventHandler(this.MemberControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label FinalDescriptionLabel;
        private System.Windows.Forms.Label FinalAmountLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label descriptionErrorLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label FinalBalanceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}
