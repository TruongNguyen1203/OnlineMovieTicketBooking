using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class MovieController : BaseApiController
    {
        private  readonly IGenericRepository<Movie> _moviesRepo ;
        private readonly StoreContext _context;
        public MovieController(IGenericRepository<Movie> moviesRepo,StoreContext context)
        {
            this._moviesRepo = moviesRepo;
            _context=context;
        }
        [HttpGet("{id}")]
        public async Task<Movie> GetMovie(int id)
        {
            return await _moviesRepo.GetByIdAsync(id);
            // return await _context.Movies.FindAsync(id);
        }
    }
}