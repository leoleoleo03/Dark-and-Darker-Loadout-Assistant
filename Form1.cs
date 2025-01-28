using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.IO;
using System.Runtime.InteropServices;
using Tesseract;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using Newtonsoft.Json.Bson;

//using Newtonsoft.Json;

namespace DarkAndDarkerFavorite
{



    public partial class Form1 : Form
    {

        //private Form1 _masterForm;

        public Form1()
        {
            InitializeComponent();


            //ghk = new KeyHandler(Keys.F1, this);
            //ghk.Register();

            //f3key = new KeyHandler(Keys.F3,this);
            //f3key.Register();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Icon = Properties.Resources.
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Page newPage = new Page();
            pages.Add(newPage);
            pages[0].page = 0;

            loadResolution();

            timer1.Tick += new EventHandler(timer1_Tick);

            // Sets the timer interval to 5 seconds.
            timer1.Interval = 16;
            timer1.Start();

            ItemStatsAutoFillSetup();
            FindAllJson();

            SelectLoadoutWithName(Properties.Settings.Default.LastSelectedLoadout);

        }

        private KeyHandler ghk;
        private KeyHandler f3key;




        #region Mouse_Clicking
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;


        //This simulates a left mouse click
        public void LeftMouseClick(int xpos, int ypos)
        {
            float newXpos = xpos / ResolutionDivide();
            xpos = (int)newXpos;

            float newYpos = ypos / ResolutionDivide();
            ypos = (int)newYpos;

            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            System.Threading.Thread.Sleep(20);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }


        public int SleepTime = 35;
        public int resolution = 0;



        float Abs(float value)
        {
            return System.Math.Abs(value);

        }

        float ResolutionDivide()
        {
            return (Abs(1 - (resolution * 1.75f)));
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //OPENS THE TRADE TAB
            LeftMouseClick(1205, 38);
            Debug.WriteLine(1205 / ResolutionDivide());
            //Debug.WriteLine(( System.Math.Abs(1 - (resolution * 1.75f))));
            //Debug.WriteLine(Abs(1 - (resolution * 1.75f)));
            Debug.WriteLine(ResolutionDivide());

            System.Threading.Thread.Sleep(100);
            //OPENS THE MARKETPLACE
            LeftMouseClick(1170, 243);



        }


        #region UI_Clicking


        private void SearchItem(string name, string rarity, string attribute)
        {
            clickResetFilters();
            InputAndClickItemName(name);
            InputAndClickRarity(rarity);
            InputAndClickAttribute(attribute, 0, true);
            ClickSearchButton();
        }

        private void SearchItem(string name, string rarity, string attribute, string attribute2)
        {
            clickResetFilters();
            InputAndClickItemName(name);
            InputAndClickRarity(rarity);
            InputAndClickAttribute(attribute, 0, true);
            InputAndClickAttribute(attribute2, 1, false);
            ClickSearchButton();
        }

        private void SearchItem(string name, string rarity)
        {
            clickResetFilters();
            //System.Threading.Thread.Sleep(SleepTime);
            //ResetAttributes();
            InputAndClickItemName(name);
            InputAndClickRarity(rarity);
            ClickSearchButton();
        }

        private void clickResetFilters()
        {
            LeftMouseClick(1794, 207);
            System.Threading.Thread.Sleep(SleepTime + 150);
        }

        private void InputAndClickItemName(string itemName)
        {
            //click over text
            //LeftMouseClick(150, 171);
            //System.Threading.Thread.Sleep(SleepTime);

            //Click item reset
            //LeftMouseClick(254, 207);
            //System.Threading.Thread.Sleep(SleepTime);

            //Click the item container
            LeftMouseClick(148, 205);
            System.Threading.Thread.Sleep(SleepTime);
            //Click the item text input
            LeftMouseClick(142, 244);
            System.Threading.Thread.Sleep(SleepTime);
            Clipboard.SetText(itemName);
            SendKeys.Send("^{v}");
            //Select First Item
            LeftMouseClick(140, 274);
            //System.Threading.Thread.Sleep(SleepTime);
        }

