using DemoRESTWS.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoRESTWS.Controllers
{
    [ApiController]
    [Route("customer")]
    public class CustomerController:ControllerBase
    {
        private readonly List<Customer> lstCustomers;


        public CustomerController()
        {
            lstCustomers = new List<Customer>();

            lstCustomers.Add(new Customer(1, "Francisco Jose", "Caceres Honores", "87667876", DateOnly.FromDateTime(DateTime.Now)));
            lstCustomers.Add(new Customer(2, "Marcelo Fabian", "Garro Vega", "87667876", (new DateOnly(2001, 09, 15))));
        }

        [HttpPut]
        [Route("iniciar")]
        public dynamic InitCustomer()
        {
            try
            {

                return new
                {
                    Result = "OK",
                    Message = "INICIALIZACIÓN COMPLETADA EXITOSAMENTE",
                    Values = lstCustomers
                };
            }
            catch(Exception ex)
            {
                return new
                {
                    Result = "ERROR",
                    Message = "OCURRIO EL SIGUIENTE ERROR: " + ex.Message
                };
            }
        }
        [HttpGet]
        [Route("listar")]
        public dynamic ListCustomers()
        {
            return lstCustomers;
        }
        [HttpGet]
        [Route("obtener")]
        public dynamic GetCustomer(int id)
        {
            try
            {
                Customer? customer = lstCustomers.FirstOrDefault(x => x.CustomerId == id);

                if (customer == null)
                {
                    return new
                    {
                        Result = "ERROR",
                        Message = "NO EXISTE CLIENTE CON EL ID INDICADO"
                    };
                }
                else
                {
                    return customer;
                }

            }
            catch (Exception ex)
            {
                return new
                {
                    Result = "ERROR",
                    Message = "OCURRIO EL SIGUIENTE ERROR: " + ex.Message
                };
            }
        }
        [HttpPost]
        [Route("registrar")]
        public dynamic AddCustomer(String FirstName,String LastName,String DNI)
        {
            try
            {
                int newId = lstCustomers.Max(x => x.CustomerId)+1;
                lstCustomers.Add(new Customer(newId, FirstName, LastName, DNI, DateOnly.FromDateTime(DateTime.Now)));

                return new
                {
                    Result = "OK",
                    Message = "CLIENTE AGREGADO EXITOSAMENTE",
                    Values = lstCustomers
                };
            }
            catch(Exception ex)
            {
                return new
                {
                    Result = "ERROR",
                    Message = "OCURRIO EL SIGUIENTE ERROR: " + ex.Message
                };
            }
        }
        [HttpDelete]
        [Route("eliminar")]
        public dynamic RemoveCustomers(int id)
        {
            try
            {
                Customer? deleteCustomer = lstCustomers.FirstOrDefault(x => x.CustomerId == id);

                if (deleteCustomer == null)
                {
                    return new
                    {
                        Result = "ERROR",
                        Message = "NO EXISTE CLIENTE CON EL ID INDICADO"
                    };
                }
                else
                {
                    lstCustomers.Remove(deleteCustomer);
                    return new
                    {
                        Result = "OK",
                        Message = "CLIENTE ELIMINADO CORRECTAMENTE",
                        Values = lstCustomers
                    };
                }

            }
            catch (Exception ex)
            {
                return new
                {
                    Result = "ERROR",
                    Message = "OCURRIO EL SIGUIENTE ERROR: " + ex.Message
                };
            }
        }
    }
}
