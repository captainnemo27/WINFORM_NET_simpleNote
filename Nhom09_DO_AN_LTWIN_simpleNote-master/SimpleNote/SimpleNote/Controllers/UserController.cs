using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleNote.Models;

namespace SimpleNote.Controllers
{
    public class UserController
    {
        
        public static bool getUser(string username, string password)
        {
            using (var _context = new DBSimpleNoteEntities())
            {
                try
                {
                    var user = (from u in _context.Users
                                where u.UserName == username && u.Password == password
                                select u.UserName).Single();
                    if (user == null)
                        return false;
                    if (string.Compare(user.Trim(), username, false) == 0)
                        return true;
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool AddUser(User user)
        {
            using(var _context = new DBSimpleNoteEntities())
            {

                var userdb = (from u in _context.Users
                              where u.UserName == user.UserName
                              select u).SingleOrDefault();
                if (userdb == null)
                {
                    
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        //public static
    }
}
