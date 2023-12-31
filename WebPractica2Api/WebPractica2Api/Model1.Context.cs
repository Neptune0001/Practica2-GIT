﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPractica2Api
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Practica2Entities : DbContext
    {
        public Practica2Entities()
            : base("name=Practica2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
    
        public virtual int RegistrarVehiculoSP(string marca, string modelo, string color, Nullable<decimal> precio, Nullable<long> idVendedor)
        {
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var idVendedorParameter = idVendedor.HasValue ?
                new ObjectParameter("IdVendedor", idVendedor) :
                new ObjectParameter("IdVendedor", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarVehiculoSP", marcaParameter, modeloParameter, colorParameter, precioParameter, idVendedorParameter);
        }
    
        public virtual int RegistrarVendedorSP(string cedula, string nombre, string correo, Nullable<bool> estado)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarVendedorSP", cedulaParameter, nombreParameter, correoParameter, estadoParameter);
        }
    }
}
