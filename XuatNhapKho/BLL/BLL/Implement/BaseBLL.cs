using Database.Interface;
using Model.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.BLL.Implement
{
    public static class BaseBLL<K, T> where K : class
    {
        private static IUnitOfWork<K> _unitOfWork = new UnitOfWork<K>();
        private static IRepository<K> _entityRepository = _unitOfWork.EntityRepository;
        public static K ConvertFromModel(T model)
        {
            K entity = (K)Activator.CreateInstance(typeof(K)); ;
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                if (entity.GetType().GetProperty(property.Name) != null)
                    entity.GetType().GetProperty(property.Name)
                        .SetValue(entity, model.GetType().GetProperty(property.Name).GetValue(model, null), null);
            }
            return entity;
        }
        public static T ConvertToModel(K entity)
        {
            T model = (T)Activator.CreateInstance(typeof(T)); ;
            var properties = typeof(K).GetProperties();
            foreach (var property in properties)
            {
                if (model.GetType().GetProperty(property.Name) != null)
                    model.GetType().GetProperty(property.Name)
                        .SetValue(model, entity.GetType().GetProperty(property.Name).GetValue(entity, null), null);
            }
            return model;
        }
        public static void Insert(T model)
        {
            K entity = ConvertFromModel(model);
            _entityRepository.Insert(entity);
            _unitOfWork.Save();
        }
        public static void InsertList(List<T> listModels)
        {
            foreach (var model in listModels)
            {
                K entity = ConvertFromModel(model);
                _entityRepository.Insert(entity);
            }
            _unitOfWork.Save();
        }
        public static void Delete(Guid id)
        {
            K entity = _entityRepository.GetById(id);
            _entityRepository.Delete(entity);
            _unitOfWork.Save();
        }
        public static void Update(T model)
        {
            K entity = ConvertFromModel(model);
            _entityRepository.Edit(entity);
            _unitOfWork.Save();
        }
        public static T GetById(Guid id)
        {
            K entity = _entityRepository.GetById(id);
            T model = ConvertToModel(entity);
            return model;
        }
        public static List<T> GetAll()
        {
            var listModel = new List<T>();
            var listEntity = _entityRepository.GetAll().AsEnumerable();
            foreach (var entity in listEntity)
            {
                listModel.Add(ConvertToModel(entity));
            }
            return listModel;
        }
    }
}
