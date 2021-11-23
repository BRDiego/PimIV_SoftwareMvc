using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Model;
using DAL;
using PimIV_Web.Models;

namespace PimIV_Web.Controllers
{
    public class ReservasController : Controller
    {
        private ReservaDAO _resDAO = new ReservaDAO();
        static List<Reserva> disponiveis = new List<Reserva>();
        TipoCustoDAO tDAO = new TipoCustoDAO();

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
            SessaoSite.Reserva = null;
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
            try
            {
                res.CheckIn = DateTime.Parse(dataEntrada);
                res.CheckOut = DateTime.Parse(dataSaida);
            }
            catch (Exception)
            {
                ViewBag.MensagemErro = "Data de entrada ou saída inválida.";
                return View();
            }
            res.Adultos = nAdultos;
            res.Criancas = nCriancas;
            res.Quarto.Tipo.NomeTipo = tQuarto;
            string mensagemErro;
            if (res.ReservaValida(out mensagemErro))
            {
                disponiveis.Clear();
                int quarto = 0;
                List<string> ListaTC = tDAO.ListarTiposQuarto();
                double[] diarias = tDAO.DiariasAdueCri();
                if (res.Quarto.Tipo.NomeTipo == "")
                {
                    foreach (string tipo in ListaTC)
                    {
                        if(_resDAO.TipoDisponivel(res.CheckIn, tipo,
                            out quarto))
                        {
                            Reserva temVaga = new Reserva();

                            temVaga.CheckIn = res.CheckIn;
                            temVaga.CheckOut = res.CheckOut;
                            temVaga.Adultos = res.Adultos;
                            temVaga.Criancas = res.Criancas;

                            temVaga.Quarto.Numero = quarto;
                            temVaga.Quarto.Tipo = tDAO.Carregar(ListaTC.IndexOf(tipo) + 1);
                            temVaga.CalcularDespesas(diarias[0],diarias[1]);
                            disponiveis.Add(temVaga);
                        }
                        else
                        {
                            mensagemErro = "Não há vagas para esta data";
                        }
                    }
                }
                else
                {
                    int idTipo = ListaTC.IndexOf(tQuarto) + 1;
                    res.Quarto.Tipo = tDAO.Carregar(idTipo);
                    if (_resDAO.TipoDisponivel(res.CheckIn, res.Quarto.Tipo.NomeTipo,
                        out quarto))
                    {
                        res.Quarto.Numero = quarto;
                        res.CalcularDespesas(diarias[0], diarias[1]);
                        disponiveis.Add(res);
                    }
                    else
                    {
                        mensagemErro = "Sem vagas para este tipo de quarto.";
                    }
                }
                if(disponiveis.Count > 0)
                {
                    return View(disponiveis);
                }
            }
            {
                ViewBag.MensagemErro = mensagemErro;
                return View();
            }
        }

        public ActionResult Confirmar(string tipo)
        {
            Reserva reserva = disponiveis
                .Find(item => item.Quarto.Tipo.NomeTipo == tipo);
            if(SessaoSite.Conta == null)
            {
                SessaoSite.Mensagem = 4;
                SessaoSite.Reserva = reserva;
                return RedirectToAction("FazerLogin", "Contas");
            }
            else
            {
                if(SessaoSite.Reserva != null && SessaoSite.Reserva.CheckIn != null)
                {
                    reserva = SessaoSite.Reserva;
                }
                else
                {
                    SessaoSite.Reserva = reserva;
                }
                reserva.Hospede = SessaoSite.Conta.HospAssociado;
            }
            return View(reserva);
        }

        public ActionResult RegistrarReserva()
        {
            if(SessaoSite.Reserva == null)
            {
                return RedirectToAction("Index", "Reservas");
            }
            Reserva reserva = SessaoSite.Reserva;
            _resDAO.Inserir_Att(reserva);
            SessaoSite.Reserva = null;
            SessaoSite.Mensagem = 6;
            return RedirectToAction("AcessarConta", "Contas");
        }
    }
}