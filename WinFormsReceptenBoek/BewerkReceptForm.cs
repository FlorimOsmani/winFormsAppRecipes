using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsReceptenBoek
{
    public partial class BewerkReceptForm : Form
    {
        private Recept bewerkRecept;
        private DatabaseManager databaseManager;

        public BewerkReceptForm(Recept recept, DatabaseManager dbManager)
        {
            InitializeComponent();

            bewerkRecept = recept;
            databaseManager = dbManager;

            // Vul de tekstvakken met de bestaande gegevens van het recept
            naamTextbox.Text = bewerkRecept.Naam;
            ingrediëntenTextbox.Text = bewerkRecept.Ingrediënten;
            instructiesTextbox.Text = bewerkRecept.Instructies;
            imageLinkTextbox.Text = bewerkRecept.ImageLink;
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            // Haal de bijgewerkte gegevens op uit de tekstvakken
            string nieuweNaam = naamTextbox.Text;
            string nieuweIngrediënten = ingrediëntenTextbox.Text;
            string nieuweInstructies = instructiesTextbox.Text;

            // Haal de Imgur-link op uit het nieuwe tekstvak
            string nieuweImageLink = imageLinkTextbox.Text;

            // Werk het recept bij in de database
            databaseManager.WerkReceptBij(bewerkRecept.ID, nieuweNaam, nieuweIngrediënten, nieuweInstructies, nieuweImageLink);

            // Sluit het bewerkingsvenster
            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
