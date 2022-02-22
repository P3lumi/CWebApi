using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWebApi.Models
{
    public class CountryDetails
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
