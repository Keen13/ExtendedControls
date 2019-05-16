﻿namespace DialogTest
{
    partial class TestTabControlCustom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ExtendedControls.TabStyleSquare tabStyleSquare2 = new ExtendedControls.TabStyleSquare();
            this.tabControlCustom1 = new ExtendedControls.ExtTabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAsGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extButton1 = new ExtendedControls.ExtButton();
            this.extButton2 = new ExtendedControls.ExtButton();
            this.tabControlCustom1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCustom1
            // 
            this.tabControlCustom1.AllowDragReorder = false;
            this.tabControlCustom1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControlCustom1.Controls.Add(this.tabPage1);
            this.tabControlCustom1.Controls.Add(this.tabPage2);
            this.tabControlCustom1.Controls.Add(this.tabPage3);
            this.tabControlCustom1.Controls.Add(this.tabPage4);
            this.tabControlCustom1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlCustom1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tabControlCustom1.Location = new System.Drawing.Point(0, 100);
            this.tabControlCustom1.Name = "tabControlCustom1";
            this.tabControlCustom1.SelectedIndex = 0;
            this.tabControlCustom1.Size = new System.Drawing.Size(1027, 379);
            this.tabControlCustom1.TabColorScaling = 0.5F;
            this.tabControlCustom1.TabControlBorderBrightColor = System.Drawing.Color.LightGray;
            this.tabControlCustom1.TabControlBorderColor = System.Drawing.Color.DarkGray;
            this.tabControlCustom1.TabDisabledScaling = 0.5F;
            this.tabControlCustom1.TabIndex = 0;
            this.tabControlCustom1.TabMouseOverColor = System.Drawing.Color.White;
            this.tabControlCustom1.TabNotSelectedBorderColor = System.Drawing.Color.Gray;
            this.tabControlCustom1.TabNotSelectedColor = System.Drawing.Color.Gray;
            this.tabControlCustom1.TabOpaque = 100F;
            this.tabControlCustom1.TabSelectedColor = System.Drawing.Color.LightGray;
            this.tabControlCustom1.TabStyle = tabStyleSquare2;
            this.tabControlCustom1.TextNotSelectedColor = System.Drawing.SystemColors.ControlText;
            this.tabControlCustom1.TextSelectedColor = System.Drawing.SystemColors.ControlText;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addAsGridToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Image = global::DialogTest.Properties.Resources.edlogo24;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // addAsGridToolStripMenuItem
            // 
            this.addAsGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem});
            this.addAsGridToolStripMenuItem.Name = "addAsGridToolStripMenuItem";
            this.addAsGridToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.addAsGridToolStripMenuItem.Text = "Add as Grid";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Image = global::DialogTest.Properties.Resources.galaxy;
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(981, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(981, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extButton2);
            this.panel1.Controls.Add(this.extButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 100);
            this.panel1.TabIndex = 1;
            // 
            // extButton1
            // 
            this.extButton1.Location = new System.Drawing.Point(44, 13);
            this.extButton1.Name = "extButton1";
            this.extButton1.Size = new System.Drawing.Size(75, 23);
            this.extButton1.TabIndex = 0;
            this.extButton1.Text = "T12";
            this.extButton1.UseVisualStyleBackColor = true;
            this.extButton1.Click += new System.EventHandler(this.extButton1_Click);
            // 
            // extButton2
            // 
            this.extButton2.Location = new System.Drawing.Point(192, 12);
            this.extButton2.Name = "extButton2";
            this.extButton2.Size = new System.Drawing.Size(75, 23);
            this.extButton2.TabIndex = 1;
            this.extButton2.Text = "T20";
            this.extButton2.UseVisualStyleBackColor = true;
            this.extButton2.Click += new System.EventHandler(this.extButton2_Click);
            // 
            // TestTabControlCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 602);
            this.Controls.Add(this.tabControlCustom1);
            this.Controls.Add(this.panel1);
            this.Name = "TestTabControlCustom";
            this.Text = "Form1";
            this.tabControlCustom1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtTabControl tabControlCustom1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAsGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private ExtendedControls.ExtButton extButton2;
        private ExtendedControls.ExtButton extButton1;
    }
}