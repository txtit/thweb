using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2._3.Models
{
 
    public class Music
    {
        private int Id;
        private string Title;
        private string FileName;

        public Music(int id, string title, string fileName)
        {
            Id = id;
            Title = title;
            FileName = fileName;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string FileName1 { get => FileName; set => FileName = value; }
    }
}