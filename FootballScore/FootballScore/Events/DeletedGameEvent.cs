using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballScore.Events
{
    public class DeletedGameEvent:INotification
    {
        public int Id { get; set; }
    }
}
