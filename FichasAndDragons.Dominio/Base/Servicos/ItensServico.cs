using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class ItensServico : IItensServico
    {
        private readonly IDanosServico danosServico;

        public ItensServico(IDanosServico danosServico)
        {
            this.danosServico = danosServico;
        }

        public Item Instanciar(ItemInstanciarComando itemInstanciarComando)
        {
            IList<Dano> danos = new List<Dano>();

            foreach (var danoComando in itemInstanciarComando.Danos)
            {
                Dano dano = danosServico.Instanciar(danoComando);

                danos.Add(dano);
            }

            return new Item(itemInstanciarComando.Nome, itemInstanciarComando.Descricao, danos);
        }
    }
}
