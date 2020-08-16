using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DashInvestimentos.Models
{
    public class Operacao
    {
        public int OperacaoId { get; set; }

        public string Ativo { get; set; }

        public DateTime Date { get; set; }

        public int Quantidade { get; set; }

        public Movimentacao Movimentacao { get; set; }


    }
}
