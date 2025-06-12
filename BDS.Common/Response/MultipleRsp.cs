namespace BDS.Common.Response
{
    public class MultipleRsp : BaseRsp
    {
        public Dictionary<string, object> Data { get; private set; }

       public class Dto
        {
            public object Data { get; private set; }
            public string Message { get; set; }
            public Dto(object data, string message)
            {
                Data = data;
                Message = message;
            }
        }
         public string Message { get; private set; }
        public MultipleRsp() : base() { }
        public MultipleRsp(string message) : base(message)
        {
        }


        /// <summary>
        /// Constructor for MultipleRsp with a custom error message and title.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="titleError"></param>
        public MultipleRsp(string message, string titleError) : base(message, titleError)
        {
        }


        /// <summary>
        /// Sets the data in the response with a key-value pair.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="o"></param>
        public void SetData(string key, object o)
        {
            if (Data == null)
            {
                Data = new Dictionary<string, object>();
            }

            Data.Add(key, o);
        }


        /// <summary>
        /// Sets the success data in the response.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="message"></param>
        public void SetSuccess(object o, string message)
        {
            var t = new Dto(o, message);
            SetData("success", t);
        }

        /// <summary>
        /// Sets the failure data in the response.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="message"></param>
        public void SetFailure(object o, string message)
        {
            var t = new Dto(o, message);
            SetData("failure", t);
        }
    }
}
