using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using RentalMovie.Core.Utilities.Results;

namespace Business.Abstract
{

    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

