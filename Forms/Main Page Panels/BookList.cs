using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class BookList : UserControl
    {


        //global link list for fictional books
        List<Book> fictionalBooks = new List<Book>
            {
                new Book("To Kill a Mockingbird", "9780061120084", BookCategory.Fiction, "Harper Lee", "J.B. Lippincott & Co.", 1960),
                new Book("1984", "9780451524935", BookCategory.Fiction, "George Orwell", "Secker & Warburg", 1949),
                new Book("Pride and Prejudice", "9780141439518", BookCategory.Fiction, "Jane Austen", "T. Egerton, Whitehall", 1813),
                new Book("The Great Gatsby", "9780743273565", BookCategory.Fiction, "F. Scott Fitzgerald", "Charles Scribner's Sons", 1925),
                new Book("One Hundred Years of Solitude", "9780061120091", BookCategory.Fiction, "Gabriel Garcia Marquez", "Editorial Sudamericana", 1967),
                new Book("The Catcher in the Rye", "9780241950425", BookCategory.Fiction, "J.D. Salinger", "Little, Brown and Company", 1951),
                new Book("The Lord of the Rings", "9780544003415", BookCategory.Fiction, "J.R.R. Tolkien", "Allen & Unwin", 1954),
                new Book("Jane Eyre", "9780141441146", BookCategory.Fiction, "Charlotte Brontë", "Smith, Elder & Co.", 1847),
                new Book("Brave New World", "9780060850524", BookCategory.Fiction, "Aldous Huxley", "Chatto & Windus", 1932),
                new Book("The Hobbit", "9780261102217", BookCategory.Fiction, "J.R.R. Tolkien", "George Allen & Unwin", 1937),
            };

        //global link list for fictional books
        List<Book> nonFictionalBooks = new List<Book>
            {
                new Book("Sapiens: A Brief History of Humankind", "9780062316097", BookCategory.NonFiction, "Yuval Noah Harari", "Harper", 2011),
                new Book("The Diary of a Young Girl", "9780553296983", BookCategory.NonFiction, "Anne Frank", "Contact Publishing", 1947),
                new Book("A Brief History of Time", "9780553380163", BookCategory.NonFiction, "Stephen Hawking", "Bantam Dell Publishing Group", 1988),
                new Book("The Immortal Life of Henrietta Lacks", "9781400052189", BookCategory.NonFiction, "Rebecca Skloot", "Crown Publishing Group", 2010),
                new Book("In Cold Blood", "9780679745587", BookCategory.NonFiction, "Truman Capote", "Random House", 1966),
                new Book("The Power of Habit", "9780812981605", BookCategory.NonFiction, "Charles Duhigg", "Random House", 2012),
                new Book("Guns, Germs, and Steel", "9780393317558", BookCategory.NonFiction, "Jared Diamond", "W. W. Norton & Company", 1997),
                new Book("Quiet: The Power of Introverts in a World That Can't Stop Talking", "9780307352156", BookCategory.NonFiction, "Susan Cain", "Crown Publishing Group", 2012),
                new Book("The Wright Brothers", "9781476728759", BookCategory.NonFiction, "David McCullough", "Simon & Schuster", 2015),
                new Book("Educated", "9780399590504", BookCategory.NonFiction, "Tara Westover", "Random House", 2018),
            };

        //global link list for academic books
        List<Book> academicBooks = new List<Book>
            {
                new Book("Introduction to Algorithms", "9780262033848", BookCategory.Academic, "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", "The MIT Press", 1990),
                new Book("The Elements of Style", "9780205309023", BookCategory.Academic, "William Strunk Jr., E.B. White", "Harcourt, Brace & World", 1918),
                new Book("Principles of Economics", "9781305585126", BookCategory.Academic, "N. Gregory Mankiw", "Cengage Learning", 1997),
                new Book("Chemistry: The Central Science", "9780134296016", BookCategory.Academic, "Theodore L. Brown, H. Eugene LeMay Jr., Bruce E. Bursten, Catherine J. Murphy, Patrick M. Woodward, Matthew W. Stoltzfus", "Pearson", 1977),
                new Book("A History of Western Philosophy", "9780415325059", BookCategory.Academic, "Bertrand Russell", "Routledge", 1945),
                new Book("Principles of Neural Science", "9781259863221", BookCategory.Academic, "Eric R. Kandel, James H. Schwartz, Thomas M. Jessell, Steven A. Siegelbaum, A. J. Hudspeth", "McGraw-Hill", 2000),
                new Book("The Structure of Scientific Revolutions", "9780226458120", BookCategory.Academic, "Thomas S. Kuhn", "University of Chicago Press", 1962),
                new Book("International Relations", "9780134409856", BookCategory.Academic, "Joshua S. Goldstein, Jon C. Pevehouse", "Pearson", 1999),
                new Book("Linear Algebra and Its Applications", "9780321982384", BookCategory.Academic, "David C. Lay, Steven R. Lay, Judi J. McDonald", "Pearson", 1993),
                new Book("The Art of Computer Programming", "9780201485417", BookCategory.Academic, "Donald E. Knuth", "Addison-Wesley", 1968),
            };

        //Library library = new Library(fictionalBooks.Concat(nonFictionalBooks).Concat(academicBooks).ToList());

        // Now you can access and manipulate the books in the library object



        // Enum to represent different book categories
        public enum BookCategory
        {
            Fiction,
            NonFiction,
            Academic
        }

        // Class to represent a book
        public class Book
        {
            public string Title { get; set; }
            public string ISBN { get; set; }
            public BookCategory Category { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int YearOfPublication { get; set; }

            // Constructor to initialize a book
            public Book(string title, string isbn, BookCategory category, string author, string publisher, int yearOfPublication)
            {
                Title = title;
                ISBN = isbn;
                Category = category;
                Author = author;
                Publisher = publisher;
                YearOfPublication = yearOfPublication;
            }
        }

        // Class to represent a library with a collection of books
        public class Library
        {
            public List<Book> Books { get; set; }

            // Constructor to initialize a library with books
            public Library(List<Book> books)
            {
                Books = books;
            }
        }


        //start of booklist

        public BookList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
 
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BookList_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            academic1.Visible = true;
            fictional1.Visible = false;
            nonFictional1.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            academic1.Visible = false;
            fictional1.Visible = false;
            nonFictional1.Visible = true;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void lblFBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            academic1.Visible = false;
            fictional1.Visible = true;
            nonFictional1.Visible = false;
        }

        private void nonFictional1_Load(object sender, EventArgs e)
        {

        }
    }
}
