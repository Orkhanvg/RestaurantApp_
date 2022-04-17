using Business.Interfaces;
using DataAcces;
using DataAccess.Repositories;
using Entities.Models;
using System.Collections.Generic;

namespace Business.Service
{
    public class WorkerService:IWorkerr
    {
        public static int Count { get; set; }

        private WorkerRepository _workerRepository;
        public WorkerService()
        {
           _workerRepository = new WorkerRepository();
        }



        public Worker Create(Worker worker)
        {
            worker.Id = Count;

            _workerRepository.Create(worker);
            Count++;
            return worker;
        }
        public Worker Delete(int Id)
        {
            Worker worker = DataContext.Workers.Find(x => x.Id == Id);
            _workerRepository.Delete(worker);
            return worker;
        }

       

        public Worker Update(int id, Worker worker)
        {
            Worker worker1 = DataContext.Workers.Find(x => x.Id == id);
           worker.Name = worker.Name;

            _workerRepository.Update(worker1);
            return worker;
        }

       

        public List<Worker> GetAll()
        {
            
                return _workerRepository.GetAll(x => x.Id == x.Id);
           
        }
    }
}
