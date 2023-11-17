using ControleDeContatos.Models;

namespace ControleDeContatos.Interfaces
{
    public interface Icontato
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel BuscarPorId(int id);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
