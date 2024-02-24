using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IItemAcervoService
    {
        int Inserir(Itemacervo itemAcervo);
        void Editar(Itemacervo itemAcervo);
        Itemacervo Obter(int idItemAcervo);
        IEnumerable<Itemacervo> ObterTodos();
        void Remover(int idItemAcervo);
    }
}
