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
    public class ProficienciasServico : IProficienciasServico
    {
        public Proficiencia Instanciar(ProficienciaInstanciarComando proficienciaInstanciarComando)
        {
            return new Proficiencia(proficienciaInstanciarComando.Nome, proficienciaInstanciarComando.Descricao);
        }
    }
}
