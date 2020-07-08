using CustomAspNetCore.Pipelines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAspNetCore
{
    public interface IConfigurator
    {
        void Configure(MiddlewareBuilder middlewareBuilder);
    }
}
