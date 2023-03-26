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
    public class MagiasServico : IMagiasServico
    {
        private readonly IDanosServico danosServico;

        public MagiasServico(IDanosServico danosServico)
        {
            this.danosServico = danosServico;
        }

        public Magia Instanciar(MagiaInstanciarComando magiaInstanciarComando)
        {
            IList<Dano> danos = new List<Dano>();

            foreach (var danoComando in magiaInstanciarComando.Danos)
            {
                Dano dano = danosServico.Instanciar(danoComando);
                danos.Add(dano);
            }

            return new Magia(magiaInstanciarComando.Nome, magiaInstanciarComando.Descricao, magiaInstanciarComando.Circulo, magiaInstanciarComando.TempoConjuracao, magiaInstanciarComando.Alcance, magiaInstanciarComando.Componentes, magiaInstanciarComando.Duracao, danos);
        }
    }
}