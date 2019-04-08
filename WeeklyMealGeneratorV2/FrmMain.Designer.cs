namespace WeeklyMealGeneratorV2
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlIngredient = new WeeklyMealGeneratorV2.Panels.IngredientPanel();
            this.pnlMenu = new WeeklyMealGeneratorV2.Panels.MenuPanel();
            this.pnlFruit = new WeeklyMealGeneratorV2.Panels.FruitPanel();
            this.runGeneratorPanel1 = new WeeklyMealGeneratorV2.Panels.RunGeneratorPanel();
            this.pnlShoppingList = new WeeklyMealGeneratorV2.Panels.ShoppingListPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnOpenMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 717);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 99);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Shopping Lists";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(-5, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 99);
            this.button4.TabIndex = 4;
            this.button4.Text = "Fruit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 173);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weekly Meal Picker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 99);
            this.button3.TabIndex = 2;
            this.button3.Text = "Run Picker";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMenu.ForeColor = System.Drawing.Color.White;
            this.btnOpenMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenMenu.Image")));
            this.btnOpenMenu.Location = new System.Drawing.Point(0, 179);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(200, 99);
            this.btnOpenMenu.TabIndex = 1;
            this.btnOpenMenu.Text = "Menu";
            this.btnOpenMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenMenu.UseVisualStyleBackColor = false;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(45)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingredients";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(400, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(491, 37);
            this.label12.TabIndex = 9;
            this.label12.Text = "Welcome To The Meal Generator";
            // 
            // pnlIngredient
            // 
            this.pnlIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.pnlIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIngredient.Location = new System.Drawing.Point(200, 0);
            this.pnlIngredient.Name = "pnlIngredient";
            this.pnlIngredient.Size = new System.Drawing.Size(910, 717);
            this.pnlIngredient.TabIndex = 11;
            this.pnlIngredient.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(200, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(910, 717);
            this.pnlMenu.TabIndex = 10;
            this.pnlMenu.Visible = false;
            // 
            // pnlFruit
            // 
            this.pnlFruit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.pnlFruit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFruit.Location = new System.Drawing.Point(200, 0);
            this.pnlFruit.Name = "pnlFruit";
            this.pnlFruit.Size = new System.Drawing.Size(910, 717);
            this.pnlFruit.TabIndex = 12;
            this.pnlFruit.Visible = false;
            // 
            // runGeneratorPanel1
            // 
            this.runGeneratorPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.runGeneratorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runGeneratorPanel1.Location = new System.Drawing.Point(200, 0);
            this.runGeneratorPanel1.Name = "runGeneratorPanel1";
            this.runGeneratorPanel1.Size = new System.Drawing.Size(910, 717);
            this.runGeneratorPanel1.TabIndex = 13;
            this.runGeneratorPanel1.Visible = false;
            // 
            // pnlShoppingList
            // 
            this.pnlShoppingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.pnlShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShoppingList.Location = new System.Drawing.Point(200, 0);
            this.pnlShoppingList.Name = "pnlShoppingList";
            this.pnlShoppingList.Size = new System.Drawing.Size(910, 717);
            this.pnlShoppingList.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1110, 717);
            this.Controls.Add(this.pnlShoppingList);
            this.Controls.Add(this.runGeneratorPanel1);
            this.Controls.Add(this.pnlFruit);
            this.Controls.Add(this.pnlIngredient);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private Panels.MenuPanel pnlMenu;
        private Panels.IngredientPanel pnlIngredient;
        private Panels.FruitPanel pnlFruit;
        private System.Windows.Forms.Button button2;
        private Panels.RunGeneratorPanel runGeneratorPanel1;
        private Panels.ShoppingListPanel pnlShoppingList;
    }
}

