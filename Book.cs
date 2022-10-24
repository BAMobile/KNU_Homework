using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string PublishingHouse { get; set; }
        public int PageCount { get; set; }
        public bool IsInLibrary { get; set; }
        private static int _maxId = 0;
        public Book(string title, string publisher, int pageC, bool isInLibr) 
        {
			_maxId++;
			Id = _maxId;
            Title = title;
            PublishingHouse = publisher;
            PageCount = pageC;
            IsInLibrary = isInLibr;
        }
        
    }
}
