using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain;
using CafeAlessio.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Service.Concrete
{
    public class CafeAlessioServiceBase<TEntity> : ICafeAlessioService<TEntity>
        where TEntity : class, IEntity
    {
        protected IRepository<TEntity> _repository;

        public CafeAlessioServiceBase(/*UnitOfWork unitOfWork,*/ IRepository<TEntity> repository)
        {
            //_unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetSingle(id);
        }

        public IEnumerable<TEntity> List()
        {
            return _repository.GetAll();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
