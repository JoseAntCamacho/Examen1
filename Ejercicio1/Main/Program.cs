using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int Importe { get; set; }
    }
    public class FacturaDescuento
    {
        public int IdFactura { get; set; }
        public int Descuento { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var lstFacturas = new List<Factura>
                  {
                    new Factura {IdFactura = 1, Importe = 500 },
                    new Factura {IdFactura = 2, Importe = 1200 },
                    new Factura {IdFactura = 3, Importe = 400 },
                    new Factura {IdFactura = 4, Importe = 3500 }
                  };

            var lstDescuentos = new List<FacturaDescuento>
                    {
                      new FacturaDescuento {IdFactura = 2, Descuento = 20 },
                      new FacturaDescuento {IdFactura = 4, Descuento = 100 }
                    };

            var lstLeftJoin =
              (from fact in lstFacturas
               join desc in lstDescuentos on fact.IdFactura equals desc.IdFactura into FactDesc
               from fd in FactDesc.DefaultIfEmpty()
               select new
               {
                   IdFactura = fact.IdFactura,
                   ImporteBase = fact.Importe,
                   ImporteACobrar = (fd == null) ? fact.Importe : fact.Importe - fd.Descuento
               }
              ).ToList();

            
        }
    }
}
