using System.Drawing;

namespace CashInfinityDemo
{
    partial class Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.btnBeginDeposit = new System.Windows.Forms.Button();
            this.btnReturnDeposit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.btnAcceptDeposit = new System.Windows.Forms.Button();
            this.btnBeginChange = new System.Windows.Forms.Button();
            this.btnBeginReplenish = new System.Windows.Forms.Button();
            this.btnEndReplenish = new System.Windows.Forms.Button();
            this.btnBeginCashout = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnErrorRecovery = new System.Windows.Forms.Button();
            this.numInputPagar = new System.Windows.Forms.NumericUpDown();
            this.numInputRetirar = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDeposito = new System.Windows.Forms.GroupBox();
            this.groupBoxReabastecimiento = new System.Windows.Forms.GroupBox();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.groupBoxRetiro = new System.Windows.Forms.GroupBox();
            this.groupBoxOtros = new System.Windows.Forms.GroupBox();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRetirar)).BeginInit();
            this.groupBoxDeposito.SuspendLayout();
            this.groupBoxReabastecimiento.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            this.groupBoxRetiro.SuspendLayout();
            this.groupBoxOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginDeposit
            // 
            this.btnBeginDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginDeposit.Location = new System.Drawing.Point(23, 37);
            this.btnBeginDeposit.Name = "btnBeginDeposit";
            this.btnBeginDeposit.Size = new System.Drawing.Size(280, 40);
            this.btnBeginDeposit.TabIndex = 0;
            this.btnBeginDeposit.Text = "Depositar";
            this.btnBeginDeposit.UseVisualStyleBackColor = true;
            this.btnBeginDeposit.Click += new System.EventHandler(this.btnBeginDeposit_Click);
            // 
            // btnReturnDeposit
            // 
            this.btnReturnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDeposit.Location = new System.Drawing.Point(175, 83);
            this.btnReturnDeposit.Name = "btnReturnDeposit";
            this.btnReturnDeposit.Size = new System.Drawing.Size(128, 40);
            this.btnReturnDeposit.TabIndex = 1;
            this.btnReturnDeposit.Text = "Cancelar Deposito";
            this.btnReturnDeposit.UseVisualStyleBackColor = true;
            this.btnReturnDeposit.Click += new System.EventHandler(this.btnReturnDeposit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(132, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Dispositivo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 322);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(822, 26);
            this.MainStatusStrip.TabIndex = 3;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // StatusTimer
            // 
            this.StatusTimer.Enabled = true;
            this.StatusTimer.Interval = 500;
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // btnAcceptDeposit
            // 
            this.btnAcceptDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDeposit.Location = new System.Drawing.Point(23, 83);
            this.btnAcceptDeposit.Name = "btnAcceptDeposit";
            this.btnAcceptDeposit.Size = new System.Drawing.Size(136, 40);
            this.btnAcceptDeposit.TabIndex = 4;
            this.btnAcceptDeposit.Text = "Confirmar deposito";
            this.btnAcceptDeposit.UseVisualStyleBackColor = true;
            this.btnAcceptDeposit.Click += new System.EventHandler(this.btnAcceptDeposit_Click);
            // 
            // btnBeginChange
            // 
            this.btnBeginChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginChange.Location = new System.Drawing.Point(232, 37);
            this.btnBeginChange.Name = "btnBeginChange";
            this.btnBeginChange.Size = new System.Drawing.Size(155, 48);
            this.btnBeginChange.TabIndex = 7;
            this.btnBeginChange.Text = "Pagar";
            this.btnBeginChange.UseVisualStyleBackColor = true;
            this.btnBeginChange.Click += new System.EventHandler(this.btnBeginChange_Click);
            // 
            // btnBeginReplenish
            // 
            this.btnBeginReplenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginReplenish.Location = new System.Drawing.Point(23, 33);
            this.btnBeginReplenish.Name = "btnBeginReplenish";
            this.btnBeginReplenish.Size = new System.Drawing.Size(280, 44);
            this.btnBeginReplenish.TabIndex = 8;
            this.btnBeginReplenish.Text = "Reabastecer";
            this.btnBeginReplenish.UseVisualStyleBackColor = true;
            this.btnBeginReplenish.Click += new System.EventHandler(this.btnBeginReplenish_Click);
            // 
            // btnEndReplenish
            // 
            this.btnEndReplenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndReplenish.Location = new System.Drawing.Point(23, 83);
            this.btnEndReplenish.Name = "btnEndReplenish";
            this.btnEndReplenish.Size = new System.Drawing.Size(280, 40);
            this.btnEndReplenish.TabIndex = 9;
            this.btnEndReplenish.Text = "Finalizar reabastecimiento";
            this.btnEndReplenish.UseVisualStyleBackColor = true;
            this.btnEndReplenish.Click += new System.EventHandler(this.btnEndReplenish_Click);
            // 
            // btnBeginCashout
            // 
            this.btnBeginCashout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginCashout.Location = new System.Drawing.Point(232, 33);
            this.btnBeginCashout.Name = "btnBeginCashout";
            this.btnBeginCashout.Size = new System.Drawing.Size(155, 48);
            this.btnBeginCashout.TabIndex = 11;
            this.btnBeginCashout.Text = "Retirar";
            this.btnBeginCashout.UseVisualStyleBackColor = true;
            this.btnBeginCashout.Click += new System.EventHandler(this.btnBeginCashout_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(6, 33);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 40);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Ver inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnErrorRecovery
            // 
            this.btnErrorRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorRecovery.Location = new System.Drawing.Point(299, 33);
            this.btnErrorRecovery.Name = "btnErrorRecovery";
            this.btnErrorRecovery.Size = new System.Drawing.Size(144, 40);
            this.btnErrorRecovery.TabIndex = 14;
            this.btnErrorRecovery.Text = "Recuperar Error";
            this.btnErrorRecovery.UseVisualStyleBackColor = true;
            this.btnErrorRecovery.Click += new System.EventHandler(this.btnErrorRecovery_Click);
            // 
            // numInputPagar
            // 
            this.numInputPagar.DecimalPlaces = 2;
            this.numInputPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInputPagar.Location = new System.Drawing.Point(70, 42);
            this.numInputPagar.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numInputPagar.Name = "numInputPagar";
            this.numInputPagar.Size = new System.Drawing.Size(141, 38);
            this.numInputPagar.TabIndex = 19;
            this.numInputPagar.ThousandsSeparator = true;
            // 
            // numInputRetirar
            // 
            this.numInputRetirar.DecimalPlaces = 2;
            this.numInputRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInputRetirar.Location = new System.Drawing.Point(70, 38);
            this.numInputRetirar.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numInputRetirar.Name = "numInputRetirar";
            this.numInputRetirar.Size = new System.Drawing.Size(141, 38);
            this.numInputRetirar.TabIndex = 20;
            this.numInputRetirar.ThousandsSeparator = true;
            // 
            // groupBoxDeposito
            // 
            this.groupBoxDeposito.Controls.Add(this.btnBeginDeposit);
            this.groupBoxDeposito.Controls.Add(this.btnAcceptDeposit);
            this.groupBoxDeposito.Controls.Add(this.btnReturnDeposit);
            this.groupBoxDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeposito.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDeposito.Name = "groupBoxDeposito";
            this.groupBoxDeposito.Size = new System.Drawing.Size(324, 136);
            this.groupBoxDeposito.TabIndex = 23;
            this.groupBoxDeposito.TabStop = false;
            this.groupBoxDeposito.Text = "Depósito";
            // 
            // groupBoxReabastecimiento
            // 
            this.groupBoxReabastecimiento.Controls.Add(this.btnBeginReplenish);
            this.groupBoxReabastecimiento.Controls.Add(this.btnEndReplenish);
            this.groupBoxReabastecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReabastecimiento.Location = new System.Drawing.Point(12, 173);
            this.groupBoxReabastecimiento.Name = "groupBoxReabastecimiento";
            this.groupBoxReabastecimiento.Size = new System.Drawing.Size(324, 138);
            this.groupBoxReabastecimiento.TabIndex = 24;
            this.groupBoxReabastecimiento.TabStop = false;
            this.groupBoxReabastecimiento.Text = "Reabastecimiento";
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.btnBeginChange);
            this.groupBoxCompra.Controls.Add(this.numInputPagar);
            this.groupBoxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCompra.Location = new System.Drawing.Point(358, 12);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(449, 102);
            this.groupBoxCompra.TabIndex = 25;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Compra";
            // 
            // groupBoxRetiro
            // 
            this.groupBoxRetiro.Controls.Add(this.btnBeginCashout);
            this.groupBoxRetiro.Controls.Add(this.numInputRetirar);
            this.groupBoxRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRetiro.Location = new System.Drawing.Point(358, 120);
            this.groupBoxRetiro.Name = "groupBoxRetiro";
            this.groupBoxRetiro.Size = new System.Drawing.Size(449, 100);
            this.groupBoxRetiro.TabIndex = 26;
            this.groupBoxRetiro.TabStop = false;
            this.groupBoxRetiro.Text = "Retiro";
            // 
            // groupBoxOtros
            // 
            this.groupBoxOtros.Controls.Add(this.btnInventory);
            this.groupBoxOtros.Controls.Add(this.btnReset);
            this.groupBoxOtros.Controls.Add(this.btnErrorRecovery);
            this.groupBoxOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOtros.Location = new System.Drawing.Point(358, 220);
            this.groupBoxOtros.Name = "groupBoxOtros";
            this.groupBoxOtros.Size = new System.Drawing.Size(449, 91);
            this.groupBoxOtros.TabIndex = 27;
            this.groupBoxOtros.TabStop = false;
            this.groupBoxOtros.Text = "Otros";
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 348);
            this.Controls.Add(this.groupBoxOtros);
            this.Controls.Add(this.groupBoxRetiro);
            this.Controls.Add(this.groupBoxCompra);
            this.Controls.Add(this.groupBoxReabastecimiento);
            this.Controls.Add(this.groupBoxDeposito);
            this.Controls.Add(this.MainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Demo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Infinity Demo";
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRetirar)).EndInit();
            this.groupBoxDeposito.ResumeLayout(false);
            this.groupBoxReabastecimiento.ResumeLayout(false);
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxRetiro.ResumeLayout(false);
            this.groupBoxOtros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginDeposit;
        private System.Windows.Forms.Button btnReturnDeposit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.Button btnAcceptDeposit;
        private System.Windows.Forms.Button btnBeginChange;
        private System.Windows.Forms.Button btnBeginReplenish;
        private System.Windows.Forms.Button btnEndReplenish;
        private System.Windows.Forms.Button btnBeginCashout;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnErrorRecovery;
        private System.Windows.Forms.NumericUpDown numInputPagar;
        private System.Windows.Forms.NumericUpDown numInputRetirar;
        private System.Windows.Forms.GroupBox groupBoxDeposito;
        private System.Windows.Forms.GroupBox groupBoxReabastecimiento;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.GroupBox groupBoxRetiro;
        private System.Windows.Forms.GroupBox groupBoxOtros;
    }
}