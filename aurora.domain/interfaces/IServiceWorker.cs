﻿using System.Collections.Generic;
using Aurora.Domain.Models;

namespace Aurora.Domain.Interfaces
{
    public interface IServiceWorker // interface dos serviços do trabalhador
    {
        WorkerModel Insert(CreateWorkerModel userModel);

        WorkerModel Update(int id, UpdateWorkerModel userModel);

        void Delete(int id);

        WorkerModel RecoverById(int id);

        IEnumerable<WorkerModel> RecoverAll();
    }
}
