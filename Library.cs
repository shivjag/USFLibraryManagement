using System;
using System.Collections.Generic;

namespace USFLibraryManagement
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Person> Patrons { get; set; } = new List<Person>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person person)
        {
            Patrons.Add(person);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var patron in Patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
            }
            Console.WriteLine();
        }
    }
}
