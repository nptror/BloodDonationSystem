namespace BDS.Common.Response
{

    public class BaseRsp
    {

        public bool Success { get; private set; } = true;
        public string Code { get; set; } = string.Empty;
        public bool Error { get; set; } = false;
        private string msg;

        private readonly string titleError;
        public static bool Dev { get; set; }

        private readonly string err;
        /// <summary>
        /// Gets or sets the error message. If an error occurs, this property will contain the error message.
        /// </summary>
        public string Message
        {
            get
            {
                if (Success)
                {
                    return "Operation completed successfully.";
                }
                else if (Error)
                {
                    return "An error occurred during the operation.";
                }
                else
                {
                    return "Operation failed.";
                }
            }
        }
        /// <summary>
        /// Gets the error message, which is either the custom error message or a default one if not set.
        /// </summary>
        public string Variant
        {
            get
            {
                return Success ? "success" : titleError;
            }
        }
        /// <summary>
        /// Default constructor for BaseRsp.
        /// </summary>
        public BaseRsp()
        {
            Success = true;
            msg = string.Empty;
            titleError = "Error";

            Dev = true;

            if (string.IsNullOrEmpty(err))
            {
                err = "Please update common error in Custom Setting";
            }

        }

        /// <summary>
        /// Constructor for BaseRsp with a message parameter.
        /// </summary>
        /// <param name="message"></param
        public BaseRsp(string message) : this()
        {
            msg = message;
        }

        /// <summary>
        /// Constructor for BaseRsp with a message and titleError parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="titleError"></param>
        public BaseRsp(string message, string titleError) : this(message)
        {
            this.titleError = titleError;
        }

        /// <summary>
        ///     Sets the error message and updates the Success property to false.
        /// </summary>
        /// <param name="message"></param>
        public void SetError(string message)
        {
            Success = false;
            msg = message;
        }

        /// <summary>
        /// Sets the error message and code, updating the Success property to false.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public void SetError(string code, string message)
        {
            Success = false;
            msg = message;
            Code = code;
        }

        /// <summary>
        /// Sets the message property to the provided message string.
        /// </summary>
        /// <param name="message"></param>
        public void SetMessage(string message)
        {
            msg = message;
        }

        /// <summary>
        /// Tests the error functionality by setting a predefined error message.
        /// </summary>
        public void TestError()
        {
            SetError("We are testing to show error message, please ignore it..");
        }



    }
}
