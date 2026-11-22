using System.Globalization;

const string PLAYERS_FILE = "players.txt";
const string PONITS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);


string[] points = File.ReadAllLines(PONITS_FILE);
string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] history = File.ReadAllLines(HISTORY_FILE);


System.Console.WriteLine("PLAYERS POINTS");

for (int i = 0; i < points.Length; i++)
{
    string names = players[i];
    Console.Write(names);
    
    Console.Write(" ");

    double score = Convert.ToDouble(points[i]);
    Console.Write(score);

    System.Console.WriteLine("");
}

//static int LeaderIndexString(string[] points);

int highScore = 0;
int bestPlayer = 0;
int total = 0;

for(int i = 0; i < points.Length; i++)
{
    if (Convert.ToInt32(points[i]) > highScore)
    {
        highScore = Convert.ToInt32(points[i]);
        bestPlayer = i;
        
    }
}
System.Console.WriteLine("Leader: " + players[bestPlayer] + " with " + highScore);

//static int TotalPoints(string[] points);

for(int i = 0; i < points.Length; i++)
{
    total += Convert.ToInt32(points[i]);
}
System.Console.WriteLine("Season total: " + total);
total = 0;

//Part 2
int point = 0;

    for(int i = 0; i < points.Length; i++)
    {
    Console.Read();
    Console.WriteLine("points tonight for " + players[i] + ": " + point);
    }




//static string HistoryEntry(int night, string winner, int points);
/*
File.WriteAllLines();
File.AppendAllLines();
*/
