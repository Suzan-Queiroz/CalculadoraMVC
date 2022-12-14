using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMVC.Controllers; 

public class OperacoesController : Controller
{
    public IActionResult Soma() => View();

    public IActionResult ResultadoSoma(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;
        return View();
    }

    public IActionResult Subtracao() => View();

    public IActionResult ResultadoSubtracao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 - n2;
        return View();
    }

    public IActionResult Multiplicacao() => View();

    public IActionResult ResultadoMultiplicacao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 * n2;
        return View();
    }

    public IActionResult Divisao() => View();

    public IActionResult ResultadoDivisao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 / n2;
        return View();
    }
}
