using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;
using System.Collections.Generic;
using static Common.Enumerations;
using SegurosGAP.Entities.DTO;
using System;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class PolizasClienteRepository : GenericRepository<DBSegurosGAPEntities, PolizasCliente>, IPolizasCliente
    {
        PolizasRepository policies = new PolizasRepository();
        public List<PolizasCliente> FindpPolicyClient(int idClient)
        {
            try
            { 
                var client = FindBy(x => x.IdCliente == idClient).ToList();
                return client;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PolizasCliente> GetPoliciesClients()
        {
            try
            { 
                var result = GetAll().ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MessageResponse UpdatePolicyClient(PolizasCliente client)
        {
            try
            { 
                MessageResponse response = new MessageResponse();
                bool responseRiskType = this.validarTipoRiesgoPoliza(client);

                if (responseRiskType)
                {
                    Edit(client);
                    Save();
                    response.Code = 1;
                    response.Message = "Success";
                }
                else
                {
                    response.Code = 2;
                    response.Message = "El porcentaje de cubrimiento no puede ser superior al 50%.";
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MessageResponse AddPolicyClient(PolizasCliente client)
        {
            try
            {
                MessageResponse response = new MessageResponse();
                bool responseRiskType = this.validarTipoRiesgoPoliza(client);

                if (responseRiskType)
                {
                    Add(client);
                    Save();
                    response.Code = 1;
                    response.Message = "Success";
                }
                else
                {
                    response.Code = 2;
                    response.Message = "El porcentaje de cubrimiento no puede ser superior al 50%.";
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       

        public bool DeletePolicyClient(PolizasCliente client)
        {
            try
            {
                Delete(client);
                Save();
                return true;
            }            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para validar el nivel de riesgo
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool validarTipoRiesgoPoliza(PolizasCliente client)
        {
            InfoPolizasSeguro info = new InfoPolizasSeguro();
            info = policies.GetPoliza(client.IdPolizaSeguro);
            bool respuesta = true;

            if (info.TipoRiesgo == TipoRiesgo.Alto.ToString())
            {
                if (client.PorcentajeCubrimiento > 50)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
