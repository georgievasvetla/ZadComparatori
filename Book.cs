using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    internal class Book:IComparable<Book>
    {
         
            public Book(string title, int year)
            {
                this.Title = title;
                this.Year = year;
                
            }
            public string Title { get;  set; }
            public int Year { get;  set; }

        public int CompareTo(Book other)
        {
            return Year.CompareTo(other.Year);
        }

        public override string ToString()
            {
                return string.Format("{0} - {1}", this.Title, this.Year);
            }

           
        }
    }

