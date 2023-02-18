using NEURONLOGISTIC.EntityLayer.Concrate.Definations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.EntityLayer.Abstract
{
    public interface IEntityStatus
    {
        public int EntitiyStatusId { get; set; }
        
        [ForeignKey("EntityStatusId")]
        public EntityStatus EntityStatus { get; set; }
    }
}
