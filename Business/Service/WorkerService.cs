namespace Business.Service
{
    public class WorkerService
    {
        public static int Count { get; set; }

        private WorkerRepository workerRepository;
        public WorkerService()
        {
            workerRepository = new WorkerRepository();
        }



        public Worker Create(Worker worker)
        {
            worker.Id = Count;

            _workerRepository.Create(worker);
            Count++;
            return worker;
        }
        public WorkerService Delete(int Id)
        {

        }

        public global::System.Collections.Generic.List<global::Entities.Models.Worker> GetAll()
        {
            throw new global::System.NotImplementedException();
        }
    }
}
