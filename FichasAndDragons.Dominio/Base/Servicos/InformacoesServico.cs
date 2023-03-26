using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class InformacoesServico : IInformacoesServico
    {
        public Informacao Instanciar(InformacaoInstanciarComando instanciarComando)
        {
            return new Informacao(
                instanciarComando.Idade,
                instanciarComando.Altura,
                instanciarComando.Peso,
                instanciarComando.CorOlhos,
                instanciarComando.CorPele,
                instanciarComando.CorCabelo,
                instanciarComando.Descricao,
                instanciarComando.Historia,
                instanciarComando.Antecedente,
                instanciarComando.Alinhamento
                );
        }
    }
}
