using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class ReservaDAO
    {

        public List<string> CarregarProdutosAtivos()
        {
            //SqlCommand comando = new SqlCommand();
            //string query = "SELECT p.Nome from Produto p where" +
            //    " p.StatusProd = 'ATIVO'";
            List<string> saida = new List<string>();
            List<Produto> produtos = new List<Produto>();
            Produto prod = new Produto();
            Produto prod2 = new Produto();
            produtos.Add(prod);
            produtos.Add(prod2);
            prod.Nome = "Agua";
            prod.Preco = 22.2;
            prod.Quantidade = 10;
            prod.Validade = DateTime.Parse("22-10-22");
            prod2.Nome = "Laranja";
            prod2.Preco = 10.2;
            prod2.Quantidade = 4;
            prod2.Validade = DateTime.Parse("01-01-22");
            
            foreach(Produto p in produtos)
            {
                saida.Add(p.Nome);
            }
            return saida;

        }

        public List<Reserva> ListarReservas()
        {
            return new List<Reserva>();
        }
    }
}
