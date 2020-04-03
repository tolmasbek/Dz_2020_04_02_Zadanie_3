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

            Book newb = new Book();    
            newb.Show();
            
            Console.ReadKey();
        }

        class Book
        {
            private string NameBook { get; set; }
            Book (string NameBook)
            {
                this.NameBook = NameBook;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"Book: {this.NameBook}");   
            }
            public string getName()
            {
                return this.NameBook;
            }
            Book ()
            {

            }   
        }
        class Title
        {
            private string NameTitle { get; set; }
            Title (string NameTitle)
            {
                this.NameTitle = NameTitle;
            }
            Title()
            {

            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Title: {this.NameTitle}");   
            }
        }
        class Author
        {
            private string NameAuthor { get; set; }
            Author (string NameAuthor)
            {
                this.NameAuthor = NameAuthor;
            }
            Author()
            {

            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"Author: {this.NameAuthor}");   
            }
        }
        class Content
        {
            private string NameContent { get; set; }
            Content (string NameContent)
            {
                this.NameContent = NameContent;
            }
            Content()
            {

            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Content: {this.NameContent}");   
            }
        }
    }
}
