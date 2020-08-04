using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRStep.Data
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ConnectionId { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }

}
