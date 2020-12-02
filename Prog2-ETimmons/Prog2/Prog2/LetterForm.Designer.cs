namespace UPVApp
{
    partial class LetterForm
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
            this.priceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.destComboBox = new System.Windows.Forms.ComboBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelLetterButton = new System.Windows.Forms.Button();
            this.addLetterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(207, 165);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(134, 26);
            this.priceTextBox.TabIndex = 3;
            // 
            // destComboBox
            // 
            this.destComboBox.FormattingEnabled = true;
            this.destComboBox.Location = new System.Drawing.Point(207, 104);
            this.destComboBox.Name = "destComboBox";
            this.destComboBox.Size = new System.Drawing.Size(134, 28);
            this.destComboBox.TabIndex = 2;
            this.destComboBox.SelectedIndexChanged += new System.EventHandler(this.destComboBox_SelectedIndexChanged);
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(207, 45);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(132, 28);
            this.originComboBox.TabIndex = 1;
            this.originComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fixed Price:";
            // 
            // cancelLetterButton
            // 
            this.cancelLetterButton.Location = new System.Drawing.Point(144, 220);
            this.cancelLetterButton.Name = "cancelLetterButton";
            this.cancelLetterButton.Size = new System.Drawing.Size(103, 40);
            this.cancelLetterButton.TabIndex = 5;
            this.cancelLetterButton.Text = "Cancel";
            this.cancelLetterButton.UseVisualStyleBackColor = true;
            this.cancelLetterButton.Click += new System.EventHandler(this.cancelLetterButton_Click);
            // 
            // addLetterButton
            // 
            this.addLetterButton.Location = new System.Drawing.Point(285, 220);
            this.addLetterButton.Name = "addLetterButton";
            this.addLetterButton.Size = new System.Drawing.Size(101, 40);
            this.addLetterButton.TabIndex = 4;
            this.addLetterButton.Text = "Add";
            this.addLetterButton.UseVisualStyleBackColor = true;
            this.addLetterButton.Click += new System.EventHandler(this.addLetterButton_Click);
            // 
            // LetterForm
            // 
            this.AcceptButton = this.addLetterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 320);
            this.Controls.Add(this.addLetterButton);
            this.Controls.Add(this.cancelLetterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.destComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox priceTextBox;
        private System.Windows.Forms.ComboBox destComboBox;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelLetterButton;
        private System.Windows.Forms.Button addLetterButton;
    }
}