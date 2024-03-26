namespace lab2_1ooap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ccoffee = new System.Windows.Forms.Button();
            this.ttea = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Label();
            this.drink = new System.Windows.Forms.Label();
            this.boil = new System.Windows.Forms.Label();
            this.brew = new System.Windows.Forms.Label();
            this.cup = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказать напиток";
            // 
            // ccoffee
            // 
            this.ccoffee.BackColor = System.Drawing.Color.Sienna;
            this.ccoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ccoffee.Location = new System.Drawing.Point(113, 120);
            this.ccoffee.Name = "ccoffee";
            this.ccoffee.Size = new System.Drawing.Size(163, 90);
            this.ccoffee.TabIndex = 1;
            this.ccoffee.Text = "Кофе";
            this.ccoffee.UseVisualStyleBackColor = false;
            this.ccoffee.Click += new System.EventHandler(this.coffee_Click);
            // 
            // ttea
            // 
            this.ttea.BackColor = System.Drawing.Color.Peru;
            this.ttea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ttea.Location = new System.Drawing.Point(519, 120);
            this.ttea.Name = "ttea";
            this.ttea.Size = new System.Drawing.Size(163, 90);
            this.ttea.TabIndex = 2;
            this.ttea.Text = "Чай";
            this.ttea.UseVisualStyleBackColor = false;
            this.ttea.Click += new System.EventHandler(this.tea_Click);
            // 
            // GO
            // 
            this.GO.AutoSize = true;
            this.GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GO.Location = new System.Drawing.Point(223, 553);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(336, 29);
            this.GO.TabIndex = 6;
            this.GO.Text = "Ваш напиток готов к выдаче";
            this.GO.Visible = false;
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.BackColor = System.Drawing.Color.White;
            this.drink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drink.Location = new System.Drawing.Point(241, 609);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(98, 27);
            this.drink.TabIndex = 7;
            this.drink.Text = "Напиток";
            this.drink.Visible = false;
            // 
            // boil
            // 
            this.boil.AutoSize = true;
            this.boil.Location = new System.Drawing.Point(304, 260);
            this.boil.Name = "boil";
            this.boil.Size = new System.Drawing.Size(35, 13);
            this.boil.TabIndex = 8;
            this.boil.Text = "label4";
            this.boil.Visible = false;
            // 
            // brew
            // 
            this.brew.AutoSize = true;
            this.brew.Location = new System.Drawing.Point(304, 331);
            this.brew.Name = "brew";
            this.brew.Size = new System.Drawing.Size(35, 13);
            this.brew.TabIndex = 10;
            this.brew.Text = "label4";
            this.brew.Visible = false;
            // 
            // cup
            // 
            this.cup.AutoSize = true;
            this.cup.Location = new System.Drawing.Point(304, 398);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(35, 13);
            this.cup.TabIndex = 11;
            this.cup.Text = "label4";
            this.cup.Visible = false;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(304, 471);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(35, 13);
            this.add.TabIndex = 12;
            this.add.Text = "label4";
            this.add.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(795, 715);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cup);
            this.Controls.Add(this.brew);
            this.Controls.Add(this.boil);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.ttea);
            this.Controls.Add(this.ccoffee);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ccoffee;
        private System.Windows.Forms.Button ttea;
        private System.Windows.Forms.Label GO;
        private System.Windows.Forms.Label drink;
        private System.Windows.Forms.Label boil;
        private System.Windows.Forms.Label brew;
        private System.Windows.Forms.Label cup;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

