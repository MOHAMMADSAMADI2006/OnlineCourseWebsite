using Application;
using Domain.Interface;
using Domain;
using MediatR;


public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUnitOfWork _uow;
    private readonly IWriteRepository<User> _writeRepo;

    public CreateUserHandler(IUnitOfWork uow)
    {
        _uow = uow;
        _writeRepo = uow.Users; // assumes UnitOfWork.Users is IWriteRepository<User>
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Phone = request.Phone,
            Gender = request.Gender,
            Password = HashPassword(request.Password)
        };

        await _writeRepo.AddAsync(user);
        await _uow.CommitAsync();
        return user.Id;
    }

    private string HashPassword(string password)
    {
        // TODO: use real hashing (e.g., BCrypt)
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }
}



//using MediatR;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<User>>
//{
//    private readonly IReadRepository<User> _readRepo;

//    public GetUsersHandler(IReadRepository<User> readRepo)
//    {
//        _readRepo = readRepo;
//    }

//    public async Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
//    {
//        var users = await _readRepo.ListAsync();
//        return users
//            .Select(u => new User
//            {
//                Id = u.Id,
//                FirstName = u.FirstName,
//                LastName = u.LastName,
//                Phone = u.Phone,
//                Gender = u.Gender
//            })
//            .ToList();
//    }
//}