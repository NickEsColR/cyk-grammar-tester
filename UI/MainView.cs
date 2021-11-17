using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cyk_grammar_tester.Model;


namespace cyk_grammar_tester
{
    public partial class Form1 : Form
    {
        private int row;
        private string productions;
        private List<string> variables;
        private List<string> productionsList;
        private Probador probador;

        /// <summary>
        ///     The constructor method for MainView
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            row = -1;
            dgvGrammar.Columns.Add("Variables", "Variables");
            dgvGrammar.Columns.Add("Productions", "Productions");
            productions = "";
            productionsList = new List<string>();
            variables = new List<string>();
            probador = new Probador();
        }

        /// <summary>
        ///     Add a variable in the grammar, show it in a data grid view and save it in a list after click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            if (txtVariable.Text != "")
            {
                lblMsg.Text = "";
                txtVariable.Text = string.Concat(txtVariable.Text.Where(char.IsLetterOrDigit));
                lblActualVariable.Text = txtVariable.Text;
                txtVariable.ForeColor = Color.Gray;
                dgvGrammar.Rows.Add();
                row++;
                dgvGrammar.Rows[row].Cells[0].Value = txtVariable.Text;
                variables.Add(txtVariable.Text);
                if (productions != "")
                {
                    productionsList.Add(productions);
                    productions = "";
                }
            }
            else
            {
                lblMsg.Text = "please introduce the variable in the field";
            }
            
        }

        /// <summary>
        ///     Add a production of current variable in the grammar, show it in a data grid view after click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduction_Click(object sender, EventArgs e)
        {
            if (txtProduction.Text != "")
            {
                if (txtVariable.Text == "")
                {
                    lblMsg.Text = "Please introduce a variable before production";
                    txtProduction.Text = "";
                }
                else
                {
                    txtProduction.Text = string.Concat(txtProduction.Text.Where(char.IsLetterOrDigit));
                    if (productions == "")
                    {
                        productions = txtProduction.Text;
                    }
                    else
                    {
                        productions += "," + txtProduction.Text;
                    }
                    dgvGrammar.Rows[row].Cells[1].Value = productions;
                    txtProduction.Text = "";
                }
            }
            else
            {
                lblMsg.Text = "please introduce the production in the field";
            }
            
        }

        /// <summary>
        ///     This method sends grammar and string test to model and asks if its produced by grammar after click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIsProduce_Click(object sender, EventArgs e)
        {
            if (txtStringTest.Text != "")
            {
                if(variables.Count==0 || productionsList.Count == 0)
                {
                    lblMsg.Text = "Please introduce the grammar first";
                    txtStringTest.Text = "";
                }
                else
                {
                    txtStringTest.Text = string.Concat(txtStringTest.Text.Where(char.IsLetterOrDigit));
                    txtStringTest.ForeColor = Color.Gray;
                    txtVariable.Text = "";
                    if (productions != "")
                    {
                        productionsList.Add(productions);
                    }
                    string[,] grammar = new string[variables.Count, 2];
                    for (int i = 0; i < variables.Count; i++)
                    {
                        grammar[i, 0] = variables[i];
                        grammar[i, 1] = productionsList[i];
                    }
                    probador.Grammar = grammar;
                    probador.TestString = txtStringTest.Text;
                    probador.GenerateTable();
                    if (probador.IsProduceByGrammar())
                    {
                        lblMsg.Text = "The string is produce by grammar ";
                    }
                    else
                    {
                        lblMsg.Text = "The string is not produce by grammar";
                    }
                }
            }
            else
            {
                lblMsg.Text = "please introduce the string to be tested in the field";
            }
        }

        private void txtVariable_Click(object sender, EventArgs e)
        {
            txtVariable.Text = "";
            txtVariable.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVariable.Text = "";
            txtVariable.ForeColor = Color.Black;
            txtProduction.Text = "";
            lblActualVariable.Text = "";
            txtStringTest.Text = "";
            txtStringTest.ForeColor = Color.Black;
            lblMsg.Text = "";
            variables.Clear();
            productionsList.Clear();
            productions = "";
            row = -1;
            dgvGrammar.Rows.Clear();
            probador = new Probador();
        }

        private void txtStringTest_Click(object sender, EventArgs e)
        {
            txtStringTest.Text = "";
            txtStringTest.ForeColor = Color.Black;
        }
    }
}
