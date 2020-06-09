using SimpleNote.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNote.Controllers
{
    public class NoteController
    {
        public static int getIDfromDB(string username)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                var id = (from t in _context.Notes
                          where t.User_k == username
                          select t.ID).ToList();
                if (id.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    int i = 1;
                    foreach (int ids in id)
                    {
                        if (ids != i)
                            return i;
                        i++;
                    }
                    return id.Max() + 1;
                }

            }
        }
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
                                 note = u.RichTextNote,
                                 user = u.User_k
                             })
                             .Select(x => new Note
                             {
                                 ID = x.ID,
                                 Title_Note = x.title,
                                 RichTextNote = x.note,
                                 User_k = x.user
                             });
                return notes.ToList();
            }
        }
        public static bool AddNote(Note note)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                
                var userdb = (from u in _context.Users
                              where u.UserName == note.User_k
                              select u).SingleOrDefault();
                if(userdb == null)
                {
                    return false;
                }
                else
                {
                    _context.Notes.Add(note);
                    _context.SaveChanges();
                    return true;
                }
                
            }
        }
    }
}
