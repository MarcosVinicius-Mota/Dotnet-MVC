using Core;
using Core.DTO;
using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LivroService : ILivroService
    {
        public void Editar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Livro Obter(int idLivro)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroPorEditoraDTO> ObterNumeroLivrosPorEditora()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDTO> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
