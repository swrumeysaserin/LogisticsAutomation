using NEURONLOGISTIC.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.EntityLayer.Concrate.Definations
{
    public class Airline : FullLogEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        
        public string Name { get; set; }
        
        [Required]
        [StringLength(5)]
        public string Code { get; set; }

    }
}
