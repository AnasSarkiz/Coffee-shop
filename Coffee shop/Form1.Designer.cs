namespace CoffeeApp
{
    partial class CoffeeForm
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
            this.grpBagel = new System.Windows.Forms.GroupBox();
            this.rdoWholeWheat = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkPeachJelly = new System.Windows.Forms.CheckBox();
            this.chkRaspberry = new System.Windows.Forms.CheckBox();
            this.chkBlueberryJam = new System.Windows.Forms.CheckBox();
            this.chkButter = new System.Windows.Forms.CheckBox();
            this.chkCreamCheese = new System.Windows.Forms.CheckBox();
            this.grpCoffee = new System.Windows.Forms.GroupBox();
            this.rdoCafeAuLait = new System.Windows.Forms.RadioButton();
            this.rdoCappuccino = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.grpPrice = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBagel.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCoffee.SuspendLayout();
            this.grpPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBagel
            // 
            this.grpBagel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpBagel.Controls.Add(this.rdoWholeWheat);
            this.grpBagel.Controls.Add(this.rdoWhite);
            this.grpBagel.Font = new System.Drawing.Font("Segoe Print", 19.8F);
            this.grpBagel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBagel.Location = new System.Drawing.Point(11, 11);
            this.grpBagel.Margin = new System.Windows.Forms.Padding(2);
            this.grpBagel.Name = "grpBagel";
            this.grpBagel.Padding = new System.Windows.Forms.Padding(2);
            this.grpBagel.Size = new System.Drawing.Size(587, 287);
            this.grpBagel.TabIndex = 0;
            this.grpBagel.TabStop = false;
            this.grpBagel.Text = "Pick a Bagel";
            // 
            // rdoWholeWheat
            // 
            this.rdoWholeWheat.AutoSize = true;
            this.rdoWholeWheat.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWholeWheat.Location = new System.Drawing.Point(33, 153);
            this.rdoWholeWheat.Margin = new System.Windows.Forms.Padding(2);
            this.rdoWholeWheat.Name = "rdoWholeWheat";
            this.rdoWholeWheat.Size = new System.Drawing.Size(328, 51);
            this.rdoWholeWheat.TabIndex = 1;
            this.rdoWholeWheat.TabStop = true;
            this.rdoWholeWheat.Text = "Whoel wheat ($1.50)";
            this.rdoWholeWheat.UseVisualStyleBackColor = true;
            this.rdoWholeWheat.CheckedChanged += new System.EventHandler(this.rdoWholeWheat_CheckedChanged);
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWhite.Location = new System.Drawing.Point(33, 53);
            this.rdoWhite.Margin = new System.Windows.Forms.Padding(2);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(231, 51);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White ($1.25)";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpToppings.Controls.Add(this.chkPeachJelly);
            this.grpToppings.Controls.Add(this.chkRaspberry);
            this.grpToppings.Controls.Add(this.chkBlueberryJam);
            this.grpToppings.Controls.Add(this.chkButter);
            this.grpToppings.Controls.Add(this.chkCreamCheese);
            this.grpToppings.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpToppings.Location = new System.Drawing.Point(11, 352);
            this.grpToppings.Margin = new System.Windows.Forms.Padding(2);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Padding = new System.Windows.Forms.Padding(2);
            this.grpToppings.Size = new System.Drawing.Size(587, 628);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Pick Your Toppings";
            // 
            // chkPeachJelly
            // 
            this.chkPeachJelly.AutoSize = true;
            this.chkPeachJelly.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeachJelly.Location = new System.Drawing.Point(29, 492);
            this.chkPeachJelly.Name = "chkPeachJelly";
            this.chkPeachJelly.Size = new System.Drawing.Size(355, 65);
            this.chkPeachJelly.TabIndex = 4;
            this.chkPeachJelly.Text = "Peach jelly ($.75)";
            this.chkPeachJelly.UseVisualStyleBackColor = true;
            // 
            // chkRaspberry
            // 
            this.chkRaspberry.AutoSize = true;
            this.chkRaspberry.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRaspberry.Location = new System.Drawing.Point(29, 385);
            this.chkRaspberry.Name = "chkRaspberry";
            this.chkRaspberry.Size = new System.Drawing.Size(353, 65);
            this.chkRaspberry.TabIndex = 3;
            this.chkRaspberry.Text = "RaspBerry ($.75)";
            this.chkRaspberry.UseVisualStyleBackColor = true;
            this.chkRaspberry.CheckedChanged += new System.EventHandler(this.chkRaspberry_CheckedChanged);
            // 
            // chkBlueberryJam
            // 
            this.chkBlueberryJam.AutoSize = true;
            this.chkBlueberryJam.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlueberryJam.Location = new System.Drawing.Point(17, 277);
            this.chkBlueberryJam.Name = "chkBlueberryJam";
            this.chkBlueberryJam.Size = new System.Drawing.Size(419, 65);
            this.chkBlueberryJam.TabIndex = 2;
            this.chkBlueberryJam.Text = "Blueberry jam ($.75)";
            this.chkBlueberryJam.UseVisualStyleBackColor = true;
            this.chkBlueberryJam.CheckedChanged += new System.EventHandler(this.chkBlueberryJam_CheckedChanged);
            // 
            // chkButter
            // 
            this.chkButter.AutoSize = true;
            this.chkButter.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButter.Location = new System.Drawing.Point(29, 156);
            this.chkButter.Name = "chkButter";
            this.chkButter.Size = new System.Drawing.Size(282, 65);
            this.chkButter.TabIndex = 1;
            this.chkButter.Text = "Butter ($.25)";
            this.chkButter.UseVisualStyleBackColor = true;
            this.chkButter.CheckedChanged += new System.EventHandler(this.chkButter_CheckedChanged);
            // 
            // chkCreamCheese
            // 
            this.chkCreamCheese.AutoSize = true;
            this.chkCreamCheese.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreamCheese.Location = new System.Drawing.Point(29, 64);
            this.chkCreamCheese.Name = "chkCreamCheese";
            this.chkCreamCheese.Size = new System.Drawing.Size(407, 65);
            this.chkCreamCheese.TabIndex = 0;
            this.chkCreamCheese.Text = "Cream cheese ($.50)";
            this.chkCreamCheese.UseVisualStyleBackColor = true;
            this.chkCreamCheese.CheckedChanged += new System.EventHandler(this.chkCreamCheese_CheckedChanged);
            // 
            // grpCoffee
            // 
            this.grpCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpCoffee.Controls.Add(this.rdoCafeAuLait);
            this.grpCoffee.Controls.Add(this.rdoCappuccino);
            this.grpCoffee.Controls.Add(this.rdoRegular);
            this.grpCoffee.Controls.Add(this.rdoNone);
            this.grpCoffee.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCoffee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCoffee.Location = new System.Drawing.Point(1314, 11);
            this.grpCoffee.Margin = new System.Windows.Forms.Padding(2);
            this.grpCoffee.Name = "grpCoffee";
            this.grpCoffee.Padding = new System.Windows.Forms.Padding(2);
            this.grpCoffee.Size = new System.Drawing.Size(577, 463);
            this.grpCoffee.TabIndex = 2;
            this.grpCoffee.TabStop = false;
            this.grpCoffee.Text = "Want Coffee With That?";
            // 
            // rdoCafeAuLait
            // 
            this.rdoCafeAuLait.AutoSize = true;
            this.rdoCafeAuLait.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCafeAuLait.Location = new System.Drawing.Point(33, 360);
            this.rdoCafeAuLait.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCafeAuLait.Name = "rdoCafeAuLait";
            this.rdoCafeAuLait.Size = new System.Drawing.Size(369, 65);
            this.rdoCafeAuLait.TabIndex = 3;
            this.rdoCafeAuLait.TabStop = true;
            this.rdoCafeAuLait.Text = "Cafe au lait ($1.7)";
            this.rdoCafeAuLait.UseVisualStyleBackColor = true;
            this.rdoCafeAuLait.CheckedChanged += new System.EventHandler(this.rdoCafeAuLait_CheckedChanged);
            // 
            // rdoCappuccino
            // 
            this.rdoCappuccino.AutoSize = true;
            this.rdoCappuccino.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCappuccino.Location = new System.Drawing.Point(33, 265);
            this.rdoCappuccino.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCappuccino.Name = "rdoCappuccino";
            this.rdoCappuccino.Size = new System.Drawing.Size(393, 65);
            this.rdoCappuccino.TabIndex = 2;
            this.rdoCappuccino.TabStop = true;
            this.rdoCappuccino.Text = "Cappuccino ($2.00)";
            this.rdoCappuccino.UseVisualStyleBackColor = true;
            this.rdoCappuccino.CheckedChanged += new System.EventHandler(this.rdoCappuccino_CheckedChanged);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegular.Location = new System.Drawing.Point(33, 172);
            this.rdoRegular.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(446, 65);
            this.rdoRegular.TabIndex = 1;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular Coffee ($1.25)";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.rdoRegular_CheckedChanged);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNone.Location = new System.Drawing.Point(33, 86);
            this.rdoNone.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(134, 65);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // grpPrice
            // 
            this.grpPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpPrice.Controls.Add(this.lblTotal);
            this.grpPrice.Controls.Add(this.lblTax);
            this.grpPrice.Controls.Add(this.txtTotal);
            this.grpPrice.Controls.Add(this.txtTax);
            this.grpPrice.Controls.Add(this.txtSubtotal);
            this.grpPrice.Controls.Add(this.lblSubtotal);
            this.grpPrice.Font = new System.Drawing.Font("Segoe Print", 19.8F);
            this.grpPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPrice.Location = new System.Drawing.Point(1314, 508);
            this.grpPrice.Margin = new System.Windows.Forms.Padding(2);
            this.grpPrice.Name = "grpPrice";
            this.grpPrice.Padding = new System.Windows.Forms.Padding(2);
            this.grpPrice.Size = new System.Drawing.Size(577, 472);
            this.grpPrice.TabIndex = 2;
            this.grpPrice.TabStop = false;
            this.grpPrice.Text = "Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.lblTotal.Location = new System.Drawing.Point(97, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 61);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.lblTax.Location = new System.Drawing.Point(97, 205);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(91, 61);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(263, 321);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(241, 54);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(263, 214);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(241, 54);
            this.txtTax.TabIndex = 2;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(263, 106);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(241, 54);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.lblSubtotal.Location = new System.Drawing.Point(61, 97);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(173, 61);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(790, 894);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(354, 86);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(790, 697);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(354, 86);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(790, 797);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(354, 86);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Coffee_shop.Properties.Resources._10373268_4435005;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 991);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpPrice);
            this.Controls.Add(this.grpCoffee);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpBagel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "CoffeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBagel.ResumeLayout(false);
            this.grpBagel.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCoffee.ResumeLayout(false);
            this.grpCoffee.PerformLayout();
            this.grpPrice.ResumeLayout(false);
            this.grpPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBagel;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoWholeWheat;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkCreamCheese;
        private System.Windows.Forms.CheckBox chkPeachJelly;
        private System.Windows.Forms.CheckBox chkRaspberry;
        private System.Windows.Forms.CheckBox chkBlueberryJam;
        private System.Windows.Forms.CheckBox chkButter;
        private System.Windows.Forms.GroupBox grpCoffee;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.RadioButton rdoCafeAuLait;
        private System.Windows.Forms.RadioButton rdoCappuccino;
        private System.Windows.Forms.GroupBox grpPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

