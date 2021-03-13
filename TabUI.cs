using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabs
{
    public partial class TabUI : Form
    {
        public TabUI()
        {
            InitializeComponent();
        }
        public string current_tab = "Script1";
        public int total_tabs = 0;
        string tabspath = Application.StartupPath + "\\Scripts";
        private void TabUI_Load(object sender, EventArgs e)
        {
            foreach (var item in Directory.GetFiles(tabspath))
            {
                total_tabs++;
                addtab.Visible = false;
                addtab.Parent = this;
                tabs.Controls.Add(maketab(total_tabs));
                addtab.Parent = tabs;
                addtab.Visible = true;
                if (item == tabspath + "\\Script1")
                {
                    Editor.Text = File.ReadAllText(item);
                }
            }
        }
        private void addtab_click(object sender, EventArgs e)
        {
            object[] args = new string[0];
            StreamWriter meow = new StreamWriter(tabspath + "\\" + current_tab);
            meow.Close();
            File.WriteAllText(tabspath + "\\" + current_tab, Editor.Text);
            total_tabs++;
            meow = new StreamWriter(tabspath + "\\Script" + total_tabs);
            meow.Close();
            Editor.Text = "";
            addtab.Visible = false;
            addtab.Parent = this;
            tabs.Controls.Add(maketab(total_tabs));
            addtab.Parent = tabs;
            addtab.Visible = true;
            current_tab = "Script" + total_tabs;
        }


        private void tabclick(object sender, EventArgs e)
        {
            string txtoplace = "";
            File.WriteAllText(tabspath + "/" + current_tab, Editor.Text);
            string[] args = sender.ToString().Split(' ');
            if (args[2] == current_tab) { return; }
            foreach (var itm in Directory.GetFiles(tabspath))
            {
                if (Path.GetFileName(itm) == args[2])
                {
                    txtoplace = File.ReadAllText(itm);
                }
            }
            Editor.Text = txtoplace;
            current_tab = args[2];
        }
        private void Close_Click(object sender, EventArgs e)
        {
            string[] args = sender.ToString().Split(' ');
            tabs.Controls.Find("tab" + args[3], false)[0].Parent = null;
            total_tabs--;
            for (var fuck = 0; fuck < total_tabs; fuck++)
            {
                var ind = fuck + 1;
                tabs.Controls[fuck].Controls[0].Text = "Script" + ind;
            }
            var end = 1;
            foreach (string item in Directory.GetFiles(tabspath))
            {
                if ((tabspath + "\\Script" + args[3]) != item)
                {
                    File.Move(item, tabspath + "\\Script" + end);
                    end++;
                }
                else { File.Delete(item); }
            }
        }
        private void TabUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(tabspath + "\\" + current_tab, Editor.Text);
        }
        private Panel maketab(int tab_number)
        {
            Console.WriteLine(tab_number);
            Panel tab_background = new Panel();
            Button tab_switch = new Button();
            Button tab_close = new Button();
            var defcolor = Color.FromArgb(55, 55, 55);
            // tab
            tab_background.BorderStyle = BorderStyle.FixedSingle;
            tab_background.Controls.Add(tab_switch);
            tab_background.Controls.Add(tab_close);
            tab_background.Dock = DockStyle.Left;
            tab_background.Location = new Point(0, 0);
            tab_background.Name = "tab" + tab_number;
            tab_background.Size = new Size(80, 23);
            tab_background.TabIndex = 1;
            tab_background.Margin = new Padding(0);
            // tab_switch
            tab_switch.BackColor = defcolor;
            tab_switch.FlatAppearance.MouseOverBackColor = defcolor;
            tab_switch.FlatAppearance.MouseDownBackColor = defcolor;
            tab_switch.ForeColor = Color.FromArgb(255, 255, 255);
            tab_switch.Dock = DockStyle.Left;
            tab_switch.FlatAppearance.BorderSize = 0;
            tab_switch.FlatStyle = FlatStyle.Flat;
            tab_switch.Font = new Font("Consolas", 7.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            tab_switch.Location = new Point(0, 0);
            tab_switch.Name = "tab" + tab_number + "click";
            tab_switch.Size = new Size(55, 23);
            tab_switch.TabIndex = 0;
            tab_switch.Text = "Script" + tab_number;
            tab_switch.Padding = new Padding(0, 2, 0, 0);
            tab_switch.TextAlign = ContentAlignment.MiddleCenter;
            tab_switch.UseVisualStyleBackColor = false;
            tab_switch.Click += tabclick;
            // tab_close
            tab_close.BackColor = defcolor;
            tab_close.FlatAppearance.MouseOverBackColor = defcolor;
            tab_close.FlatAppearance.MouseDownBackColor = defcolor;
            tab_close.ForeColor = Color.FromArgb(255, 255, 255);
            tab_close.Dock = DockStyle.Right;
            tab_close.FlatAppearance.BorderSize = 0;
            tab_close.FlatStyle = FlatStyle.Flat;
            tab_close.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            tab_close.Location = new Point(63, 0);
            tab_close.Name = "tab" + tab_number + "close";
            tab_close.Size = new Size(25, 23);
            tab_close.TabIndex = 1;
            tab_close.Text = "x " + tab_number;
            tab_close.Padding = new Padding(0, 2, 0, 0);
            tab_close.TextAlign = ContentAlignment.MiddleCenter;
            tab_close.UseVisualStyleBackColor = false;
            tab_close.Click += Close_Click;
            return tab_background;
        }

    }
}
