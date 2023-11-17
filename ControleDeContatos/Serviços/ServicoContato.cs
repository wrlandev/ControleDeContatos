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

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;
        }

        public ContatoModel BuscarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
           return _context.Contatos.ToList();
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = BuscarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro na deleção do contato!");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
