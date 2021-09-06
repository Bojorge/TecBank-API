using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TecBank_API.Models;

namespace TecBank_API
{
    public class RolManager
    {
        public List<Rol> ListaDeRoles = new List<Rol>();

        public RolManager()
        {
            listarRoles();
        }
        /**
         * A partir de un archivo json se obtiene la coleccion de items (rol) y los serilaiza en una lista
         * 
         * **/
        private void listarRoles()
        {
            using (StreamReader file = File.OpenText(@"..\..\..\roles.json"))//se puede usar la direccion exacta hay que ver donde poner el archivo
            {
                JsonSerializer serializer = new JsonSerializer();
                this.ListaDeRoles = (List<Rol>)serializer.Deserialize(file, typeof(List<Rol>));
            }

        }



        /**
         * muestra la lista en consola
         * 
         * **/
        public void mostrarlista()
        {
            foreach (Rol r in this.ListaDeRoles)
            {
                Console.WriteLine(r.ToString());
            }
        }
        /**
         * Agrega un item (rol) en la lista de colecciones y lo guarda en el archivo json
         * 
         * **/
        public void agregarRol(string nombre, string descripcion)
        {
            Rol rol = new Rol();
            rol.Nombre = nombre;
            rol.Descripcion = descripcion;
            this.ListaDeRoles.Add(rol);
            guardarRol();
        }
        public void eliminarRol(string nombre)
        {
            int index = 0;
            for (int i = 0; i < this.ListaDeRoles.Count; i++)
            {
                if (this.ListaDeRoles[i].Nombre == nombre)
                {
                    this.ListaDeRoles.RemoveAt(index);
                    index = i;
                    break;
                }
            }

            guardarRol();
        }
        /**
         * guarda la lista en archivo json comoc una coleccion
         * 
         * **/
        private void guardarRol()
        {
            using (StreamWriter file = File.CreateText(@"..\..\..\roles.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this.ListaDeRoles);
            }
        }

        public void actualizarRol(string llave, string atributoAcambiar, string ValorParaCambiar)
        {
            int index = 0;
            for (int i = 0; i < this.ListaDeRoles.Count; i++)
            {
                if (this.ListaDeRoles[i].Nombre == llave)
                {
                    index = i;
                    break;
                }
            }
            Rol r1 = this.ListaDeRoles[index];
            switch (atributoAcambiar)
            {
                case "Nombre":
                    r1.Nombre = ValorParaCambiar;
                    break;
                case "Descripcion":
                    r1.Descripcion = ValorParaCambiar;
                    break;
                default:
                    break;
            }
            guardarRol();
        }

        public Rol consultarRol(string llave)
        {
            Rol r1 = new Rol();
            int index = 0;
            for (int i = 0; i < this.ListaDeRoles.Count; i++)
            {
                if (this.ListaDeRoles[i].Nombre == llave)
                {
                    index = i;
                    break;
                }
            }
            r1 = this.ListaDeRoles[index];
            return r1;

        }


    }
}
