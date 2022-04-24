
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
            System.Windows.Forms.Label AHLabel;
            System.Windows.Forms.Label AHValueLabel;
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
            this.Move1To2 = new System.Windows.Forms.Button();
            this.Move2To1 = new System.Windows.Forms.Button();
            this.ExchangeRegisters = new System.Windows.Forms.Button();
            this.BLLabel = new System.Windows.Forms.Label();
            this.BHLabel = new System.Windows.Forms.Label();
            this.CLLabel = new System.Windows.Forms.Label();
            this.CHLabel = new System.Windows.Forms.Label();
            this.DLLabel = new System.Windows.Forms.Label();
            this.DHLabel = new System.Windows.Forms.Label();
            this.DLValueLabel = new System.Windows.Forms.Label();
            this.CLValueLabel = new System.Windows.Forms.Label();
            this.BLValueLabel = new System.Windows.Forms.Label();
            this.ALValueLabel = new System.Windows.Forms.Label();
            this.DHValueLabel = new System.Windows.Forms.Label();
            this.CHValueLabel = new System.Windows.Forms.Label();
            this.BHValueLabel = new System.Windows.Forms.Label();
            this.RegisterSelection1Label = new System.Windows.Forms.Label();
            this.RegisterSelection2Label = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SingleRegisterSelection = new System.Windows.Forms.ComboBox();
            this.SingleSelectionLabel = new System.Windows.Forms.Label();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.DecrementButton = new System.Windows.Forms.Button();
            this.NotButton = new System.Windows.Forms.Button();
            this.NegationButton = new System.Windows.Forms.Button();
            this.ANDButton = new System.Windows.Forms.Button();
            this.ORButton = new System.Windows.Forms.Button();
            this.XORButton = new System.Windows.Forms.Button();
            this.ADDButton = new System.Windows.Forms.Button();
            this.SUBButton = new System.Windows.Forms.Button();
            AHLabel = new System.Windows.Forms.Label();
            AHValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AHLabel
            // 
            AHLabel.AutoSize = true;
            AHLabel.Location = new System.Drawing.Point(289, 162);
            AHLabel.Name = "AHLabel";
            AHLabel.Size = new System.Drawing.Size(24, 15);
            AHLabel.TabIndex = 23;
            AHLabel.Text = "AH";
            AHLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AHValueLabel
            // 
            AHValueLabel.AutoSize = true;
            AHValueLabel.Location = new System.Drawing.Point(882, 133);
            AHValueLabel.Name = "AHValueLabel";
            AHValueLabel.Size = new System.Drawing.Size(24, 15);
            AHValueLabel.TabIndex = 34;
            AHValueLabel.Text = "AH";
            // 
            // ALValue
            // 
            this.ALValue.Location = new System.Drawing.Point(23, 159);
            this.ALValue.MaxLength = 2;
            this.ALValue.Name = "ALValue";
            this.ALValue.Size = new System.Drawing.Size(100, 23);
            this.ALValue.TabIndex = 0;
            this.ALValue.TextChanged += new System.EventHandler(this.ALValue_TextChanged);
            // 
            // BLValue
            // 
            this.BLValue.Location = new System.Drawing.Point(23, 188);
            this.BLValue.MaxLength = 2;
            this.BLValue.Name = "BLValue";
            this.BLValue.Size = new System.Drawing.Size(100, 23);
            this.BLValue.TabIndex = 1;
            this.BLValue.TextChanged += new System.EventHandler(this.BLValue_TextChanged);
            // 
            // CLValue
            // 
            this.CLValue.Location = new System.Drawing.Point(23, 217);
            this.CLValue.MaxLength = 2;
            this.CLValue.Name = "CLValue";
            this.CLValue.Size = new System.Drawing.Size(100, 23);
            this.CLValue.TabIndex = 2;
            this.CLValue.TextChanged += new System.EventHandler(this.CLValue_TextChanged);
            // 
            // DLValue
            // 
            this.DLValue.Location = new System.Drawing.Point(23, 246);
            this.DLValue.MaxLength = 2;
            this.DLValue.Name = "DLValue";
            this.DLValue.Size = new System.Drawing.Size(100, 23);
            this.DLValue.TabIndex = 3;
            this.DLValue.TextChanged += new System.EventHandler(this.DLValue_TextChanged);
            // 
            // AHValue
            // 
            this.AHValue.Location = new System.Drawing.Point(182, 159);
            this.AHValue.MaxLength = 2;
            this.AHValue.Name = "AHValue";
            this.AHValue.Size = new System.Drawing.Size(100, 23);
            this.AHValue.TabIndex = 4;
            this.AHValue.TextChanged += new System.EventHandler(this.AHValue_TextChanged);
            // 
            // BHValue
            // 
            this.BHValue.Location = new System.Drawing.Point(182, 188);
            this.BHValue.MaxLength = 2;
            this.BHValue.Name = "BHValue";
            this.BHValue.Size = new System.Drawing.Size(100, 23);
            this.BHValue.TabIndex = 5;
            this.BHValue.TextChanged += new System.EventHandler(this.BHValue_TextChanged);
            // 
            // CHValue
            // 
            this.CHValue.Location = new System.Drawing.Point(182, 217);
            this.CHValue.MaxLength = 2;
            this.CHValue.Name = "CHValue";
            this.CHValue.Size = new System.Drawing.Size(100, 23);
            this.CHValue.TabIndex = 6;
            this.CHValue.TextChanged += new System.EventHandler(this.CHValue_TextChanged);
            // 
            // DHValue
            // 
            this.DHValue.Location = new System.Drawing.Point(182, 246);
            this.DHValue.MaxLength = 2;
            this.DHValue.Name = "DHValue";
            this.DHValue.Size = new System.Drawing.Size(100, 23);
            this.DHValue.TabIndex = 7;
            this.DHValue.TextChanged += new System.EventHandler(this.DHValue_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(97, 285);
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
            this.ALLabel.Location = new System.Drawing.Point(129, 162);
            this.ALLabel.Name = "ALLabel";
            this.ALLabel.Size = new System.Drawing.Size(21, 15);
            this.ALLabel.TabIndex = 9;
            this.ALLabel.Text = "AL";
            this.ALLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ALShow
            // 
            this.ALShow.Enabled = false;
            this.ALShow.Location = new System.Drawing.Point(765, 101);
            this.ALShow.MaxLength = 2;
            this.ALShow.Name = "ALShow";
            this.ALShow.Size = new System.Drawing.Size(100, 23);
            this.ALShow.TabIndex = 10;
            // 
            // AHShow
            // 
            this.AHShow.Enabled = false;
            this.AHShow.Location = new System.Drawing.Point(765, 130);
            this.AHShow.MaxLength = 2;
            this.AHShow.Name = "AHShow";
            this.AHShow.Size = new System.Drawing.Size(100, 23);
            this.AHShow.TabIndex = 11;
            // 
            // BHShow
            // 
            this.BHShow.Enabled = false;
            this.BHShow.Location = new System.Drawing.Point(765, 188);
            this.BHShow.MaxLength = 2;
            this.BHShow.Name = "BHShow";
            this.BHShow.Size = new System.Drawing.Size(100, 23);
            this.BHShow.TabIndex = 13;
            // 
            // BLShow
            // 
            this.BLShow.Enabled = false;
            this.BLShow.Location = new System.Drawing.Point(765, 159);
            this.BLShow.MaxLength = 2;
            this.BLShow.Name = "BLShow";
            this.BLShow.Size = new System.Drawing.Size(100, 23);
            this.BLShow.TabIndex = 12;
            // 
            // DHShow
            // 
            this.DHShow.Enabled = false;
            this.DHShow.Location = new System.Drawing.Point(765, 314);
            this.DHShow.MaxLength = 2;
            this.DHShow.Name = "DHShow";
            this.DHShow.Size = new System.Drawing.Size(100, 23);
            this.DHShow.TabIndex = 17;
            // 
            // DLShow
            // 
            this.DLShow.Enabled = false;
            this.DLShow.Location = new System.Drawing.Point(765, 285);
            this.DLShow.MaxLength = 2;
            this.DLShow.Name = "DLShow";
            this.DLShow.Size = new System.Drawing.Size(100, 23);
            this.DLShow.TabIndex = 16;
            // 
            // CHShow
            // 
            this.CHShow.Enabled = false;
            this.CHShow.Location = new System.Drawing.Point(765, 256);
            this.CHShow.MaxLength = 2;
            this.CHShow.Name = "CHShow";
            this.CHShow.Size = new System.Drawing.Size(100, 23);
            this.CHShow.TabIndex = 15;
            // 
            // CLShow
            // 
            this.CLShow.Enabled = false;
            this.CLShow.Location = new System.Drawing.Point(765, 227);
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
            this.RegisterSelect1.Location = new System.Drawing.Point(376, 248);
            this.RegisterSelect1.Name = "RegisterSelect1";
            this.RegisterSelect1.Size = new System.Drawing.Size(121, 23);
            this.RegisterSelect1.TabIndex = 18;
            this.RegisterSelect1.SelectedIndexChanged += new System.EventHandler(this.RegisterSelect1_SelectedIndexChanged);
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
            this.RegisterSelect2.Location = new System.Drawing.Point(512, 248);
            this.RegisterSelect2.Name = "RegisterSelect2";
            this.RegisterSelect2.Size = new System.Drawing.Size(121, 23);
            this.RegisterSelect2.TabIndex = 19;
            this.RegisterSelect2.SelectedIndexChanged += new System.EventHandler(this.RegisterSelect2_SelectedIndexChanged);
            // 
            // Move1To2
            // 
            this.Move1To2.Location = new System.Drawing.Point(376, 280);
            this.Move1To2.Name = "Move1To2";
            this.Move1To2.Size = new System.Drawing.Size(108, 50);
            this.Move1To2.TabIndex = 20;
            this.Move1To2.Text = "Move 1 to 2";
            this.Move1To2.UseVisualStyleBackColor = true;
            this.Move1To2.Click += new System.EventHandler(this.Move1To2_Click);
            // 
            // Move2To1
            // 
            this.Move2To1.Location = new System.Drawing.Point(376, 343);
            this.Move2To1.Name = "Move2To1";
            this.Move2To1.Size = new System.Drawing.Size(108, 50);
            this.Move2To1.TabIndex = 21;
            this.Move2To1.Text = "Move 2 to 1";
            this.Move2To1.UseVisualStyleBackColor = true;
            this.Move2To1.Click += new System.EventHandler(this.Move2To1_Click);
            // 
            // ExchangeRegisters
            // 
            this.ExchangeRegisters.Location = new System.Drawing.Point(376, 410);
            this.ExchangeRegisters.Name = "ExchangeRegisters";
            this.ExchangeRegisters.Size = new System.Drawing.Size(108, 50);
            this.ExchangeRegisters.TabIndex = 22;
            this.ExchangeRegisters.Text = "Exchange registers";
            this.ExchangeRegisters.UseVisualStyleBackColor = true;
            this.ExchangeRegisters.Click += new System.EventHandler(this.ExchangeRegisters_Click);
            // 
            // BLLabel
            // 
            this.BLLabel.AutoSize = true;
            this.BLLabel.Location = new System.Drawing.Point(129, 191);
            this.BLLabel.Name = "BLLabel";
            this.BLLabel.Size = new System.Drawing.Size(20, 15);
            this.BLLabel.TabIndex = 24;
            this.BLLabel.Text = "BL";
            // 
            // BHLabel
            // 
            this.BHLabel.AutoSize = true;
            this.BHLabel.Location = new System.Drawing.Point(289, 191);
            this.BHLabel.Name = "BHLabel";
            this.BHLabel.Size = new System.Drawing.Size(23, 15);
            this.BHLabel.TabIndex = 25;
            this.BHLabel.Text = "BH";
            // 
            // CLLabel
            // 
            this.CLLabel.AutoSize = true;
            this.CLLabel.Location = new System.Drawing.Point(130, 220);
            this.CLLabel.Name = "CLLabel";
            this.CLLabel.Size = new System.Drawing.Size(21, 15);
            this.CLLabel.TabIndex = 26;
            this.CLLabel.Text = "CL";
            // 
            // CHLabel
            // 
            this.CHLabel.AutoSize = true;
            this.CHLabel.Location = new System.Drawing.Point(289, 220);
            this.CHLabel.Name = "CHLabel";
            this.CHLabel.Size = new System.Drawing.Size(24, 15);
            this.CHLabel.TabIndex = 27;
            this.CHLabel.Text = "CH";
            // 
            // DLLabel
            // 
            this.DLLabel.AutoSize = true;
            this.DLLabel.Location = new System.Drawing.Point(130, 249);
            this.DLLabel.Name = "DLLabel";
            this.DLLabel.Size = new System.Drawing.Size(21, 15);
            this.DLLabel.TabIndex = 28;
            this.DLLabel.Text = "DL";
            // 
            // DHLabel
            // 
            this.DHLabel.AutoSize = true;
            this.DHLabel.Location = new System.Drawing.Point(289, 249);
            this.DHLabel.Name = "DHLabel";
            this.DHLabel.Size = new System.Drawing.Size(24, 15);
            this.DHLabel.TabIndex = 29;
            this.DHLabel.Text = "DH";
            // 
            // DLValueLabel
            // 
            this.DLValueLabel.AutoSize = true;
            this.DLValueLabel.Location = new System.Drawing.Point(882, 288);
            this.DLValueLabel.Name = "DLValueLabel";
            this.DLValueLabel.Size = new System.Drawing.Size(21, 15);
            this.DLValueLabel.TabIndex = 33;
            this.DLValueLabel.Text = "DL";
            // 
            // CLValueLabel
            // 
            this.CLValueLabel.AutoSize = true;
            this.CLValueLabel.Location = new System.Drawing.Point(882, 230);
            this.CLValueLabel.Name = "CLValueLabel";
            this.CLValueLabel.Size = new System.Drawing.Size(21, 15);
            this.CLValueLabel.TabIndex = 32;
            this.CLValueLabel.Text = "CL";
            // 
            // BLValueLabel
            // 
            this.BLValueLabel.AutoSize = true;
            this.BLValueLabel.Location = new System.Drawing.Point(882, 159);
            this.BLValueLabel.Name = "BLValueLabel";
            this.BLValueLabel.Size = new System.Drawing.Size(20, 15);
            this.BLValueLabel.TabIndex = 31;
            this.BLValueLabel.Text = "BL";
            // 
            // ALValueLabel
            // 
            this.ALValueLabel.AutoSize = true;
            this.ALValueLabel.Location = new System.Drawing.Point(882, 104);
            this.ALValueLabel.Name = "ALValueLabel";
            this.ALValueLabel.Size = new System.Drawing.Size(21, 15);
            this.ALValueLabel.TabIndex = 30;
            this.ALValueLabel.Text = "AL";
            // 
            // DHValueLabel
            // 
            this.DHValueLabel.AutoSize = true;
            this.DHValueLabel.Location = new System.Drawing.Point(882, 318);
            this.DHValueLabel.Name = "DHValueLabel";
            this.DHValueLabel.Size = new System.Drawing.Size(24, 15);
            this.DHValueLabel.TabIndex = 37;
            this.DHValueLabel.Text = "DH";
            // 
            // CHValueLabel
            // 
            this.CHValueLabel.AutoSize = true;
            this.CHValueLabel.Location = new System.Drawing.Point(882, 259);
            this.CHValueLabel.Name = "CHValueLabel";
            this.CHValueLabel.Size = new System.Drawing.Size(24, 15);
            this.CHValueLabel.TabIndex = 36;
            this.CHValueLabel.Text = "CH";
            // 
            // BHValueLabel
            // 
            this.BHValueLabel.AutoSize = true;
            this.BHValueLabel.Location = new System.Drawing.Point(880, 191);
            this.BHValueLabel.Name = "BHValueLabel";
            this.BHValueLabel.Size = new System.Drawing.Size(23, 15);
            this.BHValueLabel.TabIndex = 35;
            this.BHValueLabel.Text = "BH";
            // 
            // RegisterSelection1Label
            // 
            this.RegisterSelection1Label.AutoSize = true;
            this.RegisterSelection1Label.Location = new System.Drawing.Point(418, 225);
            this.RegisterSelection1Label.Name = "RegisterSelection1Label";
            this.RegisterSelection1Label.Size = new System.Drawing.Size(58, 15);
            this.RegisterSelection1Label.TabIndex = 38;
            this.RegisterSelection1Label.Text = "Register 1";
            // 
            // RegisterSelection2Label
            // 
            this.RegisterSelection2Label.AutoSize = true;
            this.RegisterSelection2Label.Location = new System.Drawing.Point(548, 225);
            this.RegisterSelection2Label.Name = "RegisterSelection2Label";
            this.RegisterSelection2Label.Size = new System.Drawing.Size(58, 15);
            this.RegisterSelection2Label.TabIndex = 39;
            this.RegisterSelection2Label.Text = "Register 2";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(779, 357);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 40;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SingleRegisterSelection
            // 
            this.SingleRegisterSelection.FormattingEnabled = true;
            this.SingleRegisterSelection.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.SingleRegisterSelection.Location = new System.Drawing.Point(436, 41);
            this.SingleRegisterSelection.Name = "SingleRegisterSelection";
            this.SingleRegisterSelection.Size = new System.Drawing.Size(121, 23);
            this.SingleRegisterSelection.TabIndex = 41;
            this.SingleRegisterSelection.SelectedIndexChanged += new System.EventHandler(this.SingleRegisterSelection_SelectedIndexChanged);
            // 
            // SingleSelectionLabel
            // 
            this.SingleSelectionLabel.AutoSize = true;
            this.SingleSelectionLabel.Location = new System.Drawing.Point(436, 23);
            this.SingleSelectionLabel.Name = "SingleSelectionLabel";
            this.SingleSelectionLabel.Size = new System.Drawing.Size(140, 15);
            this.SingleSelectionLabel.TabIndex = 42;
            this.SingleSelectionLabel.Text = "Single Register Operation";
            // 
            // IncrementButton
            // 
            this.IncrementButton.Location = new System.Drawing.Point(461, 70);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(75, 23);
            this.IncrementButton.TabIndex = 43;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // DecrementButton
            // 
            this.DecrementButton.Location = new System.Drawing.Point(461, 99);
            this.DecrementButton.Name = "DecrementButton";
            this.DecrementButton.Size = new System.Drawing.Size(75, 23);
            this.DecrementButton.TabIndex = 44;
            this.DecrementButton.Text = "Decrement";
            this.DecrementButton.UseVisualStyleBackColor = true;
            this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
            // 
            // NotButton
            // 
            this.NotButton.Location = new System.Drawing.Point(461, 128);
            this.NotButton.Name = "NotButton";
            this.NotButton.Size = new System.Drawing.Size(75, 23);
            this.NotButton.TabIndex = 45;
            this.NotButton.Text = "Not";
            this.NotButton.UseVisualStyleBackColor = true;
            this.NotButton.Click += new System.EventHandler(this.NotButton_Click);
            // 
            // NegationButton
            // 
            this.NegationButton.Location = new System.Drawing.Point(461, 157);
            this.NegationButton.Name = "NegationButton";
            this.NegationButton.Size = new System.Drawing.Size(75, 23);
            this.NegationButton.TabIndex = 46;
            this.NegationButton.Text = "Negation";
            this.NegationButton.UseVisualStyleBackColor = true;
            this.NegationButton.Click += new System.EventHandler(this.NegationButton_Click);
            // 
            // ANDButton
            // 
            this.ANDButton.Location = new System.Drawing.Point(531, 294);
            this.ANDButton.Name = "ANDButton";
            this.ANDButton.Size = new System.Drawing.Size(75, 23);
            this.ANDButton.TabIndex = 47;
            this.ANDButton.Text = "AND";
            this.ANDButton.UseVisualStyleBackColor = true;
            this.ANDButton.Click += new System.EventHandler(this.ANDButton_Click);
            // 
            // ORButton
            // 
            this.ORButton.Location = new System.Drawing.Point(531, 323);
            this.ORButton.Name = "ORButton";
            this.ORButton.Size = new System.Drawing.Size(75, 23);
            this.ORButton.TabIndex = 48;
            this.ORButton.Text = "OR";
            this.ORButton.UseVisualStyleBackColor = true;
            this.ORButton.Click += new System.EventHandler(this.ORButton_Click);
            // 
            // XORButton
            // 
            this.XORButton.Location = new System.Drawing.Point(531, 352);
            this.XORButton.Name = "XORButton";
            this.XORButton.Size = new System.Drawing.Size(75, 23);
            this.XORButton.TabIndex = 49;
            this.XORButton.Text = "XOR";
            this.XORButton.UseVisualStyleBackColor = true;
            this.XORButton.Click += new System.EventHandler(this.XORButton_Click);
            // 
            // ADDButton
            // 
            this.ADDButton.Location = new System.Drawing.Point(531, 381);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(75, 23);
            this.ADDButton.TabIndex = 50;
            this.ADDButton.Text = "ADD";
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Click += new System.EventHandler(this.ADDButton_Click);
            // 
            // SUBButton
            // 
            this.SUBButton.Location = new System.Drawing.Point(531, 410);
            this.SUBButton.Name = "SUBButton";
            this.SUBButton.Size = new System.Drawing.Size(75, 23);
            this.SUBButton.TabIndex = 51;
            this.SUBButton.Text = "SUB";
            this.SUBButton.UseVisualStyleBackColor = true;
            this.SUBButton.Click += new System.EventHandler(this.SUBButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 472);
            this.Controls.Add(this.SUBButton);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.XORButton);
            this.Controls.Add(this.ORButton);
            this.Controls.Add(this.ANDButton);
            this.Controls.Add(this.NegationButton);
            this.Controls.Add(this.NotButton);
            this.Controls.Add(this.DecrementButton);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.SingleSelectionLabel);
            this.Controls.Add(this.SingleRegisterSelection);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RegisterSelection2Label);
            this.Controls.Add(this.RegisterSelection1Label);
            this.Controls.Add(this.DHValueLabel);
            this.Controls.Add(this.CHValueLabel);
            this.Controls.Add(this.BHValueLabel);
            this.Controls.Add(AHValueLabel);
            this.Controls.Add(this.DLValueLabel);
            this.Controls.Add(this.CLValueLabel);
            this.Controls.Add(this.BLValueLabel);
            this.Controls.Add(this.ALValueLabel);
            this.Controls.Add(this.DHLabel);
            this.Controls.Add(this.DLLabel);
            this.Controls.Add(this.CHLabel);
            this.Controls.Add(this.CLLabel);
            this.Controls.Add(this.BHLabel);
            this.Controls.Add(this.BLLabel);
            this.Controls.Add(AHLabel);
            this.Controls.Add(this.ExchangeRegisters);
            this.Controls.Add(this.Move2To1);
            this.Controls.Add(this.Move1To2);
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
            this.Text = "Intel 8086 Simulator";
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
        private System.Windows.Forms.Button Move1To2;
        private System.Windows.Forms.Button Move2To1;
        private System.Windows.Forms.Button ExchangeRegisters;
        private System.Windows.Forms.Label AHLabel;
        private System.Windows.Forms.Label BLLabel;
        private System.Windows.Forms.Label BHLabel;
        private System.Windows.Forms.Label CLLabel;
        private System.Windows.Forms.Label CHLabel;
        private System.Windows.Forms.Label DLLabel;
        private System.Windows.Forms.Label DHLabel;
        private System.Windows.Forms.Label DLValueLabel;
        private System.Windows.Forms.Label CLValueLabel;
        private System.Windows.Forms.Label BLValueLabel;
        private System.Windows.Forms.Label ALValueLabel;
        private System.Windows.Forms.Label DHValueLabel;
        private System.Windows.Forms.Label CHValueLabel;
        private System.Windows.Forms.Label BHValueLabel;
        private System.Windows.Forms.Label RegisterSelection1Label;
        private System.Windows.Forms.Label RegisterSelection2Label;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox SingleRegisterSelection;
        private System.Windows.Forms.Label SingleSelectionLabel;
        private System.Windows.Forms.Button IncrementButton;
        private System.Windows.Forms.Button DecrementButton;
        private System.Windows.Forms.Button NotButton;
        private System.Windows.Forms.Button NegationButton;
        private System.Windows.Forms.Button ANDButton;
        private System.Windows.Forms.Button ORButton;
        private System.Windows.Forms.Button XORButton;
        private System.Windows.Forms.Button ADDButton;
        private System.Windows.Forms.Button SUBButton;
    }
}

