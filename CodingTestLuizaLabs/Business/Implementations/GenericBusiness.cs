﻿using CodingTestLuizaLabs.Model.Base;
using CodingTestLuizaLabs.Repository.Generic;
using Tapioca.HATEOAS.Utils;

namespace CodingTestLuizaLabs.Business.Implementations
{
    public class GenericBusiness<T> : IBusiness<T> where T : BaseEntity
    {
        private IRepository<T> _repository;

        public GenericBusiness(IRepository<T> repository)
        {
            _repository = repository;
        }

        public T Create(T entity)
        {
            return _repository.Create(entity);
        }

        public T FindById(long id)
        {
            return _repository.FindById(id);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public PagedSearchDTO<T> FindWithPagedSearch(int page_size, int page)
        {
            throw new System.NotImplementedException();
        }
    }
}
