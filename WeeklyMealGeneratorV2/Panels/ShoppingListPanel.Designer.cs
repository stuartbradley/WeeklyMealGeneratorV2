namespace WeeklyMealGeneratorV2.Panels
{
    partial class ShoppingListPanel
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
            this.label12 = new System.Windows.Forms.Label();
            this.gvShoppingLists = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcShoppingLists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFruit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcFruit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMeals = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMiscItems = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcInclude = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.btnPrintShoppingList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvShoppingLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiscItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(283, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 37);
            this.label12.TabIndex = 35;
            this.label12.Text = "Shopping Lists";
            // 
            // gvShoppingLists
            // 
            this.gvShoppingLists.AllowUserToAddRows = false;
            this.gvShoppingLists.AllowUserToDeleteRows = false;
            this.gvShoppingLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShoppingLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcShoppingLists});
            this.gvShoppingLists.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvShoppingLists.Location = new System.Drawing.Point(12, 79);
            this.gvShoppingLists.Name = "gvShoppingLists";
            this.gvShoppingLists.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvShoppingLists.ReadOnly = true;
            this.gvShoppingLists.RowHeadersVisible = false;
            this.gvShoppingLists.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvShoppingLists.Size = new System.Drawing.Size(363, 163);
            this.gvShoppingLists.TabIndex = 36;
            this.gvShoppingLists.SelectionChanged += new System.EventHandler(this.gvShoppingLists_SelectionChanged);
            // 
            // gcShoppingLists
            // 
            this.gcShoppingLists.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcShoppingLists.DataPropertyName = "Date";
            this.gcShoppingLists.HeaderText = "Shopping Lists";
            this.gcShoppingLists.Name = "gcShoppingLists";
            this.gcShoppingLists.ReadOnly = true;
            // 
            // gvFruit
            // 
            this.gvFruit.AllowUserToAddRows = false;
            this.gvFruit.AllowUserToDeleteRows = false;
            this.gvFruit.ColumnHeadersHeight = 25;
            this.gvFruit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcFruit});
            this.gvFruit.Location = new System.Drawing.Point(12, 385);
            this.gvFruit.Name = "gvFruit";
            this.gvFruit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvFruit.ReadOnly = true;
            this.gvFruit.RowHeadersVisible = false;
            this.gvFruit.Size = new System.Drawing.Size(363, 131);
            this.gvFruit.TabIndex = 38;
            // 
            // gcFruit
            // 
            this.gcFruit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcFruit.DataPropertyName = "Name";
            this.gcFruit.HeaderText = "Fruit";
            this.gcFruit.Name = "gcFruit";
            this.gcFruit.ReadOnly = true;
            // 
            // gvMeals
            // 
            this.gvMeals.AllowUserToAddRows = false;
            this.gvMeals.AllowUserToDeleteRows = false;
            this.gvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMealName});
            this.gvMeals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvMeals.Location = new System.Drawing.Point(12, 248);
            this.gvMeals.Name = "gvMeals";
            this.gvMeals.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvMeals.ReadOnly = true;
            this.gvMeals.RowHeadersVisible = false;
            this.gvMeals.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMeals.Size = new System.Drawing.Size(363, 131);
            this.gvMeals.TabIndex = 37;
            // 
            // gcMealName
            // 
            this.gcMealName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcMealName.DataPropertyName = "Name";
            this.gcMealName.HeaderText = "Meal Name";
            this.gcMealName.Name = "gcMealName";
            this.gcMealName.ReadOnly = true;
            // 
            // gvMiscItems
            // 
            this.gvMiscItems.AllowUserToAddRows = false;
            this.gvMiscItems.AllowUserToDeleteRows = false;
            this.gvMiscItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.gcInclude});
            this.gvMiscItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvMiscItems.Location = new System.Drawing.Point(381, 79);
            this.gvMiscItems.Name = "gvMiscItems";
            this.gvMiscItems.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvMiscItems.ReadOnly = true;
            this.gvMiscItems.RowHeadersVisible = false;
            this.gvMiscItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMiscItems.Size = new System.Drawing.Size(409, 437);
            this.gvMiscItems.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Misc Item Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gcInclude
            // 
            this.gcInclude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.gcInclude.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcInclude.FalseValue = null;
            this.gcInclude.HeaderText = "Include in shopping List";
            this.gcInclude.IndeterminateValue = null;
            this.gcInclude.Name = "gcInclude";
            this.gcInclude.ReadOnly = true;
            this.gcInclude.TrueValue = null;
            // 
            // btnPrintShoppingList
            // 
            this.btnPrintShoppingList.Location = new System.Drawing.Point(657, 522);
            this.btnPrintShoppingList.Name = "btnPrintShoppingList";
            this.btnPrintShoppingList.Size = new System.Drawing.Size(133, 31);
            this.btnPrintShoppingList.TabIndex = 40;
            this.btnPrintShoppingList.Values.Text = "Print ShoppingList";
            // 
            // ShoppingListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.btnPrintShoppingList);
            this.Controls.Add(this.gvMiscItems);
            this.Controls.Add(this.gvFruit);
            this.Controls.Add(this.gvMeals);
            this.Controls.Add(this.gvShoppingLists);
            this.Controls.Add(this.label12);
            this.Name = "ShoppingListPanel";
            this.Size = new System.Drawing.Size(793, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gvShoppingLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiscItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvShoppingLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcShoppingLists;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFruit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMealName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvMiscItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn gcInclude;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrintShoppingList;
    }
}
