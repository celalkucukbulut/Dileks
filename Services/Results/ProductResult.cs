using Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Results
{
    public class ProductResult
    {
        public IEnumerable<Images> Images { get; set; }
        public IEnumerable<Contents> Contents { get; set; }
    }
}
