namespace WeeklyMealGeneratorV2.Panels
{
    partial class MenuPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvIngredients = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAveragePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMeals = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIsAvailable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.btnDeleteSelectedMeal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOpenAddMeal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnAddMeal = new System.Windows.Forms.Panel();
            this.btnHide = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMealName = new System.Windows.Forms.TextBox();
            this.gvSelectIngredientsForMeal = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPickIngredient = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).BeginInit();
            this.pnAddMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectIngredientsForMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // gvIngredients
            // 
            this.gvIngredients.AllowUserToAddRows = false;
            this.gvIngredients.AllowUserToDeleteRows = false;
            this.gvIngredients.ColumnHeadersHeight = 25;
            this.gvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIngredientName,
            this.gcFoodType,
            this.gcAveragePrice});
            this.gvIngredients.Location = new System.Drawing.Point(7, 273);
            this.gvIngredients.Name = "gvIngredients";
            this.gvIngredients.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvIngredients.ReadOnly = true;
            this.gvIngredients.RowHeadersVisible = false;
            this.gvIngredients.Size = new System.Drawing.Size(470, 171);
            this.gvIngredients.TabIndex = 12;
            // 
            // gcIngredientName
            // 
            this.gcIngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcIngredientName.DataPropertyName = "Name";
            this.gcIngredientName.HeaderText = "Ingredient Name";
            this.gcIngredientName.Name = "gcIngredientName";
            this.gcIngredientName.ReadOnly = true;
            // 
            // gcFoodType
            // 
            this.gcFoodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcFoodType.DataPropertyName = "FoodType";
            this.gcFoodType.HeaderText = "Food Type";
            this.gcFoodType.Name = "gcFoodType";
            this.gcFoodType.ReadOnly = true;
            // 
            // gcAveragePrice
            // 
            this.gcAveragePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcAveragePrice.DataPropertyName = "AveragePrice";
            this.gcAveragePrice.HeaderText = "Average Price";
            this.gcAveragePrice.Name = "gcAveragePrice";
            this.gcAveragePrice.ReadOnly = true;
            // 
            // gvMeals
            // 
            this.gvMeals.AllowUserToAddRows = false;
            this.gvMeals.AllowUserToDeleteRows = false;
            this.gvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMealName,
            this.gcIsAvailable});
            this.gvMeals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvMeals.Location = new System.Drawing.Point(7, 54);
            this.gvMeals.Name = "gvMeals";
            this.gvMeals.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvMeals.ReadOnly = true;
            this.gvMeals.RowHeadersVisible = false;
            this.gvMeals.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMeals.Size = new System.Drawing.Size(470, 182);
            this.gvMeals.TabIndex = 11;
            this.gvMeals.SelectionChanged += new System.EventHandler(this.gvMeals_SelectionChanged);
            // 
            // gcMealName
            // 
            this.gcMealName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcMealName.DataPropertyName = "Name";
            this.gcMealName.HeaderText = "Meal Name";
            this.gcMealName.Name = "gcMealName";
            this.gcMealName.ReadOnly = true;
            // 
            // gcIsAvailable
            // 
            this.gcIsAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcIsAvailable.DataPropertyName = "IsActive";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.gcIsAvailable.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcIsAvailable.FalseValue = null;
            this.gcIsAvailable.HeaderText = "Is Available";
            this.gcIsAvailable.IndeterminateValue = null;
            this.gcIsAvailable.Name = "gcIsAvailable";
            this.gcIsAvailable.ReadOnly = true;
            this.gcIsAvailable.TrueValue = null;
            // 
            // btnDeleteSelectedMeal
            // 
            this.btnDeleteSelectedMeal.Location = new System.Drawing.Point(7, 242);
            this.btnDeleteSelectedMeal.Name = "btnDeleteSelectedMeal";
            this.btnDeleteSelectedMeal.Size = new System.Drawing.Size(141, 25);
            this.btnDeleteSelectedMeal.TabIndex = 32;
            this.btnDeleteSelectedMeal.Values.Text = "Delete Selected Meal";
            // 
            // btnOpenAddMeal
            // 
            this.btnOpenAddMeal.Location = new System.Drawing.Point(8, 488);
            this.btnOpenAddMeal.Name = "btnOpenAddMeal";
            this.btnOpenAddMeal.Size = new System.Drawing.Size(126, 25);
            this.btnOpenAddMeal.TabIndex = 31;
            this.btnOpenAddMeal.Values.Text = "Open Add Meal";
            this.btnOpenAddMeal.Click += new System.EventHandler(this.btnOpenAddMeal_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(195, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 37);
            this.label12.TabIndex = 33;
            this.label12.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name Of Ingredient:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.textBox1.Location = new System.Drawing.Point(202, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 35;
            // 
            // pnAddMeal
            // 
            this.pnAddMeal.Controls.Add(this.btnHide);
            this.pnAddMeal.Controls.Add(this.kryptonButton1);
            this.pnAddMeal.Controls.Add(this.label3);
            this.pnAddMeal.Controls.Add(this.label2);
            this.pnAddMeal.Controls.Add(this.tbMealName);
            this.pnAddMeal.Controls.Add(this.gvSelectIngredientsForMeal);
            this.pnAddMeal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAddMeal.Location = new System.Drawing.Point(495, 0);
            this.pnAddMeal.Name = "pnAddMeal";
            this.pnAddMeal.Size = new System.Drawing.Size(298, 556);
            this.pnAddMeal.TabIndex = 36;
            this.pnAddMeal.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(3, 522);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(126, 25);
            this.btnHide.TabIndex = 39;
            this.btnHide.Values.Text = "Hide add panel";
            this.btnHide.Click += new System.EventHandler(this.btnHideAddMealPanel_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(3, 491);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(126, 25);
            this.kryptonButton1.TabIndex = 37;
            this.kryptonButton1.Values.Text = "Add Meal";
            this.kryptonButton1.Click += new System.EventHandler(this.btnAddMeal_ClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Meal Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Add Meal";
            // 
            // tbMealName
            // 
            this.tbMealName.Location = new System.Drawing.Point(121, 68);
            this.tbMealName.Name = "tbMealName";
            this.tbMealName.Size = new System.Drawing.Size(134, 20);
            this.tbMealName.TabIndex = 1;
            // 
            // gvSelectIngredientsForMeal
            // 
            this.gvSelectIngredientsForMeal.AllowUserToAddRows = false;
            this.gvSelectIngredientsForMeal.AllowUserToDeleteRows = false;
            this.gvSelectIngredientsForMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSelectIngredientsForMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIngredient,
            this.gcPickIngredient});
            this.gvSelectIngredientsForMeal.Location = new System.Drawing.Point(3, 95);
            this.gvSelectIngredientsForMeal.Name = "gvSelectIngredientsForMeal";
            this.gvSelectIngredientsForMeal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvSelectIngredientsForMeal.ReadOnly = true;
            this.gvSelectIngredientsForMeal.RowHeadersVisible = false;
            this.gvSelectIngredientsForMeal.Size = new System.Drawing.Size(284, 390);
            this.gvSelectIngredientsForMeal.TabIndex = 0;
            // 
            // gcIngredient
            // 
            this.gcIngredient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcIngredient.DataPropertyName = "Name";
            this.gcIngredient.HeaderText = "Ingredient";
            this.gcIngredient.Name = "gcIngredient";
            this.gcIngredient.ReadOnly = true;
            // 
            // gcPickIngredient
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.gcPickIngredient.DefaultCellStyle = dataGridViewCellStyle2;
            this.gcPickIngredient.FalseValue = null;
            this.gcPickIngredient.HeaderText = "gcPickIngredient";
            this.gcPickIngredient.IndeterminateValue = null;
            this.gcPickIngredient.Name = "gcPickIngredient";
            this.gcPickIngredient.ReadOnly = true;
            this.gcPickIngredient.TrueValue = null;
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.pnAddMeal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteSelectedMeal);
            this.Controls.Add(this.btnOpenAddMeal);
            this.Controls.Add(this.gvIngredients);
            this.Controls.Add(this.gvMeals);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(793, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).EndInit();
            this.pnAddMeal.ResumeLayout(false);
            this.pnAddMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectIngredientsForMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvIngredients;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvMeals;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteSelectedMeal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenAddMeal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnAddMeal;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvSelectIngredientsForMeal;
        private System.Windows.Forms.TextBox tbMealName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIngredient;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn gcPickIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAveragePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMealName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn gcIsAvailable;
    }
}
