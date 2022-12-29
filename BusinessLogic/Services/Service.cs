using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IAsyncRepository<T> repository;

        public Service(IAsyncRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task Delete(int id)
        {
            var reg = await repository.GetById(id);
            await repository.Delete(reg);
        }

        public async Task Delete(T reg)
        {
            await repository.Delete(reg);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await repository.GetList();
        }

        public async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<int> Insert(T reg)
        {
            var id = (int)await repository.Insert(reg);
            return id;
        }

        public async Task Update(T reg)
        {
            await repository.Update(reg);
        }
    }
}
