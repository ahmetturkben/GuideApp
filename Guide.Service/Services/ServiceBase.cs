using AutoMapper;
using Guide.Data.Interfaces;
using Guide.Service.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Guide.Service.Services
{
    public class ServiceBase<TEntity, BLEntity> : IService<TEntity, BLEntity>
         where TEntity : Data.Entities.BaseEntity
        where BLEntity : BL.Base.BaseBLModel
    {

        protected IRepositoryBase<TEntity> _repo;
        protected readonly IMapper _mapper;
        public ServiceBase(IMapper mapper, IRepositoryBase<TEntity> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public BLEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return _mapper.Map<BLEntity>(_repo.GetSingle(predicate));
        }

        public BLEntity GetById(string Id)
        {
            return _mapper.Map<BLEntity>(_repo.GetById(Id));
        }

        public List<BLEntity> GetAll()
        {
            return _mapper.Map<List<BLEntity>>(_repo.Table.ToList());
        }

        public List<BLEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _mapper.Map<List<BLEntity>>(_repo.Table.Where(predicate).ToList());
        }

        // Start: Create Methods
        public void Add(BLEntity entity)
        {
            SetCreatedDetail(entity);
            _repo.Add(_mapper.Map<TEntity>(entity));
        }
        public void Update(BLEntity entity)
        {
            TEntity ent = _mapper.Map<TEntity>(entity);
            //TEntity tEntity = repo.GetSingle(repo.SearchFilters(ent));
            //repo.Update(ent, tEntity);
            _repo.Update(ent);
        }

        public void Remove(BLEntity entity)
        {
            _repo.Update(_mapper.Map<TEntity>(entity)/*, _mapper.Map<TEntity>(entity)*/);
        }

        private void SetCreatedDetail(BL.Base.IBaseBLModel BLEntity)
        {
            BLEntity.SetCreatedDetail();
        }
    }
}
