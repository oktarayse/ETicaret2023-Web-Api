using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIProject.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebAPIProject.Controllers
{
    public class KategoriController : ApiController
    {
        //dört metod barındırır içinde
        //get listeleme
        //host
        //put update metodu
        //delete sil metodu
        ETicaretEntities db = new ETicaretEntities();

        [HttpGet]
        public List<Kategoriler> Get()
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Kategoriler> liste = db.Kategoriler.ToList();
           
           
            return liste;
        }

        [HttpGet]
       
        public IHttpActionResult Get(int id)
        {
           
            Kategoriler kategori = db.Kategoriler.Find(id);
            Kategori kat = new Kategori()
            {
                Id = kategori.KategoriID,
                name = kategori.KategoriAdi
            };

            return Ok(kat);
        }
    }
}
