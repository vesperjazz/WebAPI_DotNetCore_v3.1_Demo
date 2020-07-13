﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebAPI_DotNetCore_Demo.Domain.Entities;

namespace WebAPI_DotNetCore_Demo.Application.Persistence.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetPersonByIDWithDetails(Guid ID, CancellationToken cancellationToken = default);
        Task<IEnumerable<Person>> GetAllPersonWithDetails(CancellationToken cancellationToken = default);
    }
}
