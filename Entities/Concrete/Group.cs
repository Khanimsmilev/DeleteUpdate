using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delete_update.Entities.Abstarct;

namespace delete_update.Entities.Concrete
{
    public class Group : BaseEntities
    {
        public int TeacherId { get; set; }
        public Teachers? Teacher { get; set; }
        public Student? Student { get; set; } // One-to-One
    }
}
