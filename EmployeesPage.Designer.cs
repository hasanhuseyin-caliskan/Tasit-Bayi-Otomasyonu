namespace OTOMOTIV_BAYI_OTOMASYONU
{
    partial class carIdBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eGoBackButton = new System.Windows.Forms.Button();
            this.eAddButton = new System.Windows.Forms.Button();
            this.eDeleteButton = new System.Windows.Forms.Button();
            this.eClearButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empTCBox = new System.Windows.Forms.MaskedTextBox();
            this.ageBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.eGoBackButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eAddButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.eDeleteButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.eClearButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // eGoBackButton
            // 
            this.eGoBackButton.BackColor = System.Drawing.Color.White;
            this.eGoBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eGoBackButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.back;
            this.eGoBackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eGoBackButton.Location = new System.Drawing.Point(3, 3);
            this.eGoBackButton.Name = "eGoBackButton";
            this.eGoBackButton.Size = new System.Drawing.Size(215, 69);
            this.eGoBackButton.TabIndex = 0;
            this.eGoBackButton.Text = "GERİ GİT";
            this.eGoBackButton.UseVisualStyleBackColor = false;
            this.eGoBackButton.Click += new System.EventHandler(this.eGoBackButton_Click);
            // 
            // eAddButton
            // 
            this.eAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eAddButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.add;
            this.eAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eAddButton.Location = new System.Drawing.Point(224, 3);
            this.eAddButton.Name = "eAddButton";
            this.eAddButton.Size = new System.Drawing.Size(215, 69);
            this.eAddButton.TabIndex = 1;
            this.eAddButton.Text = "EKLE";
            this.eAddButton.UseVisualStyleBackColor = false;
            this.eAddButton.Click += new System.EventHandler(this.eAddButton_Click);
            // 
            // eDeleteButton
            // 
            this.eDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eDeleteButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.delete;
            this.eDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eDeleteButton.Location = new System.Drawing.Point(666, 3);
            this.eDeleteButton.Name = "eDeleteButton";
            this.eDeleteButton.Size = new System.Drawing.Size(217, 69);
            this.eDeleteButton.TabIndex = 3;
            this.eDeleteButton.Text = "SİL";
            this.eDeleteButton.UseVisualStyleBackColor = false;
            this.eDeleteButton.Click += new System.EventHandler(this.eDeleteButton_Click);
            // 
            // eClearButton
            // 
            this.eClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eClearButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.clear32;
            this.eClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eClearButton.Location = new System.Drawing.Point(445, 3);
            this.eClearButton.Name = "eClearButton";
            this.eClearButton.Size = new System.Drawing.Size(215, 69);
            this.eClearButton.TabIndex = 2;
            this.eClearButton.Text = "TEMİZLE";
            this.eClearButton.UseVisualStyleBackColor = false;
            this.eClearButton.Click += new System.EventHandler(this.eClearButton_Click);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 218);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(886, 99);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "T.C. NO.";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYAD";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-MAİL";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "YAŞ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            this.columnHeader5.Width = 121;
            // 
            // nameBox
            // 
            this.nameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameBox.Location = new System.Drawing.Point(150, 72);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(141, 22);
            this.nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.surnameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.surnameBox.Location = new System.Drawing.Point(297, 72);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(141, 22);
            this.surnameBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailBox.Location = new System.Drawing.Point(444, 72);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(141, 22);
            this.emailBox.TabIndex = 4;
            // 
            // addressBox
            // 
            this.addressBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressBox.Location = new System.Drawing.Point(738, 72);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(145, 68);
            this.addressBox.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addressBox, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.emailBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.nameBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.surnameBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.empTCBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ageBox, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(886, 143);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. NO.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "EMAİL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "YAŞ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ADRES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empTCBox
            // 
            this.empTCBox.Location = new System.Drawing.Point(3, 72);
            this.empTCBox.Mask = "00000000000";
            this.empTCBox.Name = "empTCBox";
            this.empTCBox.Size = new System.Drawing.Size(141, 22);
            this.empTCBox.TabIndex = 7;
            this.empTCBox.ValidatingType = typeof(int);
            // 
            // ageBox
            // 
            this.ageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ageBox.Location = new System.Drawing.Point(591, 72);
            this.ageBox.Mask = "000";
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(141, 22);
            this.ageBox.TabIndex = 8;
            this.ageBox.ValidatingType = typeof(int);
            // 
            // carIdBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(886, 317);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "carIdBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBO - Personel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeesPage_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button eGoBackButton;
        private System.Windows.Forms.Button eAddButton;
        private System.Windows.Forms.Button eClearButton;
        private System.Windows.Forms.Button eDeleteButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox empTCBox;
        private System.Windows.Forms.MaskedTextBox ageBox;
    }
}