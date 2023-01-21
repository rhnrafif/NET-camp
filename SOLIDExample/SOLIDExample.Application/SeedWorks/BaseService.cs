using SOLIDExample.Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.SeedWorks
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWorks UnitOfWork;
        protected BaseService(IUnitOfWorks unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }


    }
}
