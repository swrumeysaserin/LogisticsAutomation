using NEURONLOGISTIC.EntityLayer.Concrate.Definations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.EntityLayer.Abstract
{
    public abstract class FullLogEntity : IDateLog, IUserLog,IEntityStatus
    {
        public DateTime CreatedDate { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        public DateTime? DeletedDate { get; set; }
        
        public int CreatedByEmployeeId { get; set; }
        
        public int LastModifiedByEmployeeId { get; set; }
        
        public int? DeletedByEmployeeId { get; set; }

        public int EntitiyStatusId { get; set; }

        [ForeignKey("CreatedByEmployeeId")]
        public Employee CreatedByEmployee { get; set; }

        [ForeignKey("LastModifiedByEmployeeId")]
        public Employee LastModifiedByEmployee { get; set; }

        [ForeignKey("DeletedByEmployeeId")]
        public Employee DeletedByEmployee { get; set; }

        [ForeignKey("EntitiyStatusId")]
        public EntityStatus EntityStatus { get; set; }
    }
}