using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