        private void InputAndClickRarity(string rarity)
        {
            //Click Rarity reset
            //LeftMouseClick(489, 200);
            //System.Threading.Thread.Sleep(SleepTime);

            //Click Rarity Container
            LeftMouseClick(370, 205);
            System.Threading.Thread.Sleep(SleepTime);
            //Click rarity text input
            LeftMouseClick(351, 244);
            System.Threading.Thread.Sleep(SleepTime);
            //Set the rarity to the clipboard and then press ctrl+v
            Clipboard.SetText(rarity);
            SendKeys.Send("^{v}");
            //Click the First item
            LeftMouseClick(348, 277);
            //System.Threading.Thread.Sleep(SleepTime);


        }

        private void ResetAttributes()
        {
            //click attribute reset
            LeftMouseClick(1674, 205);
        }

        private void InputAndClickAttribute(string attribute, int position, bool reset)
        {
            //int SleepTime = 200;
            int position_diff = 26;

            //click over the text
            LeftMouseClick(1545, 173);

            if (reset)
            {
                ResetAttributes();
            }
            System.Threading.Thread.Sleep(SleepTime);
            //click Container
            LeftMouseClick(1544, 205);
            System.Threading.Thread.Sleep(SleepTime);

            //click text Input
            LeftMouseClick(1521, 248);
            System.Threading.Thread.Sleep(SleepTime);
            //Set the attributes to the clipboard and then press ctrl+v
            Clipboard.SetText(attribute);
            SendKeys.Send("^{v}");
            //Select first
            LeftMouseClick(1573, 282 + (position * position_diff));
            System.Threading.Thread.Sleep(SleepTime);
        }

        private void ClickSearchButton()
        {
            //Click Search Button
            LeftMouseClick(1785, 277);
        }
        #endregion

        private void ClickViewMarket()
        {
            LeftMouseClick(855, 117);
        }

        private void ClickSearchListing()
        {
            LeftMouseClick(955, 475);
        }

        private void ClickMarketListing()
        {
            LeftMouseClick(1046, 110);
        }

        private void ClickMarketCreateListing()
        {
            LeftMouseClick(963, 970);
        }

        private void ClickMarketplace()
        {


            //OPENS THE TRADE TAB
            LeftMouseClick(1205, 38);


            System.Threading.Thread.Sleep(100);
            //OPENS THE MARKETPLACE
            LeftMouseClick(1170, 243);
        }


        #region Search_Buttons

        private void SearchBasic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GroupBox grp = (GroupBox)btn.Parent;

            string itemName = "null";
            string itemRarity = "null";
            //string itemStat = "null";


            groupBoxData newgroup = ReturnGboxOfButton(btn);

            itemName = newgroup.itemName.Text;
            itemRarity = newgroup.itemRarity.Text;

            //ResetAttributes();

            SearchItem(itemName, itemRarity);
        }

        private void SearchFull_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GroupBox grp = (GroupBox)btn.Parent;


            //string itemName = itemNameBox.Text;
            //string itemRarity = ItemRarityBox.Text;
            //string itemStat = ItemStatBox.Text;

            string itemName = "null";
            string itemRarity = "null";
            string itemStat = "null";
            string itemStat2 = "null";


            groupBoxData newgroup = ReturnGboxOfButton(btn);

            itemName = newgroup.itemName.Text;
            itemRarity = newgroup.itemRarity.Text;
            itemStat = newgroup.itemAttribute.Text;
            itemStat2 = newgroup.itemAttribute2.Text;

            //SearchItem(itemName, itemRarity,itemStat);

