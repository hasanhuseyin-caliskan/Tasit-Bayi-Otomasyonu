namespace OTOMOTIV_BAYI_OTOMASYONU
{
    partial class MotocyclesPage
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
            this.motoGoBackButton = new System.Windows.Forms.Button();
            this.motoAddButton = new System.Windows.Forms.Button();
            this.motoClearButton = new System.Windows.Forms.Button();
            this.motoDeleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.motoDateLbl = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.MaskedTextBox();
            this.listViewMotorcycles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.motoGoBackButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.motoAddButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.motoClearButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.motoDeleteButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // motoGoBackButton
            // 
            this.motoGoBackButton.BackColor = System.Drawing.Color.White;
            this.motoGoBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoGoBackButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.back;
            this.motoGoBackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motoGoBackButton.Location = new System.Drawing.Point(3, 3);
            this.motoGoBackButton.Name = "motoGoBackButton";
            this.motoGoBackButton.Size = new System.Drawing.Size(185, 53);
            this.motoGoBackButton.TabIndex = 0;
            this.motoGoBackButton.Text = "GERİ GİT";
            this.motoGoBackButton.UseVisualStyleBackColor = false;
            this.motoGoBackButton.Click += new System.EventHandler(this.motoGoBackButton_Click);
            // 
            // motoAddButton
            // 
            this.motoAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.motoAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoAddButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.add;
            this.motoAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motoAddButton.Location = new System.Drawing.Point(194, 3);
            this.motoAddButton.Name = "motoAddButton";
            this.motoAddButton.Size = new System.Drawing.Size(185, 53);
            this.motoAddButton.TabIndex = 1;
            this.motoAddButton.Text = "EKLE";
            this.motoAddButton.UseVisualStyleBackColor = false;
            this.motoAddButton.Click += new System.EventHandler(this.motoAddButton_Click);
            // 
            // motoClearButton
            // 
            this.motoClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.motoClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoClearButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.clear32;
            this.motoClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motoClearButton.Location = new System.Drawing.Point(385, 3);
            this.motoClearButton.Name = "motoClearButton";
            this.motoClearButton.Size = new System.Drawing.Size(185, 53);
            this.motoClearButton.TabIndex = 2;
            this.motoClearButton.Text = "TEMİZLE";
            this.motoClearButton.UseVisualStyleBackColor = false;
            this.motoClearButton.Click += new System.EventHandler(this.motoClearButton_Click);
            // 
            // motoDeleteButton
            // 
            this.motoDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.motoDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoDeleteButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.delete;
            this.motoDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motoDeleteButton.Location = new System.Drawing.Point(576, 3);
            this.motoDeleteButton.Name = "motoDeleteButton";
            this.motoDeleteButton.Size = new System.Drawing.Size(187, 53);
            this.motoDeleteButton.TabIndex = 3;
            this.motoDeleteButton.Text = "SİL";
            this.motoDeleteButton.UseVisualStyleBackColor = false;
            this.motoDeleteButton.Click += new System.EventHandler(this.motoDeleteButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.1746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.8254F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.motoDateLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMarka, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtModel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRenk, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHp, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.04124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.95876F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 97);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "TARİH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(106, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(196, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 66);
            this.label3.TabIndex = 2;
            this.label3.Text = "MARKA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(304, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 66);
            this.label4.TabIndex = 3;
            this.label4.Text = "MODEL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(490, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 66);
            this.label5.TabIndex = 4;
            this.label5.Text = "RENK";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(637, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 66);
            this.label6.TabIndex = 5;
            this.label6.Text = "HP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motoDateLbl
            // 
            this.motoDateLbl.AutoSize = true;
            this.motoDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoDateLbl.Location = new System.Drawing.Point(3, 66);
            this.motoDateLbl.Name = "motoDateLbl";
            this.motoDateLbl.Size = new System.Drawing.Size(97, 31);
            this.motoDateLbl.TabIndex = 6;
            this.motoDateLbl.Text = "-";
            this.motoDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(106, 69);
            this.txtID.Mask = "00000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 22);
            this.txtID.TabIndex = 7;
            this.txtID.ValidatingType = typeof(int);
            // 
            // txtMarka
            // 
            this.txtMarka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarka.Location = new System.Drawing.Point(196, 69);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(102, 22);
            this.txtMarka.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Location = new System.Drawing.Point(304, 69);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 22);
            this.txtModel.TabIndex = 9;
            // 
            // txtRenk
            // 
            this.txtRenk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRenk.Location = new System.Drawing.Point(490, 69);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(141, 22);
            this.txtRenk.TabIndex = 10;
            // 
            // txtHp
            // 
            this.txtHp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHp.Location = new System.Drawing.Point(637, 69);
            this.txtHp.Mask = "0000";
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(126, 22);
            this.txtHp.TabIndex = 11;
            this.txtHp.ValidatingType = typeof(int);
            // 
            // listViewMotorcycles
            // 
            this.listViewMotorcycles.CheckBoxes = true;
            this.listViewMotorcycles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMotorcycles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMotorcycles.HideSelection = false;
            this.listViewMotorcycles.Location = new System.Drawing.Point(0, 156);
            this.listViewMotorcycles.Name = "listViewMotorcycles";
            this.listViewMotorcycles.Size = new System.Drawing.Size(766, 134);
            this.listViewMotorcycles.TabIndex = 2;
            this.listViewMotorcycles.UseCompatibleStateImageBehavior = false;
            this.listViewMotorcycles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TARİH";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MARKA";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MODEL";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "RENK";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "HP";
            // 
            // MotocyclesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(766, 290);
            this.Controls.Add(this.listViewMotorcycles);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MotocyclesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBO - Motosikletler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MotocyclesPage_FormClosing);
            this.Load += new System.EventHandler(this.MotocyclesPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button motoGoBackButton;
        private System.Windows.Forms.Button motoAddButton;
        private System.Windows.Forms.Button motoClearButton;
        private System.Windows.Forms.Button motoDeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label motoDateLbl;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.MaskedTextBox txtHp;
        private System.Windows.Forms.ListView listViewMotorcycles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}