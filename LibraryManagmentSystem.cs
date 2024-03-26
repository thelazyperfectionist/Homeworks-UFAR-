using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class LibraryManagementSystem
    {
        private static List<Book> books = new List<Book>();

        public static void Run()
        {
            while (true)
            {
                OfferingChoice();
                int choice = GetChoice();
                ProcessChoice(choice);
            }
        }

        private static void OfferingChoice()
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List all Books");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
        }

        private static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))  // to check whether it is int or no
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.Write("Select an option: ");
            }
            return choice;
        }

        private static void ProcessChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    ListAllBooks();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option! Please try again.");
                    break;
            }
            Console.WriteLine(); //blank line, for making more beautiful
        }

        private static void AddBook()
        {
            Console.WriteLine("Enter Book Details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();
            Console.Write("Author Biography: ");
            string authorBio = Console.ReadLine();
            Console.Write("Category Name: ");
            string categoryName = Console.ReadLine();
            Console.Write("Category Description: ");
            string categoryDesc = Console.ReadLine();
            Console.Write("Year: ");
            int year = GetIntegerInput();
            Console.Write("Price: ");
            double price = GetDoubleInput();

            Author author = new Author(authorName, authorBio);
            Category category = new Category(categoryName, categoryDesc);
            Book book = new Book(title, author, category, year, price);

            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        private static void RemoveBook()
        {
            Console.Write("Enter the title of the book to remove: ");
            string title = Console.ReadLine();
            Book bookToRemove = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully!");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        private static void ListAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
            else
            {
                Console.WriteLine("List of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}, {book.Author.Biography} ,Category: {book.Category.Description} , {book.Category.CategoryName}, DescriptionYear: {book.Year}, Price: {book.Price}");
                }
            }
        }

        private static int GetIntegerInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.Write("Year: ");
            }
            return input;
        }

        private static double GetDoubleInput()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.Write("Price: ");
            }
            return input;
        }
    }
}
