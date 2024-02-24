using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTO;

namespace Core.Service
{
    public interface IAutorService
    {
        bool Editar(Autor autor);

        uint Inserir(Autor autor);

        Autor ? Obter(uint idAutor);

        IEnumerable<Autor> ObterPorNome(string nome);

        IEnumerable<Autor> ObterTodos();

        bool Remover(uint idAutor);

        IEnumerable<AutorDTO> ObterPorNomeOrdenadoDescending(string nome);
    }
}
