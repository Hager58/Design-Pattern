using Lab1.Observer_DP.Classes;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matchBall = new Football();

            var player1 = new Player() { PlayerNumber = 10 };
            var player2 = new Player() { PlayerNumber = 11 };
            var player3 = new Player() { PlayerNumber = 20 };
            var referee = new Referee();

            matchBall.Subscribe(player1);
            matchBall.Subscribe(player2);
            matchBall.Subscribe(player3);
            matchBall.Subscribe(referee);

            matchBall.BallPosition = new Position() { X = 1, Y = 2, Z = 3 };
        }
    }
}