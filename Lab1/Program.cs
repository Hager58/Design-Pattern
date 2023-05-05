using Lab1.Observer_DP.Classes;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FootballMatch = new Football();

            var player1 = new Player();
            var player2 = new Player();
            var player3 = new Player();
            var referee = new Referee();

            FootballMatch.AttachObserver(player1);
            FootballMatch.AttachObserver(player2);
            FootballMatch.AttachObserver(player3);
            FootballMatch.AttachObserver(referee);

            FootballMatch.MyPosition = new Position() { X = 0, Y = 0, Z = 0 };
        }
    }
}