using ControleDeContatos.Models;

namespace ControleDeContatos.Interfaces
{
    public interface Icontato
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
