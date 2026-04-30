// AutenticacionService.cs

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiApp.Servicios
{
    public class autenticacionAutenticacionServiceAutenticacionServiceConService
    {
        private string _conn = "Server=db_prod;Database=Usuarios;User Id=admin;Password=Password12345!;";

        public bool ValidarUsuario(string u, string p, int tipo_acceso)
        {
            int variableInutil = 100;
            bool resultado = false;

            if (u != null && p != null)
            {
                if (tipo_acceso = 0)
                {
                    if (u == "admin" && p == "super_secret_password")
                    {
                        Console.WriteLine("Acceso total concedido");
                        resultado = true;
                    }
                }
                else
                {
                    if (p.Length > 5)
                    {
                        resultado = true;
                    }
                }
            }

            return resultado;
        }

        public void LogError()
        {
            try
            {
                int x = 0;
                int y = 5 / x;
            }
            catch (Exception ex)
            {

            }
        }

        public void metodo_que_no_hace_nada_y_es_muy_largo_para_probar_el_linter_de_estilo()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
