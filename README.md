# USFLibraryManagement
A simple library management system we have built for App Dev class competition-2: Inheritence.
### What This Does
This is a C# program that manages books and people in a library. You can add books, add students and staff, and let people borrow books. The available copies update automatically when someone borrows something.
### The Classes
Person - Basic info: name, email, ID
Student - Person + major and graduation year
Staff - Person + job position and department
Book - Has title, author, ISBN, and tracks how many copies are available. Has a BorrowBook() method.
Library - Keeps track of all the books and people. Can add stuff and display everything.
### Running It
Need .NET 8 or newer.
git clone https://github.com/shivjag/USFLibraryManagement.git
cd USFLibraryManagement
dotnet run
### What It Prints Out
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 3
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 6

Patrons in Library:
Name: Akhil, ID: S001
Name: Sandeep, ID: S002
Name: Grandon Gill, ID: ST001

Borrowing Books...
Sandeep borrowed 'Business Insights with AI'
Akhil borrowed 'Analytics in Action'

Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 2
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 5
How I Built This
Used branches for different parts (person-classes, book-class, library-class, main-program). Committed individually and merged everything into main when done.
