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

        /// <summary>
        ///     private constructor for CYK class to ensure unique instanciation.
        /// </summary>
        private CYK()
        {

        }

        /// <summary>
        ///     Method for get the CYK instance; if its the first time the method create the instance.
        /// </summary>
        /// <returns>uniqueInstance</returns>
        public CYK GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new CYK();
            }
            return uniqueInstance;
        }

        /// <summary>
        ///     <para>
        ///         Method for adding content to the table of the CYK.
        ///     </para>
        ///     <para>
        ///         The precondition is that table was already created.
        ///     </para>
        /// </summary>
        /// <param name="row">The row of the content to be insert. The row must be in the table size.</param>
        /// <param name="col">The column of the content to be insert. The column must be in the table size.</param>
        /// <param name="value">The content to be added in the table.</param>
        public void AddInTable(int row, int col, string value)
        {
            Table[row, col] = value;
        }

        /// <summary>
        ///     Checks if the table ends with initial state, and says if the grammar produce the string.
        /// </summary>
        /// <returns>Bool thats true if is produce and false if is not produce.</returns>
        public bool IsProduceByGrammar()
        {
            int col = Table.GetLength(1) - 1;
            return Table[0, col].Contains("S");
        }

        /// <summary>
        ///     <para>
        ///         Method for getting the content of a row column specify.
        ///     </para>
        ///     <para>
        ///         The precondition is that table was already created. The return could be null.
        ///     </para>
        /// </summary>
        /// <param name="row">The row for the content asked.</param>
        /// <param name="col">The column for the content asked.</param>
        /// <returns></returns>
        public string getContent(int row, int col)
        {
            return Table[row, col];
        }
    }
}
