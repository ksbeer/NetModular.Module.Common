﻿using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Common.Infrastructure.Repositories.SQLite
{
    public class MediaTypeRepository : SqlServer.MediaTypeRepository
    {
        public MediaTypeRepository(IDbContext context) : base(context)
        {
        }
    }
}
