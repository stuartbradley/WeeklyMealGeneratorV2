namespace WeeklyMealGeneratorV2.Panels
{
    partial class FruitPanel
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
            this.label12 = new System.Windows.Forms.Label();
            this.gvFruit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcFruit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNumberOfTimesPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFruitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFruit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(309, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 37);
            this.label12.TabIndex = 34;
            this.label12.Text = "Fruit";
            // 
            // gvFruit
            // 
            this.gvFruit.AllowUserToAddRows = false;
            this.gvFruit.AllowUserToDeleteRows = false;
            this.gvFruit.ColumnHeadersHeight = 25;
            this.gvFruit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcFruit,
            this.gcNumberOfTimesPicked});
            this.gvFruit.Location = new System.Drawing.Point(7, 54);
            this.gvFruit.Name = "gvFruit";
            this.gvFruit.ReadOnly = true;
            this.gvFruit.RowHeadersVisible = false;
            this.gvFruit.Size = new System.Drawing.Size(470, 182);
            this.gvFruit.TabIndex = 35;
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
            // tbFruitName
            // 
            this.tbFruitName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.tbFruitName.Location = new System.Drawing.Point(156, 251);
            this.tbFruitName.Name = "tbFruitName";
            this.tbFruitName.Size = new System.Drawing.Size(178, 20);
            this.tbFruitName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name Of Fruit:";
            // 
            // btnAddFruit
            // 
            this.btnAddFruit.Location = new System.Drawing.Point(9, 276);
            this.btnAddFruit.Name = "btnAddFruit";
            this.btnAddFruit.Size = new System.Drawing.Size(126, 25);
            this.btnAddFruit.TabIndex = 36;
            this.btnAddFruit.Values.Text = "Add Fruit";
            this.btnAddFruit.Click += new System.EventHandler(this.btnAddFruit_Click);
            // 
            // FruitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.tbFruitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFruit);
            this.Controls.Add(this.gvFruit);
            this.Controls.Add(this.label12);
            this.Name = "FruitPanel";
            this.Size = new System.Drawing.Size(793, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gvFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNumberOfTimesPicked;
        private System.Windows.Forms.TextBox tbFruitName;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddFruit;
    }
}
