﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Entidades;

namespace Parcial.Negocio
{
    public class ClsUsuario
    {
        public bool Acceso(string nombre, string contra)
        {
            // Verificar las credenciales del usuario
            return nombre == "TUNOMBRE" && contra == "123";
        }
    }
    public class ClsVenta
    {
        public void Cobro(Venta venta)
        {
            decimal total = venta.PrecioDelProducto * venta.CantidadDeProducto;

            // Aplicar descuento si el total de la venta es mayor a $50
            if (total > 50)
            {
                total -= 10;
                Console.WriteLine($"Precio original: ${venta.PrecioDelProducto * venta.CantidadDeProducto}");
                Console.WriteLine($"Descuento aplicado: $10");
                Console.WriteLine($"Total a pagar: ${total}");
            }
            else
            {
                Console.WriteLine($"Total a pagar: ${total}");
            }
        }
    }
}
