using SegurosGAP.BusinessRules.GenericBusinessRules;
using SegurosGAP.Entities;
using System;
using System.Threading.Tasks;

namespace WebApiGap
{
    public class AuthRepository : IDisposable
    {
        UsuariosRepository _usuariosRepository;
        ApplicationRepository _applicationRepository;
        RefreshTokensRepository _refreshTokensRepository;

        public AuthRepository()
        {
            _usuariosRepository = new UsuariosRepository();
            _applicationRepository = new ApplicationRepository();
            _refreshTokensRepository = new RefreshTokensRepository();
        }

        public Usuario FindUser(string userName, string password)
        {
            var user = _usuariosRepository.FindUser(userName, password);
            return user;
        }

        public bool UpdateUser(Usuario user)
        {
            var result = _usuariosRepository.UpdateUser(user);
            return result;
        }

        public Application FindAplicacion(string clientId)
        {
            var result = _applicationRepository.FindAplicacion(clientId);
            return result;
        }
        public bool AddRefreshToken(RefreshToken token)
        {
            return _refreshTokensRepository.AddRefreshToken(token);
        }
        public bool RemoveRefreshToken(RefreshToken token)
        {            
            return _refreshTokensRepository.RemoveRefreshToken(token);
        }

        public RefreshToken FindRefreshToken(string refreshTokenId)
        {
            return _refreshTokensRepository.FindRefreshToken(refreshTokenId);
        }

        public void Dispose()
        {            
            _usuariosRepository = null;
            _applicationRepository = null;
            _refreshTokensRepository = null;
        }
    }
}