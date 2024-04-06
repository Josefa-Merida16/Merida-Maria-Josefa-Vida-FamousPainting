using System;
namespace PaintingBL
{
    public class History
    {
        List<Paint> paintings = new List<Paint>();

        public void DisplayPaintingHistory(Paint painting)
        {
            Console.WriteLine("Title of the Painting: " + painting.Title);
            Console.WriteLine("Artist: " + painting.Painter);
            Console.WriteLine("Date: " + painting.Date);
            Console.WriteLine("Location of the painting: " + painting.Where);
            Console.WriteLine("Description: " + painting.Description);
            Console.WriteLine("--------------------");
        }
    }
}
