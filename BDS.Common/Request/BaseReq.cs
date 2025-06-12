using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Common.Request
{
    public  abstract class BaseReq<T>
    {

        public int Id { get; set; } // Property to hold the ID
        public string Keywork { get; set; } // Property to hold the keyword for search or filtering
        public abstract T ToModel(int? createBy = null);
        public BaseReq(int id)
        {
            Id = id;
        }
        /// <summary>
        /// Default constructor for BaseReq.
        /// </summary>
        public BaseReq()
        {
            Keywork = string.Empty;
        }
        /// <summary>
        /// Constructor for BaseReq with a keyword parameter.
        /// </summary>
        /// <param name="keywork"></param>
        public BaseReq(string keywork)
        {
            Keywork = keywork;
        }
    }
}
