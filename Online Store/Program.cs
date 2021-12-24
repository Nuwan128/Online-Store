using System;

namespace Online_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();
            PurchaseItem();
        }

        static void welcome()
        {
            Console.WriteLine("Hello,welcome to online store !!");
            Console.WriteLine("Book");
            Console.WriteLine("Pen");
            Console.WriteLine("A4");
            Console.WriteLine("Stikers");

        }
        static void PurchaseItem()
        {
            Console.WriteLine("what do you like to buy?");
            var item = Console.ReadLine();
            switch (item)
            {
                case "Book":
                    Book book = new Book();
                    book.Title = "Abayaluwo";
                    book.Price = 100.55;
                    book.Authur = "T.B Ilangaratne";
                    Console.WriteLine($"you purchase  {book.Title} by " +
                        $"{book.Authur} for {book.Price}");
                    break;

                case "Pen":
                    Pen pen = new Pen();
                    pen.Title = "Office";
                    pen.Price = 10.00;
                    pen.Brand = "Atlas";
                    Console.WriteLine($"you purchase  {pen.Title} type " +
                        $"{pen.Brand} Brand pen for {pen.Price}");
                    break;

                case "A4":
                    A4 a4 = new A4();
                    a4.Title = "Papers";
                    a4.Price = 4.99;
                    a4.Quntity = 2;
                    a4.Price = a4.Price * a4.Quntity;
                    Console.WriteLine($"you purchase  {a4.Quntity} " +
                        $"{a4.Title} for {a4.Price}");
                    break;

                case "Stikers":
                    Stikers stiker = new Stikers();
                    stiker.Title = "Cartoon";
                    stiker.Price = 10.55;
                    stiker.Type = "Batman";
                    Console.WriteLine($"you purchase a {stiker.Title} " +
                        $"{stiker.Type} stiker for {stiker.Price}");
                    break;

                default:
                    break;



            }
        }

       
        
    }
    class BaseItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
    class Book : BaseItem
    {
        public string Authur { get; set; }
    }
    class Pen : BaseItem
    {
        public string Brand { get; set; }
    }
    class A4 : BaseItem
    {
        public int Quntity { get; set; }
    }
    class Stikers : BaseItem
    {
        public string Type { get; set; }
    }
}
