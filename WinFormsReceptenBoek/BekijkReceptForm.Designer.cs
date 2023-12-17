namespace WinFormsReceptenBoek
{
    partial class BekijkReceptForm
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
            naamTextbox = new TextBox();
            ingrediëntenTextbox = new TextBox();
            instructiesTextbox = new TextBox();
            pictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // naamTextbox
            // 
            naamTextbox.Location = new Point(38, 38);
            naamTextbox.Name = "naamTextbox";
            naamTextbox.ReadOnly = true;
            naamTextbox.Size = new Size(218, 23);
            naamTextbox.TabIndex = 0;
            // 
            // ingrediëntenTextbox
            // 
            ingrediëntenTextbox.Location = new Point(38, 99);
            ingrediëntenTextbox.Name = "ingrediëntenTextbox";
            ingrediëntenTextbox.ReadOnly = true;
            ingrediëntenTextbox.Size = new Size(218, 23);
            ingrediëntenTextbox.TabIndex = 1;
            // 
            // instructiesTextbox
            // 
            instructiesTextbox.Location = new Point(38, 164);
            instructiesTextbox.Multiline = true;
            instructiesTextbox.Name = "instructiesTextbox";
            instructiesTextbox.ReadOnly = true;
            instructiesTextbox.Size = new Size(218, 205);
            instructiesTextbox.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(272, 38);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(494, 331);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 81);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Ingrediënten:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 146);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Instructies:";
            // 
            // BekijkReceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 404);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(instructiesTextbox);
            Controls.Add(ingrediëntenTextbox);
            Controls.Add(naamTextbox);
            Name = "BekijkReceptForm";
            Text = "Recept bekijken";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox naamTextbox;
        private TextBox ingrediëntenTextbox;
        private TextBox instructiesTextbox;
        private PictureBox pictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}