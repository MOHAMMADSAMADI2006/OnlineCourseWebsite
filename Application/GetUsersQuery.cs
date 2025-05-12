using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using MediatR;

namespace Application
{
    public class GetUsersQuery : IRequest<List<User>>
    { }
}
