using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public ToDo()
        {
            _raterCount++;
        }
        private int _rating = 10;
        private int _raterCount = 2;
        private int _rated;
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public int Rating
        {
            get { return _rating; }
            
            set
            {
                _rating = (_rating + value) / _raterCount;
            }
        }
        public int RaterCount { get { return _raterCount; } set { _raterCount = value; } }
        public int Rated { get { return _rated; } set { _rated = value; } }
    }
}
