using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; } 
        //We have a collection of books because
        //even though each book only has a single category (ex. Fantasy)
        //each category (ex. Fantasy) has many books.
        //Don't have to use an ICollection.
        //We are using it here because it doesn't have as many features as a list
        //and so is more efficieint in certain ways than a List.

    }
}