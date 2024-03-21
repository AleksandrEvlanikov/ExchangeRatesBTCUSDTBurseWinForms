namespace ExchangeRatesBTCUSDTBurseWinForms
{
    partial class ExchangeQuotesDesktop
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
            tabControl1 = new TabControl();
            tabPageBinance = new TabPage();
            textBoxBinance = new TextBox();
            tabPageBybit = new TabPage();
            textBoxBybit = new TextBox();
            tabPageKucoin = new TabPage();
            textBoxKucoin = new TextBox();
            tabPageBitget = new TabPage();
            textBoxBitget = new TextBox();
            tabPage1 = new TabPage();
            textBoxAll = new TextBox();
            StartBatton = new Button();
            dropDownList = new ComboBox();
            tabControl1.SuspendLayout();
            tabPageBinance.SuspendLayout();
            tabPageBybit.SuspendLayout();
            tabPageKucoin.SuspendLayout();
            tabPageBitget.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBinance);
            tabControl1.Controls.Add(tabPageBybit);
            tabControl1.Controls.Add(tabPageKucoin);
            tabControl1.Controls.Add(tabPageBitget);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 11);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(652, 427);
            tabControl1.TabIndex = 1;
            // 
            // tabPageBinance
            // 
            tabPageBinance.Controls.Add(textBoxBinance);
            tabPageBinance.Location = new Point(4, 29);
            tabPageBinance.Name = "tabPageBinance";
            tabPageBinance.Padding = new Padding(3);
            tabPageBinance.Size = new Size(644, 394);
            tabPageBinance.TabIndex = 0;
            tabPageBinance.Text = "Binance";
            tabPageBinance.UseVisualStyleBackColor = true;
            // 
            // textBoxBinance
            // 
            textBoxBinance.Location = new Point(-4, 0);
            textBoxBinance.Multiline = true;
            textBoxBinance.Name = "textBoxBinance";
            textBoxBinance.Size = new Size(652, 398);
            textBoxBinance.TabIndex = 0;
            // 
            // tabPageBybit
            // 
            tabPageBybit.Controls.Add(textBoxBybit);
            tabPageBybit.Location = new Point(4, 29);
            tabPageBybit.Name = "tabPageBybit";
            tabPageBybit.Padding = new Padding(3);
            tabPageBybit.Size = new Size(644, 394);
            tabPageBybit.TabIndex = 1;
            tabPageBybit.Text = "Bybit";
            tabPageBybit.UseVisualStyleBackColor = true;
            // 
            // textBoxBybit
            // 
            textBoxBybit.Location = new Point(-4, -2);
            textBoxBybit.Multiline = true;
            textBoxBybit.Name = "textBoxBybit";
            textBoxBybit.Size = new Size(652, 398);
            textBoxBybit.TabIndex = 4;
            // 
            // tabPageKucoin
            // 
            tabPageKucoin.Controls.Add(textBoxKucoin);
            tabPageKucoin.Location = new Point(4, 29);
            tabPageKucoin.Name = "tabPageKucoin";
            tabPageKucoin.Padding = new Padding(3);
            tabPageKucoin.Size = new Size(644, 394);
            tabPageKucoin.TabIndex = 2;
            tabPageKucoin.Text = "Kucoin";
            tabPageKucoin.UseVisualStyleBackColor = true;
            // 
            // textBoxKucoin
            // 
            textBoxKucoin.Location = new Point(-4, -2);
            textBoxKucoin.Multiline = true;
            textBoxKucoin.Name = "textBoxKucoin";
            textBoxKucoin.Size = new Size(652, 398);
            textBoxKucoin.TabIndex = 4;
            // 
            // tabPageBitget
            // 
            tabPageBitget.Controls.Add(textBoxBitget);
            tabPageBitget.Location = new Point(4, 29);
            tabPageBitget.Name = "tabPageBitget";
            tabPageBitget.Padding = new Padding(3);
            tabPageBitget.Size = new Size(644, 394);
            tabPageBitget.TabIndex = 3;
            tabPageBitget.Text = "Bitget";
            tabPageBitget.UseVisualStyleBackColor = true;
            // 
            // textBoxBitget
            // 
            textBoxBitget.Location = new Point(-4, -2);
            textBoxBitget.Multiline = true;
            textBoxBitget.Name = "textBoxBitget";
            textBoxBitget.Size = new Size(652, 398);
            textBoxBitget.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxAll);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(644, 394);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxAll
            // 
            textBoxAll.Location = new Point(-4, -2);
            textBoxAll.Multiline = true;
            textBoxAll.Name = "textBoxAll";
            textBoxAll.Size = new Size(652, 398);
            textBoxAll.TabIndex = 5;
            // 
            // StartBatton
            // 
            StartBatton.BackColor = Color.LimeGreen;
            StartBatton.FlatStyle = FlatStyle.Popup;
            StartBatton.ForeColor = SystemColors.ActiveCaptionText;
            StartBatton.Location = new Point(682, 40);
            StartBatton.Name = "StartBatton";
            StartBatton.Size = new Size(106, 61);
            StartBatton.TabIndex = 0;
            StartBatton.Text = "Start";
            StartBatton.UseVisualStyleBackColor = false;
            StartBatton.Click += button1_Click;
            // 
            // dropDownList
            // 
            dropDownList.FormattingEnabled = true;
            dropDownList.Location = new Point(682, 124);
            dropDownList.Name = "dropDownList";
            dropDownList.Size = new Size(106, 28);
            dropDownList.TabIndex = 2;
            // 
            // ExchangeQuotesDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dropDownList);
            Controls.Add(StartBatton);
            Controls.Add(tabControl1);
            Name = "ExchangeQuotesDesktop";
            Text = "Котировки бирж";
            tabControl1.ResumeLayout(false);
            tabPageBinance.ResumeLayout(false);
            tabPageBinance.PerformLayout();
            tabPageBybit.ResumeLayout(false);
            tabPageBybit.PerformLayout();
            tabPageKucoin.ResumeLayout(false);
            tabPageKucoin.PerformLayout();
            tabPageBitget.ResumeLayout(false);
            tabPageBitget.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBinance;
        private TabPage tabPageBybit;
        private Button StartBatton;
        private ComboBox dropDownList;
        private TabPage tabPageKucoin;
        private TabPage tabPageBitget;
        private TextBox textBoxBinance;
        private TextBox textBoxBybit;
        private TextBox textBoxKucoin;
        private TextBox textBoxBitget;
        private TabPage tabPage1;
        private TextBox textBoxAll;
    }
}
