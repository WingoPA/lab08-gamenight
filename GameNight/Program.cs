const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;


string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));

Directory.SetCurrentDirectory(projectFolder);


string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);
string[] history = File.ReadAllLines(HISTORY_FILE);

System.Console.WriteLine("=== GAME NIGHT LEADER BOARD ===");
if(history.Length == 0)
{
   Console.WriteLine("No nights played yet.");
}
else
{
   Console.WriteLine("Nights played: " + history.Length);
   foreach (string line in history)
   {
       Console.WriteLine("  " + line);
   }
}
int nightNumber = history.Length + 1;
Console.WriteLine("Tonight is Night " + nightNumber + ".");


System.Console.WriteLine("PLAYERS     POINTS");


for (int i = 0; i < points.Length; i++)
{
    Console.WriteLine(players[i].PadRight(11) + points[i]);
}


int pointsTonight = 0;
int bestTonight = -1;
string winnerTonight = "";


Console.WriteLine("Leader: " + players[LeaderIndex(points)]);
Console.WriteLine("Season total: " + TotalPoints(points));




//Part 2


   for(int i = 0; i < points.Length; i++)
   {
  
       Console.Write("points tonight for " + players[i] + ": ");


       pointsTonight = Convert.ToInt32(Console.ReadLine());
       


       while(pointsTonight > MAX_POINTS || pointsTonight < 0)
   {
       System.Console.WriteLine("Points tonight must be from 0 to 20.");
       Console.Write("points tonight for " + players[i] + ": ");
       pointsTonight = Convert.ToInt32(Console.ReadLine());
   }
       int season = Convert.ToInt32(points[i]) + pointsTonight;
       points[i] = season.ToString();
       
      


       if(pointsTonight > bestTonight)
   {
       bestTonight = pointsTonight;
       winnerTonight = players[i];


   }


   }
File.WriteAllLines(POINTS_FILE, points);
System.Console.WriteLine("Tonight's winner: " + winnerTonight + " with " + bestTonight);


//Part 3

string[] newEntry = { HistoryEntry(nightNumber, winnerTonight, bestTonight) };
File.AppendAllLines(HISTORY_FILE, newEntry);


// methods
static int LeaderIndex(string[] points)
{
    int leader = 0;

    for(int i = 1; i < points.Length; i++)
    {
        if(Convert.ToInt32(points[i]) > Convert.ToInt32(points[leader]))
        {
            leader = i;
        }
    }

    return leader;
}


static int TotalPoints(string[] points)
{
    int total = 0;

    foreach(string score in points)
    {
        total += Convert.ToInt32(score);
    }

    return total;
}


static string HistoryEntry(int night, string winner, int points)
{
    return "Night " + night + ": " + winner + " won with " + points + " points";
}


