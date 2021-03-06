using Docker.MultiApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.MultiApp.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {


        private BookContext context;
        public BookController(BookContext mc)
        {
            context = mc;
        }

        [HttpGet]
        public Book Get()
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, 2);
            
            //Book book = Repository().Skip(toSkip).Take(1).FirstOrDefault();
            Book book =  context.Books.ToList().Skip(toSkip).Take(1).FirstOrDefault();
            return book;
        }
        
        
        //protected List<Book> Repository()
        //{
        //    List<Book> BookList = new List<Book> {
        //        new Book {Name = "Thinking Fast and Slow", Author = "Daniel Kanhneman", Category="Economics", Price=400 },
        //        new Book {Name = "MisBehaving", Author = "Richard Thaler", Category="Economics", Price=500 },
        //        new Book {Name = "Why We Sleep", Author = "Mathew Walker", Category="Health Sciences", Price=900 },
        //        new Book {Name = "12 Rules for Life", Author = "Jordan Peterson", Category="Philosophy", Price=600 },
        //        new Book {Name = "Docker Deep Dive", Author = "Nigel Poulton", Category="Computer/IT", Price=400 },
        //        };

        //    return BookList;
        //}


       
    }
}

