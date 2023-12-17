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

        /*private string connectionString = @"Data Source=..\..\..\Files\ReceptenDatabase.db;Version=3;";*/

        /*public void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\..\Files\ReceptenDatabase.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\..\Files\ReceptenDatabase.db");
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Recepten (ID INTEGER PRIMARY KEY AUTOINCREMENT, Naam TEXT, Ingrediënten TEXT, Instructies TEXT, ImgurLink TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }*/

        /*public void InitializeDatabase()
        {
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();
            }
        }*/

        public void InitializeDatabase()
        {
            _context.Database.EnsureCreated();
        }

        /*public void VoegReceptToe(string naam, string ingrediënten, string instructies, string imgurLink)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Recepten (Naam, Ingrediënten, Instructies, ImgurLink) VALUES (@Naam, @Ingrediënten, @Instructies, @ImgurLink)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Naam", naam);
                    command.Parameters.AddWithValue("@Ingrediënten", ingrediënten);
                    command.Parameters.AddWithValue("@Instructies", instructies);
                    command.Parameters.AddWithValue("@ImgurLink", imgurLink);

                    command.ExecuteNonQuery();
                }
            }
        }*/

        /*public void VoegReceptToe(string naam, string ingrediënten, string instructies, string imgurLink)
        {
            using (var context = new ApplicationDbContext())
            {
                var nieuwRecept = new Recept
                {
                    Naam = naam,
                    Ingrediënten = ingrediënten,
                    Instructies = instructies,
                    ImgurLink = imgurLink
                };

                context.Recepten.Add(nieuwRecept);
                context.SaveChanges();
            }
        }*/

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

        /*public void VerwijderRecept(int receptID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Recepten WHERE ID = @ReceptID";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReceptID", receptID);

                    command.ExecuteNonQuery();
                }
            }
        }*/

        public void VerwijderRecept(int receptID)
        {
            var recept = _context.Recepten.Find(receptID);
            if (recept != null)
            {
                _context.Recepten.Remove(recept);
                _context.SaveChanges();
            }
        }

        /*public void WerkReceptBij(int receptID, string nieuweNaam, string nieuweIngrediënten, string nieuweInstructies, string nieuweImgurLink)
        {
            // Voeg de Imgur-link toe aan de UPDATE-query
            string query = "UPDATE Recepten SET Naam = @NieuweNaam, Ingrediënten = @NieuweIngrediënten, Instructies = @NieuweInstructies, ImgurLink = @NieuweImgurLink WHERE ID = @ReceptID";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReceptID", receptID);
                    command.Parameters.AddWithValue("@NieuweNaam", nieuweNaam);
                    command.Parameters.AddWithValue("@NieuweIngrediënten", nieuweIngrediënten);
                    command.Parameters.AddWithValue("@NieuweInstructies", nieuweInstructies);
                    command.Parameters.AddWithValue("@NieuweImgurLink", nieuweImgurLink);

                    command.ExecuteNonQuery();
                }
            }
        }*/

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

        /*public List<Recept> HaalAlleReceptenOp()
        {
            List<Recept> recepten = new List<Recept>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Recepten";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recept recept = new Recept
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Naam = reader["Naam"].ToString(),
                                Ingrediënten = reader["Ingrediënten"].ToString(),
                                Instructies = reader["Instructies"].ToString(),
                                ImgurLink = reader["ImgurLink"].ToString()
                            };

                            recepten.Add(recept);
                        }
                    }
                }
            }

            return recepten;
        }*/

        public List<Recept> HaalAlleReceptenOp()
        {
            return _context.Recepten.ToList();
        }
    }

}
