﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ardalis.Specification.EntityFrameworkCore.IntegrationTests.Fixture
{
    /// <inheritdoc/>
    public class Repository : RepositoryBase
    {
        protected readonly TestDbContext dbContext;

        public Repository(TestDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
