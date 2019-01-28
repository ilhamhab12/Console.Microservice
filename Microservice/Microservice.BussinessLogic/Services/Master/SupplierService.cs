using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.DataAccess.Model;
using Microservice.DataAccess.Model.Param;
using Microservice.Common.Interfaces;
using Microservice.Common.Interfaces.Master;

namespace Microservice.BussinessLogic.Services.Master
{
    public class SupplierService : ISupplierService
    {
        bool status = false;
        ISupplierRepository _supplierRepository = new SupplierRepository();
        public bool Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Insert id if you want to delete");
                Console.Read();
            }
            else if(id.ToString() == " ")
            {
                Console.WriteLine("Dont Insert white space");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Delete(id);
                Console.WriteLine("Delete Succesfully");
                Console.Read();
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {

            return _supplierRepository.Get(id);

        }

        public bool Insert(SupplierParam supplierParam)
        {
            if (supplierParam == null)
            {
                Console.WriteLine("Please Insert Data");
                Console.Read();
            }
            else if (supplierParam.ToString() == " ")
            {
                Console.WriteLine("Dont Insert white space");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Insert(supplierParam);
                Console.WriteLine("Insert Successfuly");
                Console.Read();
            }
            return status;
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            if (id == null)
            {
                Console.WriteLine("Please Insert Id");
                Console.Read();
            }
            else if (id.ToString() == " ")
            {
                Console.WriteLine("Dont Insert white space");
                Console.Read();
            }
            else
            {
                if (supplierParam == null)
                {
                    Console.WriteLine("Please Insert Supplier");
                    Console.Read();
                }
                else if (supplierParam.ToString() == " ")
                {
                    Console.WriteLine("Dont Insert white space");
                    Console.Read();
                }
                else
                {
                    status = _supplierRepository.Update(id, supplierParam);
                    Console.WriteLine("Update Successfuly");
                    Console.Read();
                }
            }
            return status;
        }
    }
}
