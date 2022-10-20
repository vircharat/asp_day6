using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyyEntity
{
    public class Product
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid productId { get; set; }

        public string productName { get; set; }



        public int productYear { get; set; }
        public int channelId { get; set; }

        
       
        public string productCode{ get; set; }

        [ForeignKey("size")]
        public Guid sizeScaleId { get; set; }

        public Sizee size { get; set; }

        public List<Article> articles { get; set; }

        


    }
}
