using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application
{
    public class CreateCourseCommand : IRequest<int>
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Id { get; internal set; }
    }
}
