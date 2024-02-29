using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class CatalogueController : Controller
{
   public IActionResult Catalogue() //LocalHost/Catalogue/Catalogue
   {
      var catalogue = new Catalogue // Instance of "Catalogue" was created
      {
         BookCatalogue = [
         new Book
         {
            Title = "Harry Potter and the Philosopher Stone",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 10,
            NumOfCopiesOnLoan = 5
         },
         new Book
         {
            Title = "Harry Potter and the Chamber of Secrets",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 15,
            NumOfCopiesOnLoan = 10
         },
         new Book
         {
            Title = "Harry Potter and the Prisoner of Azkaban",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 7,
            NumOfCopiesOnLoan = 3
         },
         ]
      };
      return View(catalogue); // This is what will be displayed, so pass "catalogue"
   }
}