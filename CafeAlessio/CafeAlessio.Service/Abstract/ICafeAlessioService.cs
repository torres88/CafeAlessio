using CafeAlessio.Domain;
using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Service.Abstract
{
    public interface ICafeAlessioService<TEntity>
        where TEntity : IEntity
    {
        IEnumerable<TEntity> List();
        TEntity GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save(TEntity entity);
    }
}
