using System.Web.Mvc;
using Model;
using PimIV_Web.Models.ViewModels;

namespace PimIV_Web.Controllers
{
    public class ContasController : Controller
    {
        // GET: Contas
        public ActionResult FazerLogin()
        {
            return View();
        }

        public ActionResult AcessarConta(Conta conta)
        {
            HospedeViewModel pessoa = new HospedeViewModel();
            pessoa.Hospede.Nome = "Diego";
            pessoa.Conta.NomeUsuario = "Peter parker";
            return View(pessoa);
        }

        public ActionResult Edit(HospedeViewModel pessoa)
        {
            pessoa.Hospede.Nome = "Tony stark";
            pessoa.Conta.NomeUsuario = "ARmadura";
            return View(pessoa);
        }
    }
}