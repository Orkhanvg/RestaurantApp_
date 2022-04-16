using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class WorkerService:IWorker

    {
        public static int Count { get; set; }

        public WorkerRepository workerRepository;
        public WorkerService(WorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public Worker Create (Worker worker)
        {
            group.Id = Count;

            _workerRepository.Create(worker);

            return worker;


        }
    }
}
