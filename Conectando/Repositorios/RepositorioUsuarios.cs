using Backend.Modelos;
using Conectando.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectando.Repositorios
{
    public class RepositorioUsuarios
    {

        private DataContext? dbContext;

        public RepositorioUsuarios()
        {
        }

        public Usuario LoginUsuario(string email)
        {
            dbContext = new DataContext();
            return dbContext.Usuarios.FirstOrDefault(x => x.nombreLogin == email);
        }

        public bool AltaUsuario()
        {

            Persona persona = new Persona()
            {
                dni = "30782195",
                Nombre = "Emiliano",
                apellido = "Policardo",

                telefono = "23987129387"

            };
            Usuario usuario = new Usuario()
            {
                Nombre = "Admin",
                Apellido = "admin"
            };

            this.dbContext = new DataContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Persona.Load();
            dbContext.Persona.Add(persona);
            dbContext.SaveChanges();
            return true;
        }
        public bool BajaUsuario() { return true; }

        public bool ModificaUsuario() {
            //Repo
            //foreach (var item in dbContext.Persona)
            //{
            //    if (item.Nombre == usuariotxt.Text)
            //    {


            //        MenuUsuarios menu = new MenuUsuarios();
            //        menu.Show();

            //    }
            //}
            return true; }


    }
}
