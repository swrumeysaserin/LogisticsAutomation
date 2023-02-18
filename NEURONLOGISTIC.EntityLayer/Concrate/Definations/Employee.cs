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
   public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        
        [Required]
        [StringLength(15)]
        public string IdentityNumber { get; set; }
        
        public DateTime StartWork { get; set; }
        
        public DateTime? LeaveWork { get; set; }
        
        [StringLength(20)]
        public string Type { get; set; }
        
        [Required]
        [StringLength(50)]
        public string MotherFullName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FatherFullName { get; set; }
        
        [StringLength(50)]
        public string UserName { get; set; }
        
        [StringLength(50)]
        public string Password { get; set; }
        
        public int RoleId { get; set; }

        
        [StringLength(50)]
        public string Email { get; set; }
        
        
        [StringLength(50)]
        public string EmailPassword { get; set; }
        
        public int BranchId { get; set; }
   
        [ForeignKey("BranchId")]
        public Branch Branch { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

    }
}