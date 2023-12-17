using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WinFormsReceptenBoek
{
    // SQLite Database Manager Class
    public class DatabaseManager
    {
        private readonly ApplicationDbContext _context;

        public DatabaseManager()
        {
            _context = new ApplicationDbContext();
        }

        // Nieuwe constructor om een DbContext te accepteren
        public DatabaseManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\..\Files\ReceptenDatabase.db"))
            {
                CreateSQLiteDatabase();
            }

            _context.Database.EnsureCreated();
        }

        private void CreateSQLiteDatabase()
        {
            // Get the directory where the application is running
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path to the database file
            string databasePath = Path.Combine(baseDirectory, @"Files\ReceptenDatabase.db");

            string connectionString = $"Data Source={databasePath};Version=3;";

            // Ensure the directory exists before creating the file
            Directory.CreateDirectory(Path.GetDirectoryName(databasePath));

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Recepten (ID INTEGER PRIMARY KEY AUTOINCREMENT, Naam TEXT, Ingrediënten TEXT, Instructies TEXT, ImgurLink TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void VoegReceptToe(string naam, string ingrediënten, string instructies, string imageLink)
        {
            var nieuwRecept = new Recept
            {
                Naam = naam,
                Ingrediënten = ingrediënten,
                Instructies = instructies,
                ImageLink = imageLink
            };

            _context.Recepten.Add(nieuwRecept);
            _context.SaveChanges();
        }

        public void VerwijderRecept(int receptID)
        {
            var recept = _context.Recepten.Find(receptID);
            if (recept != null)
            {
                _context.Recepten.Remove(recept);
                _context.SaveChanges();
            }
        }

        public void WerkReceptBij(int receptID, string nieuweNaam, string nieuweIngrediënten, string nieuweInstructies, string nieuweImageLink)
        {
            var recept = _context.Recepten.Find(receptID);
            if (recept != null)
            {
                recept.Naam = nieuweNaam;
                recept.Ingrediënten = nieuweIngrediënten;
                recept.Instructies = nieuweInstructies;
                recept.ImageLink = nieuweImageLink;

                _context.SaveChanges();
            }
        }

        public List<Recept> HaalAlleReceptenOp()
        {
            return _context.Recepten.ToList();
        }
    }
}