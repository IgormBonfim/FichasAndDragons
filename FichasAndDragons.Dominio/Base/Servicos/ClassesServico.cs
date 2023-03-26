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
    public class ClassesServico : IClassesServico
    {
        private readonly IDadosServico dadosServico;

        public ClassesServico(IDadosServico dadosServico)
        {
            this.dadosServico = dadosServico;
        }

        public Classe Instanciar(ClasseInstanciarComando classeInstanciarComando)
        {
            Dado dado = dadosServico.Instanciar(classeInstanciarComando.DadoVida);

            return new Classe(classeInstanciarComando.Nome, classeInstanciarComando.Nivel, classeInstanciarComando.Experiencia, dado);
        }
    }
}
