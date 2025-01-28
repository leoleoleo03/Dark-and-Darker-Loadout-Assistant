namespace DarkAndDarkerFavorite
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonOpenMarket = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            PageList = new System.Windows.Forms.ComboBox();
            LoadJson = new System.Windows.Forms.Button();
            SaveJson = new System.Windows.Forms.Button();
            NewLoadoutText = new System.Windows.Forms.TextBox();
            NewLoadoutButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            LoadoutPriceDisplaye = new System.Windows.Forms.Label();
            ScreenShotBox = new System.Windows.Forms.PictureBox();
            SearchItemNameLabel = new System.Windows.Forms.Label();
            OriginalPriceText = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            MarketPlaceGuideLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SideLoadoutButton = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScreenShotBox).BeginInit();
            SuspendLayout();
            // 
            // ButtonOpenMarket
            // 
            ButtonOpenMarket.Location = new System.Drawing.Point(949, 286);
            ButtonOpenMarket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonOpenMarket.Name = "ButtonOpenMarket";
            ButtonOpenMarket.Size = new System.Drawing.Size(155, 48);
            ButtonOpenMarket.TabIndex = 0;
            ButtonOpenMarket.Text = "Open Market";
            ButtonOpenMarket.UseVisualStyleBackColor = true;
            ButtonOpenMarket.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(949, 230);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(155, 50);
            button1.TabIndex = 8;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(14, 14);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(928, 720);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(792, 16);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(33, 15);
            label7.TabIndex = 4;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(512, 16);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 15);
            label6.TabIndex = 3;
            label6.Text = "Attribute 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(377, 16);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 2;
            label5.Text = "Attribute 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(250, 16);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "Rarity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 16);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Item Name";
            // 
            // PageList
            // 
            PageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PageList.FormattingEnabled = true;
            PageList.Location = new System.Drawing.Point(944, 29);
            PageList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PageList.Name = "PageList";
            PageList.Size = new System.Drawing.Size(194, 23);
            PageList.TabIndex = 16;
            PageList.SelectedIndexChanged += PageList_SelectedIndexChanged;
            // 
            // LoadJson
            // 
            LoadJson.Location = new System.Drawing.Point(949, 117);
            LoadJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LoadJson.Name = "LoadJson";
            LoadJson.Size = new System.Drawing.Size(155, 50);
            LoadJson.TabIndex = 17;
            LoadJson.Text = "Reload Loadouts";
            LoadJson.UseVisualStyleBackColor = true;
            LoadJson.Click += LoadJson_Click;
            // 
            // SaveJson
            // 
            SaveJson.Location = new System.Drawing.Point(949, 173);
            SaveJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SaveJson.Name = "SaveJson";
            SaveJson.Size = new System.Drawing.Size(155, 50);
            SaveJson.TabIndex = 18;
            SaveJson.Text = "Save Loadout";
            SaveJson.UseVisualStyleBackColor = true;
            SaveJson.Click += SaveJson_Click;
            // 
            // NewLoadoutText
            // 
            NewLoadoutText.Location = new System.Drawing.Point(944, 75);
            NewLoadoutText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewLoadoutText.Name = "NewLoadoutText";
            NewLoadoutText.Size = new System.Drawing.Size(159, 23);
            NewLoadoutText.TabIndex = 19;
            // 
            // NewLoadoutButton
            // 
            NewLoadoutButton.Location = new System.Drawing.Point(1102, 75);
            NewLoadoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewLoadoutButton.Name = "NewLoadoutButton";
            NewLoadoutButton.Size = new System.Drawing.Size(37, 23);
            NewLoadoutButton.TabIndex = 20;
            NewLoadoutButton.Text = "+";
            NewLoadoutButton.UseVisualStyleBackColor = true;
            NewLoadoutButton.Click += NewLoadoutButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(958, 57);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 15);
            label2.TabIndex = 21;
            label2.Text = "Create New Loadout";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(7, 30);
            radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(56, 19);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "1080p";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(7, 57);
            radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(56, 19);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "1440p";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new System.Drawing.Point(949, 407);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(168, 93);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "ScreenResolution";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(944, 506);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 27);
            button2.TabIndex = 25;
            button2.Text = "Calculate Price";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(947, 539);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 15);
            label8.TabIndex = 26;
            label8.Text = "Loadout Cost:";
            // 
            // LoadoutPriceDisplaye
            // 
            LoadoutPriceDisplaye.AutoSize = true;
            LoadoutPriceDisplaye.Location = new System.Drawing.Point(1039, 539);
            LoadoutPriceDisplaye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LoadoutPriceDisplaye.Name = "LoadoutPriceDisplaye";
            LoadoutPriceDisplaye.Size = new System.Drawing.Size(21, 15);
            LoadoutPriceDisplaye.TabIndex = 27;
            LoadoutPriceDisplaye.Text = "0G";
            // 
            // ScreenShotBox
            // 
            ScreenShotBox.Location = new System.Drawing.Point(946, 559);
            ScreenShotBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ScreenShotBox.Name = "ScreenShotBox";
            ScreenShotBox.Size = new System.Drawing.Size(261, 69);
            ScreenShotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ScreenShotBox.TabIndex = 30;
            ScreenShotBox.TabStop = false;
            // 
            // SearchItemNameLabel
            // 
            SearchItemNameLabel.AutoSize = true;
            SearchItemNameLabel.Location = new System.Drawing.Point(953, 636);
            SearchItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SearchItemNameLabel.Name = "SearchItemNameLabel";
            SearchItemNameLabel.Size = new System.Drawing.Size(0, 15);
            SearchItemNameLabel.TabIndex = 31;
            // 
            // OriginalPriceText
            // 
            OriginalPriceText.AutoSize = true;
            OriginalPriceText.Location = new System.Drawing.Point(1124, 636);
            OriginalPriceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OriginalPriceText.Name = "OriginalPriceText";
            OriginalPriceText.Size = new System.Drawing.Size(0, 15);
            OriginalPriceText.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1111, 141);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(119, 15);
            label9.TabIndex = 33;
            label9.Text = "[F1] Check Item Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(1111, 176);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 15);
            label10.TabIndex = 34;
            label10.Text = "[F3] Return to my Listing";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(1111, 194);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(98, 15);
            label11.TabIndex = 35;
            label11.Text = "[F4] Sell cheapest";
            // 
            // MarketPlaceGuideLabel
            // 
            MarketPlaceGuideLabel.AutoSize = true;
            MarketPlaceGuideLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MarketPlaceGuideLabel.Location = new System.Drawing.Point(1111, 117);
            MarketPlaceGuideLabel.Name = "MarketPlaceGuideLabel";
            MarketPlaceGuideLabel.Size = new System.Drawing.Size(134, 15);
            MarketPlaceGuideLabel.TabIndex = 36;
            MarketPlaceGuideLabel.Text = "[Marketplace Hotkeys]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1111, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 15);
            label1.TabIndex = 37;
            label1.Text = "[F2] Open My Listings";
            // 
            // SideLoadoutButton
            // 
            SideLoadoutButton.Location = new System.Drawing.Point(949, 340);
            SideLoadoutButton.Name = "SideLoadoutButton";
            SideLoadoutButton.Size = new System.Drawing.Size(154, 48);
            SideLoadoutButton.TabIndex = 38;
            SideLoadoutButton.Text = "Open Loadout Sidebar";
            SideLoadoutButton.UseVisualStyleBackColor = true;
            SideLoadoutButton.Click += SideLoadoutButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1111, 211);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(148, 15);
            label12.TabIndex = 39;
            label12.Text = "[F5] Open Loadout Sidebar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1274, 780);
            Controls.Add(label12);
            Controls.Add(SideLoadoutButton);
            Controls.Add(label1);
            Controls.Add(MarketPlaceGuideLabel);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(OriginalPriceText);
            Controls.Add(SearchItemNameLabel);
            Controls.Add(ScreenShotBox);
            Controls.Add(LoadoutPriceDisplaye);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(NewLoadoutButton);
            Controls.Add(NewLoadoutText);
            Controls.Add(SaveJson);
            Controls.Add(LoadJson);
            Controls.Add(PageList);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(ButtonOpenMarket);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "DaD Loadout Assistant";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ScreenShotBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenMarket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox PageList;
        private System.Windows.Forms.Button LoadJson;
        private System.Windows.Forms.Button SaveJson;
        private System.Windows.Forms.TextBox NewLoadoutText;
        private System.Windows.Forms.Button NewLoadoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LoadoutPriceDisplaye;
        private System.Windows.Forms.PictureBox ScreenShotBox;
        private System.Windows.Forms.Label SearchItemNameLabel;
        private System.Windows.Forms.Label OriginalPriceText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MarketPlaceGuideLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SideLoadoutButton;
        private System.Windows.Forms.Label label12;
    }
}

