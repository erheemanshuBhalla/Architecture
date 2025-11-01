
using Architecture_V4.Core.Entities;
using Architecture_V4.Core.Interfaces;
using System.Threading.Tasks;


namespace Architecture_V4.BusinessLogic.Services
{
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task RegisterUserAsync(string name, string email)
        {
            var existing = await _unitOfWork.Users.GetByEmailAsync(email);
            if (existing != null)
                throw new Exception("User already exists.");

            var user = new User { Name = name, Email = email };
            await _unitOfWork.Users.AddAsync(user);

            _unitOfWork.Commit();
        }
    }

}
