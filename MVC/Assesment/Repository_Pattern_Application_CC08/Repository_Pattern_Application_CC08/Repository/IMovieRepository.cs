using Repository_Pattern_Application_CC08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_Application_CC08.Repository
{
    internal interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        IEnumerable<Movie> GetByYear(int year);
        IEnumerable<Movie> GetByDirector(string director);
        void Save();
    }
}
