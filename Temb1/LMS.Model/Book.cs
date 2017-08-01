using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Model.Entites
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
    }
}