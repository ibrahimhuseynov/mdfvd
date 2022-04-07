using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string AuthorName { get; set; }  
        public double Price { get; set; }   
        public string ShowInfo()
        {
           return  $"Id - {Id}  Name -{Name}  AuthorName - {AuthorName}  Price - {Price} ";
        }


    }
}
