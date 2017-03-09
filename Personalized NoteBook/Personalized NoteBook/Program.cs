using PNb.Data;
using PNb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized.NoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                NoteData.Insert(new Note() {
                    ID = Guid.NewGuid(),
                    Content = "This is number " + i,
                });
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
