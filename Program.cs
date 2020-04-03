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

            
            Console.ReadKey();
        }

        class Book                                      
        {  
                          
        }

        class Title
        {
            private string nameTitle { get; set; }      
            public Title (string nameTitle)              
            {
                this.nameTitle = nameTitle;             
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Title: {this.nameTitle}");   
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
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Content: {this.nameContent}");   
            }
        }
    }
}
