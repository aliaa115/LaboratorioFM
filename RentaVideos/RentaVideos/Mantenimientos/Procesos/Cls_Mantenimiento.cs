using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaVideos.Mantenimientos.Procesos
{
    public class Cls_Mantenimiento
    {
        /*
         ID DE TABLAS:
            1 = bono
            2 = categoria
            3 = cliente
            4 = empleado
            5 = material
            6 = mora
            7 = ayuda

        ORDEN DE LOS DATOS EN RETURN PARA datos:
            1 = alias
            2 = ayuda
            3 = tabla
            4 = form
            5 = nombre
            6 = noForaneas
            
        ORDEN DE LOS DATOS EN RETURN PARA foraneas:
            1 = tabla
            2 = campo
            3 = modo
             */
        public (string[], string, string, string, string, int) datos(int tabla)
        {
            switch (tabla)
            {
                case 1:
                    string[] alias1 = { "Bono", "Membresia", "Monto", "Fecha Bono", "Estado" };
                    return (alias1, "1", "bono", "de Bonos", "BONO", 1);

                case 2:
                    string[] alias2 = { "Categoria", "Nombre", "Estado" };
                    return (alias2, "1", "categoria", "de Categorias", "CATEGORIA", 0);

                case 3:
                    string[] alias3 = { "Cliente", "DPI", "Nombres", "Apellidos", "Fecha Nac", "Direccion", "Telefono", "Correo", "Sexo", "Estado" };
                    return (alias3, "1", "cliente", "de Clientes", "CLIENTE", 0);

                case 4:
                    string[] alias4 = { "Empleado", "Nombres", "Apellidos", "Estado" };
                    return (alias4, "1", "empleado", "de Empleados", "EMPLEADO", 0);

                case 5:
                    string[] alias5 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias5, "1", "categorias", "de Categorias", "CATEGORIA", 0);

                case 6:
                    string[] alias6 = { "Material", "Nombre", "Descripcion", "Categoria", "Genero", "Autor", "Precio", "Existencias", "Estado" };
                    return (alias6, "1", "material", "de Materiales", "MATERIAL", 1);

                case 7:
                    string[] alias7 = { "Mora", "Membresia", "Monto", "Fecha", "Estado" };
                    return (alias7, "1", "mora", "de Moras", "MORA", 1);

                default:
                    break;
            }
            return (null, null, null, null, null, 0);
        }

        public (string, string, int) foraneas(int tabla, int no)
        {
            switch (tabla)
            {
                //bono
                case 1:
                    switch (no)
                    {
                        case 1:
                            return ("cliente", "MEMBRESIA", 0);
                    }
                    break;
                    
                //material
                case 6:
                    switch (no)
                    {
                        case 1:
                            return ("categorias", "CATEGORIA", 0);
                    }
                    break;

                //mora
                case 7:
                    switch (no)
                    {
                        case 1:
                            return ("cliente", "MEMBRESIA", 0);
                    }
                    break;

                default:
                    break;
            }
            return ("", "", 0);
        }

    }
}
