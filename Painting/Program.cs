using PaintingBL;
namespace Painting
{
    class Program
    {
        static void Main(string[] args)
        {

            History famouspainting = new History();
            Console.WriteLine("Welcome to the history website of the world's famous paintings!!!");

            Console.WriteLine("PRESS ENTER KEY ONLY TO CONTINUE :)");
            Console.WriteLine("____________________");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

            Console.WriteLine("The 5 Famous Paintings In The World: ");
            Console.WriteLine();

            Paint famous1Painting = new Paint()
            {
                Title = "Mona Lisa",
                Painter = "Leonardo da Vinci",
                Date = "Year 1503 to 1519",
                Where = "Lourve Museum (Paris)",
                Description = "Famous portrait of Lisa Gherardini, known for its enigmatic smile. ",
            };

            Paint famous2Painting = new Paint()
            {
                Title = "The Starry Night",
                Painter = "Vincent van Gogh",
                Date = "Year 1889",
                Where = "Museum of Modern Art (New York City)",
                Description = "Iconic depiction of the night sky, featuring swirling clouds and stars.",
            };

            Paint famous3Painting = new Paint()
            {
                Title = "The Last Supper",
                Painter = "Leonardo da Vinci",
                Date = "Year 1495 to 1498",
                Where = "Santa Maria delle Grazie (Milan, Italy)",
                Description = "Religious mural depicting the last supper of Jesus with his disciples. ",
            };

            Paint famous4Painting = new Paint()
            {
                Title = "The Persistence of Memory",
                Painter = "Salvador Dali",
                Date = "Year 1931",
                Where = "The Museum of Modern Art (New York City)",
                Description = "Surrealist painting featuring melting clocks draped over various objects. ",
            };

            Paint famous5Painting = new Paint()
            {
                Title = "Guernica",
                Painter = "Pablo Picasso",
                Date = "Year 1937",
                Where = "Museo Reina Sofia (Madrid)",
                Description = "Powerful anti-war mural depicting the boming of Guernica during the Spanish Civil War. ",
            };

            famouspainting.DisplayPaintingHistory(famous1Painting);
            famouspainting.DisplayPaintingHistory(famous2Painting);
            famouspainting.DisplayPaintingHistory(famous3Painting);
            famouspainting.DisplayPaintingHistory(famous4Painting);
            famouspainting.DisplayPaintingHistory(famous5Painting);
        }
    }
}
