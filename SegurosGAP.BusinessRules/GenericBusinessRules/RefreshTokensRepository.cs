using SegurosGAP.Entities;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class RefreshTokensRepository : GenericRepository<DBSegurosGAPEntities, RefreshToken>, IRefreshTokensRepository
    {
        public bool AddRefreshToken(RefreshToken token)
        {
            var existingToken = FindBy(x => x.Subject == token.Subject && x.ClientId == token.ClientId).FirstOrDefault();

            if (existingToken != null)
            {
                RemoveRefreshToken(existingToken);
            }
            Add(token);
            Save();
            return true;          
        }

        public bool RemoveRefreshToken(RefreshToken token)
        {
            Delete(token);
            Save();
            return true;
        }

        public RefreshToken FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = GetAll().FirstOrDefault(x => x.Id == refreshTokenId);
            return refreshToken;
        }

    }
}
