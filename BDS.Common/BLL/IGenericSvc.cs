using System.Linq.Expressions;
using BDS.Common.Response;

namespace BDS.Common.BLL
{
    public interface IGenericSvc<T> where T : class
    {

        #region --Methods--

        /// <summary>
        /// Create the model
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        SingleRsp Create(T m);

        /// <summary>
        /// Create a list of models
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        MultipleRsp Create(List<T> l);

        /// <summary>
        /// Read all models
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        IQueryable<T> Read(Expression<Func<T, bool>> p);


        /// <summary>
        /// Read single model by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SingleRsp ReadById(int id);

        /// <summary>
        /// Read single model by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        SingleRsp ReadByCode(string code);

        /// <summary>
        /// Update the model
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        SingleRsp Update(T m);


        /// <summary>
        /// Update a list of models
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        MultipleRsp Update(List<T> l);

        /// <summary>
        /// Delete a model by id
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        SingleRsp Delete(int id);

        /// <summary>
        /// Delete a model by code
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        SingleRsp Delete(string code);


        /// <summary>
        /// Restore a model by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SingleRsp Restore(int id);

        /// <summary>
        /// Restore a model by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        SingleRsp Restore(string code);


        /// <summary>
        /// Remove a model by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Remove(int id);

        #endregion

        #region --Properties--
        /// <summary>
        /// Get all models
        /// </summary>
        IQueryable<T> All { get; }

        #endregion

    }
}
