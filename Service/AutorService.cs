using Core;
using Core.DTO;
using Core.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Service
{
    public class AutorService : IAutorService
    {
        private readonly BibliotecaContext _dbContext;

        public AutorService(BibliotecaContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IQueryable<Autor> GetQuery()
        {
            var query = from autor in _dbContext.Autors select autor;
            return query;
        }

        public bool Editar(Autor autor)
        {
            try
            {
                _dbContext.Autors.Update(autor);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception) 
            {
                return false;    
            }
        }

        public uint Inserir(Autor autor)
        {
            _dbContext.Autors.Add(autor);
            _dbContext.SaveChanges();
            return autor.Id;
        }

        public Autor ? Obter(uint idAutor)
        {
            return _dbContext.Autors.Find(idAutor);
        }

        public IEnumerable<Autor> ObterPorNome(string nome)
        {
            return GetQuery().Where(
                    x => x.Nome.StartsWith(nome)
                );
        }

        public IEnumerable<AutorDTO> ObterPorNomeOrdenadoDescending(string nome)
        {
            return from autor in _dbContext.Autors
                        where autor.Nome.StartsWith(nome)
                        orderby autor.Nome descending
                        select new AutorDTO
                        {
                            Nome = autor.Nome
                        };
        }

        public IEnumerable<Autor> ObterTodos()
        {
            return GetQuery();
        }

        public bool Remover(uint idAutor)
        {
            try
            {
                _dbContext.Autors.Remove(Obter(idAutor));
                _dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
