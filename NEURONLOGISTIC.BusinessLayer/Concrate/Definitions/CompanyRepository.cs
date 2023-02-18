using NEURONLOGISTIC.BusinessLayer.Abstract.Definitions;
using NEURONLOGISTIC.EntityLayer.Concrate.Definations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.BusinessLayer.Concrate.Definitions
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyService
    {
    }
}
