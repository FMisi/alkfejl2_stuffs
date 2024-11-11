namespace Kisallatok.View
{
    partial class DeleteKategoria
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
            kategoriaTorlesLabel = new Label();
            kategoriaComboBox = new ComboBox();
            torlesButton = new Button();
            megseButton = new Button();
            SuspendLayout();
            // 
            // kategoriaTorlesLabel
            // 
            kategoriaTorlesLabel.AutoSize = true;
            kategoriaTorlesLabel.Location = new Point(27, 36);
            kategoriaTorlesLabel.Name = "kategoriaTorlesLabel";
            kategoriaTorlesLabel.Size = new Size(178, 20);
            kategoriaTorlesLabel.TabIndex = 0;
            kategoriaTorlesLabel.Text = "Torlendo Kategoria Neve:";
            // 
            // kategoriaComboBox
            // 
            kategoriaComboBox.FormattingEnabled = true;
            kategoriaComboBox.Location = new Point(236, 33);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new Size(245, 28);
            kategoriaComboBox.TabIndex = 7;
            // 
            // torlesButton
            // 
            torlesButton.DialogResult = DialogResult.OK;
            torlesButton.Location = new Point(111, 171);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(94, 29);
            torlesButton.TabIndex = 8;
            torlesButton.Text = "Torles";
            torlesButton.UseVisualStyleBackColor = true;
            torlesButton.Click += torlesButton_Click;
            // 
            // megseButton
            // 
            megseButton.DialogResult = DialogResult.Cancel;
            megseButton.Location = new Point(387, 171);
            megseButton.Name = "megseButton";
            megseButton.Size = new Size(94, 29);
            megseButton.TabIndex = 9;
            megseButton.Text = "Megse";
            megseButton.UseVisualStyleBackColor = true;
            // 
            // DeleteKategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(532, 263);
            Controls.Add(megseButton);
            Controls.Add(torlesButton);
            Controls.Add(kategoriaComboBox);
            Controls.Add(kategoriaTorlesLabel);
            Name = "DeleteKategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteKategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kategoriaTorlesLabel;
        private ComboBox kategoriaComboBox;
        private Button torlesButton;
        private Button megseButton;
    }
}