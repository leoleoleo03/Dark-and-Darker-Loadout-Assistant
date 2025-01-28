using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkAndDarkerFavorite
{
    public partial class SideLoadout : Form
    {
        Form1 mainForm;

        public SideLoadout(Form1 parent)
        {
            InitializeComponent();
            mainForm = parent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            mainForm.CallSideLoaderClose();
        }

        private void SideLoadout_Load(object sender, EventArgs e)
        {

        }

        List<Button> buttonList = new List<Button>();
        List<Button> buttonListBasic = new List<Button>();

        public void loadSideLoadoutButtons(int count)
        {
            buttonList = new List<Button>();
            buttonListBasic = new List<Button>();
            //gboxesCount = gboxes.Count;
            for (int x = 0; x < count; x++)
            {
                Label itemName = new Label();
                itemName.Location = new System.Drawing.Point(5, 30 + (30 * x));
                itemName.Size = new System.Drawing.Size(100, 30);
                itemName.Text = GetItemNameInPosition(x);

                Button SearchFull = new Button();
                SearchFull.Location = new System.Drawing.Point(115, 25 + (30 * x));
                SearchFull.Size = new System.Drawing.Size(50, 25);
                SearchFull.Text = "Full";
                SearchFull.Name = "SearchFull";

                Button SearchBasic = new Button();
                SearchBasic.Location = new System.Drawing.Point(165, 25 + (30 * x));
                SearchBasic.Size = new System.Drawing.Size(50, 25);
                SearchBasic.Text = "Basic";
                SearchBasic.Name = "SearchBasic";


                buttonList.Add(SearchFull);
                buttonListBasic.Add(SearchBasic);

                this.Controls.Add(SearchFull);
                this.Controls.Add(SearchBasic);
                this.Controls.Add(itemName);
                

                SearchFull.Click += new System.EventHandler(this.SearchFull_Loadout);
                SearchBasic.Click += new System.EventHandler(this.SearchBasic_Loadout);

            }
        }

        private string GetItemNameInPosition(int itemPosition)
        {
           string itemName = mainForm.ReturnItemNameInGboxPosition(itemPosition);
            return itemName;
        }

        private void SearchFull_Loadout(object sender, EventArgs e)
        {
            int button_position = buttonList.IndexOf((Button)sender);
            Debug.WriteLine("button position is [" + button_position + "]");
            mainForm.SideLoadoutClicked(button_position);


        }

        private void SearchBasic_Loadout(object sender, EventArgs e)
        {
            int button_position = buttonListBasic.IndexOf((Button)sender);
            Debug.WriteLine("button position is [" + button_position + "]");
            mainForm.SideLoadoutClickedBasic(button_position);


        }
    }
}
