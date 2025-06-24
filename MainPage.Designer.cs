namespace OTOMOTIV_BAYI_OTOMASYONU
{
    partial class MainPage
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
            this.employeesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.motocyclesButton = new System.Windows.Forms.Button();
            this.automobilesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesButton
            // 
            this.employeesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.employee100;
            this.employeesButton.Location = new System.Drawing.Point(373, 398);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(364, 390);
            this.employeesButton.TabIndex = 3;
            this.employeesButton.Text = "PERSONELLER";
            this.employeesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.customer100;
            this.customersButton.Location = new System.Drawing.Point(3, 398);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(364, 390);
            this.customersButton.TabIndex = 2;
            this.customersButton.Text = "MÜŞTERİLER";
            this.customersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // motocyclesButton
            // 
            this.motocyclesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motocyclesButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.motocycle100;
            this.motocyclesButton.Location = new System.Drawing.Point(373, 3);
            this.motocyclesButton.Name = "motocyclesButton";
            this.motocyclesButton.Size = new System.Drawing.Size(364, 389);
            this.motocyclesButton.TabIndex = 1;
            this.motocyclesButton.Text = "MOTOSİKLETLER";
            this.motocyclesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.motocyclesButton.UseVisualStyleBackColor = true;
            this.motocyclesButton.Click += new System.EventHandler(this.motocycles_Click);
            // 
            // automobilesButton
            // 
            this.automobilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.automobilesButton.Image = global::OTOMOTIV_BAYI_OTOMASYONU.Properties.Resources.car100;
            this.automobilesButton.Location = new System.Drawing.Point(3, 3);
            this.automobilesButton.Name = "automobilesButton";
            this.automobilesButton.Size = new System.Drawing.Size(364, 389);
            this.automobilesButton.TabIndex = 0;
            this.automobilesButton.Text = "OTOMOBİLLER";
            this.automobilesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.automobilesButton.UseVisualStyleBackColor = true;
            this.automobilesButton.Click += new System.EventHandler(this.automobiles_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.automobilesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.motocyclesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.customersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeesButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 791);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 791);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBO - Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button automobilesButton;
        private System.Windows.Forms.Button motocyclesButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button employeesButton;
    }
}