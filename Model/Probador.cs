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
            string[,] table = new string[size, size];
            int row = 1;
            foreach (char terminal in TestString)
            {
                string value = "";
                table[row, 0] = char.ToString(terminal);
                for(int rowGrammar = 0; rowGrammar < Grammar.GetLength(0); rowGrammar++)
                {
                    for(int columnGrammar = 1; columnGrammar<Grammar.GetLength(1); columnGrammar++)
                    {
                        if (Grammar[rowGrammar, columnGrammar] == null)
                        {
                            columnGrammar = Grammar.GetLength(1);
                        }
                        else
                        {
                            if (Grammar[rowGrammar, columnGrammar].Equals(terminal))
                            {
                                if (!value.Contains(Grammar[rowGrammar, 0]))
                                {
                                    value += Grammar[rowGrammar, 0]+",";
                                }
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
            for(int column = 0; column < size; column++)
            {
                table[0, column] = "J = " + column;
            }
            cyk.Table = table;
        }

        /// <summary>
        ///     This method end the creation of the cyk table and return if is produced or not.
        /// </summary>
        /// <returns>Bool thats true if is produce and false if is not produce.</returns>
        public bool isProduceByGrammar()
        {
            return false; 
        }
    }
}
