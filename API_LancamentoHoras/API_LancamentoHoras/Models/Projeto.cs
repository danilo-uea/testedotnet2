﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LancamentoHoras.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<LancamentoHoras> LancamentosHoras { get; set; }
        public List<ProjetoDesenvolvedor> ProjetosDesenvolvedores { get; set; }
    }
}
