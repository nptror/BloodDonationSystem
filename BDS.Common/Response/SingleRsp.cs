namespace BDS.Common.Response
{
    public class SingleRsp : BaseRsp
    {
        public object Data { get; set; }


        public SingleRsp() : base() { }
        

        public SingleRsp(string message) : base(message)
        {
        }

        public SingleRsp(string message, string titleError) : base(message, titleError)
        {
        }

        public void SetData(string code, object data)
        {
            Code = code;
            Data = data;
        }
    }
}
