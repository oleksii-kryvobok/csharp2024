using System;
namespace ConsoleApp7
{
    /* Task 1 - 06.03.2024
    class Book
    {
        private Title title;
        private Author author;
        private Content content;
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Title: " + title);
            Console.ResetColor();
        }
    }
    class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: " + author);
            Console.ResetColor();
        }
    }
    class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Content: \n\"" + content + "\"");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // edit 17.04.2024: book data is now provided by the user
            string bookTitle, bookAuthor, bookContent;
            Console.Write("Enter book title: "); bookTitle = Console.ReadLine();
            Console.Write("Enter book author: "); bookAuthor = Console.ReadLine();
            Console.Write("Enter book content: "); bookContent = Console.ReadLine();
            Book theBook = new Book(bookTitle, bookAuthor, bookContent);
            theBook.Show();
            Console.ReadKey();
        }
    }
    ===== Task 1 */


  
    /* Task 2 - 06.03.2024
    class Point
    {
        private int c1;
        private int c2;
        private string label;
        public Point(int c1, int c2, string label)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.label = label;
        }
        public int Coord1 { get { return c1; } }
        public int Coord2 { get { return c2; } }
        public string Label { get { return label; } }
    }
    class Figure
    {
        private Point[] points;
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                //throw new ArgumentException("Too many or too few polygon sides.");
                Console.WriteLine("Too many or too few polygon sides, program terminated.");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            this.points = points;
        }
        public double CalculateLengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.Coord1 - A.Coord1, 2) + Math.Pow(B.Coord2 - A.Coord2, 2));
        }
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int next = (i + 1) % points.Length;
                perimeter += CalculateLengthSide(points[i], points[next]);
            }
            Console.WriteLine("Perimeter (rounded): " + Math.Round(perimeter, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 5, "A"); // 0, 5
            Point B = new Point(1, 7, "B"); // 1, 7
            Point C = new Point(5, 1, "C"); // 5, 1
            Point D = new Point(10, 7, "D"); // 10, 7
            Point E = new Point(9, 5, "E"); // 9, 5
            //Point F = new Point(10, 10, "F"); // 10, 10
            //Figure figure = new Figure(A, B, C, D, E, F);
            Figure figure = new Figure(A, B, C, D, E);
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
    ===== Task 2 */
}
