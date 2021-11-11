using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyk_grammar_tester.Model
{
    class Probador
    {
        public string[,] Grammar { get; set; }
        public string TestString { get; set; }
        private CYK cyk;

        /// <summary>
        ///     The constructor of the Probador class.
        /// </summary>
        public Probador()
        {

        }

        /// <summary>
        ///     The method to set the cyk relation.
        /// </summary>
        /// <param name="cyk">The CYK previous got according to the design.It has the table created.</param>
        public void SetCYK(CYK cyk)
        {
            this.cyk = cyk;
        }

        /// <summary>
        ///     <para>
        ///         The method to initialize the table with the size required.
        ///     </para>
        ///     <para>
        ///         The precondition is that TestString and cyk were already initialize.
        ///     </para>
        /// </summary>
        public void GenerateTable()
        {
            int size = TestString.Length;
            string[,] table = new string[size, size+1];
            int row = 0;
            foreach (char terminal in TestString)
            {
                string value = "";
                table[row, 0] = char.ToString(terminal);
                for(int rowGrammar = 0; rowGrammar < Grammar.GetLength(0); rowGrammar++)
                {
                    string[] productions = Grammar[rowGrammar, 1].Split(',');
                    foreach (string production in productions)
                    {
                        if (production.Equals(terminal))
                        {
                            if (!value.Contains(Grammar[rowGrammar, 0]))
                            {
                                value += Grammar[rowGrammar, 0] + ",";
                            }
                        }
                    }
                }
                if(value[value.Length - 1] == ',')
                {
                    value = value.Substring(0, value.Length - 1);
                }
                table[row, 1] = value;
                row++;
            }
            cyk.Table = table;
        }

        /// <summary>
        ///     This method end the creation of the cyk table and return if is produced or not.
        /// </summary>
        /// <returns>Bool thats true if is produce and false if is not produce.</returns>
        public bool IsProduceByGrammar()
        {

            return false; 
        }

        /// <summary>
        ///     This method do the validation of 1 k-repetition of the repet process.
        /// </summary>
        /// <param name="b">The first variables of the algorithm<./param>
        /// <param name="c">The second variables of the algorithm.</param>
        /// <returns>
        ///     The grammar's variables have a production found with the algorithm. with the same format of the table's value.
        /// </returns>
        public string GetVariablesProduce(string b, string c)
        {
            return b + c;
        }
    }
}
