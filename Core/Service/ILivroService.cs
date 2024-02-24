using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface ILivroService
    {
        void Editar(Livro livro);
        void Inserir(Livro livro);
        Livro Obter(int idLivro);
        IEnumerable<LivroDTO> ObterPorNome(string nome);
        IEnumerable<Livro> ObterTodos();
        void Remover(int idLivro);
        public IEnumerable<LivroPorEditoraDTO> ObterNumeroLivrosPorEditora();
    }
}
