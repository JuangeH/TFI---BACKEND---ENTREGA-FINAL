﻿using Core.Business.Services;
using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Core.Services
{
    public class RecomendacionVideojuegoService : GenericService<RecomendacionVideojuegoModel>, IRecomendacionVideojuegoService
    {
        public RecomendacionVideojuegoService(IUnitOfWork unitOfWork)
           : base(unitOfWork, unitOfWork.GetRepository<IRecomendacionVideojuegoRepository>())
        {

        }
    }
}
