using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNote.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Title_Note { get; set; }
        public string Note { get; set; }
        public List<Notes> NoteList { get; set; }
    }
}
