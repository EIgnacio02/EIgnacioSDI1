using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Empleado empleado = new ML.Empleado();

            SL_WCF.Empleado empleadoSerivce = new SL_WCF.Empleado();
            var result = empleadoSerivce.GetAll();
            //ML.Result result = BL.Empleado.GetAll();
            if (result.Correct)
            {
                empleado.EmpleadoList = result.ObjectList;
                return View(empleado);
            }
            else
            {

               return View();
            }
        }

        [HttpGet]
        public ActionResult Formulario(int? IdEmpleado)
        {
            ML.Empleado empleado = new ML.Empleado();
            if (IdEmpleado==null)
            {
                return View(empleado);
            }
            else
            {
                //ML.Result result = BL.Empleado.GetById(IdEmpleado.Value);
                SL_WCF.Empleado empleadoService = new SL_WCF.Empleado();
                var result = empleadoService.GetById(IdEmpleado.Value);

                if (result.Correct)
                {
                    empleado = (ML.Empleado)result.Object;
                }
               return View(empleado);
            }
        }

        [HttpPost]
        public ActionResult Formulario(ML.Empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                //ML.Result result = new ML.Result();
                if (empleado.IdEmpleado==0)
                {
                    //result = BL.Empleado.Add(empleado);
                    SL_WCF.Empleado empleadoSerivce = new SL_WCF.Empleado();
                    var result = empleadoSerivce.Add(empleado);

                    if (result.Correct)
                    {
                        ViewBag.Message = result.Mensaje;
                    }
                    else
                    {
                        ViewBag.Message = "Ocurrio un error";
                    }
                }
                else
                {
                    //result = BL.Empleado.Update(empleado);
                    SL_WCF.Empleado empleadoSerivce = new SL_WCF.Empleado();
                    var result = empleadoSerivce.Update(empleado);

                    if (result.Correct)
                    {
                        ViewBag.Message = result.Mensaje;
                    }
                    else
                    {
                        ViewBag.Message = "Ocurrio un error";
                    }
                }
               return PartialView("Modal");
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Delete(int? IdEmpleado)
        {
            if (IdEmpleado > 0)
            {
                //ML.Result result = BL.Empleado.Delete(IdEmpleado.Value);

                SL_WCF.Empleado empleadoService = new SL_WCF.Empleado();
                var result = empleadoService.Delete(IdEmpleado.Value);

                ViewBag.Message = result.Mensaje;
            }
            else
            {
                ViewBag.Message = "Ocurrio un error";
            }
            return PartialView("Modal");

        }
    }
}