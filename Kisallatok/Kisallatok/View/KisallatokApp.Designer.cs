﻿namespace Kisallatok.View
{
    partial class KisallatokApp
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
            menuStrip1 = new MenuStrip();
            hozzaadasToolStripMenuItem = new ToolStripMenuItem();
            kisallatAdd = new ToolStripMenuItem();
            kategoriaToolStripMenuItem = new ToolStripMenuItem();
            listazasToolStripMenuItem = new ToolStripMenuItem();
            listKisallat = new ToolStripMenuItem();
            exportalasToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hozzaadasToolStripMenuItem, listazasToolStripMenuItem, exportalasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hozzaadasToolStripMenuItem
            // 
            hozzaadasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kisallatAdd, kategoriaToolStripMenuItem });
            hozzaadasToolStripMenuItem.Name = "hozzaadasToolStripMenuItem";
            hozzaadasToolStripMenuItem.Size = new Size(96, 24);
            hozzaadasToolStripMenuItem.Text = "Hozzaadas";
            // 
            // kisallatAdd
            // 
            kisallatAdd.Name = "kisallatAdd";
            kisallatAdd.Size = new Size(157, 26);
            kisallatAdd.Text = "Kisallat";
            kisallatAdd.Click += kisallatAdd_Click;
            // 
            // kategoriaToolStripMenuItem
            // 
            kategoriaToolStripMenuItem.Name = "kategoriaToolStripMenuItem";
            kategoriaToolStripMenuItem.Size = new Size(157, 26);
            kategoriaToolStripMenuItem.Text = "Kategoria";
            kategoriaToolStripMenuItem.Click += kategoriaAdd_Click;
            // 
            // listazasToolStripMenuItem
            // 
            listazasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listKisallat });
            listazasToolStripMenuItem.Name = "listazasToolStripMenuItem";
            listazasToolStripMenuItem.Size = new Size(74, 24);
            listazasToolStripMenuItem.Text = "Listazas";
            // 
            // listKisallat
            // 
            listKisallat.Name = "listKisallat";
            listKisallat.Size = new Size(224, 26);
            listKisallat.Text = "Kisallat";
            listKisallat.Click += listKisallat_Click;
            // 
            // exportalasToolStripMenuItem
            // 
            exportalasToolStripMenuItem.Name = "exportalasToolStripMenuItem";
            exportalasToolStripMenuItem.Size = new Size(92, 24);
            exportalasToolStripMenuItem.Text = "Exportalas";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 28);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(782, 425);
            dataGridView.TabIndex = 1;
            // 
            // KisallatokApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "KisallatokApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kisallat Nyilvantarto Rendszer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hozzaadasToolStripMenuItem;
        private ToolStripMenuItem kisallatAdd;
        private ToolStripMenuItem kategoriaToolStripMenuItem;
        private ToolStripMenuItem listazasToolStripMenuItem;
        private ToolStripMenuItem exportalasToolStripMenuItem;
        private ToolStripMenuItem listKisallat;
        private DataGridView dataGridView;
    }
}
