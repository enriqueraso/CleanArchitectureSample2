using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample2.UseCases.Interfaces
{
    internal interface IRequestHandler<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest data);
    }
}
