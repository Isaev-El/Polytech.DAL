using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.Collections.Generic;

namespace Polytech.DAL
{
    public class Repository<T>
    {
        private readonly string path;

        public Repository(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(
                    "Путь не может быть пустым!");
            this.path = path;
        }

        public ReturnResult<T> GetAllClients()
        {
            ReturnResult<T> result = new ReturnResult<T>();

            try
            {
                using (var db = new LiteDatabase(path))
                {
                    result.ListData = db.GetCollection<T>
                        (typeof(T).Name)
                        .FindAll()
                        .ToList();
                }
            }
            catch (Exception ex)
                when (string.IsNullOrWhiteSpace(path))
            {
                result.Exception = ex;
                result.IsError = true;
            }
            catch (Exception ex)
            {

                result.Exception = ex;
                result.IsError = true;
            }

            return result;
        }


        public ReturnResult<T> Create(T data)
        {
            ReturnResult<T> result = new ReturnResult<T>();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var list = db.GetCollection<T>
                        (typeof(T).Name);
                    list.Insert(data);
                }
            }
            catch (Exception ex)
            {

                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }

        public ReturnResult<T> Delete(int id)
        {
            ReturnResult<T> result = new ReturnResult<T>();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    // Get a collection (or create, if doesn't exist)
                    var list = db.GetCollection<T>("Client");

                    list.Delete(id);
                }
            }
            catch (Exception ex)
            {

                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }
        public ReturnResult<T> Update(T data)
        {
            ReturnResult<T> result = new ReturnResult<T>();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    // Get a collection (or create, if doesn't exist)
                    var list = db.GetCollection<T>
                        (typeof(T).Name);
                    list.Update(data);
                }
            }
            catch (Exception ex)
            {

                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }
    }
}
