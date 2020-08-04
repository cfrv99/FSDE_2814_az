using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.EntityFrameworkCore;
using SignalRStep.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRStep.Data
{
    public class DataContrext:DbContext
    {
        private readonly IHubContext<ChatHub> hubContext;

        public DataContrext(DbContextOptions<DataContrext> dbContextOptions,IHubContext<ChatHub> hubContext)
            :base(dbContextOptions)
        {
            this.hubContext = hubContext;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            await hubContext.Clients.All.AllNotifyChange();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
