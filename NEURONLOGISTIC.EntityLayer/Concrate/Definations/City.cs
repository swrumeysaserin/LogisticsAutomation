using NEURONLOGISTIC.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.EntityLayer.Concrate.Definations
{
    public class City:FullLogEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        
    }
}