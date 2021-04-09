using Microsoft.AspNetCore.Mvc;
using rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class MathClassController : ControllerBase
    {
        [HttpPost]
        [Route("/{a}+{b}")]
        public int Post([FromRoute]int a, [FromRoute]int b)
        {
            return MathClass.Add(a, b);
        }
    }
}
