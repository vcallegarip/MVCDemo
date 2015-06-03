using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using Mvc_Bootstrap_Knockout.Models;
using System.Data.Entity;


namespace Mvc_Bootstrap_Knockout.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Victor",
                LastName = "Callegari"
            };

            var books = new List<Book>
            {
                new Book{
                    Author = author,
                    Description="...",
                    ImageUrl="https://books.google.com/books?id=xOiw3avKvzYC&printsec=frontcover&dq=libro&hl=en&sa=X&ei=_zNtVZPOI8GosAXrhYPQCA&ved=0CCoQ6AEwAA#v=onepage&q=libro&f=false",
                    Isbn = "987852159",
                    Synopsis = "...",
                    Title = "El Libro de Tratados 2"
                },

                new Book{
                    Author =author,
                    Description="...",
                    ImageUrl="https://books.google.com/books?id=xOiw3avKvzYC&printsec=frontcover&dq=libro&hl=en&sa=X&ei=_zNtVZPOI8GosAXrhYPQCA&ved=0CCoQ6AEwAA#v=onepage&q=libro&f=false",
                    Isbn = "3216549879",
                    Synopsis = "...",
                    Title = "El Libro de Tratados"
                }
            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }



    }
}