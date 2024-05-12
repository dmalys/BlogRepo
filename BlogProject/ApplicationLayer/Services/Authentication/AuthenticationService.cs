using ApplicationLayer.Common.Interfaces;
using ContractsLayer.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthentictationResult> Login(LoginRequest loginRequest)
        {
            
            return new AuthentictationResult(
                Guid.NewGuid(),
                "" ,
                "",
                loginRequest.Email, 
                "token");
        }

        public async Task<AuthentictationResult> Register(RegisterRequest registerRequest)
        {
            //check if user already exists

            //create user gen unique id

            //create jwt token
            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateJwtToken(userId, registerRequest.FirstName, registerRequest.LastName);


            return new AuthentictationResult
                (
                Guid.NewGuid(),
                registerRequest.FirstName,
                registerRequest.LastName,
                registerRequest.Email,
                token
                );
        }
    }
}
