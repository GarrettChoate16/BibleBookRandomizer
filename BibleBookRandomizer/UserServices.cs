using System;
using System.Collections.Generic;
using System.Text;

namespace BibleBookRandomizer
{
    public class UserServices
    {
        public void Introduction()
        {
            Console.Clear();
            Console.WriteLine("Hello, welcome to bible book randomizer.\n");
        }
        public string PromptChoice()
        {
            while (true)
            {
                Console.Write("Please enter a category:\n\n'New' for a New Testament book\n'Old' for a Old Testament book\n'Any' for a random book in the whole bible\nor 'Wisdom' for a Wisdom Book.\n\nChoice: ");
                string choice = Console.ReadLine();
                string orginial = choice;
                choice = choice.ToLower();

                if (choice != "new" && choice != "old" && choice != "wisdom" && choice != "any")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You put {orginial}. You must enter a valid choice of 'New, Old, Any, or Wisdom'.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your choice was successful!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    return choice;
                }
            }
        }
        public string GetRandomBook(string choice)
        {
            RandomizerServices service = new RandomizerServices();
            Books books = new Books();
            string book = "";
            switch (choice)
            {
                case "old":
                    book = service.RandomOldTestament(books.oldTestament);
                    break;
                case "new":
                    book = service.RandomNewTestament(books.newTestament);
                    break;
                case "wisdom":
                    book = service.RandomWisdom(books.widsomBook);
                    break;
                case "any":
                    book = service.RandomBibleBook(books.bibleBook);
                    break;
            }
            return book;
        }
        public void GiveAnswer(string book)
        {
            Console.WriteLine($"Your book has been randomly picked. Your book is: {book}. ");
        }
        public bool Restart()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to pick another book?");
                Console.WriteLine("Enter 'Y' for Yes or 'N' for No");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice == "Y")
                {
                    return true;
                }
                else if (choice == "N")
                {
                    return false;
                }
            }
        }
    }
}
