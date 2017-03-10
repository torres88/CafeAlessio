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

        public virtual void Create(TEntity entity)
        {
            _repository.Add(entity);
            _repository.Commit();
        }

        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _repository.Commit();
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetSingle(id);
        }

        public virtual IEnumerable<TEntity> List()
        {
            return _repository.GetAll();
        }

        public virtual void Save(TEntity entity)
        {
            _repository.Update(entity);
            _repository.Commit();
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
            _repository.Commit();
        }
    }
}
