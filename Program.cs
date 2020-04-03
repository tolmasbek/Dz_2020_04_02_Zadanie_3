using System;

namespace dz_zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  • Задание 3
             *      A. Создайте проект по шаблону Console Application.
             *      B. Требуется: создать класс Book. Создать классы Title, Author и Content, каждый из
             *      которых должен содержать одно строковое поле и метод void Show().
             *          1. Реализуйте возможность добавления в книгу названия книги, имени автора и
             *          содержания.
             *          2. Выведите на экран разными цветами при помощи метода Show() название
             *          книги, имя автора и содержание.
             */

            string text1, text2, text3;
                System.Console.Write("Enter book title: ");
            text1 = Console.ReadLine();
                System.Console.Write("Enter the author of the book: ");
            text2 = Console.ReadLine();
                System.Console.Write("Enter content book: ");
            text3 = Console.ReadLine();

            Book newBook = new Book(text1, text2, text3);   // Создание экземпляра класса  по сильной ссылке
                newBook.Show();                             // Метдо Show вызывается из класса Book                
            
            Console.ReadKey();
        }

        class Book                                                      // Класс Book                                     
        {           
            private Title title;                                        // поле title типа класса Title                    
            private Author author;                                      // поле author типа класса Author
            private Content content;                                    // поле content типа класса Content

            public Book(string title, string author, string content)    // Перегруженный конструктор класса Book
            {
                this.title = new Title(title);                          // инициализируется поле title
                this.author = new Author(author);                       // инициализируется поле author
                this.content = new Content(content);                    // инициализируется поле content
            }

            public void Show()              // Метод show
            {
                title.Show();               // Метдо Show вызывается из класса Title
                author.Show();              // Метдо Show вызывается из класса Author
                content.Show();             // Метдо Show вызывается из класса Content
            }
        }

        class Title                                         // Класс Title
        {
            private string nameTitle { get; set; }          // Поле класса Title со свойством чтения и записи
            public Title (string nameTitle)                 // Перегруженный конструктор класса Title 
            {
                this.nameTitle = nameTitle;                 
            }
            public void Show()                                          // Метод show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;          // Цвет текста в консоли
                System.Console.WriteLine($"Title: {this.nameTitle}");   // Вывод значение поля 
            }
        }
        class Author
        {
            private string nameAuthor { get; set; }
            public Author (string nameAuthor)
            {
                this.nameAuthor = nameAuthor;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"Author: {this.nameAuthor}");   
            }
        }
        class Content
        {
            private string nameContent { get; set; }
            public Content (string nameContent)
            {
                this.nameContent = nameContent;
                // это конструктор
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Content: {this.nameContent}");   //
            }
        }
    }
}
