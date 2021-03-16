using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class SchoolTaskService : ISchoolTaskService
    {
        private readonly IRepository<SchoolTask> _repository;

        public SchoolTaskService(IRepository<SchoolTask> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);           
        }

        public async Task<SchoolTask> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<SchoolTask>> Get()
        {
            return await _repository.SelectAsync();
        }

        public async Task<SchoolTask> Post(SchoolTask obj)
        {
            return await _repository.InsertAsync(obj);
        }

        public async Task<SchoolTask> Put(SchoolTask obj)
        {
            return await _repository.UpdateAsync(obj);
        }
    }
}
