using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsReceptenBoek
{
    public partial class BekijkReceptForm : Form
    {
        private Recept bekekenRecept;

        public BekijkReceptForm(Recept recept)
        {
            InitializeComponent();

            bekekenRecept = recept;

            // Vul de tekstvakken met de gegevens van het recept
            naamTextbox.Text = bekekenRecept.Naam;
            ingrediëntenTextbox.Text = bekekenRecept.Ingrediënten;
            instructiesTextbox.Text = bekekenRecept.Instructies;

            // Voeg hier code toe om afbeeldingen weer te geven in de PictureBox
            // Je kunt dit doen met behulp van bekekenRecept.ID om de juiste afbeeldingen op te halen uit de database of een map.
            pictureBox.ImageLocation = bekekenRecept.ImageLink;
        }
    }

}
