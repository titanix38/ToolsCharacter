﻿using Data.Context;
using Data.Entities.Person;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IDbCharacterRepository : IDisposable
    {
        IQueryable<Character> GetAll(bool noTracking = true);
       
        int Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));

        TResult Execute<TResult>(string functionName, params object[] parameters);
        //void Add(Character character);
        void Create(string firstName, string lastName, string pseudo, EnumGender gender);
        int GetId(string name, string lastName, string pseudo);
    }
}