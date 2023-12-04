namespace BillWater
{
    partial class ManagerBill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbCustom = new ComboBox();
            lbYourname = new Label();
            lbPhoneNumber = new Label();
            tbYourname = new TextBox();
            tbPhonenumber = new TextBox();
            lbAmountofwaterthismonth = new Label();
            tbAmountofwaterthismonth = new TextBox();
            lbAmountofwaterlastmonth = new Label();
            tbAmountofwaterlastmonth = new TextBox();
            lvTable = new ListView();
            btAdd = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            lbAmountofwaterconsumed = new Label();
            lbTotalBill = new Label();
            lbCustomtype = new Label();
            btTotal = new Button();
            btArrange = new Button();
            btSearch = new Button();
            tbSearch = new TextBox();
            SuspendLayout();
            // 
            // cbCustom
            // 
            cbCustom.FormattingEnabled = true;
            cbCustom.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cbCustom.Location = new Point(804, 24);
            cbCustom.Name = "cbCustom";
            cbCustom.Size = new Size(166, 28);
            cbCustom.TabIndex = 0;
            // 
            // lbYourname
            // 
            lbYourname.AutoSize = true;
            lbYourname.Location = new Point(40, 34);
            lbYourname.Name = "lbYourname";
            lbYourname.Size = new Size(82, 20);
            lbYourname.TabIndex = 1;
            lbYourname.Text = "Your Name";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(366, 33);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(108, 20);
            lbPhoneNumber.TabIndex = 2;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // tbYourname
            // 
            tbYourname.Location = new Point(128, 26);
            tbYourname.Name = "tbYourname";
            tbYourname.Size = new Size(175, 27);
            tbYourname.TabIndex = 3;
            // 
            // tbPhonenumber
            // 
            tbPhonenumber.Location = new Point(480, 25);
            tbPhonenumber.Name = "tbPhonenumber";
            tbPhonenumber.Size = new Size(175, 27);
            tbPhonenumber.TabIndex = 4;
            tbPhonenumber.TextChanged += textBox2_TextChanged;
            // 
            // lbAmountofwaterthismonth
            // 
            lbAmountofwaterthismonth.AutoSize = true;
            lbAmountofwaterthismonth.Location = new Point(40, 117);
            lbAmountofwaterthismonth.Name = "lbAmountofwaterthismonth";
            lbAmountofwaterthismonth.Size = new Size(202, 20);
            lbAmountofwaterthismonth.TabIndex = 5;
            lbAmountofwaterthismonth.Text = "Amount Of Water This Month";
            // 
            // tbAmountofwaterthismonth
            // 
            tbAmountofwaterthismonth.Location = new Point(306, 110);
            tbAmountofwaterthismonth.Name = "tbAmountofwaterthismonth";
            tbAmountofwaterthismonth.Size = new Size(125, 27);
            tbAmountofwaterthismonth.TabIndex = 6;
            // 
            // lbAmountofwaterlastmonth
            // 
            lbAmountofwaterlastmonth.AutoSize = true;
            lbAmountofwaterlastmonth.Location = new Point(527, 117);
            lbAmountofwaterlastmonth.Name = "lbAmountofwaterlastmonth";
            lbAmountofwaterlastmonth.Size = new Size(195, 20);
            lbAmountofwaterlastmonth.TabIndex = 7;
            lbAmountofwaterlastmonth.Text = "Amount of water last month";
            lbAmountofwaterlastmonth.Click += label1_Click;
            // 
            // tbAmountofwaterlastmonth
            // 
            tbAmountofwaterlastmonth.Location = new Point(787, 110);
            tbAmountofwaterlastmonth.Name = "tbAmountofwaterlastmonth";
            tbAmountofwaterlastmonth.Size = new Size(125, 27);
            tbAmountofwaterlastmonth.TabIndex = 8;
            // 
            // lvTable
            // 
            lvTable.Location = new Point(4, 367);
            lvTable.Name = "lvTable";
            lvTable.Size = new Size(979, 201);
            lvTable.TabIndex = 9;
            lvTable.UseCompatibleStateImageBehavior = false;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(28, 301);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 10;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(178, 301);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 11;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(337, 301);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 12;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // lbAmountofwaterconsumed
            // 
            lbAmountofwaterconsumed.AutoSize = true;
            lbAmountofwaterconsumed.Location = new Point(219, 223);
            lbAmountofwaterconsumed.Name = "lbAmountofwaterconsumed";
            lbAmountofwaterconsumed.Size = new Size(212, 20);
            lbAmountofwaterconsumed.TabIndex = 13;
            lbAmountofwaterconsumed.Text = "Amount of water consumed : 0";
            // 
            // lbTotalBill
            // 
            lbTotalBill.AutoSize = true;
            lbTotalBill.Location = new Point(562, 223);
            lbTotalBill.Name = "lbTotalBill";
            lbTotalBill.Size = new Size(86, 20);
            lbTotalBill.TabIndex = 14;
            lbTotalBill.Text = "Total Bill : 0";
            // 
            // lbCustomtype
            // 
            lbCustomtype.AutoSize = true;
            lbCustomtype.Location = new Point(704, 32);
            lbCustomtype.Name = "lbCustomtype";
            lbCustomtype.Size = new Size(94, 20);
            lbCustomtype.TabIndex = 15;
            lbCustomtype.Text = "Custom Type";
            // 
            // btTotal
            // 
            btTotal.Location = new Point(527, 301);
            btTotal.Name = "btTotal";
            btTotal.Size = new Size(94, 29);
            btTotal.TabIndex = 16;
            btTotal.Text = "Total";
            btTotal.UseVisualStyleBackColor = true;
            btTotal.Click += btTotal_Click;
            // 
            // btArrange
            // 
            btArrange.Location = new Point(658, 301);
            btArrange.Name = "btArrange";
            btArrange.Size = new Size(94, 29);
            btArrange.TabIndex = 17;
            btArrange.Text = "Arrange";
            btArrange.UseVisualStyleBackColor = true;
            btArrange.Click += btArrange_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(768, 301);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 18;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(868, 303);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(91, 27);
            tbSearch.TabIndex = 19;
            // 
            // ManagerBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 570);
            Controls.Add(tbSearch);
            Controls.Add(btSearch);
            Controls.Add(btArrange);
            Controls.Add(btTotal);
            Controls.Add(lbCustomtype);
            Controls.Add(lbTotalBill);
            Controls.Add(lbAmountofwaterconsumed);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(lvTable);
            Controls.Add(tbAmountofwaterlastmonth);
            Controls.Add(lbAmountofwaterlastmonth);
            Controls.Add(tbAmountofwaterthismonth);
            Controls.Add(lbAmountofwaterthismonth);
            Controls.Add(tbPhonenumber);
            Controls.Add(tbYourname);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbYourname);
            Controls.Add(cbCustom);
            Name = "ManagerBill";
            Text = "ManagerBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCustom;
        private Label lbYourname;
        private Label lbPhoneNumber;
        private TextBox tbYourname;
        private TextBox tbPhonenumber;
        private Label lbAmountofwaterthismonth;
        private TextBox tbAmountofwaterthismonth;
        private Label lbAmountofwaterlastmonth;
        private TextBox tbAmountofwaterlastmonth;
        private ListView lvTable;
        private Button btAdd;
        private Button btUpdate;
        private Button btDelete;
        private Label lbAmountofwaterconsumed;
        private Label lbTotalBill;
        private Label lbCustomtype;
        private Button btTotal;
        private Button btArrange;
        private Button btSearch;
        private TextBox tbSearch;
    }
}