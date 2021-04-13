using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        IEnumerable<T> QueryStoredProcedure<T>(string spName, DynamicParameters dynamicParameters);
        int ExecuteStoredProcedure<T>(string spName, DynamicParameters dynamicParameters);
    }
}