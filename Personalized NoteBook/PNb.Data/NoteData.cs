using PNb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNb.Data
{
    public class NoteData
    {
        public static void Insert(Note note)
        {
            using (var db = new PNbContext())
            {
                db.Notes.Add(note);
                db.SaveChanges();
            }
        }
    }
}
