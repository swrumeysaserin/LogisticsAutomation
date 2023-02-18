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
  public  class Port:FullLogEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public int CountryId { get; set; }
        
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
                
    }
}