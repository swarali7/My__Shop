using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Shop.Core.Models
{
    public class Product //in order to be accessed by other projects in the solution shift to public
    {
        public string Id { get; set; }

        [StringLength(20)] //Quick actions to add Data Annotations
        [DisplayName("Product Name")]  //Quick Actions to add using System.component Model
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0,5000)]
        public decimal Price { get; set; }
        public string Category { get; set; } //to group the products by different categories
        public string Image { get; set; }  //URL for product image

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

    }
}
