using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public sealed class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
    }
}
