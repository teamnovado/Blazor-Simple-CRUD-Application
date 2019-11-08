using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Datalayer.Context;

namespace Businesslayer.Services
{
    public class ServiceBase
    {
        protected readonly IMapper Mapper;
        protected readonly VerifieerContext Context;

        public ServiceBase(IMapper mapper, VerifieerContext context)
        {
            Mapper = mapper;
            Context = context;
        }
    }
}
