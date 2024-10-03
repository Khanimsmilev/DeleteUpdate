using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delete_update.Entities.Abstarct;

namespace delete_update.Entities.Concrete
{
    public class Student : BaseEntities
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
