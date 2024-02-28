using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Party
    {
        public int PartyID { get; set; }
        public string PartyName { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
