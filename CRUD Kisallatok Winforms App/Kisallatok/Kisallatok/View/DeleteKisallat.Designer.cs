namespace Kisallatok.View
{
    partial class DeleteKisallat
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
            torlesButton = new Button();
            megseButton = new Button();
            label1 = new Label();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // torlesButton
            // 
            torlesButton.DialogResult = DialogResult.OK;
            torlesButton.Location = new Point(99, 209);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(94, 29);
            torlesButton.TabIndex = 0;
            torlesButton.Text = "Torles";
            torlesButton.UseVisualStyleBackColor = true;
            torlesButton.Click += torlesButton_Click;
            // 
            // megseButton
            // 
            megseButton.DialogResult = DialogResult.Cancel;
            megseButton.Location = new Point(331, 209);
            megseButton.Name = "megseButton";
            megseButton.Size = new Size(94, 29);
            megseButton.TabIndex = 1;
            megseButton.Text = "Megse";
            megseButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 2;
            label1.Text = "Torlendo kisallat ID-ja:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(213, 49);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(212, 27);
            idTextBox.TabIndex = 3;
            // 
            // DeleteKisallat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(462, 293);
            Controls.Add(idTextBox);
            Controls.Add(label1);
            Controls.Add(megseButton);
            Controls.Add(torlesButton);
            Name = "DeleteKisallat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kisallat Torlese";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button torlesButton;
        private Button megseButton;
        private Label label1;
        private TextBox idTextBox;
    }
}