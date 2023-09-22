using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
NÄSTA STEG är att börja jobba med show statistics

göra filsökvägen dynamisk, så den går att köra på alla enheter?

*/
namespace MagicStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string deck1 = "";
        string deck2 = "";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\john_\Desktop\Programmering\MagicStats\MagicStatsDatabase.mdf;Integrated Security=True";
        int number = 0;
        int resultOne = 0;
        int resultTwo = 0;
        DateTime dateTime;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sen utveckla denna metod till att ge all data nödvändig för att
            // displaya last logged match
            number = CreateNewMatchNr(number);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            

            dateTime = DateTime.Now;

            string query = "INSERT INTO MagicStatsTable (Deck1, Deck2, DateTime, MatchNr, Deck1Wins, Deck2Wins) VALUES (@Deck1, @Deck2, @DateTime, @MatchNr, @Deck1Wins, @Deck2Wins)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (listBoxPlayerOne.CheckedItems.Count == 0 || listBoxPlayerTwo.CheckedItems.Count == 0 || listBoxPlayerOne.SelectedIndex == listBoxPlayerTwo.SelectedIndex) // + must add result?
                    {
                        MessageBox.Show("You must check a deck for both players\nand chosen decks must be diffirent");
                    }
                    else
                    {
                        // Kanske strunta i denna MessageBox?
                        DialogResult result = MessageBox.Show("Do you want to log these results: XXXX", "Confirmation", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@Deck1", deck1);
                            command.Parameters.AddWithValue("@Deck2", deck2);
                            command.Parameters.AddWithValue("@DateTime", dateTime);
                            command.Parameters.AddWithValue("@MatchNr", number);
                            command.Parameters.AddWithValue("@Deck1Wins", resultOne);
                            command.Parameters.AddWithValue("@Deck2Wins", resultTwo);

                            connection.Open();

                            command.ExecuteNonQuery();

                            connection.Close();

                            for (int i = 0; i < listBoxPlayerOne.Items.Count; i++)
                            {
                                listBoxPlayerOne.SetItemChecked(i, false);
                                listBoxPlayerTwo.SetItemChecked(i, false);
                            }
                            btnResultOne.Font = new Font(btnResultOne.Font.FontFamily, 16, btnResultOne.Font.Style);
                            btnResultOne.Text = "Player One Result";
                            btnResultTwo.Font = new Font(btnResultTwo.Font.FontFamily, 16, btnResultTwo.Font.Style);
                            btnResultTwo.Text = "Player Two Result";
                            // UPDATE LATEST MATCH LOGGED to DISPLAY

                            number = CreateNewMatchNr(number);
                        }
                    }
                }
            }
        }

        private void listBoxPlayerOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Göra metod av detta? Nästan exakt samma kod två gånger

            int index = listBoxPlayerOne.SelectedIndex;
            int count = listBoxPlayerOne.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                    listBoxPlayerOne.SetItemCheckState(i, CheckState.Unchecked);
            }

            deck1 = ChosenDeck(index);

            picturePlayerOne.Image = Image.FromFile(@"C:\Users\john_\Desktop\Programmering\MagicStats\Images\" + deck1 + ".jpg");

            // + Visa miniatyrbild på vald lek
        }

        private void listBoxPlayerTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPlayerTwo.SelectedIndex;
            int count = listBoxPlayerTwo.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                    listBoxPlayerTwo.SetItemCheckState(i, CheckState.Unchecked);
            }

            deck2 = ChosenDeck(index);

            picturePlayerTwo.Image = Image.FromFile(@"C:\Users\john_\Desktop\Programmering\MagicStats\Images\" + deck2 + ".jpg");

            // + Visa miniatyrbild på vald lek
        }



        ////        Följande kod är för att kunna ta ut MatchNr från den senast
        ////        tillagda matchen.Så att man kan ge nästa tillagda match MatchNr+1
        public int CreateNewMatchNr(int number)
        {
            // Det ska alltid displayas latest match, på form load och efter en ny match har loggats
            // Den här koden tar ju fram senast loggade matchen
            // Borde gå att extrahera all information från den härifrån då
            // Och använda den till att displaya in the window
            string query = "SELECT TOP 1 Deck1, Deck2, DateTime, MatchNr, Deck1Wins, Deck2Wins FROM MagicStatsTable ORDER BY DateTime DESC";
            int d1w = 000;
            int d2w = 000;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Här inne kan det behövas en if-sats. För när första matchen loggas
                            // kommer inget MatchNr värde finnas (vara NULL)
                            // Typ if ( MatchNr == null) { number = 1; }
                            deck1 = reader["Deck1"].ToString();
                            deck2 = reader["Deck2"].ToString();
                            dateTime = (DateTime)reader["DateTime"];
                            number = (int)reader["MatchNr"] + 1;
                            d1w = (int)reader["Deck1Wins"];
                            d2w = (int)reader["Deck2Wins"];
                            
                        }
                    }
                }
                connection.Close();
            }
            textBoxLatestMatch.Text = $"{deck1} - {deck2}  {d1w} - {d2w}. MatchNr: {number - 1}. {dateTime.ToString("yy-MM-dd")}";
            return number;
        }

        public static string ChosenDeck(int index)
        {
            string deck = "";
            switch (index)
            {
                case 0: deck = "Batallion"; break;
                case 1: deck = "Draw Fire"; break;
                case 2: deck = "Extort"; break;
                case 3: deck = "Grave"; break;
                case 4: deck = "Illusion"; break;
                case 5: deck = "Life Gain"; break;
                case 6: deck = "Modern"; break;
                case 7: deck = "Red Deck Wins"; break;
                default: deck = "NO VALID DECK NAME"; break;
            }
            return deck;
        }

        private void btnResultOne_MouseDown(object sender, MouseEventArgs e)
        {
            btnResultOne.Font = new Font(btnResultOne.Font.FontFamily, 40, btnResultOne.Font.Style);
            if (e.Button == MouseButtons.Left)
                resultOne++;
            if (e.Button == MouseButtons.Right)
                resultOne--;
            btnResultOne.Text = resultOne.ToString();
        }

        private void btnResultTwo_MouseDown(object sender, MouseEventArgs e)
        {
            btnResultTwo.Font = new Font(btnResultTwo.Font.FontFamily, 40, btnResultTwo.Font.Style);
            if (e.Button == MouseButtons.Left)
                resultTwo++;
            if (e.Button == MouseButtons.Right)
                resultTwo--;
            btnResultTwo.Text = resultTwo.ToString();
        }
    }
}
