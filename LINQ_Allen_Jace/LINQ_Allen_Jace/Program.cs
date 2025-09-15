using System;
using System.Linq;

namespace LINQ_Allen_Jace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game titles, ratedings, and genre
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action FPS"),
                new Game("ZombCube", 'E', "FBS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket league", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sport")
            };
            //Games from, where, and selected
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }
            //
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                             .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());
            //Games rated t for teens
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Game:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }
            //Games rated e for everyone
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E Rated Game:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}
