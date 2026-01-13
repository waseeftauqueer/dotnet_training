using Repository_Pattern_Application_CC08.Models;
using Repository_Pattern_Application_CC08.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Application_CC08.Controllers
{
    public class MoviesController : Controller
    {
        IMovieRepository _movieRepository = null;


        public MoviesController()
        {
            _movieRepository = new MovieRepository();
        }
        public ActionResult Index()
        {
            return View(_movieRepository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            _movieRepository.Add(movie);
            _movieRepository.Save();
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int id)
        {
            return View(_movieRepository.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            _movieRepository.Update(movie);
            _movieRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _movieRepository.Delete(id);
            _movieRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByYear(int year)
        {
            var mov = _movieRepository.GetByYear(year);

            if (!mov.Any())
            {
                ViewBag.Message = $"No movies found for the{year}.";
            }

            return View(mov);
        }

        public ActionResult MoviesByDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByDirector(string director)
        {
            var mov = _movieRepository.GetByDirector(director);

            if (!mov.Any())
            {
                ViewBag.Message = $"no movies found for'{director}'";
            }

            return View(mov);
        }
    }
}