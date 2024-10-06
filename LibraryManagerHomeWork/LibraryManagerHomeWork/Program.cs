namespace LibraryManagerHomeWork
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class Library
    {
        private Dictionary<string, List<Book>> booksByAuthor;

        public Library()
        {
            booksByAuthor = new Dictionary<string, List<Book>>();
        }

        public void AddBook(Book book)
        {
            if (!booksByAuthor.ContainsKey(book.Author))
            {
                booksByAuthor[book.Author] = new List<Book>();
            }

            booksByAuthor[book.Author].Add(book);
            Console.WriteLine($"Book \"{book.Title}\" added by the author {book.Author}.");
        }

        public void RemoveBook(string author, string title)
        {
            if (booksByAuthor.ContainsKey(author))
            {
                var books = booksByAuthor[author];
                var bookToRemove = books.FirstOrDefault(b => b.Title == title);

                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine($"Book \"{title}\" deleted from the author {author}.");

                    if (books.Count == 0)
                    {
                        booksByAuthor.Remove(author);
                    }
                }
                else
                {
                    Console.WriteLine($"Book \"{title}\" not found on the author {author}.");
                }
            }
            else
            {
                Console.WriteLine($"Author {author} not found.");
            }
        }

        public void ShowBooksByAuthor(string author)
        {
            if (booksByAuthor.ContainsKey(author))
            {
                Console.WriteLine($"Books by the author {author}:");
                foreach (var book in booksByAuthor[author])
                {
                    Console.WriteLine($"{book.Title}");
                }
            }
            else
            {
                Console.WriteLine($"Author {author} not found.");
            }
        }

        public void FindBookByTitle(string title)
        {
            bool found = false;
            foreach (var author in booksByAuthor)
            {
                var book = author.Value.FirstOrDefault(b => b.Title == title);
                if (book != null)
                {
                    Console.WriteLine($"Book \"{title}\" found from the author  {author.Key}.");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Book \"{title}\" not found.");
            }
        }

        public void ShowAllBooks()
        {
            if (booksByAuthor.Count == 0)
            {
                Console.WriteLine("The library is empty.");
                return;
            }

            Console.WriteLine("All books in the library, grouped by author:");
            foreach (var author in booksByAuthor)
            {
                Console.WriteLine($"Author: {author.Key}");
                foreach (var book in author.Value)
                {
                    Console.WriteLine($"{book.Title}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            var book1 = new Book("Test Title 1", "Test Author 1");
            var book2 = new Book("Test Title 2", "Test Author 2");
            var book3 = new Book("Test Title 3", "Test Author 3");

            var book4 = new Book("Test Title 13", "Test Author 1");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            library.ShowBooksByAuthor("Test Author 1");

            //library.FindBookByTitle("Book 3");

            //library.RemoveBook("Author A", "Book 1");

            //library.ShowAllBooks();
        }
    }

}
