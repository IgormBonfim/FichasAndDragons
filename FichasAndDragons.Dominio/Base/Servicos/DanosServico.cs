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
    public class DanosServico : IDanosServico
    {
        private readonly IDadosServico dadosServico;

        public DanosServico(IDadosServico dadosServico)
        {
            this.dadosServico = dadosServico;
        }

        public Dano Instanciar(DanoInstanciarComando danoInstanciarComando)
        {
            Dado dado = dadosServico.Instanciar(danoInstanciarComando.Dado);
            return new Dano(dado, danoInstanciarComando.Tipo);
        }
    }
}
