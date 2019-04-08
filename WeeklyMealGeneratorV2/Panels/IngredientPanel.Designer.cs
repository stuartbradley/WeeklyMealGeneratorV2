namespace WeeklyMealGeneratorV2.Panels
{
    partial class IngredientPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvMeals = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gvIngredients = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnAddIngredient = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gcIngredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMeals
            // 
            this.gvMeals.AllowUserToAddRows = false;
            this.gvMeals.AllowUserToDeleteRows = false;
            this.gvMeals.ColumnHeadersHeight = 25;
            this.gvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIngredientName});
            this.gvMeals.Location = new System.Drawing.Point(7, 253);
            this.gvMeals.Name = "gvMeals";
            this.gvMeals.ReadOnly = true;
            this.gvMeals.RowHeadersVisible = false;
            this.gvMeals.Size = new System.Drawing.Size(470, 171);
            this.gvMeals.TabIndex = 12;
            // 
            // gvIngredients
            // 
            this.gvIngredients.AllowUserToAddRows = false;
            this.gvIngredients.AllowUserToDeleteRows = false;
            this.gvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIngredients});
            this.gvIngredients.Location = new System.Drawing.Point(7, 54);
            this.gvIngredients.Name = "gvIngredients";
            this.gvIngredients.ReadOnly = true;
            this.gvIngredients.RowHeadersVisible = false;
            this.gvIngredients.Size = new System.Drawing.Size(470, 182);
            this.gvIngredients.TabIndex = 11;
            this.gvIngredients.SelectionChanged += new System.EventHandler(this.gvIngredients_SelectionChanged);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(7, 465);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(126, 25);
            this.btnAddIngredient.TabIndex = 31;
            this.btnAddIngredient.Values.Text = "Add Meal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(303, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 37);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ingredients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name Of Ingredient:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.textBox1.Location = new System.Drawing.Point(201, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 35;
            // 
            // gcIngredients
            // 
            this.gcIngredients.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcIngredients.DataPropertyName = "Name";
            this.gcIngredients.HeaderText = "Ingredient";
            this.gcIngredients.Name = "gcIngredients";
            this.gcIngredients.ReadOnly = true;
            // 
            // gcIngredientName
            // 
            this.gcIngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcIngredientName.DataPropertyName = "Name";
            this.gcIngredientName.HeaderText = "Meal";
            this.gcIngredientName.Name = "gcIngredientName";
            this.gcIngredientName.ReadOnly = true;
            // 
            // IngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.gvMeals);
            this.Controls.Add(this.gvIngredients);
            this.Name = "IngredientPanel";
            this.Size = new System.Drawing.Size(793, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvMeals;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvIngredients;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddIngredient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIngredients;
    }
}
