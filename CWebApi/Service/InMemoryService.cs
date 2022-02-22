using CWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWebApi.Service
{
    public class InMemoryService
    {
        public void AddCountry (Country country)
        {
            InMemoryDb.Countries.Add(country);
        }

        public List<Country> GetAllCountries()
        {
            return InMemoryDb.Countries;
        }

        public ReturnDTO GetNumberDetails(string number)
        {
            ReturnDTO returnDTO = new ReturnDTO();
            //var result = GetAllCountries();

            //check for the first 3 characters
            string check = number.Substring(0,3);

            var confirm = InMemoryDb.Countries.Where(c => c.CountryCode == check);
            if (confirm.Count() > 0)
            {
                foreach(var item in confirm)
                {
                    returnDTO.CountryCode = item.CountryCode;
                    returnDTO.Name = item.Name;
                    returnDTO.CountryIso = item.CountryIso;
                   
                }
            }
            return returnDTO;
           
        }
    }
}
