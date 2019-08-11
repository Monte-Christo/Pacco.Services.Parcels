using System;
using Pacco.Services.Parcels.Application;

namespace Pacco.Services.Parcels.Infrastructure.Contexts
{
    internal class AppContext : IAppContext
    {
        public string RequestId { get; }
        public IIdentityContext Identity { get; }

        internal AppContext() : this(Guid.NewGuid().ToString("N"), IdentityContext.Empty)
        {
        }

        internal AppContext(CorrelationContext context) : this(context.CorrelationId, new IdentityContext(context.User))
        {
        }

        internal AppContext(string requestId, IIdentityContext identity)
        {
            RequestId = requestId;
            Identity = identity;
        }
        
        internal static IAppContext Empty => new AppContext();
    }
}