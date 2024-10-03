using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delete_update.Entities.Abstarct;

namespace delete_update.Entities.Concrete
{
    public class Teachers : BaseEntities
    {
        public ICollection<Group> Groups { get; set; } = new List<Group>(); // One-to-Many
    }
}
