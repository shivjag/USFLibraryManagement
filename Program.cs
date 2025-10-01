using System;
using USFLibraryManagement;
class Program
{
    static void Main(string[] args)
    {
        // Initialize library
        Library library = new Library();

        // Add Books
        var b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
        var b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
        var b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

        library.AddBook(b1);
        library.AddBook(b2);
        library.AddBook(b3);

        // Add Patrons
        var s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        var s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
        var st1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

        library.AddPatron(s1);
        library.AddPatron(s2);
        library.AddPatron(st1);

        // Initial Display
        library.DisplayBooks();
        library.DisplayPatrons();

        // Borrow Scenario
        Console.WriteLine("Borrowing Books...");
        if (b2.BorrowBook()) Console.WriteLine($"{s2.Name} borrowed '{b2.Title}'");
        if (b3.BorrowBook()) Console.WriteLine($"{s1.Name} borrowed '{b3.Title}'");
        Console.WriteLine();

        // After Borrow
        library.DisplayBooks();
    }
}
