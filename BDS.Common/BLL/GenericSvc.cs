namespace BDS.Common.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using BDS.Common.Response;
    using DAL;
   
    public class GenericSvc<D,T> : IGenericSvc<T> where T : class where D : IGenericRep<T>, new()
    {

        #region --Fields--
        
        protected D _rep;

        #endregion
        #region --Implementation--
        public IQueryable<T> All 
        
        {
            get { return _rep.GetAll; }
        }

        public GenericSvc()
        {
            _rep = new D();
        }

        /// <summary>
        /// Default constructor for GenericSvc.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public virtual SingleRsp Create(T m)
        {
            var rsp = new SingleRsp();

            try
            {
              var now = DateTime.Now;
                _rep.Create(m);
            }
            catch (Exception ex)
            {
                rsp.SetError(ex.Message);
            }

            return rsp;
        }

        public virtual MultipleRsp Create(List<T> l)
        {
        var res = new MultipleRsp();
            try
            {
                _rep.CreateList(l);
            }
            catch (Exception ex)
            {
                res.SetError(ex.Message);
            }
            return res;

        }

        public virtual SingleRsp Delete(int id)
        {
            return null;
        }

        public virtual SingleRsp Delete(string code)
        {
            return null;
        }

        public virtual IQueryable<T> Read(Expression<Func<T, bool>> p)
        {
            return _rep.Read(p); 
        }

        public virtual SingleRsp ReadByCode(string code)
        {
            return null;
        }

        public virtual SingleRsp ReadById(int id)
        {
            return null;
        }

        public virtual int Remove(int id)
        {
            return 0;
        }

        public virtual SingleRsp Restore(int id)
        {
            return null;
        }

        public virtual SingleRsp Restore(string code)
        {
            return null;
        }

        public virtual SingleRsp Update(T m)
        {
            var rsp = new SingleRsp();
            try
            {
                _rep.Update(m);
            }
            catch (Exception ex)
            {
                rsp.SetError(ex.Message);
            }
            return rsp;
        }

        public virtual MultipleRsp Update(List<T> l)
        {
            var res = new MultipleRsp();
            try
            {

                _rep.UpdateList(l);
            }
            catch (Exception ex)
            {
                res.SetError(ex.Message);
            }

            return res;
        }
      

        #endregion

    }
}
