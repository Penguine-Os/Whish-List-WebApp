using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishListApp.Models
{
    public class WishItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string ShortDescription { get; set; }
        public string ImageLink { get; set; }
        public bool IsAcquired { get; set; } = false;

        public string StatusMessage { get; set; }
        public int Star { get; set; } = 0;
    }
}
