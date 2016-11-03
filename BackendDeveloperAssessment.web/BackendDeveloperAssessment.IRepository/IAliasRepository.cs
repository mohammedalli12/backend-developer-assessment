﻿using BackendDeveloperAssessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDeveloperAssessment.IRepository
{
    public interface IAliasRepository : IRepository<Aliases>
    {
        IQueryable<Aliases> GetByArtistId(int artistId);
    }
}