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
    public class PersonalidadesServico : IPersonalidadesServico
    {
        public Personalidade Instanciar(PersonalidadeInstanciarComando instanciarComando)
        {
            return new Personalidade(instanciarComando.TracoPersonalidade, instanciarComando.Ideais, instanciarComando.Vinculos, instanciarComando.Fraquezas);
        }
    }
}