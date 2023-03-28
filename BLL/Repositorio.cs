using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    public class Repositorio
    {
        public List<Cliente> Nomes { get; set; } = new List<Cliente>();

        public void Incluir(Cliente _nomes)
        {
            Nomes.Add(_nomes);
        }

        public void Remover(Cliente _nomes)
        {
            Nomes.Remove(_nomes);
        }
    }
}
