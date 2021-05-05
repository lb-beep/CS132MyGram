using System;
using System.Collections.Generic;
using CS132MyGram.Models;

#nullable disable

namespace CS132MyGram.MyGramContext
{
    public partial class Image
    {
        public Image()
        {
            ProductImage = new HashSet<ProductImage>();
        }

        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public string ImageAltText { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<ProductImage> Image { get; set; }

    }

    internal class ProductImage
    {
    }
}
