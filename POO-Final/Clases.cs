using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    internal class Clases
    {

        private class Usuario {
            public int Id {  get; set; }
            public string Nombre { get; set; }
            public string Rol { get; set; } //administrador, vendedor
            public string Contraseña { get; set; } //Contraseña Usuario

            public Usuario(int id, string Nombre, string Rol, string Contraseña)
            {
                this.Id = id;
                this.Nombre = Nombre;
                this.Rol = Rol;
                this.Contraseña = Contraseña;  
            }
        }

        private class Administrador : Usuario {
            public Administrador(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
            {

            }

        }

        private class Vendedor : Usuario { 
            public Vendedor(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
            {

            }
        }

        private class Espectaculo { 
            public int id { get; set; }
            public string Nombre { get; set; }
            public int CapacidadTotal { get; set; }
            public double PrecioBase { get; set; }
            public string Foto { get; set; }
            List<Ubicacion> Ubicaciones;
        }

        private class Ubicacion { 
            public int id {get; set;}
            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public double Precio { get; set; }
            public int EntradasVendidas { get; set; }


        }

        private class Venta {
            public int idVenta {get; set;}
            public DateTime Fecha { get; set; }
            public Espectaculo Espectaculo { get; set; }
            public Ubicacion Ubicacion { get; set; }
            public Usuario Vendedor { get; set; }
            public int Cantidad { get; set; }
            public double Total { get; set; }

        }

        private class Reporte { 
            
        } 
    }
}
