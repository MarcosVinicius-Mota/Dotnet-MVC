using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IEditoraService
    {
        void Editar(Editora editora);
        int Inserir(Editora editora);
        Editora Obter(int idEditora);
        IEnumerable<Editora> ObterPorNome(string nome);
        IEnumerable<Editora> ObterTodos();
        void Remover(int idEditora);
    }
}
