using System;
using System.Collections.Generic;
using System.Text;

namespace BibleBookRandomizer
{
    public class RandomizerServices
    {
        public string RandomWisdom(List<string> books)
        {
            Random rnd = new Random();
            string book = books[rnd.Next(0, 4)];
            return book;
        }
        public string RandomNewTestament(List<string> books)
        {
            Random rnd = new Random();
            string book = books[rnd.Next(0, 25)];
            return book;
        }
        public string RandomOldTestament(List<string> books)
        {
            Random rnd = new Random();
            string book = books[rnd.Next(0, 38)];
            return book;
        }
        public string RandomBibleBook(List<string> books)
        {
            Random rnd = new Random();
            string book = books[rnd.Next(0, 65)];
            return book;
        }
    }
}
