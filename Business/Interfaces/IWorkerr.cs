using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IWorkerr 
    {
        Worker Create(Worker worker);

        Worker Update(string Name, Worker worker);

        Worker Delete(string Name);

        Worker GetWorker(double salary);
    }
}
