using SimpleNote.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
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
        public static List<Note> getlistNote(string searchTitle,string user)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                var Note = (from u in _context.Notes.AsEnumerable()
                            where u.User_k == user && u.Title_Note.Contains(searchTitle)
                            select u)
                           .Select(x => new Note
                           {
                               ID = x.ID,
                               Title_Note = x.Title_Note,
                               RichTextNote = x.RichTextNote,
                               Size = x.Size,
                               Font = x.Font,
                               ColorBg = x.ColorBg,
                               ColorText = x.ColorText,
                               User_k = x.User_k

                           }).ToList();
                return Note;
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
                                 size = u.Size,
                                 font = u.Font,
                                 colorBack = u.ColorBg,
                                 colorText = u.ColorText,
                                 user = u.User_k
                             })
                             .Select(x => new Note
                             {
                                 ID = x.ID,
                                 Title_Note = x.title,
                                 RichTextNote = x.note,
                                 Size = x.size,
                                 Font = x.font,
                                 ColorBg = x.colorBack,
                                 ColorText = x.colorText,
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
        public static bool DeleteNote(User user, int id)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                var dbtask = (from u in _context.Notes
                              where u.ID ==  id && u.User_k == user.UserName
                              select u).SingleOrDefault();
                

                _context.Notes.Remove(dbtask);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool SaveNote(Note note)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                var dbNote = (from u in _context.Notes
                              where u.ID == note.ID && u.User_k == note.User_k
                              select u).SingleOrDefault();
                dbNote.ID = note.ID;
                dbNote.Title_Note = note.Title_Note;
                dbNote.RichTextNote = note.RichTextNote;
                dbNote.Size = note.Size;
                dbNote.Font = note.Font;
                dbNote.ColorText = note.ColorText;
                dbNote.ColorBg = note.ColorBg;
                dbNote.User_k = note.User_k;

                _context.Notes.AddOrUpdate(dbNote);
                _context.SaveChanges();
                return true;
            }
        }
        
    }
}
