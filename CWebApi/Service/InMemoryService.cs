using AutoMapper;
using CWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWebApi.Service
{
    public class InMemoryService: IInMemoryService
    {
        private readonly IMapper _mapper;
        public InMemoryService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ReturnDTO GetNumberDetails(string number)
        {
            ReturnDTO result = new ReturnDTO();
            
            //check for the first 3 characters
            string check = number.Substring(0,3);
            var confirm = InMemoryDb.Countries.Where(c => c.CountryCode == check);
            if (confirm.Count() > 0)
            {
                foreach (var item in confirm)
                {
                    result = _mapper.Map<ReturnDTO>(item);
                    result.Number = number;
                }
                return result;
            }

            return null;
        }
    }
}
