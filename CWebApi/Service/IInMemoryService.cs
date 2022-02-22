using CWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWebApi.Service
{
    public interface IInMemoryService
    {
        public ReturnDTO GetNumberDetails(string number);
    }
}
