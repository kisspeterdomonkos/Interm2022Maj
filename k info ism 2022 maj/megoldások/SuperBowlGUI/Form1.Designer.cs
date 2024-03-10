namespace SuperBowlGUI
{
    partial class SuperBowlGUI
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
            this.switchButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.romanTextBox = new System.Windows.Forms.TextBox();
            this.arabicTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(234, 43);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(65, 31);
            this.switchButton.TabIndex = 0;
            this.switchButton.Text = "--->";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(234, 129);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(65, 31);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Átvált";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Római szám [I-X]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arab szám [1-10]:";
            // 
            // romanTextBox
            // 
            this.romanTextBox.Location = new System.Drawing.Point(49, 84);
            this.romanTextBox.Name = "romanTextBox";
            this.romanTextBox.Size = new System.Drawing.Size(85, 27);
            this.romanTextBox.TabIndex = 4;
            // 
            // arabicTextBox
            // 
            this.arabicTextBox.Enabled = false;
            this.arabicTextBox.Location = new System.Drawing.Point(379, 84);
            this.arabicTextBox.Name = "arabicTextBox";
            this.arabicTextBox.Size = new System.Drawing.Size(85, 27);
            this.arabicTextBox.TabIndex = 4;
            // 
            // SuperBowlGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 222);
            this.Controls.Add(this.arabicTextBox);
            this.Controls.Add(this.romanTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.switchButton);
            this.Name = "SuperBowlGUI";
            this.Text = "Átváltó";
            this.Load += new System.EventHandler(this.SuperBowlGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button switchButton;
        private Button changeButton;
        private Label label1;
        private Label label2;
        private TextBox romanTextBox;
        private TextBox arabicTextBox;
    }
}