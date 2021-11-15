
namespace cyk_grammar_tester
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVariable = new System.Windows.Forms.Label();
            this.lblProduction = new System.Windows.Forms.Label();
            this.lblActualVariable = new System.Windows.Forms.Label();
            this.txtVariable = new System.Windows.Forms.TextBox();
            this.txtProduction = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.btnAddProduction = new System.Windows.Forms.Button();
            this.btnIsProduce = new System.Windows.Forms.Button();
            this.lblString = new System.Windows.Forms.Label();
            this.txtStringTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGrammar = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrammar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(55, 43);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(45, 13);
            this.lblVariable.TabIndex = 0;
            this.lblVariable.Text = "Variable";
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Location = new System.Drawing.Point(55, 86);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(70, 13);
            this.lblProduction.TabIndex = 1;
            this.lblProduction.Text = "Production of";
            // 
            // lblActualVariable
            // 
            this.lblActualVariable.AutoSize = true;
            this.lblActualVariable.Location = new System.Drawing.Point(131, 86);
            this.lblActualVariable.Name = "lblActualVariable";
            this.lblActualVariable.Size = new System.Drawing.Size(0, 13);
            this.lblActualVariable.TabIndex = 2;
            // 
            // txtVariable
            // 
            this.txtVariable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVariable.Location = new System.Drawing.Point(106, 40);
            this.txtVariable.Name = "txtVariable";
            this.txtVariable.Size = new System.Drawing.Size(100, 20);
            this.txtVariable.TabIndex = 3;
            this.txtVariable.Click += new System.EventHandler(this.txtVariable_Click);
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(182, 79);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(55, 20);
            this.txtProduction.TabIndex = 4;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMsg.Location = new System.Drawing.Point(55, 195);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 24);
            this.lblMsg.TabIndex = 5;
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.Location = new System.Drawing.Point(225, 38);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(116, 23);
            this.btnAddVariable.TabIndex = 6;
            this.btnAddVariable.Text = "Add Variable ";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // btnAddProduction
            // 
            this.btnAddProduction.Location = new System.Drawing.Point(243, 77);
            this.btnAddProduction.Name = "btnAddProduction";
            this.btnAddProduction.Size = new System.Drawing.Size(98, 23);
            this.btnAddProduction.TabIndex = 7;
            this.btnAddProduction.Text = "Add Production";
            this.btnAddProduction.UseVisualStyleBackColor = true;
            this.btnAddProduction.Click += new System.EventHandler(this.btnAddProduction_Click);
            // 
            // btnIsProduce
            // 
            this.btnIsProduce.Location = new System.Drawing.Point(142, 153);
            this.btnIsProduce.Name = "btnIsProduce";
            this.btnIsProduce.Size = new System.Drawing.Size(199, 23);
            this.btnIsProduce.TabIndex = 8;
            this.btnIsProduce.Text = "Is produced by grammar";
            this.btnIsProduce.UseVisualStyleBackColor = true;
            this.btnIsProduce.Click += new System.EventHandler(this.btnIsProduce_Click);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(55, 125);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(81, 13);
            this.lblString.TabIndex = 9;
            this.lblString.Text = "String to be test";
            // 
            // txtStringTest
            // 
            this.txtStringTest.Location = new System.Drawing.Point(142, 122);
            this.txtStringTest.Name = "txtStringTest";
            this.txtStringTest.Size = new System.Drawing.Size(199, 20);
            this.txtStringTest.TabIndex = 10;
            this.txtStringTest.TextChanged += new System.EventHandler(this.txtStringTest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "GRAMMAR";
            // 
            // dgvGrammar
            // 
            this.dgvGrammar.AllowUserToAddRows = false;
            this.dgvGrammar.AllowUserToDeleteRows = false;
            this.dgvGrammar.AllowUserToResizeColumns = false;
            this.dgvGrammar.AllowUserToResizeRows = false;
            this.dgvGrammar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrammar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrammar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrammar.Location = new System.Drawing.Point(406, 59);
            this.dgvGrammar.Name = "dgvGrammar";
            this.dgvGrammar.ReadOnly = true;
            this.dgvGrammar.Size = new System.Drawing.Size(382, 285);
            this.dgvGrammar.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvGrammar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStringTest);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.btnIsProduce);
            this.Controls.Add(this.btnAddProduction);
            this.Controls.Add(this.btnAddVariable);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.txtVariable);
            this.Controls.Add(this.lblActualVariable);
            this.Controls.Add(this.lblProduction);
            this.Controls.Add(this.lblVariable);
            this.Name = "Form1";
            this.Text = "Grammar Tester with CYK";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrammar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.Label lblActualVariable;
        private System.Windows.Forms.TextBox txtVariable;
        private System.Windows.Forms.TextBox txtProduction;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.Button btnAddProduction;
        private System.Windows.Forms.Button btnIsProduce;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox txtStringTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrammar;
        private System.Windows.Forms.Button btnClear;
    }
}

