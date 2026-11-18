const string PLAYERS_FILE = "players.txt";
const string PONITS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);


string[] points = File.ReadAllLines(PONITS_FILE);
string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] history = File.ReadAllLines(HISTORY_FILE);

static int LeaderIndexString(string[] points);
static int TotalPoints(string[] points);
static string HistoryEntry(int night, string winner, int points);



System.Console.WriteLine("PLAYERS POINTS");

for (int i = 0; i < points.Length; i++)
{
    string names = Convert.ToString(players[i]);
    Console.Write(names);
    
    Console.Write(" ");

    double score = Convert.ToDouble(points[i]);
    Console.Write(score);

    System.Console.WriteLine("");

    
    System.Console.WriteLine("Leader: " + );
}








/*
File.WriteAllLines();
File.AppendAllLines();
*/
