using PokerOptimierung;

namespace PokerOptimierung
{
    public struct Karte
    {
        public int KartenWert;
        public int KartenFarbeWert;

        public Karte(int kartenWert, int kartenFarbeWert)
        {
            this.KartenWert = kartenWert;
            this.KartenFarbeWert = kartenFarbeWert;
        }
    }
}

public class Program
{
    private static List<Karte> deck = new List<Karte>();
    private static List<Karte> spielerKarten = new List<Karte>();
    private static List<Karte> mitteKarten = new List<Karte>();
    private static int[,] kartenMatrix = new int[4, 13];
    private static bool straightflush = false;
    private static float straightflushCount = 0;
    private static float roundsPlayed = 0;
    
    public static void Main()
    {
            while (roundsPlayed <= 10000000)
            {
                roundsPlayed++;
                GenerateDeck();
                DealCardsToPlayers();
                DealCardsToMiddle();
                InsertIntoKartenMatrix();
                CheckForStraightFlush();
                Array.Clear(kartenMatrix, 0, kartenMatrix.Length);
            }
            Console.WriteLine((straightflushCount / roundsPlayed) * 100);
    }

    private static void GenerateDeck()
    {
        deck.Clear();
        for (int f = 0; f <= 3; f++)
        {
            for (int w = 0; w <= 12; w++)
            {
                Karte karte = new Karte
                {
                    KartenWert = (w),
                    KartenFarbeWert = f
                };
                deck.Add(karte);
            }
        }
    }
    
    private static void DealCardsToPlayers()
    {
        spielerKarten.Clear();
        Random random = new Random();
        
        for (int i = 0; i <= 1; i++)
        {
            Karte karte = deck[random.Next(0, deck.Count)];
            spielerKarten.Add(karte);
            deck.Remove(karte);
        }
    }

    private static void DealCardsToMiddle()
    {
        mitteKarten.Clear();
        Random random = new Random();
        
        for (int i = 0; i <= 4; i++)
        {
            Karte karte = deck[random.Next(0, deck.Count)];
            mitteKarten.Add(karte);
            deck.Remove(karte);
        }
    }

    private static void InsertIntoKartenMatrix()
    {
        for (int m = 0; m < mitteKarten.Count; m++)
        {
            kartenMatrix[mitteKarten[m].KartenFarbeWert, mitteKarten[m].KartenWert] = 1;
        }
        
        for (int s = 0; s < spielerKarten.Count; s++)
        {
            kartenMatrix[spielerKarten[s].KartenFarbeWert, spielerKarten[s].KartenWert] = 1;
        }
    }
    
    private static void CheckForStraightFlush()
    {
        int consecutiveCards = 0;
        
        for (int row = 0; row < kartenMatrix.GetLength(0); row++)
        {
            int count = 0; 
            for (int col = 0; col < kartenMatrix.GetLength(1); col++)
            {
                if (kartenMatrix[row, col] > 0)
                {
                    count++;
                }
            }

            if (count >= 5)
            {
                int straightFlush = 0;
                for (int col = 0; col < kartenMatrix.GetLength(1); col++)
                {
                    if (kartenMatrix[row, col] > 0)
                    {
                        straightFlush++;
                    }
                    else
                    {
                        straightFlush = 0;
                    }

                    if(straightFlush >= 5)
                    {
                        straightflushCount++;
                        straightflush = true;
                    }
                }
            }
        }
    }
}
