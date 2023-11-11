using ControleDeContatos.Data;
using ControleDeContatos.Interfaces;
using ControleDeContatos.Models;

namespace ControleDeContatos.Serviços
{
    public class ServicoContato : Icontato
    {
        private readonly BancoContext _context;
        public ServicoContato(BancoContext bancoContext)
        {
            _context = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public List<ContatoModel> BuscarTodos()
        {
           return _context.Contatos.ToList();
        }
    }
}
