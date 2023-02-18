using NEURONLOGISTIC.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.EntityLayer.Concrate.Definations
{
   public class Currency:FullLogEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(5)]
        public string Symbol { get; set; }
        
        [Required]
        [StringLength(5)]
        public string ThousandsSeparator { get; set; }
        
        [Required]
        [StringLength(5)]
        public string DecimalSeparator { get; set; }
        
        [Required]
        public bool SymbolOnLeft { get; set; }
        
        [Required]
        public bool SpaceBetweenAmountAndSymbol { get; set; }
        
        [Required]
        public short DecimalDigits { get; set; }
        
    }
}