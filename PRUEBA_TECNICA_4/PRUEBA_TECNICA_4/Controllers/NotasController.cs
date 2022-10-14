using Microsoft.AspNetCore.Mvc;
using PRUEBA_TECNICA_4.Data;
using PRUEBA_TECNICA_4.Models;

namespace PRUEBA_TECNICA_4.Controllers
{
    public class NotasController : Controller
    {
        NotasData _notasData = new NotasData();

        public IActionResult Listar()
        {
            //LISTA LAS NOTAS
            var oNotas = _notasData.Listar();

            return View(oNotas);
        }

        public IActionResult Guardar()
        {
            //DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Notas oNotas)
        {
            //RECIBE EL OBJETO PARA GUARDARLO
            if (!ModelState.IsValid)
                return View();

            var respuesta = _notasData.Guardar(oNotas);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Editar(int IdNota)
        {
            //DEVUELVE LA VISTA
            var oNota = _notasData.Obtener(IdNota);

            return View(oNota);
        }

        [HttpPost]
        public IActionResult Editar(Notas oNotas)
        {
            //RECIBE EL ID PARA EDITARLO
            if (!ModelState.IsValid)
                return View();

            var respuesta = _notasData.Editar(oNotas);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdNota)
        {
            //DEVUELVE LA VISTA
            var oNota = _notasData.Obtener(IdNota);

            return View(oNota);
        }

        [HttpPost]
        public IActionResult Eliminar(Notas oNotas)
        {
            //RECIBE EL ID PARA EDITARLO
            var respuesta = _notasData.Eliminar(oNotas.NoId);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
