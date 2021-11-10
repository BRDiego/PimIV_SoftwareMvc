using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using DAL;

namespace PimIV_Web.Controllers
{
    public class ReservasController : Controller
    {
        private ReservaDAO _resDAO = new ReservaDAO();
        // GET: Reservas
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int nAdultos, int nCriancas,
            string tQuarto, int monthIn, int dayIn, int monthOut,
            int dayOut)
        {  
            Reserva res = new Reserva();
            int ano = 0;
            if (monthIn >= DateTime.Now.Month)
            {
                ano = DateTime.Now.Year;
            }
            else
            {
                ano = DateTime.Now.Year + 1;
            }
            string dataEntrada = dayIn + "-" + monthIn + "-" + ano;
            string dataSaida = dayOut + "-" + monthOut + "-" + ano;
            res.CheckIn = DateTime.Parse(dataEntrada);
            res.CheckOut = DateTime.Parse(dataSaida);
            res.Adultos = nAdultos;
            res.Criancas = nCriancas;
            if(res.ReservaValida(out string mensagem))
            {
                return View(res);
            }
            else
            {
                ViewBag.MensagemErro = mensagem;
                return View();
            }
        }

    }
}