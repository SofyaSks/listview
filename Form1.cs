using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        ListView lv;



      
        List<Tovar> tovar = new List<Tovar>() {
                new Tovar("name 1", 1000, 10),
                new Tovar("name 2", 2000, 20),
                new Tovar("name 3", 3000, 30),
                new Tovar("name 4", 4000, 40)
        };

       
        
        public Form1()
        {
            InitializeComponent();
            lv = new ListView();
            lv.SetBounds(300, 40, 300, 200);
            Controls.Add(lv);
            
            
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.Tile;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.Details;
        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            lv.SmallImageList = imageList1;
            lv.LargeImageList = imageList1;
            lv.Items.Add(new ListViewItem(tovar[0].name_tovar));
            lv.Items.Add(new ListViewItem(tovar[1].name_tovar));
            lv.Items.Add(new ListViewItem(tovar[2].name_tovar));
            lv.Items.Add(new ListViewItem(tovar[3].name_tovar));
            lv.Columns.Add("Name");
            lv.Columns[0].Width = 100;
            lv.Columns.Add("Price");
            lv.Columns[1].Width = 100;
            lv.Columns.Add("Count");
            lv.Columns[2].Width = 100;
            int i = 0;
            foreach (ListViewItem item in lv.Items)
            {
                item.SubItems.Add($"{tovar[i].price}");
                item.SubItems.Add($"{tovar[i].count}");
                item.ImageIndex = i;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv.Clear();
            int i = 0;
            foreach(Tovar item in tovar)
            {
                if (item.price >= 3000)
                {
                    lv.SmallImageList = imageList1;
                    lv.LargeImageList = imageList1;
                    int j = 0;
                    lv.Items.Add(new ListViewItem(tovar[i].name_tovar));
                    foreach (ListViewItem itemm in lv.Items)
                    {
                        itemm.SubItems.Add($"{tovar[i].price}");
                        itemm.SubItems.Add($"{tovar[i].count}");
                        itemm.ImageIndex = j;
                        j++;
                    }
                }
                else
                {
                    lv.Items.Remove(new ListViewItem(tovar[i].name_tovar));
                    
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv.Clear();
            int i = 0;
            foreach (Tovar item in tovar)
            {
                if (item.count <= 30)
                {
                    lv.SmallImageList = imageList1;
                    lv.LargeImageList = imageList1;
                    int j = 0;
                    lv.Items.Add(new ListViewItem(tovar[i].name_tovar));
                    foreach (ListViewItem itemm in lv.Items)
                    {
                        itemm.SubItems.Add($"{tovar[i].price}");
                        itemm.SubItems.Add($"{tovar[i].count}");
                        itemm.ImageIndex = j;
                        j++;
                    }
                }
                else
                {
                    lv.Items.Remove(new ListViewItem(tovar[i].name_tovar));

                }
                i++;
            }
        }
    }
}
