using System;
using Microsoft.EntityFrameworkCore;
using AplicacionWebG3.Dominio;

namespace AplicacionWebG3.Persistencia
{
    public class AppC : DbContext
    {
        public DbSet<Persona> personas {get; set;}
        public DbSet<Profesional> Profesionales {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<TipoDocumento> TipoDocumentos {get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Server=ELIYJHONNY\\SQLEXPRESS; Database=AplicacionWebG3; Integrated Security = True;");
        }
    }
    }
}