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

        class Book                                          // Класс Book                                     
        {  
                          
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
                System.Console.WriteLine($"Content: {this.nameContent}");   
            }
        }
    }
}
