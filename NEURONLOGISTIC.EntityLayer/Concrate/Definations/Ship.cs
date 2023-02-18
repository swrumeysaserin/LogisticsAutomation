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
  public  class Ship:FullLogEntity
    {
        [Key]
        public int Id { get; set; }
    
        [Required]
        [StringLength(75)]
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        
        [Required]
        [StringLength(5)]
        public string YearConstruction { get; set; }
        
        [Required]
        [StringLength(15)]
        public string Imo { get; set; }
        
        public string Link { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}