using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Semana9.Models;

namespace Semana9.DAO
{
    //capturas por teclado la nueva información que el usuario digite

    public class CrudProductos
    {

        public void AgregarProducto(Producto Parametrosproducto)
        {
            using (AlmacenContext db =
                new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = Parametrosproducto.Nombre;
                producto.Descripción = Parametrosproducto.Descripción;
                producto.Precio = Parametrosproducto.Precio;
                producto.Stock = Parametrosproducto.Stock;
                db.Add(producto);
                db.SaveChanges();
            }
        }
    }

}
