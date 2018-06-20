using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreatedBy = Guid.NewGuid();
            CreatedOn = DateTime.Now;
            UpdatedBy = Guid.NewGuid();
            UpdatedOn = DateTime.Now;
            Status = 0;
        }
        public System.Guid Id { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int Status { get; set; }
    }
}
