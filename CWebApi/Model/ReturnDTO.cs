using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWebApi.Model
{
    public class ReturnDTO
    {
        public string Number { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public static List<CountryDetails> countryDetails { get; set; }
    }
}
