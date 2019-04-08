namespace WeeklyMealGeneratorV2.Panels
{
    partial class RunGeneratorPanel
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
            this.label12 = new System.Windows.Forms.Label();
            this.gvFruit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcFruit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNumberOfTimesPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcMealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumberOfDays = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbNumberOfFruit = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnRunGenerator = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNumberOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNumberOfFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMeals
            // 
            this.gvMeals.AllowUserToAddRows = false;
            this.gvMeals.AllowUserToDeleteRows = false;
            this.gvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMealName});
            this.gvMeals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvMeals.Location = new System.Drawing.Point(16, 75);
            this.gvMeals.Name = "gvMeals";
            this.gvMeals.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.gvMeals.ReadOnly = true;
            this.gvMeals.RowHeadersVisible = false;
            this.gvMeals.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMeals.Size = new System.Drawing.Size(470, 182);
            this.gvMeals.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(304, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 37);
            this.label12.TabIndex = 34;
            this.label12.Text = "Run Generator";
            // 
            // gvFruit
            // 
            this.gvFruit.AllowUserToAddRows = false;
            this.gvFruit.AllowUserToDeleteRows = false;
            this.gvFruit.ColumnHeadersHeight = 25;
            this.gvFruit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcFruit,
            this.gcNumberOfTimesPicked});
            this.gvFruit.Location = new System.Drawing.Point(16, 282);
            this.gvFruit.Name = "gvFruit";
            this.gvFruit.ReadOnly = true;
            this.gvFruit.RowHeadersVisible = false;
            this.gvFruit.Size = new System.Drawing.Size(470, 182);
            this.gvFruit.TabIndex = 36;
            // 
            // gcFruit
            // 
            this.gcFruit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcFruit.DataPropertyName = "Name";
            this.gcFruit.HeaderText = "Fruit";
            this.gcFruit.Name = "gcFruit";
            this.gcFruit.ReadOnly = true;
            // 
            // gcNumberOfTimesPicked
            // 
            this.gcNumberOfTimesPicked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcNumberOfTimesPicked.DataPropertyName = "NumberOfTimesPicked";
            this.gcNumberOfTimesPicked.HeaderText = "Number Of Times Picked";
            this.gcNumberOfTimesPicked.Name = "gcNumberOfTimesPicked";
            this.gcNumberOfTimesPicked.ReadOnly = true;
            // 
            // gcMealName
            // 
            this.gcMealName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcMealName.DataPropertyName = "Name";
            this.gcMealName.HeaderText = "Meal Name";
            this.gcMealName.Name = "gcMealName";
            this.gcMealName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Number Of Days";
            // 
            // cbNumberOfDays
            // 
            this.cbNumberOfDays.DropDownWidth = 121;
            this.cbNumberOfDays.Location = new System.Drawing.Point(647, 78);
            this.cbNumberOfDays.Name = "cbNumberOfDays";
            this.cbNumberOfDays.Size = new System.Drawing.Size(121, 21);
            this.cbNumberOfDays.TabIndex = 38;
            // 
            // cbNumberOfFruit
            // 
            this.cbNumberOfFruit.DropDownWidth = 121;
            this.cbNumberOfFruit.Location = new System.Drawing.Point(647, 116);
            this.cbNumberOfFruit.Name = "cbNumberOfFruit";
            this.cbNumberOfFruit.Size = new System.Drawing.Size(121, 21);
            this.cbNumberOfFruit.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Number Of Fruit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(539, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date From";
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.CalendarTodayDate = new System.DateTime(2019, 4, 6, 0, 0, 0, 0);
            this.dtDateFrom.Location = new System.Drawing.Point(647, 153);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtDateFrom.TabIndex = 42;
            // 
            // btnRunGenerator
            // 
            this.btnRunGenerator.Location = new System.Drawing.Point(647, 180);
            this.btnRunGenerator.Name = "btnRunGenerator";
            this.btnRunGenerator.Size = new System.Drawing.Size(121, 25);
            this.btnRunGenerator.TabIndex = 43;
            this.btnRunGenerator.Values.Text = "Run Generator";
            this.btnRunGenerator.Click += new System.EventHandler(this.btnRunGenerator_Click);
            // 
            // RunGeneratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.btnRunGenerator);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNumberOfFruit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNumberOfDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvFruit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gvMeals);
            this.Name = "RunGeneratorPanel";
            this.Size = new System.Drawing.Size(793, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gvMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNumberOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNumberOfFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvMeals;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMealName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNumberOfTimesPicked;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNumberOfDays;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbNumberOfFruit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDateFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRunGenerator;
    }
}
