using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.DataAccess.Model;
using Microservice.DataAccess.Model.Param;

namespace Microservice.Common.Interfaces.Master
{
    
    public class SupplierRepository : ISupplierRepository
    {
        bool status = false;
        MyContext _context = new MyContext();
        public bool Delete(int? id)
        {
            var result = 0;
            Supplier supplier = Get(id);
            supplier.IsDelete = true;
            supplier.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = _context.SaveChanges();
            if (result == 0)
            {
                return status = true;
            }
            return status;

        }

        public List<Supplier> Get()
        {
            var get = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Supplier Get(int? id)
        {
            var getId = _context.Suppliers.Find(id);
            return getId;
        }

        public bool Insert(SupplierParam supplierParam)
        {
            var result = 0;
            var supplier = new Supplier();
            supplier.Name = supplierParam.Name;
            supplier.JoinDate = DateTimeOffset.UtcNow.LocalDateTime;
            supplier.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            _context.Suppliers.Add(supplier);
            result = _context.SaveChanges();
            if (result > 0)
            {
                return status = true;
            }
            return status;
            
        }

        public bool Update(int? id,SupplierParam supplierParam)
        {
            var result = 0;
            var supplier = Get(id);
            //var get = _context.Suppliers.Find(id);
            supplier.Name = supplierParam.Name;
            supplier.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = _context.SaveChanges();
            if (result > 0)
            {
                return status = true;
            }
            return status;
        }
    }
}
