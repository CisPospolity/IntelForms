
namespace Intel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ALValue = new System.Windows.Forms.TextBox();
            this.BLValue = new System.Windows.Forms.TextBox();
            this.CLValue = new System.Windows.Forms.TextBox();
            this.DLValue = new System.Windows.Forms.TextBox();
            this.AHValue = new System.Windows.Forms.TextBox();
            this.BHValue = new System.Windows.Forms.TextBox();
            this.CHValue = new System.Windows.Forms.TextBox();
            this.DHValue = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.ALLabel = new System.Windows.Forms.Label();
            this.ALShow = new System.Windows.Forms.TextBox();
            this.AHShow = new System.Windows.Forms.TextBox();
            this.BHShow = new System.Windows.Forms.TextBox();
            this.BLShow = new System.Windows.Forms.TextBox();
            this.DHShow = new System.Windows.Forms.TextBox();
            this.DLShow = new System.Windows.Forms.TextBox();
            this.CHShow = new System.Windows.Forms.TextBox();
            this.CLShow = new System.Windows.Forms.TextBox();
            this.RegisterSelect1 = new System.Windows.Forms.ComboBox();
            this.RegisterSelect2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ALValue
            // 
            this.ALValue.Location = new System.Drawing.Point(29, 38);
            this.ALValue.MaxLength = 2;
            this.ALValue.Name = "ALValue";
            this.ALValue.Size = new System.Drawing.Size(100, 23);
            this.ALValue.TabIndex = 0;
            this.ALValue.TextChanged += new System.EventHandler(this.ALValue_TextChanged);
            // 
            // BLValue
            // 
            this.BLValue.Location = new System.Drawing.Point(29, 67);
            this.BLValue.MaxLength = 2;
            this.BLValue.Name = "BLValue";
            this.BLValue.Size = new System.Drawing.Size(100, 23);
            this.BLValue.TabIndex = 1;
            this.BLValue.TextChanged += new System.EventHandler(this.BLValue_TextChanged);
            // 
            // CLValue
            // 
            this.CLValue.Location = new System.Drawing.Point(29, 96);
            this.CLValue.MaxLength = 2;
            this.CLValue.Name = "CLValue";
            this.CLValue.Size = new System.Drawing.Size(100, 23);
            this.CLValue.TabIndex = 2;
            this.CLValue.TextChanged += new System.EventHandler(this.CLValue_TextChanged);
            // 
            // DLValue
            // 
            this.DLValue.Location = new System.Drawing.Point(29, 125);
            this.DLValue.MaxLength = 2;
            this.DLValue.Name = "DLValue";
            this.DLValue.Size = new System.Drawing.Size(100, 23);
            this.DLValue.TabIndex = 3;
            this.DLValue.TextChanged += new System.EventHandler(this.DLValue_TextChanged);
            // 
            // AHValue
            // 
            this.AHValue.Location = new System.Drawing.Point(188, 38);
            this.AHValue.MaxLength = 2;
            this.AHValue.Name = "AHValue";
            this.AHValue.Size = new System.Drawing.Size(100, 23);
            this.AHValue.TabIndex = 4;
            this.AHValue.TextChanged += new System.EventHandler(this.AHValue_TextChanged);
            // 
            // BHValue
            // 
            this.BHValue.Location = new System.Drawing.Point(188, 67);
            this.BHValue.MaxLength = 2;
            this.BHValue.Name = "BHValue";
            this.BHValue.Size = new System.Drawing.Size(100, 23);
            this.BHValue.TabIndex = 5;
            this.BHValue.TextChanged += new System.EventHandler(this.BHValue_TextChanged);
            // 
            // CHValue
            // 
            this.CHValue.Location = new System.Drawing.Point(188, 96);
            this.CHValue.MaxLength = 2;
            this.CHValue.Name = "CHValue";
            this.CHValue.Size = new System.Drawing.Size(100, 23);
            this.CHValue.TabIndex = 6;
            this.CHValue.TextChanged += new System.EventHandler(this.CHValue_TextChanged);
            // 
            // DHValue
            // 
            this.DHValue.Location = new System.Drawing.Point(188, 125);
            this.DHValue.MaxLength = 2;
            this.DHValue.Name = "DHValue";
            this.DHValue.Size = new System.Drawing.Size(100, 23);
            this.DHValue.TabIndex = 7;
            this.DHValue.TextChanged += new System.EventHandler(this.DHValue_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(103, 164);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 41);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ALLabel
            // 
            this.ALLabel.AutoSize = true;
            this.ALLabel.Location = new System.Drawing.Point(135, 41);
            this.ALLabel.Name = "ALLabel";
            this.ALLabel.Size = new System.Drawing.Size(21, 15);
            this.ALLabel.TabIndex = 9;
            this.ALLabel.Text = "AL";
            this.ALLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ALShow
            // 
            this.ALShow.Enabled = false;
            this.ALShow.Location = new System.Drawing.Point(680, 38);
            this.ALShow.MaxLength = 2;
            this.ALShow.Name = "ALShow";
            this.ALShow.Size = new System.Drawing.Size(100, 23);
            this.ALShow.TabIndex = 10;
            // 
            // AHShow
            // 
            this.AHShow.Enabled = false;
            this.AHShow.Location = new System.Drawing.Point(680, 67);
            this.AHShow.MaxLength = 2;
            this.AHShow.Name = "AHShow";
            this.AHShow.Size = new System.Drawing.Size(100, 23);
            this.AHShow.TabIndex = 11;
            // 
            // BHShow
            // 
            this.BHShow.Enabled = false;
            this.BHShow.Location = new System.Drawing.Point(680, 125);
            this.BHShow.MaxLength = 2;
            this.BHShow.Name = "BHShow";
            this.BHShow.Size = new System.Drawing.Size(100, 23);
            this.BHShow.TabIndex = 13;
            // 
            // BLShow
            // 
            this.BLShow.Enabled = false;
            this.BLShow.Location = new System.Drawing.Point(680, 96);
            this.BLShow.MaxLength = 2;
            this.BLShow.Name = "BLShow";
            this.BLShow.Size = new System.Drawing.Size(100, 23);
            this.BLShow.TabIndex = 12;
            // 
            // DHShow
            // 
            this.DHShow.Enabled = false;
            this.DHShow.Location = new System.Drawing.Point(680, 251);
            this.DHShow.MaxLength = 2;
            this.DHShow.Name = "DHShow";
            this.DHShow.Size = new System.Drawing.Size(100, 23);
            this.DHShow.TabIndex = 17;
            // 
            // DLShow
            // 
            this.DLShow.Enabled = false;
            this.DLShow.Location = new System.Drawing.Point(680, 222);
            this.DLShow.MaxLength = 2;
            this.DLShow.Name = "DLShow";
            this.DLShow.Size = new System.Drawing.Size(100, 23);
            this.DLShow.TabIndex = 16;
            // 
            // CHShow
            // 
            this.CHShow.Enabled = false;
            this.CHShow.Location = new System.Drawing.Point(680, 193);
            this.CHShow.MaxLength = 2;
            this.CHShow.Name = "CHShow";
            this.CHShow.Size = new System.Drawing.Size(100, 23);
            this.CHShow.TabIndex = 15;
            // 
            // CLShow
            // 
            this.CLShow.Enabled = false;
            this.CLShow.Location = new System.Drawing.Point(680, 164);
            this.CLShow.MaxLength = 2;
            this.CLShow.Name = "CLShow";
            this.CLShow.Size = new System.Drawing.Size(100, 23);
            this.CLShow.TabIndex = 14;
            // 
            // RegisterSelect1
            // 
            this.RegisterSelect1.FormattingEnabled = true;
            this.RegisterSelect1.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.RegisterSelect1.Location = new System.Drawing.Point(323, 96);
            this.RegisterSelect1.Name = "RegisterSelect1";
            this.RegisterSelect1.Size = new System.Drawing.Size(121, 23);
            this.RegisterSelect1.TabIndex = 18;
            // 
            // RegisterSelect2
            // 
            this.RegisterSelect2.FormattingEnabled = true;
            this.RegisterSelect2.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.RegisterSelect2.Location = new System.Drawing.Point(459, 96);
            this.RegisterSelect2.Name = "RegisterSelect2";
            this.RegisterSelect2.Size = new System.Drawing.Size(121, 23);
            this.RegisterSelect2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 472);
            this.Controls.Add(this.RegisterSelect2);
            this.Controls.Add(this.RegisterSelect1);
            this.Controls.Add(this.DHShow);
            this.Controls.Add(this.DLShow);
            this.Controls.Add(this.CHShow);
            this.Controls.Add(this.CLShow);
            this.Controls.Add(this.BHShow);
            this.Controls.Add(this.BLShow);
            this.Controls.Add(this.AHShow);
            this.Controls.Add(this.ALShow);
            this.Controls.Add(this.ALLabel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DHValue);
            this.Controls.Add(this.CHValue);
            this.Controls.Add(this.BHValue);
            this.Controls.Add(this.AHValue);
            this.Controls.Add(this.DLValue);
            this.Controls.Add(this.CLValue);
            this.Controls.Add(this.BLValue);
            this.Controls.Add(this.ALValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ALValue;
        private System.Windows.Forms.TextBox BLValue;
        private System.Windows.Forms.TextBox CLValue;
        private System.Windows.Forms.TextBox DLValue;
        private System.Windows.Forms.TextBox AHValue;
        private System.Windows.Forms.TextBox BHValue;
        private System.Windows.Forms.TextBox CHValue;
        private System.Windows.Forms.TextBox DHValue;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label ALLabel;
        private System.Windows.Forms.TextBox ALShow;
        private System.Windows.Forms.TextBox AHShow;
        private System.Windows.Forms.TextBox BHShow;
        private System.Windows.Forms.TextBox BLShow;
        private System.Windows.Forms.TextBox DHShow;
        private System.Windows.Forms.TextBox DLShow;
        private System.Windows.Forms.TextBox CHShow;
        private System.Windows.Forms.TextBox CLShow;
        private System.Windows.Forms.ComboBox RegisterSelect1;
        private System.Windows.Forms.ComboBox RegisterSelect2;
    }
}

