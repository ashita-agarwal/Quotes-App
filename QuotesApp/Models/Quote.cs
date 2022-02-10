using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteAuthor { get; set; }
        public string QuoteContent { get; set; }

        public Quote()
        {

        }
    }
}
