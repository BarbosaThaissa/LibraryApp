using BookAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookAPI.Services
{
    public class BookService
    {
        private List<Book> _books = new List<Book>
        {
            new Book{ Id = 1, Author = "George Orwell", Title = "1984", Description = "Dystopian novel" },
            new Book{ Id = 2, Author = "Harper Lee", Title = "To Kill a Mockingbird", Description = "Classic of modern American literature" },
            new Book{ Id = 3, Author = "J.K. Rowling", Title = "Harry Potter and the Sorcerer's Stone", Description = "Fantasy novel" },
            new Book{ Id = 4, Author = "J.R.R. Tolkien", Title = "The Hobbit", Description = "Fantasy novel" },
            new Book{ Id = 5, Author = "F. Scott Fitzgerald", Title = "The Great Gatsby", Description = "Classic American novel" },
            new Book{ Id = 6, Author = "Jane Austen", Title = "Pride and Prejudice", Description = "Romantic novel" },
            new Book{ Id = 7, Author = "Mark Twain", Title = "The Adventures of Huckleberry Finn", Description = "Classic American novel" },
            new Book{ Id = 8, Author = "Herman Melville", Title = "Moby-Dick", Description = "Epic sea story" },
            new Book{ Id = 9, Author = "Leo Tolstoy", Title = "War and Peace", Description = "Historical novel" },
            new Book{ Id = 10, Author = "Charles Dickens", Title = "Great Expectations", Description = "Classic English novel" },
            new Book{ Id = 11, Author = "Gabriel Garcia Marquez", Title = "One Hundred Years of Solitude", Description = "Magical realism" },
            new Book{ Id = 12, Author = "Fyodor Dostoevsky", Title = "Crime and Punishment", Description = "Psychological novel" },
            new Book{ Id = 13, Author = "Mary Shelley", Title = "Frankenstein", Description = "Gothic novel" },
            new Book{ Id = 14, Author = "H.G. Wells", Title = "The War of the Worlds", Description = "Science fiction" },
            new Book{ Id = 15, Author = "Aldous Huxley", Title = "Brave New World", Description = "Dystopian novel" },
            new Book{ Id = 16, Author = "J.D. Salinger", Title = "The Catcher in the Rye", Description = "Coming-of-age novel" },
            new Book{ Id = 17, Author = "George R.R. Martin", Title = "A Game of Thrones", Description = "Fantasy novel" },
            new Book{ Id = 18, Author = "Ernest Hemingway", Title = "The Old Man and the Sea", Description = "Short novel" },
            new Book{ Id = 19, Author = "Homer", Title = "The Odyssey", Description = "Epic poem" },
            new Book{ Id = 20, Author = "Miguel de Cervantes", Title = "Don Quixote", Description = "Classic Spanish novel" },
            new Book{ Id = 21, Author = "Jules Verne", Title = "Twenty Thousand Leagues Under the Sea", Description = "Science fiction" },
            new Book{ Id = 22, Author = "Arthur Conan Doyle", Title = "The Adventures of Sherlock Holmes", Description = "Detective stories" },
            new Book{ Id = 23, Author = "Ray Bradbury", Title = "Fahrenheit 451", Description = "Dystopian novel" },
            new Book{ Id = 24, Author = "Isaac Asimov", Title = "Foundation", Description = "Science fiction" },
            new Book{ Id = 25, Author = "Philip K. Dick", Title = "Do Androids Dream of Electric Sheep?", Description = "Science fiction" },
            new Book{ Id = 26, Author = "Kurt Vonnegut", Title = "Slaughterhouse-Five", Description = "Science fiction" },
            new Book{ Id = 27, Author = "Joseph Heller", Title = "Catch-22", Description = "Satirical novel" },
            new Book{ Id = 28, Author = "William Golding", Title = "Lord of the Flies", Description = "Allegorical novel" },
            new Book{ Id = 29, Author = "George Orwell", Title = "Animal Farm", Description = "Political satire" },
            new Book{ Id = 30, Author = "J.R.R. Tolkien", Title = "The Lord of the Rings", Description = "Fantasy novel" },
            new Book{ Id = 31, Author = "C.S. Lewis", Title = "The Lion, the Witch and the Wardrobe", Description = "Fantasy novel" },
            new Book{ Id = 32, Author = "Lewis Carroll", Title = "Alice's Adventures in Wonderland", Description = "Fantasy novel" },
            new Book{ Id = 33, Author = "Bram Stoker", Title = "Dracula", Description = "Gothic novel" },
            new Book{ Id = 34, Author = "Oscar Wilde", Title = "The Picture of Dorian Gray", Description = "Philosophical novel" },
            new Book{ Id = 35, Author = "Franz Kafka", Title = "The Metamorphosis", Description = "Absurdist fiction" },
            new Book{ Id = 36, Author = "James Joyce", Title = "Ulysses", Description = "Modernist novel" },
            new Book{ Id = 37, Author = "Virginia Woolf", Title = "Mrs Dalloway", Description = "Modernist novel" },
            new Book{ Id = 38, Author = "Marcel Proust", Title = "In Search of Lost Time", Description = "Modernist novel" },
            new Book{ Id = 39, Author = "Thomas Mann", Title = "The Magic Mountain", Description = "Philosophical novel" },
            new Book{ Id = 40, Author = "Vladimir Nabokov", Title = "Lolita", Description = "Controversial novel" },
            new Book{ Id = 41, Author = "Albert Camus", Title = "The Stranger", Description = "Philosophical novel" },
            new Book{ Id = 42, Author = "Jack Kerouac", Title = "On the Road", Description = "Beat generation novel" },
            new Book{ Id = 43, Author = "Toni Morrison", Title = "Beloved", Description = "Historical novel" },
            new Book{ Id = 44, Author = "Margaret Atwood", Title = "The Handmaid's Tale", Description = "Dystopian novel" },
            new Book{ Id = 45, Author = "Salman Rushdie", Title = "Midnight's Children", Description = "Historical novel" },
            new Book{ Id = 46, Author = "Kazuo Ishiguro", Title = "Never Let Me Go", Description = "Dystopian novel" },
            new Book{ Id = 47, Author = "Orhan Pamuk", Title = "My Name Is Red", Description = "Historical novel" },
            new Book{ Id = 48, Author = "Haruki Murakami", Title = "Kafka on the Shore", Description = "Magical realism" },
            new Book{ Id = 49, Author = "Chinua Achebe", Title = "Things Fall Apart", Description = "Historical novel" },
            new Book{ Id = 50, Author = "Gabriel Garcia Marquez", Title = "Love in the Time of Cholera", Description = "Romantic novel" }
        };

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
    }
}