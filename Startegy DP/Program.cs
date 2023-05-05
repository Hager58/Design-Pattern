using Startegy_DP.Classes;

namespace Startegy_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team(new AttackStrategy());

            team.PlayGame();

            team.SetStrategy(new DefendStartegy());

            team.PlayGame();

        }
    }
}