﻿using ExtendedControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogTest
{
    public partial class TestListBoxIcon : Form
    {
        ThemeStandard theme;
        public TestListBoxIcon()
        {
            InitializeComponent();
            theme = new ThemeStandard();
            ThemeableFormsInstance.Instance = theme;
            theme.LoadBaseThemes();
            theme.SetThemeByName("Elite EuroCaps");
        }

        private void F_CheckedChanged(object sender, ItemCheckEventArgs e)
        {
            extRichTextBox1.Text += "From " + sender.GetType().Name + " " + e.Index + " c " + e.CurrentValue + " new " + e.NewValue + Environment.NewLine;
            if (sender is CheckedIconListBoxForm)
            {
                var s = sender as CheckedIconListBoxForm;
                extRichTextBox1.Text += ".. " + s.GetChecked();
            }
            if (sender is CheckedListBoxForm)
            {
                var s = sender as CheckedListBoxForm;
                extRichTextBox1.Text += ".. " + s.GetChecked();
            }

            extRichTextBox1.Select(extRichTextBox1.Text.Length, extRichTextBox1.Text.Length);
        }
        private void extButton1_Click(object sender, EventArgs e)
        {
            CheckedIconListBoxForm f = new CheckedIconListBoxForm();

            var imglist = new Image[] { Properties.Resources.edlogo24, Properties.Resources.Logo8bpp48, Properties.Resources.galaxy_white, Properties.Resources.Logo8bpp48rot, Properties.Resources.galaxy_red, };

            for (int i = 0; i < 20; i++)
                f.AddItem("T" + i.ToString(), "Tx" + i.ToString(), imglist[i % imglist.Length]);

            f.PositionBelow(extButton1, new Size(200, 300));
            f.SetChecked("Two;Four");
            f.SetColour(Color.AliceBlue, Color.DarkOrange);
            f.CheckedChanged += F_CheckedChanged;
            f.CheckBoxColor = Color.Orange;
            f.CheckBoxInnerColor = Color.Yellow;
            f.CheckColor = Color.White;
            f.FlatStyle = FlatStyle.Popup;
            //f.ImageSize = new Size(32, 32);
            f.SliderColor = Color.Green;
            f.ThumbButtonColor = Color.Red;
            f.ArrowButtonColor = Color.Yellow;
            f.TickBoxReductionSize = 8;
            f.Font = new Font("Euro Caps", 16);
            f.Show(this);
        }

        private void extButton2_Click(object sender, EventArgs e)
        {
            CheckedListBoxForm f = new CheckedListBoxForm();
            f.Items.AddRange(new string[] { "One", "Two", "Three", "Four" });
            f.PositionBelow(extButton2, new Size(200, 500));
            f.SetChecked("Two;Four");
            f.CheckedChanged += F_CheckedChanged;
            f.Show(this);

        }

        private void extButton3_Click(object sender, EventArgs e)
        {
            CheckedIconListBoxForm f = new CheckedIconListBoxForm();

            var imglist = new Image[] { Properties.Resources.edlogo24, Properties.Resources.Logo8bpp48, Properties.Resources.galaxy_white, Properties.Resources.Logo8bpp48rot, Properties.Resources.galaxy_red, };

            for (int i = 0; i < 20; i++)
                f.AddItem("T" + i.ToString(), "Tx" + i.ToString(), imglist[i % imglist.Length]);

            f.PositionBelow(extButton1, new Size(200, 300));
            f.SetChecked("Two;Four");
            f.SetColour(Color.AliceBlue, Color.Aqua);
            f.CheckedChanged += F_CheckedChanged;
            f.CheckBoxColor = Color.Orange;
            f.CheckBoxInnerColor = Color.Yellow;
            f.CheckColor = Color.White;
            f.FlatStyle = FlatStyle.System;
            //f.ImageSize = new Size(32, 32);
            f.TickBoxReductionSize = 8;
            f.Show(this);

        }


        private void extButton4_Click(object sender, EventArgs e)
        {
            CheckedIconListBoxForm f = new CheckedIconListBoxForm();

            var imglist = new Image[] { Properties.Resources.edlogo24, Properties.Resources.Logo8bpp48, Properties.Resources.galaxy_white, Properties.Resources.Logo8bpp48rot, Properties.Resources.galaxy_red, };
            for (int i = 0; i < 20; i++)
                f.AddItem("T" + i.ToString(), "Tx" + i.ToString(), imglist[i % imglist.Length]);

            f.PositionBelow(extButton1, new Size(200, 600));
            f.SetChecked("Two;Four");
            f.CheckedChanged += F_CheckedChanged;
            f.TickBoxReductionSize = 8;
            f.Font = new Font("Euro Caps", 16);
            theme.ApplyToControls(f);
            f.Show(this);

        }




        private void extButton5_Click(object sender, EventArgs e)
        {
            CheckedIconListBoxFilterForm f = new CheckedIconListBoxFilterForm();

            var imglist = new Image[] { Properties.Resources.edlogo24, Properties.Resources.Logo8bpp48, Properties.Resources.galaxy_white, Properties.Resources.Logo8bpp48rot, Properties.Resources.galaxy_red, };

            for (int i = 0; i < 50; i++)
            {
                f.AddStandardOption("T" + i.ToString(), "Tx" + i.ToString(), imglist[i % imglist.Length]);
            }

            f.AddGroupOption("T1;T2;T3;T4;", "G1-4");
            f.AddGroupOption("T5;T6;T7;T8;", "G5-8");
            f.CloseOnDeactivate = false;
            f.CheckedChanged += F_CheckedChanged;

            f.Filter("", extButton5, this, applytheme:true);

        }
    }
}
