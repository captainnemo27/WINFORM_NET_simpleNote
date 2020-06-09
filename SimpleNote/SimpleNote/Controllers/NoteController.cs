using SimpleNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNote.Controllers
{
    public class NoteController
    {
        public static List<Note> getAllNote(string _user)
        {
            using(var _context = new DBSimpleNoteEntities())
            {
                var notes = (from u in _context.Notes.AsEnumerable()
                             where u.User_k == _user// tìm giùm t cách load lên còn lại t đg coi lại khóa với lưu định dạng

                             select new//u).ToList;
                             {
                                 ID = u.ID,
                                 title = u.Title_Note,
                                 note = u.Note1,
                                 user = u.User_k
                             })
                             .Select(x => new Note
                             {
                                 ID = x.ID,
                                 Title_Note = x.title,
                                 Note1 = x.note,
                                 User_k = x.user
                             });
                return notes.ToList();
            }
        }
    }
}
