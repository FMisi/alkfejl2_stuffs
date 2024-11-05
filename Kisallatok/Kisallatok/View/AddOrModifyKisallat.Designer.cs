namespace Kisallatok.View
{
    partial class AddOrModifyKisallat
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
            hozzaadasButton = new Button();
            megseButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nevTextBox = new TextBox();
            nostenyRadioButton = new RadioButton();
            himRadioButton = new RadioButton();
            eletkorNumericUpDown = new NumericUpDown();
            sulyNumericUpDown = new NumericUpDown();
            kategoriaComboBox = new ComboBox();
            groupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)eletkorNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sulyNumericUpDown).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // hozzaadasButton
            // 
            hozzaadasButton.Location = new Point(79, 331);
            hozzaadasButton.Name = "hozzaadasButton";
            hozzaadasButton.Size = new Size(94, 29);
            hozzaadasButton.TabIndex = 0;
            hozzaadasButton.Text = "Hozzaadas";
            hozzaadasButton.UseVisualStyleBackColor = true;
            hozzaadasButton.Click += addButton_Click;
            // 
            // megseButton
            // 
            megseButton.Location = new Point(320, 331);
            megseButton.Name = "megseButton";
            megseButton.Size = new Size(94, 29);
            megseButton.TabIndex = 1;
            megseButton.Text = "Megse";
            megseButton.UseVisualStyleBackColor = true;
            megseButton.Click += megseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 45);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Nev";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 99);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Nem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 151);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Eletkor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 203);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 5;
            label4.Text = "Suly";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 255);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 6;
            label5.Text = "Kategoria";
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(169, 42);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(245, 27);
            nevTextBox.TabIndex = 7;
            // 
            // nostenyRadioButton
            // 
            nostenyRadioButton.AutoSize = true;
            nostenyRadioButton.Location = new Point(16, 22);
            nostenyRadioButton.Name = "nostenyRadioButton";
            nostenyRadioButton.Size = new Size(81, 24);
            nostenyRadioButton.TabIndex = 8;
            nostenyRadioButton.TabStop = true;
            nostenyRadioButton.Text = "nosteny";
            nostenyRadioButton.UseVisualStyleBackColor = true;
            // 
            // himRadioButton
            // 
            himRadioButton.AutoSize = true;
            himRadioButton.Location = new Point(151, 20);
            himRadioButton.Name = "himRadioButton";
            himRadioButton.Size = new Size(55, 24);
            himRadioButton.TabIndex = 9;
            himRadioButton.TabStop = true;
            himRadioButton.Text = "him";
            himRadioButton.UseVisualStyleBackColor = true;
            // 
            // eletkorNumericUpDown
            // 
            eletkorNumericUpDown.Location = new Point(169, 149);
            eletkorNumericUpDown.Name = "eletkorNumericUpDown";
            eletkorNumericUpDown.Size = new Size(143, 27);
            eletkorNumericUpDown.TabIndex = 10;
            // 
            // sulyNumericUpDown
            // 
            sulyNumericUpDown.Location = new Point(169, 201);
            sulyNumericUpDown.Name = "sulyNumericUpDown";
            sulyNumericUpDown.Size = new Size(143, 27);
            sulyNumericUpDown.TabIndex = 11;
            // 
            // kategoriaComboBox
            // 
            kategoriaComboBox.FormattingEnabled = true;
            kategoriaComboBox.Location = new Point(169, 252);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new Size(245, 28);
            kategoriaComboBox.TabIndex = 12;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(nostenyRadioButton);
            groupBox.Controls.Add(himRadioButton);
            groupBox.Location = new Point(169, 75);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(245, 68);
            groupBox.TabIndex = 13;
            groupBox.TabStop = false;
            // 
            // AddOrModifyKisallat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 433);
            Controls.Add(groupBox);
            Controls.Add(kategoriaComboBox);
            Controls.Add(sulyNumericUpDown);
            Controls.Add(eletkorNumericUpDown);
            Controls.Add(nevTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(megseButton);
            Controls.Add(hozzaadasButton);
            Name = "AddOrModifyKisallat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kisallat Hozzaadasa vagy Modositasa";
            ((System.ComponentModel.ISupportInitialize)eletkorNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sulyNumericUpDown).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hozzaadasButton;
        private Button megseButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nevTextBox;
        private RadioButton nostenyRadioButton;
        private RadioButton himRadioButton;
        private NumericUpDown eletkorNumericUpDown;
        private NumericUpDown sulyNumericUpDown;
        private ComboBox kategoriaComboBox;
        private GroupBox groupBox;
    }
}