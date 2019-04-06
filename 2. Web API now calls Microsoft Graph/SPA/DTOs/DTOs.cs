using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureADAspNetCore21SPA.DTOs
{
    public class UnrestrictedEntity
    {
        public int Id { get; set; }

        public string Property1 { get; set; }
    }

    public class RestrictedEntity
    {
        public int Id { get; set; }
        public string Property1 { get; set; }
    }
}
