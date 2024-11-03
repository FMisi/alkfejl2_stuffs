namespace gyak2.View
{
    partial class AddOrModifyHero
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
            cancelButton = new Button();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            heroNameTextBox = new TextBox();
            powerComboBox = new ComboBox();
            ageNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(356, 337);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(155, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.DialogResult = DialogResult.OK;
            addButton.Location = new Point(31, 337);
            addButton.Name = "addButton";
            addButton.Size = new Size(155, 29);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 34);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Hero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Hero Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 213);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 149);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Power";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(272, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(239, 27);
            nameTextBox.TabIndex = 1;
            // 
            // heroNameTextBox
            // 
            heroNameTextBox.Location = new Point(272, 82);
            heroNameTextBox.Name = "heroNameTextBox";
            heroNameTextBox.Size = new Size(239, 27);
            heroNameTextBox.TabIndex = 2;
            // 
            // powerComboBox
            // 
            powerComboBox.FormattingEnabled = true;
            powerComboBox.Items.AddRange(new object[] { "Maga által készített", "Szerzett", "Vele született" });
            powerComboBox.Location = new Point(272, 141);
            powerComboBox.Name = "powerComboBox";
            powerComboBox.Size = new Size(239, 28);
            powerComboBox.TabIndex = 3;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(272, 206);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(239, 27);
            ageNumericUpDown.TabIndex = 4;
            ageNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // AddOrModifyHero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 393);
            Controls.Add(ageNumericUpDown);
            Controls.Add(powerComboBox);
            Controls.Add(heroNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOrModifyHero";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrModifyHero";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox heroNameTextBox;
        private ComboBox powerComboBox;
        private NumericUpDown ageNumericUpDown;
    }
}