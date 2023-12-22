using System;
using System.Collections.Generic;

namespace BibleBookRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserServices userService = new UserServices();
            bool choice = true;
            while (choice)
            {
                userService.Introduction();
                string input = userService.PromptChoice();
                string book = userService.GetRandomBook(input);
                userService.GiveAnswer(book);
                choice = userService.Restart();
            }
        }
    }
}
