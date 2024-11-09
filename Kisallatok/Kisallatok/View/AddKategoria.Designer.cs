namespace Kisallatok.View
{
    partial class AddKategoria
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
            nevTextBox = new TextBox();
            label1 = new Label();
            megseButton = new Button();
            hozzaadasButton = new Button();
            SuspendLayout();
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(203, 49);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(245, 27);
            nevTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 52);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 8;
            label1.Text = "Kategoria Neve";
            // 
            // megseButton
            // 
            megseButton.BackColor = SystemColors.ControlLight;
            megseButton.DialogResult = DialogResult.Cancel;
            megseButton.Location = new Point(354, 200);
            megseButton.Name = "megseButton";
            megseButton.Size = new Size(94, 35);
            megseButton.TabIndex = 3;
            megseButton.Text = "Megse";
            megseButton.UseVisualStyleBackColor = false;
            megseButton.Click += megseButton_Click;
            // 
            // hozzaadasButton
            // 
            hozzaadasButton.BackColor = SystemColors.ControlLight;
            hozzaadasButton.DialogResult = DialogResult.OK;
            hozzaadasButton.Location = new Point(66, 200);
            hozzaadasButton.Name = "hozzaadasButton";
            hozzaadasButton.Size = new Size(94, 35);
            hozzaadasButton.TabIndex = 2;
            hozzaadasButton.Text = "Hozzaadas";
            hozzaadasButton.UseVisualStyleBackColor = false;
            hozzaadasButton.Click += hozzaadasButton_Click;
            // 
            // AddKategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(502, 313);
            Controls.Add(megseButton);
            Controls.Add(hozzaadasButton);
            Controls.Add(nevTextBox);
            Controls.Add(label1);
            Name = "AddKategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddKategoria";
            Load += AddKategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nevTextBox;
        private Label label1;
        private Button megseButton;
        private Button hozzaadasButton;
    }
}