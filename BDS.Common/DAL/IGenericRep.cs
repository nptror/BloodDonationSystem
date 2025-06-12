using System.Linq.Expressions;

namespace BDS.Common.DAL
{
    public interface IGenericRep<T> where T : class
    {

        /// <summary>
        /// Create the model
        ///</summary>
        ///<typeparam name="m">Model type</typeparam>
        ///
        void Create(T m);

        /// <summary>
        /// Create list model
        /// </summary>
        /// <param name="l">List of models</param>
        void CreateList(List<T> l);
        /// <summary>
        /// Read the model by expression
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        IQueryable<T> Read(Expression<Func<T, bool>> p);
        /// <summary>
        /// Read all models
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T ReadById(int id);
        /// <summary>
        /// Update the model
        /// </summary>
        /// <param name="m"></param>
        void Update(T m);
        /// <summary>
        /// Update list of models
        /// </summary>
        /// <param name="l"></param>
        void UpdateList(List<T> l);

        /// <summary>
        /// Delete the model
        /// </summary>
        /// <param name="m"></param>
        void Delete(T m);
        /// <summary>
        /// Delete list of models
        /// </summary>
        /// <param name="l"></param>
        void DeleteList(List<T> l);

        IQueryable<T> GetAll { get; }
        
    }
}
