using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DashInvestimentos.Models
{
    public class Movimentacao
    {

        public int MovimentacaoId { get; set; }

        public string Ativo { get; set; }

        public DateTime Date { get; set; }

        public int Quantidade { get; set; }

        public string Tipo { get; set; }

        public float ValorVenda { get; set; }

        public float ValorCompra { get; set; }

        public float TotalMovimentacao { get; set; }

        public string Status { get; set; }
    }
}
