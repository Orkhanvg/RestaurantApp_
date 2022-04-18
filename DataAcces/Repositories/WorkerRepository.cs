
using DataAcces;

using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class WorkerRepository : IRepository<Worker>
    {
        public WorkerRepository()
        {
           
        }
        public bool Create(Worker entity)
        {
            try
            {
                DataContext.Workers.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }


        }



        public bool Delete(Worker entity)
        {
            try
            {
                DataContext.Workers.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Worker> GetAll(Predicate<Worker> filter = null)
        {
            try
            {


                return DataContext.Workers.FindAll(filter);


            }
            catch (Exception)
            {

                throw;
            }
        }



        public Worker GetOne(Predicate<Worker> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Workers[0] :
                    DataContext.Workers.Find(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }



        public bool Update(Worker entity)
        {
            try
            {
                Worker isExist = GetOne(r => r.Name == entity.Name);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
