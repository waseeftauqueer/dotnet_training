using Repository_Pattern_Application_CC08.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository_Pattern_Application_CC08.Repository
{
    public class MovieRepository : IMovieRepository
    {
        MoviesContext db = new MoviesContext();

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }

        public void Add(Movie movie)
        {
            db.Movies.Add(movie);
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
        }

        public IEnumerable<Movie> GetByYear(int year)
        {
            return db.Movies.Where(m => m.DateOfRelease.Year == year).ToList();
        }

        public IEnumerable<Movie> GetByDirector(string director)
        {
            return db.Movies.Where(m => m.DirectorName == director).ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}