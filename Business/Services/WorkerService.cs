namespace Business.Services
{
    public class WorkerService : IWorkerr

    {
        public static int Count { get; set; }

        public WorkerRepository workerRepository;
        public WorkerService(WorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public Worker Create(Worker worker)
        {
            group.Id = Count;

            _workerRepository.Create(worker);
            Count++;
            return worker;
        }
        public WorkerService Delete (int Id)
        {

        }
    }
}
