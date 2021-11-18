using System.Web.Mvc;
using Model;
using DAL;
using System;
using PimIV_Web.Models.ViewModels;
using PimIV_Web.Models;

namespace PimIV_Web.Controllers
{
    public class ContasController : Controller
    {
        ContaDAO cDAO = new ContaDAO();
        HospedeDAO hDAO = new HospedeDAO();
        // GET: Contas
        public ActionResult FazerLogin()
        {
            switch (SessaoSite.Mensagem)
            {
                case 1:
                    ViewBag.ErroCadastro = "Hóspede já cadastrado. Faça login.";
                    break;
                case 2:
                    ViewBag.ErroCadastro = "Ocorreu um erro no cadastro\nVerifique seus dados";
                    break;
                case 3:
                    ViewBag.LoginInvalido = "Dados de login inválidos";
                    break;
                default:
                    break;
            }
            SessaoSite.Mensagem = 0;
            return View();
        }


        [HttpPost]
        public ActionResult ValidarHosp(string email, string senha)
        {
            Conta conta = cDAO.ValidarHospede(email, senha);
            if (conta != null)
            {
                SessaoSite.Conta = conta;
                SessaoSite.Conta.HospAssociado = conta.HospAssociado;
                return RedirectToAction("AcessarConta");
            }
            else
            {
                SessaoSite.Mensagem = 3;
                return RedirectToAction("FazerLogin");
            }
        }

        [HttpPost]
        public ActionResult CadastrarHospede(string nome,string email,
            DateTime nasc, string sexo, string cpfPass, string senha)
        {
            Hospede hospede = new Hospede();
            Conta conta = new Conta();
            hospede.Nome = nome;
            hospede.DataNascimento = nasc;
            hospede.Sexo = char.Parse(sexo);
            hospede.Email = email;
            if (cpfPass.Contains(".") || cpfPass.Contains("-") || cpfPass.Length == 11)
            {
                hospede.setarCPF(cpfPass);
            }
            else
            {
                hospede.Passaporte = cpfPass;
            }
            string buscar = hospede.CPF != "" ? hospede.CPF : hospede.Passaporte;
            if(hDAO.Carregar(buscar).Id != 0)
            {
                SessaoSite.Mensagem = 1;
                return RedirectToAction("FazerLogin");
            }
            hDAO.InserirHospede(hospede, out string mensagem);
            hospede = hDAO.Carregar(buscar);
            if(hospede == null)
            {
                SessaoSite.Mensagem = 2;
                return RedirectToAction("FazerLogin");
            }
            conta.HospAssociado = hospede;
            conta.Senha = senha;
            conta.NomeUsuario = " ";
            cDAO.Inserir_Att(conta);
            SessaoSite.Conta = conta;
            return RedirectToAction("AcessarConta");
        }

        public ActionResult FazerLogoff()
        {
            SessaoSite.Conta = null;
            SessaoSite.Reserva = null;
            return RedirectToAction("FazerLogin");
        }

        public ActionResult AcessarConta()
        {
            HospedeViewModel mostrar = new HospedeViewModel();
            if(SessaoSite.Conta != null)
            {
                mostrar.Conta = SessaoSite.Conta;
                mostrar.Hospede = SessaoSite.Conta.HospAssociado;
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("FazerLogin");
            }
        }

        public ActionResult Edit()
        {
            HospedeViewModel mostrar = new HospedeViewModel();
            if (SessaoSite.Conta != null)
            {
                mostrar.Conta = SessaoSite.Conta;
                mostrar.Hospede = SessaoSite.Conta.HospAssociado;
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("FazerLogin");
            }
        }

        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            //collection: 1-6 = criar hospede/10-11 = criar conta
            Conta conta = new Conta();
            Hospede hospede = new Hospede();
            hospede.Nome = collection[1].ToString();
            hospede.DataNascimento = DateTime.Parse(collection[2].ToString());
            hospede.Sexo = char.Parse(collection[3].ToString());
            hospede.Email = collection[4].ToString();
            hospede.Telefone = collection[5].ToString();
            hospede.setarCPF(collection[6].ToString());
            hospede.Passaporte = collection[7].ToString();
            conta.NomeUsuario = collection[8].ToString();
            conta.Senha = collection[9].ToString();
            hDAO.InserirHospede(hospede, out string mensagem);
            string cpfPass = !hospede.CPF.Contains(" ")
                ? hospede.CPF : hospede.Passaporte;
            hospede = hDAO.Carregar(cpfPass);
            conta.HospAssociado = hospede;
            cDAO.Inserir_Att(conta);
            SessaoSite.Conta = conta;
            SessaoSite.Conta.HospAssociado = conta.HospAssociado;
            return RedirectToAction("AcessarConta");
        }
    }
}