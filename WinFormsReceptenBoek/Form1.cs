namespace WinFormsReceptenBoek
{
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;
        private readonly ApplicationDbContext _context;

        public Form1()
        {
            /*InitializeComponent();

            // Maak een instantie van de Database Manager en initialiseer de database
            databaseManager = new DatabaseManager();
            databaseManager.InitializeDatabase();

            // Laad de recepten in de lijstbox
            LaadReceptenInLijstbox();*/

            InitializeComponent();
            _context = new ApplicationDbContext();
            databaseManager = new DatabaseManager(_context);
            databaseManager.InitializeDatabase();
            LaadReceptenInLijstbox();
        }

        // In de ontsluitingsmethode of het afsluiten van het formulier
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        /*private void LaadReceptenInLijstbox()
        {
            // Haal alle recepten op uit de database en laad ze in de lijstbox
            List<Recept> recepten = databaseManager.HaalAlleReceptenOp();

            // Annuleer de databinding om duplicaten te voorkomen
            receptenLijstbox.DataSource = null;

            // Wijs de lijst met recepten toe aan de DataSource van de lijstbox
            receptenLijstbox.DataSource = recepten;

            // Toon de naam van het recept in de lijstbox
            receptenLijstbox.DisplayMember = "Naam";
        }*/

        private void LaadReceptenInLijstbox()
        {
            using (var context = new ApplicationDbContext())
            {
                receptenLijstbox.DataSource = context.Recepten.ToList();
                receptenLijstbox.DisplayMember = "Naam";
            }
        }

        // In het formulier voor het toevoegen/bewerken van recepten
        private void OpslaanButton_Click(object sender, EventArgs e)
        {
            // Haal de gegevens op uit de textboxen
            string naam = naamTextbox.Text;
            string ingrediënten = ingrediëntenTextbox.Text;
            string instructies = instructiesTextbox.Text;

            // Haal de Image-link op uit het nieuwe tekstvak
            string imageLink = imageLinkTextbox.Text;

            // Voeg het recept toe aan de database
            databaseManager.VoegReceptToe(naam, ingrediënten, instructies, imageLink);

            // Laad de bijgewerkte lijst van recepten in de lijstbox
            LaadReceptenInLijstbox();

            // Reset de textboxen
            ResetFormulier();
        }

        private void bewerkenButton_Click(object sender, EventArgs e)
        {
            // Controleer of er een item is geselecteerd in de lijstbox
            if (receptenLijstbox.SelectedItem != null)
            {
                // Haal het geselecteerde recept op
                Recept geselecteerdRecept = (Recept)receptenLijstbox.SelectedItem;

                // Open een nieuw venster voor het bewerken van het recept
                BewerkReceptForm bewerkForm = new BewerkReceptForm(geselecteerdRecept, databaseManager);
                DialogResult result = bewerkForm.ShowDialog();

                // Als het bewerken is voltooid, laad de bijgewerkte lijst van recepten in de lijstbox
                if (result == DialogResult.OK)
                {
                    LaadReceptenInLijstbox();
                }
            }
            else
            {
                MessageBox.Show("Selecteer een recept om te bewerken.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void verwijderenButton_Click(object sender, EventArgs e)
        {
            // Controleer of er een item is geselecteerd in de lijstbox
            if (receptenLijstbox.SelectedItem != null)
            {
                // Haal het geselecteerde recept op
                Recept geselecteerdRecept = (Recept)receptenLijstbox.SelectedItem;

                // Verwijder het recept uit de database
                databaseManager.VerwijderRecept(geselecteerdRecept.ID);

                // Laad de bijgewerkte lijst van recepten in de lijstbox
                LaadReceptenInLijstbox();
            }
            else
            {
                MessageBox.Show("Selecteer een recept om te verwijderen.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bekijkenButton_Click(object sender, EventArgs e)
        {
            // Controleer of er een item is geselecteerd in de lijstbox
            if (receptenLijstbox.SelectedItem != null)
            {
                // Haal het geselecteerde recept op
                Recept geselecteerdRecept = (Recept)receptenLijstbox.SelectedItem;

                // Open een nieuw venster voor het bekijken van het recept
                BekijkReceptForm bekijkForm = new BekijkReceptForm(geselecteerdRecept);
                bekijkForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecteer een recept om te bekijken.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetFormulier()
        {
            // Code om de textboxen te legen
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
