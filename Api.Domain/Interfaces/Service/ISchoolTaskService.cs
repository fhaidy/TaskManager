using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Service
{
    public interface ISchoolTaskService
    {
        Task<SchoolTask> Get(Guid id);
        Task<IEnumerable<SchoolTask>> Get();
        Task<SchoolTask> Put(SchoolTask obj);
        Task<SchoolTask> Post(SchoolTask obj);
        Task<bool> Delete(Guid id);
    }
}
