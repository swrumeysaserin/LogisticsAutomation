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
    //Deniz,hava,karaya özel lcl,air,ftl gibi olması gereken kargotiplerini tutatacak.
    public class CargoType:FullLogEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int ShipmentTypeId { get; set; }
        
        [ForeignKey("ShipmentTypeId")]
        public ShipmentType ShipmentType { get; set; }
        
    }
}
