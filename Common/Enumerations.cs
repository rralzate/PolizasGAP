using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Enumerations
    {
        public enum eCustomerMessages : int
        {
            None = SGRepositoryGeneric.Enumerations.eActions.None,

            Save = SGRepositoryGeneric.Enumerations.eActions.Save,
            Modify = SGRepositoryGeneric.Enumerations.eActions.Modify,
            Delete = SGRepositoryGeneric.Enumerations.eActions.Delete,
            Query = SGRepositoryGeneric.Enumerations.eActions.Query,
            Validations = SGRepositoryGeneric.Enumerations.eActions.Validations,

            SaveError,
            ModifyError,
            DeleteError,

            UserNotFound,
            NotificationSending,
            NotificationNotSending,

            InactiveData,
            DataNotFound,
            IncorrectData
        }

        public enum TipoRiesgo
        {
            Bajo = 1,
            Medio = 2,
            MedioAlto = 3,
            Alto = 4
        }

        public enum eParameter : int { AccessTokenExpire = 1, CantidadRegistrosPagina = 2 }

        public enum eParameterHTML : int { PlantillaMensajes = 1 }

        public enum eNotification : int { RecordarContrasena = 1, ErroresServicio = 2 }
    }
}
