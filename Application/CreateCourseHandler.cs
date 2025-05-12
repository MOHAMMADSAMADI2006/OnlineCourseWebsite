using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using MediatR;

namespace Application
{
    public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly IUnitOfWork _uow;
        public CreateCourseHandler(IUnitOfWork uow) => _uow = uow;

        public async Task<int> Handle(CreateCourseCommand request, CancellationToken ct)
        {
            var course = new CreateCourseCommand { Title = request.Title, Price = request.Price };
            await _uow.Courses.AddAsync(course);
            await _uow.CommitAsync();
            return course.Id;
        }
    }
}
