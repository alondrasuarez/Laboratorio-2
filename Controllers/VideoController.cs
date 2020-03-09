﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;


namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        //Muestra Interfaz
        public ActionResult Create()
        {
            return View();
        }
        //Procesa datos
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            //Guardar en la base de datos 
        List<SqlParameter> parametros =new List<SqlParameter>(); 
        parametros.Add(new SqlParameter("@idVideo", idVideo));
        parametros.Add(new SqlParameter("@titulo", titulo));
        parametros.Add(new SqlParameter("@repro", repro));
        parametros.Add(new SqlParameter("@url",url));
        BaseHelper.ejecutarSentencia("sp_video_insert", 
        CommandType.StoredProcedure, 
        parametros);
        RedirectToAction("Index", "Video");
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idvideo)
        {//Borrar de la base de datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idvideo));
            BaseHelper.ejecutarSentencia("sp_video_delete",
            CommandType.StoredProcedure,
            parametros);
            RedirectToAction("Index", "Video");
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("sp_video_edit",
            CommandType.StoredProcedure,
            parametros);
            RedirectToAction("Index", "Video");
            return View();
        }

        public ActionResult Mostrar()
        {
            ViewData["DataVideo"] = BaseHelper.ejecutarConsulta(
                "SELECT * FROM video", CommandType.Text);
            return View();
        }
       
        

    }
}
