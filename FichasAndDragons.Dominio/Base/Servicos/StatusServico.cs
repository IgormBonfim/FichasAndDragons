using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class StatusServico : IStatusServico
    {
        private readonly IAtributosServico atributosServico;

        public StatusServico(IAtributosServico atributosServico)
        {
            this.atributosServico = atributosServico;
        }
        public Status Instanciar(StatusInstanciarComando instanciarComando)
        {
            Atributo forca = atributosServico.Instanciar(instanciarComando.Forca);
            Atributo destreza = atributosServico.Instanciar(instanciarComando.Destreza);
            Atributo constituicao = atributosServico.Instanciar(instanciarComando.Constituicao);
            Atributo inteligencia = atributosServico.Instanciar(instanciarComando.Inteligencia);
            Atributo sabedoria = atributosServico.Instanciar(instanciarComando.Sabedoria);
            Atributo carisma = atributosServico.Instanciar(instanciarComando.Carisma);

            return new Status(instanciarComando.BonusProficiencia, forca, destreza, constituicao, inteligencia, sabedoria, carisma);
        }
    }
}