            if (itemStat == "")
            {

                SearchItem(itemName, itemRarity);
            }
            else if (itemStat2 == "")
            {
                SearchItem(itemName, itemRarity, itemStat);
            }
            else
            {
                SearchItem(itemName, itemRarity, itemStat, itemStat2);
            }
        }
        #endregion

        int item_counter = 0;

        List<Page> pages = new List<Page>();
        int pageCount = 0;
        int current_page = 0;



        #region Group Box

        List<groupBoxData> gboxes = new List<groupBoxData>();

        groupBoxData ReturnGboxOfButton(Button button)
        {
            for (int x = 0; x < gboxes.Count; x++)
            {
                if (gboxes[x].SearchFull == button)
                {
                    return gboxes[x];
                }
            }

            for (int x = 0; x < gboxes.Count; x++)
            {
                if (gboxes[x].SearchBasic == button)
                {
                    return gboxes[x];
                }
            }
            return null;
        }



        private void ClearGboxes()
        {
            item_counter = 0;
            foreach (groupBoxData gp in gboxes)
            {

                panel1.Controls.Remove(gp.groupBox);
                gp.groupBox.Dispose();
            }
            gboxes.Clear();
        }


        GroupBox gbox;
        private void GenerateGbox(string itemName, string itemRarity, string itemAttributes, string itemAttributes2, string itemPrice)
        {
            int yPosition = 15;
            TextBox itemNameBox = new TextBox();
            itemNameBox.Location = new System.Drawing.Point(6, yPosition);
            itemNameBox.Name = "itemNameBox";
            itemNameBox.Size = new System.Drawing.Size(186, 20);
            if (itemName != "null")
                itemNameBox.Text = itemName;
            //itemNameBox.TabIndex = 2;

            ComboBox ItemRarityBox = new ComboBox();
            ItemRarityBox.FormattingEnabled = true;
            ItemRarityBox.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary",
            "Unique"});
            ItemRarityBox.Location = new System.Drawing.Point(198, yPosition);
            ItemRarityBox.Name = "ItemRarityBox";
            ItemRarityBox.Size = new System.Drawing.Size(121, 21);
            if (itemRarity != "null")
                ItemRarityBox.Text = itemRarity;
            //ItemRarityBox.TabIndex = 3;

            TextBox ItemStatBox = new TextBox();
            if (itemAttributes != "null")
                ItemStatBox.Text = itemAttributes;
            ItemStatBox.Location = new System.Drawing.Point(325, yPosition);
            ItemStatBox.Name = "ItemStatBox";
            ItemStatBox.Size = new System.Drawing.Size(135, 20);
            //ItemStatBox.TabIndex = 4;

            TextBox ItemStatBox2 = new TextBox();
            if (itemAttributes != "null")
                ItemStatBox2.Text = itemAttributes2;
            ItemStatBox2.Location = new System.Drawing.Point(325 + 140, yPosition);
            ItemStatBox2.Name = "ItemStatBox2";
            ItemStatBox2.Size = new System.Drawing.Size(125, 20);
            //ItemStatBox.TabIndex = 4;

            Button SearchFull = new Button();
            SearchFull.Location = new System.Drawing.Point(450 + 145, yPosition);
            SearchFull.Name = "SearchFull";
            SearchFull.Size = new System.Drawing.Size(75, 23);
            //SearchFull.TabIndex = 5;
            SearchFull.Text = "Search Full";
            SearchFull.UseVisualStyleBackColor = true;
            SearchFull.Click += new System.EventHandler(this.SearchFull_Click);

            Button SearchBasic = new Button();
            SearchBasic.Location = new System.Drawing.Point(525 + 145, yPosition);
            SearchBasic.Name = "SearchBasic";
            SearchBasic.Size = new System.Drawing.Size(90, 23);
            SearchBasic.Text = "Search Basic";
            SearchBasic.UseVisualStyleBackColor = true;
            SearchBasic.Click += new System.EventHandler(this.SearchBasic_Click);

            TextBox PriceTextbox = new TextBox();
            if (itemPrice != "null")
                PriceTextbox.Text = itemPrice;
            PriceTextbox.Location = new System.Drawing.Point(620 + 145, yPosition);
            PriceTextbox.Name = "PriceTextBox";
            PriceTextbox.Size = new System.Drawing.Size(80, 20);
            //ItemStatBox.TabIndex = 4;

            gbox = new GroupBox();

            gbox.Controls.Add(itemNameBox);
            gbox.Controls.Add(ItemRarityBox);
            gbox.Controls.Add(SearchFull);
            gbox.Controls.Add(SearchBasic);
            gbox.Controls.Add(ItemStatBox);
            gbox.Controls.Add(ItemStatBox2);
            gbox.Controls.Add(PriceTextbox);
            gbox.Location = new System.Drawing.Point(12, 22 + (42 * item_counter));
            gbox.Name = "GroupBox";
            gbox.Size = new System.Drawing.Size(850, 40);
            //gbox.TabIndex = 7;
            gbox.TabStop = false;
            //gbox.Text = "Item Generated";

            panel1.Controls.Add(gbox);
            //this.Controls.Add(gbox);

            item_counter++;

            groupBoxData group = new groupBoxData();
            group.groupBox = gbox;
            group.itemName = itemNameBox;
            group.itemRarity = ItemRarityBox;
            group.itemAttribute = ItemStatBox;
            group.itemAttribute2 = ItemStatBox2;
            group.SearchFull = SearchFull;
            group.SearchBasic = SearchBasic;
            group.itemPrice = PriceTextbox;

            gboxes.Add(group);


            ItemStatBox.AutoCompleteMode = AutoCompleteMode.Append;
            ItemStatBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ItemStatBox.AutoCompleteCustomSource = col;
            ItemStatBox2.AutoCompleteCustomSource = col;


        }
        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        private void ItemStatsAutoFillSetup()
        {
            col.Add("Action Speed");
            col.Add("Additional Armor Rating");
            col.Add("Additional Magical Damage");
            col.Add("Addidiontal Memory Capacity");
            col.Add("Additional Move Speed");
            col.Add("Additional Physical Damage");
            col.Add("Additional Weapon Damage");
            col.Add("Agility");
            col.Add("All Attributes");
            col.Add("Armor Penetration");
            col.Add("Buff Duration Bonus");
            col.Add("Debuff Duration Bonus");
            col.Add("Dexterity");
            col.Add("Knowledge");
            col.Add("Luck");
            col.Add("Magic Penetration");
            col.Add("Magic Resistance");
            col.Add("Magical Damage Bonus");
            col.Add("Magical Damage Reduction");
            col.Add("Magical Healing");
            col.Add("Magical Power");
            col.Add("Max Health");
            col.Add("Max Health Bonus");
            col.Add("Memory Capacity Bonus");
            col.Add("Move Speed Bonus");
            col.Add("Physical Damage Bonus");
            col.Add("Physical Damage Reduction");
            col.Add("Physical Healing");
            col.Add("Physical Power");
            col.Add("Projectile Damage Reduction");
            col.Add("Resourcefulness");
            col.Add("Strength");
            col.Add("True Magical Damage");
            col.Add("True Physical Damage");
            col.Add("Vigor");
            col.Add("Will");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GenerateGbox("null", "null", "null", "null", "null");
        }
        #endregion

        void loadPage(int page)
        {

            for (int x = 0; x < loadedItems.Count; x++)
            {
                if (loadedItems[x].itemPage == page)
                {
                    GenerateGbox(loadedItems[x].itemName, loadedItems[x].itemRarity, loadedItems[x].itemAttributes, loadedItems[x].itemAttributes2, loadedItems[x].itemPrice);
                }
            }
        }

        #region Json
        private void FindAllJson()
        {
            List<string> jsonFiles = new List<string>();
            PageList.Items.Clear();
            int pageCount = 0;
            foreach (string fileName in Directory.GetFiles("loadouts", "*.json"))
            {
                jsonFiles.Add(fileName);
                PageList.Items.Add(fileName);
                pageCount++;
            }

            //if (pageCount > 0)
            //{
            //    PageList.SelectedIndex = 0;
            //}
            //var loadoutJson = File.ReadAllText(jsonFiles[0]);
            Debug.WriteLine("aa");
            //JsonLoad();
        }

        private void CreateJson()
        {
            string loadoutname = NewLoadoutText.Text;

            if (loadoutname != null)
            {
                string loadoutDirectory = "loadouts";
                loadoutDirectory += @"\";
                loadoutDirectory += loadoutname;
                loadoutDirectory += ".json";

                List<Gear> listOfItems = new List<Gear>();

                //File.WriteAllText(loadoutDirectory, "empty");

                string jsonString = JsonSerializer.Serialize(listOfItems);
                File.WriteAllText(loadoutDirectory, jsonString);
            }
        }

        private void JsonLoad()
        {
            string loadoutName = PageList.SelectedItem.ToString();
            string debug = Properties.Settings.Default.LastSelectedLoadout;
            Properties.Settings.Default.LastSelectedLoadout = loadoutName;
            Properties.Settings.Default.Save();
            var loadoutJson = File.ReadAllText(loadoutName);
            loadedItems = JsonSerializer.Deserialize<List<Gear>>(loadoutJson);
            loadPage(0);
            CalculateAveragePrice();

        }

        private void SelectLoadoutWithName(string name)
        {
            bool foundLoadout = false;
            for (int x = 0; x < PageList.Items.Count; x++)
            {
                string value = PageList.GetItemText(PageList.Items[x]);
                if (string.Equals(name, value))
                {

                    PageList.SelectedIndex = x;

                    Debug.WriteLine(name);
                    foundLoadout = true;
                    break;
                }
            }

            if (!foundLoadout)
            {
                if (PageList.Items.Count > 0)
                {
                    PageList.SelectedIndex = 0;
                }
            }



        }

        private void JsonSave(string loadoutName)
        {
            int gboxesSize = gboxes.Count;

            List<Gear> listOfItems = new List<Gear>();


            foreach (groupBoxData gp in gboxes)
            {
                Gear newItem = new Gear();
                newItem.itemName = gp.itemName.Text;
                newItem.itemRarity = gp.itemRarity.Text;
                newItem.itemAttributes = gp.itemAttribute.Text;
                newItem.itemAttributes2 = gp.itemAttribute2.Text;
                newItem.itemPrice = gp.itemPrice.Text;

                listOfItems.Add(newItem);

            }


            List<Page> pages = new List<Page>();
            Page newpage = new Page();
            pages.Add(newpage);

            pages[0].page = 0;
            pages[0].pageName = "Standard";


            string jsonString = JsonSerializer.Serialize(listOfItems);
            string jsonPage = JsonSerializer.Serialize(pages);
            File.WriteAllText(loadoutName, jsonString);
            //File.WriteAllText("loadoutpages.json", jsonPage);
        }

        private void LoadJson_Click(object sender, EventArgs e)
        {

            FindAllJson();
        }

        private void SaveJson_Click(object sender, EventArgs e)
        {
            JsonSave(PageList.SelectedItem.ToString());
        }

        private void NewLoadoutButton_Click(object sender, EventArgs e)
        {
            CreateJson();
            FindAllJson();
            PageList.SelectedIndex = PageList.Items.Count - 1;
            NewLoadoutText.Clear();
            //PageList.SelectedIndex = -1;

        }

        private void PageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGboxes();
            JsonLoad();
        }
        #endregion

        #region Price_Calculation
        void CalculateAveragePrice()
        {
            int totalvalue = 0;
            for (int x = 0; x < gboxes.Count; x++)
            {
                if (gboxes[x].itemPrice.Text != " ")
                {
                    try
                    {
                        int result = Int32.Parse(gboxes[x].itemPrice.Text);
                        totalvalue += result;
                        //Console.WriteLine(result);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to parse");
                    }
                }
            }
            LoadoutPriceDisplaye.Text = totalvalue.ToString() + " G";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CalculateAveragePrice();
        }

        #endregion

        List<Gear> loadedItems;




        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            //SaveData();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //ClearGboxes();
            //LoadData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        #region Resolution
        private void loadResolution()
        {
            int newRes = Properties.Settings.Default.ResolutionDefault;

            resolution = newRes;

            if (newRes == 0)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resolution = 0;
            Properties.Settings.Default.ResolutionDefault = 0;
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resolution = 1;
            Properties.Settings.Default.ResolutionDefault = 1;
            Properties.Settings.Default.Save();
        }
        #endregion

        int listing_mousexpos;
        int listing_mouseypos;
        #region Listing
        private void ListingSearch()
        {
            listing_mousexpos = Cursor.Position.X;
            listing_mouseypos = Cursor.Position.Y;
            ClickSearchListing();

        }

        private void OpenMyListing()
        {
            ClickMarketplace();
            System.Threading.Thread.Sleep(500);
            ClickMarketListing();
        }

        private void ReturnToSelectedListed()
        {
            ClickMarketListing();
            System.Threading.Thread.Sleep(SleepTime * 15);
            //LeftMouseClick(listing_mousexpos, listing_mouseypos);
            LeftMouseClick(1016, 621);
        }

        private void SellCheapest()
        {
            string price = ScreenShotAndReadCheapest();
            string numeric = new String(price.Where(char.IsDigit).ToArray());
            SearchItemNameLabel.Text = numeric;
            OriginalPriceText.Text = price;
            ClickMarketListing();
            System.Threading.Thread.Sleep(SleepTime * 15);
            //LeftMouseClick(listing_mousexpos, listing_mouseypos);
            LeftMouseClick(1016, 621);
            Clipboard.SetText(numeric);
            SendKeys.Send("^{v}");
            System.Threading.Thread.Sleep(SleepTime);
            ClickMarketCreateListing();
            DisplayPriceBox(numeric);
        }

        string ScreenShotAndReadCheapest()
        {

            int screenx = (int)(1496 / ResolutionDivide());
            int screeny = (int)(353 / ResolutionDivide());

            Bitmap screen = CaptureScreen(screenx - (int)(26 / ResolutionDivide()), screeny - (int)(12 / ResolutionDivide()), 100, 40);


            Bitmap d = new Bitmap(screen.Width, screen.Height);

            for (int i = 0; i < screen.Width; i++)
            {
                for (int x = 0; x < screen.Height; x++)
                {
                    Color oc = screen.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    d.SetPixel(i, x, nc);
                }
            }

            screen = d;

            screen = ProcessImage(screen, 1, 2, 1);

            ScreenShotBox.Image = screen;

            //string readtext = new IronOcr.IronTesseract().Read(screen).Text;
            //label1.Text = readtext;

            string readtext;

            Pix img = PixConverter.ToPix(screen);



            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var img_new = img)
                {
                    using (var page = engine.Process(img_new))
                    {
                        readtext = page.GetText();
                    }
                }
            }

            //SearchItemNameLabel.Text = readtext;

            return readtext;
        }

        #endregion


        #region Read_Button_Press
        string itemToList;
        private void HandleHotkey()
        {
            // Do stuff...
            //label1.Text = "worked.";

            int screenx = Cursor.Position.X;
            int screeny = Cursor.Position.Y;

            if (screenx >= 1555)
                screenx = 1555;

            Bitmap screen = CaptureScreen(screenx + 25, screeny + 30, 300, 30);


            Bitmap d = new Bitmap(screen.Width, screen.Height);

            for (int i = 0; i < screen.Width; i++)
            {
                for (int x = 0; x < screen.Height; x++)
                {
                    Color oc = screen.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    d.SetPixel(i, x, nc);
                }
            }

            screen = d;

            screen = ProcessImage(screen, 1, 2, 1);

            ScreenShotBox.Image = screen;

            //string readtext = new IronOcr.IronTesseract().Read(screen).Text;
            //label1.Text = readtext;

            string readtext;

            Pix img = PixConverter.ToPix(screen);



            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var img_new = img)
                {
                    using (var page = engine.Process(img_new))
                    {
                        readtext = page.GetText();
                    }
                }
            }

            SearchItemNameLabel.Text = readtext;

            itemToList = readtext;

            //System.Threading.Thread.Sleep(SleepTime);
            ClickViewMarket();
            System.Threading.Thread.Sleep(SleepTime * 15);
            clickResetFilters();
            System.Threading.Thread.Sleep(SleepTime);
            InputAndClickItemName(readtext);
            System.Threading.Thread.Sleep(SleepTime);
            ClickSearchButton();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }


        public static class Constants
        {
            //windows message id for hotkey
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }

        public static Bitmap CaptureScreen(int x, int y, int width, int height)
        {
            var bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(x, y, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
            }
            return bitmap;
        }
        #endregion 

        public Bitmap ProcessImage(Bitmap originalImage, float brightness, float contrast, float gamma)
        {
            //Bitmap originalImage;
            Bitmap adjustedImage = new Bitmap(originalImage.Width, originalImage.Height);
            //float brightness = 1.0f; // no change in brightness
            //float contrast = 2.0f; // twice the contrast
            //float gamma = 1.0f; // no change in gamma

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
            new float[] {contrast, 0, 0, 0, 0}, // scale red
            new float[] {0, contrast, 0, 0, 0}, // scale green
            new float[] {0, 0, contrast, 0, 0}, // scale blue
            new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
            new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(adjustedImage);
            g.DrawImage(originalImage, new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                , 0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes);

            return adjustedImage;
        }


        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private static readonly int VK_SNAPSHOT = 0x2C; //This is the print-screen key.
        private static readonly int VK_F1 = 0x70;
        private static readonly int VK_F2 = 0x71;
        private static readonly int VK_F3 = 0x72;
        private static readonly int VK_F4 = 0x73;
        private static readonly int VK_F5 = 0x74;

        //Assume the timer is setup with Interval = 16 (corresponds to ~60FPS).
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        private void timer1_Tick(object sender, EventArgs e)
        {

            //F1 HOTKEY.

            short f1keyState = GetAsyncKeyState(VK_F1);
            //Check if the MSB is set. If so, then the key is pressed.
            bool f1IsPressed = ((f1keyState >> 15) & 0x0001) == 0x0001;
            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool f1unprocessedPress = ((f1keyState >> 0) & 0x0001) == 0x0001;

            if (f1IsPressed)
            {
                ListingSearch();
                //TODO Execute client code...

            }

            if (f1unprocessedPress)
            {
                //TODO Execute client code...
            }

            //F2HOTKEY
            short f2keyState = GetAsyncKeyState(VK_F2);
            //Check if the MSB is set. If so, then the key is pressed.
            bool f2IsPressed = ((f2keyState >> 15) & 0x0001) == 0x0001;
            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool f2unprocessedPress = ((f2keyState >> 0) & 0x0001) == 0x0001;

            if (f2IsPressed)
            {
                //ListingSearch();
                OpenMyListing();

                //TODO Execute client code...

            }

            if (f2unprocessedPress)
            {
                //TODO Execute client code...
            }


            //F3 HOTKEY
            short f3keyState = GetAsyncKeyState(VK_F3);
            //Check if the MSB is set. If so, then the key is pressed.
            bool f3IsPressed = ((f3keyState >> 15) & 0x0001) == 0x0001;
            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool f3unprocessedPress = ((f3keyState >> 0) & 0x0001) == 0x0001;

            if (f3IsPressed)
            {
                ReturnToSelectedListed();
                //TODO Execute client code...

            }

            if (f3unprocessedPress)
            {

                //TODO Execute client code...
            }

            short f4keyState = GetAsyncKeyState(VK_F4);

            //Check if the MSB is set. If so, then the key is pressed.
            bool f4IsPressed = ((f4keyState >> 15) & 0x0001) == 0x0001;

            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool f4unprocessedPress = ((f4keyState >> 0) & 0x0001) == 0x0001;

            if (f4IsPressed)
            {
                SellCheapest();
                //TODO Execute client code...

            }

            if (f4unprocessedPress)
            {

                //TODO Execute client code...
            }

            short f5keyState = GetAsyncKeyState(VK_F5);

            //Check if the MSB is set. If so, then the key is pressed.
            bool f5IsPressed = ((f5keyState >> 15) & 0x0001) == 0x0001;

            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool f5unprocessedPress = ((f5keyState >> 0) & 0x0001) == 0x0001;

            if (f5IsPressed)
            {

                //TODO Execute client code...

            }

            if (f5unprocessedPress)
            {
                if (isSideLoaderCalled == false)
                {

                    CallSideLoadout();
                }
                else
                {
                    CloseSideLoadout();
                }
                //TODO Execute client code...
            }
        }

        private void DisplayPriceBox(string price)
        {
            PriceForm f2 = new PriceForm(price);
            f2.Location = new Point((int)(812 / ResolutionDivide()), (int)(666 / ResolutionDivide()));
            f2.TopMost = true;
            f2.ShowDialog();

        }


        SideLoadout f3 = null;
        bool isSideLoaderCalled = false;
        private void SideLoadoutButton_Click(object sender, EventArgs e)
        {
            CallSideLoadout();
        }


        private void CallSideLoadout()
        {
            if (f3 == null && isSideLoaderCalled == false)
            {
                f3 = new SideLoadout(this);
                f3.TopMost = true;

                f3.Show();
                f3.Location = new Point((int)(321 / ResolutionDivide()), (int)(532 / ResolutionDivide()));
                isSideLoaderCalled = true;
                f3.loadSideLoadoutButtons(gboxes.Count);

            }
        }

        private void CloseSideLoadout()
        {
            f3.Close();
            CallSideLoaderClose();
        }

        public void CallSideLoaderClose()
        {
            isSideLoaderCalled = false;
            f3 = null;
        }

        public void SideLoadoutClicked(int position)
        {
            gboxes[position].SearchFull.PerformClick();
        }

        public void SideLoadoutClickedBasic(int position)
        {
            gboxes[position].SearchBasic.PerformClick();
        }

        public string ReturnItemNameInGboxPosition(int position)
        {
            string itemname;
            itemname = gboxes[position].itemName.Text;
            return itemname;
        }

      

    }

    class groupBoxData
    {
        public GroupBox groupBox;
        public TextBox itemName;
        public ComboBox itemRarity;
        public TextBox itemAttribute;
        public TextBox itemAttribute2;
        public Button SearchFull;
        public Button SearchBasic;
        public TextBox itemPrice;

    }

    public class KeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(hWnd, id);
        }
    }


    [System.Serializable]

    public class Gear
    {
        public string itemName { get; set; }
        public string itemRarity { get; set; }
        public string itemAttributes { get; set; }
        public string itemAttributes2 { get; set; }
        public string itemPrice { get; set; }
        public int itemPage { get; set; }
    }

    public class Page
    {
        public int page { get; set; }
        public string pageName { get; set; }
    }

    public class SavedObject
    {
        public List<string> itemName = new List<string>();
        public List<string> itemRarity = new List<string>();
        public List<string> itemAttributes = new List<string>();
    }
}
