using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IWorkerr 
    {
        Worker Create(Worker worker);

        Worker Update(int Id, Worker worker);

        Worker Delete(int id);

        List<Worker> GetAll();
    }
}
