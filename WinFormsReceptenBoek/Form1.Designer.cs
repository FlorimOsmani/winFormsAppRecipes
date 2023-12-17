namespace WinFormsReceptenBoek
{
    partial class Form1
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
            receptenLijstbox = new ListBox();
            naamTextbox = new TextBox();
            ingrediëntenTextbox = new TextBox();
            instructiesTextbox = new TextBox();
            OpslaanButton = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bekijkenButton = new Button();
            imageLinkTextbox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // receptenLijstbox
            // 
            receptenLijstbox.FormattingEnabled = true;
            receptenLijstbox.ItemHeight = 15;
            receptenLijstbox.Location = new Point(353, 52);
            receptenLijstbox.Name = "receptenLijstbox";
            receptenLijstbox.Size = new Size(120, 139);
            receptenLijstbox.TabIndex = 0;
            receptenLijstbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // naamTextbox
            // 
            naamTextbox.Location = new Point(110, 22);
            naamTextbox.Name = "naamTextbox";
            naamTextbox.Size = new Size(189, 23);
            naamTextbox.TabIndex = 1;
            naamTextbox.TextChanged += textBox1_TextChanged;
            // 
            // ingrediëntenTextbox
            // 
            ingrediëntenTextbox.Location = new Point(110, 81);
            ingrediëntenTextbox.Name = "ingrediëntenTextbox";
            ingrediëntenTextbox.Size = new Size(189, 23);
            ingrediëntenTextbox.TabIndex = 2;
            // 
            // instructiesTextbox
            // 
            instructiesTextbox.Location = new Point(110, 110);
            instructiesTextbox.Multiline = true;
            instructiesTextbox.Name = "instructiesTextbox";
            instructiesTextbox.Size = new Size(189, 82);
            instructiesTextbox.TabIndex = 3;
            // 
            // OpslaanButton
            // 
            OpslaanButton.Location = new Point(139, 198);
            OpslaanButton.Name = "OpslaanButton";
            OpslaanButton.Size = new Size(137, 23);
            OpslaanButton.TabIndex = 4;
            OpslaanButton.Text = "Toevoegen";
            OpslaanButton.UseVisualStyleBackColor = true;
            OpslaanButton.Click += OpslaanButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 109);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 5;
            button2.Text = "Bewerken";
            button2.UseVisualStyleBackColor = true;
            button2.Click += bewerkenButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 145);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 6;
            button3.Text = "Verwijderen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += verwijderenButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Naam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 8;
            label2.Text = "Ingrediënten:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 113);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Instructies:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 25);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 10;
            label4.Text = "Recepten lijst:";
            // 
            // bekijkenButton
            // 
            bekijkenButton.Location = new Point(479, 74);
            bekijkenButton.Name = "bekijkenButton";
            bekijkenButton.Size = new Size(80, 23);
            bekijkenButton.TabIndex = 11;
            bekijkenButton.Text = "Bekijken";
            bekijkenButton.UseVisualStyleBackColor = true;
            bekijkenButton.Click += bekijkenButton_Click;
            // 
            // imageLinkTextbox
            // 
            imageLinkTextbox.Location = new Point(110, 52);
            imageLinkTextbox.Name = "imageLinkTextbox";
            imageLinkTextbox.Size = new Size(189, 23);
            imageLinkTextbox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 55);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 13;
            label5.Text = "Image link:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 236);
            Controls.Add(label5);
            Controls.Add(imageLinkTextbox);
            Controls.Add(bekijkenButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(OpslaanButton);
            Controls.Add(instructiesTextbox);
            Controls.Add(ingrediëntenTextbox);
            Controls.Add(naamTextbox);
            Controls.Add(receptenLijstbox);
            Name = "Form1";
            Text = "Homepage";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox receptenLijstbox;
        private TextBox naamTextbox;
        private TextBox ingrediëntenTextbox;
        private TextBox instructiesTextbox;
        private Button OpslaanButton;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bekijkenButton;
        private TextBox imageLinkTextbox;
        private Label label5;
    }
}
