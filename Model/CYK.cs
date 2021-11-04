using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyk_grammar_tester.Model
{
    class CYK
    {
        private string[,] Table { get; set; }
        private CYK uniqueInstance;

        private CYK()
        {

        }

        public CYK GetInstance()
        {
            return uniqueInstance;
        }

        public void AddInTable(int row, int col, string value)
        {

        }
        public bool IsProduceByGrammar()
        {
            return false;
        }
    }
}
