namespace gyak2.View
{
    partial class HeroesApp
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
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            addHeroToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            listHeroToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, listToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addHeroToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "&Add";
            // 
            // addHeroToolStripMenuItem
            // 
            addHeroToolStripMenuItem.Name = "addHeroToolStripMenuItem";
            addHeroToolStripMenuItem.Size = new Size(125, 26);
            addHeroToolStripMenuItem.Text = "Hero";
            addHeroToolStripMenuItem.Click += addHeroToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listHeroToolStripMenuItem });
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(45, 24);
            listToolStripMenuItem.Text = "&List";
            // 
            // listHeroToolStripMenuItem
            // 
            listHeroToolStripMenuItem.Name = "listHeroToolStripMenuItem";
            listHeroToolStripMenuItem.Size = new Size(125, 26);
            listHeroToolStripMenuItem.Text = "Hero";
            listHeroToolStripMenuItem.Click += listHeroToolStripMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 28);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(800, 422);
            dataGridView.TabIndex = 1;
            // 
            // HeroesApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HeroesApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeroesApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem addHeroToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem listHeroToolStripMenuItem;
        private DataGridView dataGridView;
    }
}