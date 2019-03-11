﻿using Tapioca.HATEOAS.Utils;

namespace CodingTestLuizaLabs.Business
{
    public interface IBusiness<T> where T : class
    {
        T Create(T entity);
        T FindById(long id);
        T Update(T entity);
        void Delete(long id);
        bool Exists(long id);
        PagedSearchDTO<T> FindWithPagedSearch(int page_size, int page);
    }
}