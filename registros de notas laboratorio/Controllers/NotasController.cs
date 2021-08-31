using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registrosdenotaslaboratorio.Controllers
{
    public class notasController : Controller
    {
        // GET: notas
        public ActionResult index()
        {
            return View();
        }

        public ActionResult Proceso(String Nombre, String lab1, String lab2, String lab3, String par1, String par2, String par3)
        {
            if (Nombre.Equals("") && lab1.Equals("") && lab2.Equals("") && lab3.Equals("") && par1.Equals("") && par2.Equals("") && par3.Equals(""))

                ViewBag.total = Nombre;
            ViewBag.total = lab1;
            ViewBag.total = lab2;
            ViewBag.total = lab3;
            ViewBag.total = par1;
            ViewBag.total = par2;
            ViewBag.total = par3;

            return Redirect("/notas/resultado");

            return Redirect("/notas/index");
        }
        public ActionResult resultado(String Nombre, String L1, String P1, String L2, String P2, String L3, String P3)
        {

            ViewBag.Nombre = Nombre;
            ViewBag.L1 = L1;
            ViewBag.P1 = P1;
            ViewBag.L1 = L2;
            ViewBag.P2 = P2;
            ViewBag.L1 = L3;
            ViewBag.P3 = P3;

            float periodo1 = ((float)(float.Parse(L1) * 0.40) + (float)(float.Parse(P1) * 0.60)) / 3;
            ViewBag.total1 = periodo1;
            float periodo2 = ((float)(float.Parse(L2) * 0.40) + (float)(float.Parse(P2) * 0.60)) / 3;
            ViewBag.total2 = periodo2;
            float periodo3 = ((float)(float.Parse(L3) * 0.40) + (float)(float.Parse(P3) * 0.60)) / 3;
            ViewBag.total3 = periodo3;


            float Nota = (periodo1 + periodo2 + periodo3);
            ViewBag.total = Nota;

            return View();
        }
    }
}

