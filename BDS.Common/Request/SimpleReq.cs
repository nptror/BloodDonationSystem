namespace BDS.Common.Request
{
    public class SimpleReq : BaseReq<BaseModel>
    {
      
        #region --Overrides--
        /// <summary>
        /// Converts the request to a model.
        /// </summary>
        /// <param name="createBy"></param>
        /// <returns></returns>
        public override BaseModel ToModel(int? createBy = null)
        {
            return new BaseModel(Id);
        }

        #endregion
        #region --Methods--
        /// <summary>
        /// Default constructor for SimpleReq.
        /// </summary>
        public SimpleReq() : base()
        {
        }
        /// <summary>
        /// Constructor for SimpleReq with an ID parameter.
        /// </summary>
        /// <param name="id"></param>
        public SimpleReq(int id) : base(id)
        {
        }
        /// <summary>
        /// Constructor for SimpleReq with a keyword parameter.
        /// </summary>
        /// <param name="keywork"></param>
        public SimpleReq(string keywork) : base(keywork)
        {
        }

        #endregion

    }
}
