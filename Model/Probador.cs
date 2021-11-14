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
                                if(value == "")
                                {
                                    value = Grammar[rowGrammar, 0];
                                }
                                else
                                {
                                    value += "," + Grammar[rowGrammar, 0];
                                }
                            }
                        }
                    }
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
            for(int j = 2; j < cyk.Table.GetLength(1); j++)
            {
                int limit = cyk.Table.GetLength(1) - j;
                for(int i = 0; i < limit; i++)
                {
                    string value = "";
                    for(int k = 1; k < j; k++)
                    {
                        string prevalue = GetVariablesProduce(cyk.GetContent(i, k), cyk.GetContent(i + k, j - k));
                        if(prevalue != "")
                        {
                            if (value == "")
                            {
                                value = prevalue;
                            }
                            else
                            {
                                string[] variables = prevalue.Split(',');
                                for (int num = 0; num < variables.Length && value.Split(',').Length < Grammar.GetLength(0); num++)
                                {
                                    if (!value.Contains(variables[num]))
                                    {
                                        value += "," + variables[num];
                                    }
                                }
                            }
                        }
                    }
                    cyk.AddInTable(i, j, value);
                }

            }
            return cyk.IsProduceByGrammar(); 
        }

        /// <summary>
        ///     This method do the validation of 1 k-repetition of the repet process.
        /// </summary>
        /// <param name="b">The first variables of the algorithm<./param>
        /// <param name="c">The second variables of the algorithm.</param>
        /// <returns>
        ///     The grammar's variables have a production found with the algorithm. 
        ///     with the same format of the table's value. if has no valiables with the productions returns empty
        /// </returns>
        public string GetVariablesProduce(string b, string c)
        {
            string[] firstVariables = b.Split(',');
            string[] secondVariables = c.Split(',');
            string combination = "";
            foreach (string variable1 in firstVariables)
            {
                for(int i = 0; i < secondVariables.Length; i++)
                {
                    combination += variable1 + secondVariables[i] + ",";
                }
            }
            string[] searchProductions = combination.Split(',');
            string value = "";
            foreach (string production in searchProductions)
            {
                for (int row = 0; row < Grammar.GetLength(0); row++)
                {
                    string[] grammarProductions = Grammar[row, 1].Split(',');
                    bool found = false;
                    for (int i = 0; i < grammarProductions.Length && !found; i++)
                    {
                        if (production.Equals(grammarProductions[i]))
                        {
                            found = true;
                            if (!value.Contains(Grammar[row, 0]))
                            {
                                if(value == "")
                                {
                                    value = Grammar[row, 0];
                                }
                                else
                                {
                                    value += "," + Grammar[row, 0];
                                }
                                
                            }
                        }
                    }
                }
                if(value.Split(',').Length == Grammar.GetLength(0))
                {
                    break;
                }
            }
            return value;
        }
    }
}
