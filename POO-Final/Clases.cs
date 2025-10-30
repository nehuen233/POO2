using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace POO_Final
{
    internal class Clases
    {

        private class Usuario
        {
            public int Id { get; set; }
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

            public bool IniciarSesion(string nombre, string contraseña)
            {
                return false;
            }

            public void CerrarSesion()
            {

            }
        }

        private class Administrador : Usuario
        {
            public Administrador(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
            {
                Rol = "Administrador";
            }
            public void CrearEspectaculo(Espectaculo es)
            {

            }

            public void CrearUbicacion(Espectaculo es, Ubicacion ub)
            {

            }

            public void VerReporte(DateTime desde, DateTime hasta)
            {


            }

        }

        private class Vendedor : Usuario
        {
            public Vendedor(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
            {
                Rol = "Vendedor";
            }

            public void RegistrarVenta(Venta v)
            {

            }

            public bool VerificarDisponibilidad(Ubicacion u, int cantidad)
            {

                return false;
            }


        }

        private class Espectaculo
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public int CapacidadTotal { get; set; }
            public double PrecioBase { get; set; }
            public string Foto { get; set; }
            List<Ubicacion> Ubicaciones;

            public Espectaculo(int id, string Nombre, int CapacidadTotal, double PrecioBase, string Foto)
            {
                this.id = id;
                this.Nombre = Nombre;
                this.CapacidadTotal = CapacidadTotal;
                this.PrecioBase = PrecioBase;
                this.Foto = Foto;
                Ubicaciones = new List<Ubicacion>();
            }
            public void AgregarUbicacion(Ubicacion u)
            {

            }

            public bool VerificarCapacidad(int cantidad)
            {
                return false;
            }

            public int ObtenerCapacidadDisponible()
            {
                return 0;
            }
        }



        private class Ubicacion
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public double Precio { get; set; }
            public int EntradasVendidas { get; set; }

            public Ubicacion(int id, string nombre, int capacidad, double precio, int entradasVendidas)
            {
                this.id = id;
                Nombre = nombre;
                Capacidad = capacidad;
                Precio = precio;
                EntradasVendidas = entradasVendidas;
            }

            public bool HayDisponibilidad(int cantidad)
            {
                return false;
            }

            public void RegistrarVenta(int cantidad)
            {

            }

        }

        private class Venta
        {
            public int idVenta { get; set; }
            public DateTime Fecha { get; set; }
            public Espectaculo Espectaculo { get; set; }
            public Ubicacion Ubicacion { get; set; }
            public Usuario Vendedor { get; set; }
            public int Cantidad { get; set; }
            public double Total { get; set; }

            public Venta(int idVenta, DateTime Fecha, Espectaculo Espectaculo, Usuario Vendedor, int Cantidad, double Total)
            {
                this.idVenta = idVenta;
                this.Fecha = Fecha;
                this.Espectaculo = Espectaculo;
                this.Vendedor = Vendedor;
                this.Cantidad = Cantidad;
                this.Total = Total;

            }

            public decimal CalculoTotal()
            {
                return 0;
            }

            public bool ValidarCapacidad()
            {
                return false;
            }
        }

        private class Reporte
        {

            public List<Venta> ObtenerVentasPorFechas(DateTime desde, DateTime hasta)
            {
                return new List<Venta>();
            }

            public decimal CalculaeTotalPorEspectaculo(int idEspectaculo)
            {
                return 0;
            }

        }
    }
}


