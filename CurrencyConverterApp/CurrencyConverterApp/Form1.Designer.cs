namespace CurrencyConverterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.USDBuyLabel = new System.Windows.Forms.Label();
            this.USDSellLabel = new System.Windows.Forms.Label();
            this.EuroBuyLabel = new System.Windows.Forms.Label();
            this.EuroSellLabel = new System.Windows.Forms.Label();
            this.EuroSellText = new System.Windows.Forms.Label();
            this.EuroBuyText = new System.Windows.Forms.Label();
            this.USDSellText = new System.Windows.Forms.Label();
            this.USDBuyText = new System.Windows.Forms.Label();
            this.UsdBuyBtn = new System.Windows.Forms.Button();
            this.UsdSellBtn = new System.Windows.Forms.Button();
            this.EuroBuyBtn = new System.Windows.Forms.Button();
            this.EuroSellBtn = new System.Windows.Forms.Button();
            this.CurrencyTransactionsBox = new System.Windows.Forms.GroupBox();
            this.Reversebtn = new System.Windows.Forms.Button();
            this.RemainingTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTxtbox = new System.Windows.Forms.TextBox();
            this.AmountTxtbox = new System.Windows.Forms.TextBox();
            this.CurrencyTxtbox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.AmountBuyLabel = new System.Windows.Forms.Label();
            this.AmountSellLabel = new System.Windows.Forms.Label();
            this.CurrencyTransactionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // USDBuyLabel
            // 
            this.USDBuyLabel.BackColor = System.Drawing.Color.Transparent;
            this.USDBuyLabel.ForeColor = System.Drawing.Color.White;
            this.USDBuyLabel.Location = new System.Drawing.Point(95, 60);
            this.USDBuyLabel.Name = "USDBuyLabel";
            this.USDBuyLabel.Size = new System.Drawing.Size(150, 44);
            this.USDBuyLabel.TabIndex = 0;
            this.USDBuyLabel.Text = "USD / Buy : ";
            // 
            // USDSellLabel
            // 
            this.USDSellLabel.BackColor = System.Drawing.Color.Transparent;
            this.USDSellLabel.ForeColor = System.Drawing.Color.White;
            this.USDSellLabel.Location = new System.Drawing.Point(95, 150);
            this.USDSellLabel.Name = "USDSellLabel";
            this.USDSellLabel.Size = new System.Drawing.Size(150, 44);
            this.USDSellLabel.TabIndex = 1;
            this.USDSellLabel.Text = "USD / Sell : ";
            // 
            // EuroBuyLabel
            // 
            this.EuroBuyLabel.BackColor = System.Drawing.Color.Transparent;
            this.EuroBuyLabel.ForeColor = System.Drawing.Color.White;
            this.EuroBuyLabel.Location = new System.Drawing.Point(95, 239);
            this.EuroBuyLabel.Name = "EuroBuyLabel";
            this.EuroBuyLabel.Size = new System.Drawing.Size(150, 44);
            this.EuroBuyLabel.TabIndex = 2;
            this.EuroBuyLabel.Text = "Euro / Buy : ";
            // 
            // EuroSellLabel
            // 
            this.EuroSellLabel.BackColor = System.Drawing.Color.Transparent;
            this.EuroSellLabel.ForeColor = System.Drawing.Color.White;
            this.EuroSellLabel.Location = new System.Drawing.Point(95, 337);
            this.EuroSellLabel.Name = "EuroSellLabel";
            this.EuroSellLabel.Size = new System.Drawing.Size(150, 44);
            this.EuroSellLabel.TabIndex = 3;
            this.EuroSellLabel.Text = "Euro / Sell : ";
            // 
            // EuroSellText
            // 
            this.EuroSellText.BackColor = System.Drawing.Color.Transparent;
            this.EuroSellText.ForeColor = System.Drawing.Color.White;
            this.EuroSellText.Location = new System.Drawing.Point(278, 337);
            this.EuroSellText.Name = "EuroSellText";
            this.EuroSellText.Size = new System.Drawing.Size(107, 44);
            this.EuroSellText.TabIndex = 7;
            // 
            // EuroBuyText
            // 
            this.EuroBuyText.BackColor = System.Drawing.Color.Transparent;
            this.EuroBuyText.ForeColor = System.Drawing.Color.White;
            this.EuroBuyText.Location = new System.Drawing.Point(278, 239);
            this.EuroBuyText.Name = "EuroBuyText";
            this.EuroBuyText.Size = new System.Drawing.Size(107, 44);
            this.EuroBuyText.TabIndex = 6;
            // 
            // USDSellText
            // 
            this.USDSellText.BackColor = System.Drawing.Color.Transparent;
            this.USDSellText.ForeColor = System.Drawing.Color.White;
            this.USDSellText.Location = new System.Drawing.Point(278, 150);
            this.USDSellText.Name = "USDSellText";
            this.USDSellText.Size = new System.Drawing.Size(107, 44);
            this.USDSellText.TabIndex = 5;
            // 
            // USDBuyText
            // 
            this.USDBuyText.BackColor = System.Drawing.Color.Transparent;
            this.USDBuyText.ForeColor = System.Drawing.Color.White;
            this.USDBuyText.Location = new System.Drawing.Point(278, 60);
            this.USDBuyText.Name = "USDBuyText";
            this.USDBuyText.Size = new System.Drawing.Size(107, 44);
            this.USDBuyText.TabIndex = 4;
            this.USDBuyText.Click += new System.EventHandler(this.label8_Click);
            // 
            // UsdBuyBtn
            // 
            this.UsdBuyBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsdBuyBtn.Location = new System.Drawing.Point(500, 60);
            this.UsdBuyBtn.Name = "UsdBuyBtn";
            this.UsdBuyBtn.Size = new System.Drawing.Size(78, 44);
            this.UsdBuyBtn.TabIndex = 8;
            this.UsdBuyBtn.Text = "Select";
            this.UsdBuyBtn.UseVisualStyleBackColor = false;
            this.UsdBuyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsdSellBtn
            // 
            this.UsdSellBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsdSellBtn.Location = new System.Drawing.Point(500, 150);
            this.UsdSellBtn.Name = "UsdSellBtn";
            this.UsdSellBtn.Size = new System.Drawing.Size(78, 44);
            this.UsdSellBtn.TabIndex = 9;
            this.UsdSellBtn.Text = "Select";
            this.UsdSellBtn.UseVisualStyleBackColor = false;
            this.UsdSellBtn.Click += new System.EventHandler(this.UsdSellBtn_Click);
            // 
            // EuroBuyBtn
            // 
            this.EuroBuyBtn.BackColor = System.Drawing.Color.Transparent;
            this.EuroBuyBtn.Location = new System.Drawing.Point(500, 239);
            this.EuroBuyBtn.Name = "EuroBuyBtn";
            this.EuroBuyBtn.Size = new System.Drawing.Size(78, 44);
            this.EuroBuyBtn.TabIndex = 10;
            this.EuroBuyBtn.Text = "Select";
            this.EuroBuyBtn.UseVisualStyleBackColor = false;
            this.EuroBuyBtn.Click += new System.EventHandler(this.EuroBuyBtn_Click);
            // 
            // EuroSellBtn
            // 
            this.EuroSellBtn.BackColor = System.Drawing.Color.Transparent;
            this.EuroSellBtn.Location = new System.Drawing.Point(500, 337);
            this.EuroSellBtn.Name = "EuroSellBtn";
            this.EuroSellBtn.Size = new System.Drawing.Size(78, 44);
            this.EuroSellBtn.TabIndex = 11;
            this.EuroSellBtn.Text = "Select";
            this.EuroSellBtn.UseVisualStyleBackColor = false;
            this.EuroSellBtn.Click += new System.EventHandler(this.EuroSellBtn_Click);
            // 
            // CurrencyTransactionsBox
            // 
            this.CurrencyTransactionsBox.BackColor = System.Drawing.Color.Transparent;
            this.CurrencyTransactionsBox.Controls.Add(this.Reversebtn);
            this.CurrencyTransactionsBox.Controls.Add(this.RemainingTxtbox);
            this.CurrencyTransactionsBox.Controls.Add(this.label1);
            this.CurrencyTransactionsBox.Controls.Add(this.TotalTxtbox);
            this.CurrencyTransactionsBox.Controls.Add(this.AmountTxtbox);
            this.CurrencyTransactionsBox.Controls.Add(this.CurrencyTxtbox);
            this.CurrencyTransactionsBox.Controls.Add(this.CalculateBtn);
            this.CurrencyTransactionsBox.Controls.Add(this.CurrencyLabel);
            this.CurrencyTransactionsBox.Controls.Add(this.AmountBuyLabel);
            this.CurrencyTransactionsBox.Controls.Add(this.AmountSellLabel);
            this.CurrencyTransactionsBox.ForeColor = System.Drawing.Color.White;
            this.CurrencyTransactionsBox.Location = new System.Drawing.Point(640, 47);
            this.CurrencyTransactionsBox.Name = "CurrencyTransactionsBox";
            this.CurrencyTransactionsBox.Size = new System.Drawing.Size(525, 498);
            this.CurrencyTransactionsBox.TabIndex = 12;
            this.CurrencyTransactionsBox.TabStop = false;
            this.CurrencyTransactionsBox.Text = "Currency Transactions";
            // 
            // Reversebtn
            // 
            this.Reversebtn.ForeColor = System.Drawing.Color.Black;
            this.Reversebtn.Location = new System.Drawing.Point(282, 403);
            this.Reversebtn.Name = "Reversebtn";
            this.Reversebtn.Size = new System.Drawing.Size(198, 50);
            this.Reversebtn.TabIndex = 25;
            this.Reversebtn.Text = "Reverse";
            this.Reversebtn.UseVisualStyleBackColor = true;
            this.Reversebtn.Click += new System.EventHandler(this.Reversebtn_Click);
            // 
            // RemainingTxtbox
            // 
            this.RemainingTxtbox.Location = new System.Drawing.Point(173, 321);
            this.RemainingTxtbox.Name = "RemainingTxtbox";
            this.RemainingTxtbox.Size = new System.Drawing.Size(251, 30);
            this.RemainingTxtbox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Remaining : ";
            // 
            // TotalTxtbox
            // 
            this.TotalTxtbox.Location = new System.Drawing.Point(173, 235);
            this.TotalTxtbox.Name = "TotalTxtbox";
            this.TotalTxtbox.Size = new System.Drawing.Size(251, 30);
            this.TotalTxtbox.TabIndex = 22;
            this.TotalTxtbox.TextChanged += new System.EventHandler(this.TotalTxtbox_TextChanged);
            // 
            // AmountTxtbox
            // 
            this.AmountTxtbox.Location = new System.Drawing.Point(173, 143);
            this.AmountTxtbox.Name = "AmountTxtbox";
            this.AmountTxtbox.Size = new System.Drawing.Size(251, 30);
            this.AmountTxtbox.TabIndex = 21;
            // 
            // CurrencyTxtbox
            // 
            this.CurrencyTxtbox.Location = new System.Drawing.Point(173, 56);
            this.CurrencyTxtbox.Name = "CurrencyTxtbox";
            this.CurrencyTxtbox.Size = new System.Drawing.Size(251, 30);
            this.CurrencyTxtbox.TabIndex = 20;
            this.CurrencyTxtbox.TextChanged += new System.EventHandler(this.CurrencyTxtbox_TextChanged_1);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.ForeColor = System.Drawing.Color.Black;
            this.CalculateBtn.Location = new System.Drawing.Point(45, 403);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(198, 50);
            this.CalculateBtn.TabIndex = 19;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrencyLabel.ForeColor = System.Drawing.Color.White;
            this.CurrencyLabel.Location = new System.Drawing.Point(17, 56);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(150, 44);
            this.CurrencyLabel.TabIndex = 13;
            this.CurrencyLabel.Text = "Currency :";
            // 
            // AmountBuyLabel
            // 
            this.AmountBuyLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountBuyLabel.ForeColor = System.Drawing.Color.White;
            this.AmountBuyLabel.Location = new System.Drawing.Point(17, 235);
            this.AmountBuyLabel.Name = "AmountBuyLabel";
            this.AmountBuyLabel.Size = new System.Drawing.Size(150, 44);
            this.AmountBuyLabel.TabIndex = 15;
            this.AmountBuyLabel.Text = "Total : ";
            // 
            // AmountSellLabel
            // 
            this.AmountSellLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountSellLabel.ForeColor = System.Drawing.Color.White;
            this.AmountSellLabel.Location = new System.Drawing.Point(17, 146);
            this.AmountSellLabel.Name = "AmountSellLabel";
            this.AmountSellLabel.Size = new System.Drawing.Size(150, 44);
            this.AmountSellLabel.TabIndex = 14;
            this.AmountSellLabel.Text = "Amount  : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 577);
            this.Controls.Add(this.CurrencyTransactionsBox);
            this.Controls.Add(this.EuroSellBtn);
            this.Controls.Add(this.EuroBuyBtn);
            this.Controls.Add(this.UsdSellBtn);
            this.Controls.Add(this.UsdBuyBtn);
            this.Controls.Add(this.EuroSellText);
            this.Controls.Add(this.EuroBuyText);
            this.Controls.Add(this.USDSellText);
            this.Controls.Add(this.USDBuyText);
            this.Controls.Add(this.EuroSellLabel);
            this.Controls.Add(this.EuroBuyLabel);
            this.Controls.Add(this.USDSellLabel);
            this.Controls.Add(this.USDBuyLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Currency Conversion Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CurrencyTransactionsBox.ResumeLayout(false);
            this.CurrencyTransactionsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label USDBuyLabel;
        private Label USDSellLabel;
        private Label EuroBuyLabel;
        private Label EuroSellLabel;
        private Label EuroSellText;
        private Label EuroBuyText;
        private Label USDSellText;
        private Label USDBuyText;
        private Button UsdBuyBtn;
        private Button UsdSellBtn;
        private Button EuroBuyBtn;
        private Button EuroSellBtn;
        private GroupBox CurrencyTransactionsBox;
        private Label CurrencyLabel;
        private Label AmountBuyLabel;
        private Label AmountSellLabel;
        private Button CalculateBtn;
        private TextBox TotalTxtbox;
        private TextBox AmountTxtbox;
        private TextBox CurrencyTxtbox;
        private Label label1;
        private Button Reversebtn;
        private TextBox RemainingTxtbox;
    }
}