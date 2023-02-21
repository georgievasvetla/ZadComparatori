using System;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2013);
            Book bookTwo = new Book("The Documents in the Case", 2007);
            Book bookThree = new Book("The Documents in the Case", 2012);
            List<Book> book = new List<Book>()
            {
                bookOne,
                bookTwo,
                bookThree

            };
            book.Sort();
            book.ForEach(x => Console.WriteLine(x.Year));
            Console.WriteLine(string.Join(" ",book.Select(x => x.Year)));
            var comperer = new BookComparatot();
            book.Sort(comperer);
            book.ForEach(x => Console.WriteLine(x.Title));
            Console.WriteLine(string.Join(" ", book.Select(x => x.Title)));

        }
    }
}