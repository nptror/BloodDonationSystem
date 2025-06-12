namespace BDS.Common.Request
{
    public class BaseModel
    {
        public int Id { get; set; } // Property to hold the ID
        public Enum Status { get; set; } // Property to hold the status
        public int? CreateBy { get; set; } // Property to hold the ID of the user who created the record
        public DateTime? CreateDate { get; set; } // Property to hold the creation date
        public int? ModifieBy { get; set; } // Property to hold the ID of the user who last updated the record
        public DateTime? ModifieDate { get; set; } // Property to hold the last modification date
        public BaseModel(int id ) 
        {
            Id = id;    
        }

        public BaseModel()
        {
            // Default constructor
        }
    }
}
