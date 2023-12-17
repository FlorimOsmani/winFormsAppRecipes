namespace WinFormsReceptenBoek
{
    partial class BewerkReceptForm
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
            opslaanButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            imageLinkTextbox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // naamTextbox
            // 
            naamTextbox.Location = new Point(46, 38);
            naamTextbox.Name = "naamTextbox";
            naamTextbox.Size = new Size(180, 23);
            naamTextbox.TabIndex = 0;
            // 
            // ingrediëntenTextbox
            // 
            ingrediëntenTextbox.Location = new Point(46, 140);
            ingrediëntenTextbox.Name = "ingrediëntenTextbox";
            ingrediëntenTextbox.Size = new Size(180, 23);
            ingrediëntenTextbox.TabIndex = 1;
            // 
            // instructiesTextbox
            // 
            instructiesTextbox.Location = new Point(46, 192);
            instructiesTextbox.Multiline = true;
            instructiesTextbox.Name = "instructiesTextbox";
            instructiesTextbox.Size = new Size(180, 91);
            instructiesTextbox.TabIndex = 2;
            // 
            // opslaanButton
            // 
            opslaanButton.Location = new Point(70, 299);
            opslaanButton.Name = "opslaanButton";
            opslaanButton.Size = new Size(131, 23);
            opslaanButton.TabIndex = 3;
            opslaanButton.Text = "Opslaan";
            opslaanButton.UseVisualStyleBackColor = true;
            opslaanButton.Click += opslaanButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Naam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Ingrediënten:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 174);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Instructies:";
            // 
            // imageLinkTextbox
            // 
            imageLinkTextbox.Location = new Point(46, 90);
            imageLinkTextbox.Name = "imageLinkTextbox";
            imageLinkTextbox.Size = new Size(180, 23);
            imageLinkTextbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 72);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Image link:";
            // 
            // BewerkReceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 346);
            Controls.Add(label4);
            Controls.Add(imageLinkTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(opslaanButton);
            Controls.Add(instructiesTextbox);
            Controls.Add(ingrediëntenTextbox);
            Controls.Add(naamTextbox);
            Name = "BewerkReceptForm";
            Text = "BewerkReceptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox naamTextbox;
        private TextBox ingrediëntenTextbox;
        private TextBox instructiesTextbox;
        private Button opslaanButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox imageLinkTextbox;
        private Label label4;
    }
}