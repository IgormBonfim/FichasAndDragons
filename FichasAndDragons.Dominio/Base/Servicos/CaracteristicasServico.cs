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
    public class CaracteristicasServico : ICaracteristicasServico
    {
        public Caracteristica Instanciar(CaracteristicaInstanciarComando caracteristicaInstanciarComando)
        {
            return new Caracteristica(caracteristicaInstanciarComando.Nome, caracteristicaInstanciarComando.Descricao);
        }
    }
}
