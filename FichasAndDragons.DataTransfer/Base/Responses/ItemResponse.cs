﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Responses
{
    public class ItemResponse
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<DanoResponse>? Danos { get; set; }
    }
}
