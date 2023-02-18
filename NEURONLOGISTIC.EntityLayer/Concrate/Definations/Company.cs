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
   public class Company:FullLogEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        
        [StringLength(20)]
        public string Fax { get; set; }
        
        public int CompanyTypeId { get; set; }
      
        public int CountryId { get; set; }
        
        public int CityId { get; set; }
        
        [StringLength(50)]
        public string WebLink { get; set; }
        
        public string Note { get; set; }
        public int? SalespersonImportId { get; set; }
        
        public int? SalespersonExportId { get; set; }
        
        public int? SalespersonAirId { get; set; }
      
        public int? SalespersonSupportId { get; set; }

        [StringLength(20)]
        public string SalesCurrentCode { get; set; }
        
        [StringLength(20)]
        public string PurchaseCurrentCode { get; set; }
        
        public int? CreditDay { get; set; }
        
        public int? AirCreditDay { get; set; }
        
        public int? CurrencyId { get; set; }
        
        [Required]
        [StringLength(15)]
        public string TaxNumber { get; set; }
        
        [Required]
        [StringLength(25)]
        public string TaxOffice { get; set; }
        
        public int? PaymentTypeId { get; set; }
        
        public int? InvoiceTypeId { get; set; }
        
        [StringLength(40)]
        public string MersisNo { get; set; }
        
        public string AccountNote { get; set; }

        [ForeignKey("CompanyTypeId")]
        public CompanyType CompanyType { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        [ForeignKey("SalespersonImportId")]
        public Employee SalespersonImportEmployee { get; set; }

        [ForeignKey("SalespersonExportId")]
        public Employee SalespersonExportEmployee { get; set; }

        [ForeignKey("SalespersonAirId")]
        public Employee SalespersonAirEmployee { get; set; }

        [ForeignKey("SalespersonSupportId")]
        public Employee SalespersonSupportEmployee { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
        
        [ForeignKey("InvoiceTypeId")]
        public InvoiceType InvoiceType { get; set; }
    }
}