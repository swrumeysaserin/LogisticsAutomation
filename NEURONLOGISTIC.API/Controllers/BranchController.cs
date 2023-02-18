using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NEURONLOGISTIC.BusinessLayer.Abstract;
using NEURONLOGISTIC.EntityLayer.Concrate.Definations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : GenericController<Branch>
    {
        public BranchController(IGenericService<Branch> genericRepository) : base(genericRepository)
        {
        }
    }
}
