namespace FreshersManagementSystem_WindowsApplication
{
    partial class SaveFresher
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.QualificationBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MobileNumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressBox);
            this.groupBox1.Controls.Add(this.IdBox);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.QualificationBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MobileNumberBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(203, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(208, 22);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(198, 26);
            this.IdBox.TabIndex = 14;
            this.IdBox.Visible = false;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(206, 168);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 26);
            this.DateBox.TabIndex = 12;
            this.DateBox.Validating += new System.ComponentModel.CancelEventHandler(this.DateBox_Validating);
            // 
            // QualificationBox
            // 
            this.QualificationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualificationBox.FormattingEnabled = true;
            this.QualificationBox.Items.AddRange(new object[] {
            "BCA",
            "BSC",
            "B.Tech/B.E",
            "MCA",
            "MSC",
            "M.Tech/M.E"});
            this.QualificationBox.Location = new System.Drawing.Point(208, 213);
            this.QualificationBox.Name = "QualificationBox";
            this.QualificationBox.Size = new System.Drawing.Size(121, 28);
            this.QualificationBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // MobileNumberBox
            // 
            this.MobileNumberBox.Location = new System.Drawing.Point(208, 114);
            this.MobileNumberBox.Name = "MobileNumberBox";
            this.MobileNumberBox.Size = new System.Drawing.Size(198, 26);
            this.MobileNumberBox.TabIndex = 5;
            this.MobileNumberBox.Validating += new System.ComponentModel.CancelEventHandler(this.MobileNumberBox_Validating);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(208, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(198, 26);
            this.NameBox.TabIndex = 4;
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qualification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(374, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(206, 270);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(284, 100);
            this.AddressBox.TabIndex = 15;
            // 
            // SaveFresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaveFresher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Fresher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MobileNumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QualificationBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox AddressBox;
    }
}