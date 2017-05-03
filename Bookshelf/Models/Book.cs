using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        //Properties. Basically telling us what kind of data is going to be entered.

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Date Published")] 
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime PublishedDate { get; set; }

        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] //a primary key from a different table. Also only refernces line directly below it.
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}