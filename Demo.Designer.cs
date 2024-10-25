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
            this.depositoLabel = new System.Windows.Forms.Label();
            this.btnBeginCashout = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnErrorRecovery = new System.Windows.Forms.Button();
            this.reabastecerLabel = new System.Windows.Forms.Label();
            this.compraLabel = new System.Windows.Forms.Label();
            this.retiroLabel = new System.Windows.Forms.Label();
            this.estadoDispLabel = new System.Windows.Forms.Label();
            this.numInputPagar = new System.Windows.Forms.NumericUpDown();
            this.numInputRetirar = new System.Windows.Forms.NumericUpDown();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRetirar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeginDeposit
            // 
            this.btnBeginDeposit.Location = new System.Drawing.Point(32, 43);
            this.btnBeginDeposit.Name = "btnBeginDeposit";
            this.btnBeginDeposit.Size = new System.Drawing.Size(280, 40);
            this.btnBeginDeposit.TabIndex = 0;
            this.btnBeginDeposit.Text = "Depositar";
            this.btnBeginDeposit.UseVisualStyleBackColor = true;
            this.btnBeginDeposit.Click += new System.EventHandler(this.btnBeginDeposit_Click);
            // 
            // btnReturnDeposit
            // 
            this.btnReturnDeposit.Location = new System.Drawing.Point(184, 89);
            this.btnReturnDeposit.Name = "btnReturnDeposit";
            this.btnReturnDeposit.Size = new System.Drawing.Size(128, 40);
            this.btnReturnDeposit.TabIndex = 1;
            this.btnReturnDeposit.Text = "Cancelar Deposito";
            this.btnReturnDeposit.UseVisualStyleBackColor = true;
            this.btnReturnDeposit.Click += new System.EventHandler(this.btnReturnDeposit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(466, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 40);
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
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 297);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(769, 26);
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
            this.btnAcceptDeposit.Location = new System.Drawing.Point(32, 89);
            this.btnAcceptDeposit.Name = "btnAcceptDeposit";
            this.btnAcceptDeposit.Size = new System.Drawing.Size(136, 40);
            this.btnAcceptDeposit.TabIndex = 4;
            this.btnAcceptDeposit.Text = "Confirmar deposito";
            this.btnAcceptDeposit.UseVisualStyleBackColor = true;
            this.btnAcceptDeposit.Click += new System.EventHandler(this.btnAcceptDeposit_Click);
            // 
            // btnBeginChange
            // 
            this.btnBeginChange.Location = new System.Drawing.Point(613, 43);
            this.btnBeginChange.Name = "btnBeginChange";
            this.btnBeginChange.Size = new System.Drawing.Size(144, 48);
            this.btnBeginChange.TabIndex = 7;
            this.btnBeginChange.Text = "Pagar";
            this.btnBeginChange.UseVisualStyleBackColor = true;
            this.btnBeginChange.Click += new System.EventHandler(this.btnBeginChange_Click);
            // 
            // btnBeginReplenish
            // 
            this.btnBeginReplenish.Location = new System.Drawing.Point(32, 196);
            this.btnBeginReplenish.Name = "btnBeginReplenish";
            this.btnBeginReplenish.Size = new System.Drawing.Size(280, 44);
            this.btnBeginReplenish.TabIndex = 8;
            this.btnBeginReplenish.Text = "Reabastecer";
            this.btnBeginReplenish.UseVisualStyleBackColor = true;
            this.btnBeginReplenish.Click += new System.EventHandler(this.btnBeginReplenish_Click);
            // 
            // btnEndReplenish
            // 
            this.btnEndReplenish.Location = new System.Drawing.Point(32, 246);
            this.btnEndReplenish.Name = "btnEndReplenish";
            this.btnEndReplenish.Size = new System.Drawing.Size(280, 40);
            this.btnEndReplenish.TabIndex = 9;
            this.btnEndReplenish.Text = "Finalizar reabastecimiento";
            this.btnEndReplenish.UseVisualStyleBackColor = true;
            this.btnEndReplenish.Click += new System.EventHandler(this.btnEndReplenish_Click);
            // 
            // depositoLabel
            // 
            this.depositoLabel.AutoSize = true;
            this.depositoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.depositoLabel.Location = new System.Drawing.Point(26, 9);
            this.depositoLabel.Name = "depositoLabel";
            this.depositoLabel.Size = new System.Drawing.Size(240, 31);
            this.depositoLabel.TabIndex = 10;
            this.depositoLabel.Text = "- Realizar depósito";
            // 
            // btnBeginCashout
            // 
            this.btnBeginCashout.Location = new System.Drawing.Point(613, 145);
            this.btnBeginCashout.Name = "btnBeginCashout";
            this.btnBeginCashout.Size = new System.Drawing.Size(144, 48);
            this.btnBeginCashout.TabIndex = 11;
            this.btnBeginCashout.Text = "Retirar";
            this.btnBeginCashout.UseVisualStyleBackColor = true;
            this.btnBeginCashout.Click += new System.EventHandler(this.btnBeginCashout_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(338, 246);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 40);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Ver inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnErrorRecovery
            // 
            this.btnErrorRecovery.Location = new System.Drawing.Point(613, 246);
            this.btnErrorRecovery.Name = "btnErrorRecovery";
            this.btnErrorRecovery.Size = new System.Drawing.Size(144, 40);
            this.btnErrorRecovery.TabIndex = 14;
            this.btnErrorRecovery.Text = "Recuperar Error";
            this.btnErrorRecovery.UseVisualStyleBackColor = true;
            this.btnErrorRecovery.Click += new System.EventHandler(this.btnErrorRecovery_Click);
            // 
            // reabastecerLabel
            // 
            this.reabastecerLabel.AutoSize = true;
            this.reabastecerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reabastecerLabel.Location = new System.Drawing.Point(26, 162);
            this.reabastecerLabel.Name = "reabastecerLabel";
            this.reabastecerLabel.Size = new System.Drawing.Size(185, 31);
            this.reabastecerLabel.TabIndex = 15;
            this.reabastecerLabel.Text = "- Reabastecer";
            // 
            // compraLabel
            // 
            this.compraLabel.AutoSize = true;
            this.compraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.compraLabel.Location = new System.Drawing.Point(420, 9);
            this.compraLabel.Name = "compraLabel";
            this.compraLabel.Size = new System.Drawing.Size(323, 31);
            this.compraLabel.TabIndex = 16;
            this.compraLabel.Text = "- Pagar total de la compra";
            // 
            // retiroLabel
            // 
            this.retiroLabel.AutoSize = true;
            this.retiroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.retiroLabel.Location = new System.Drawing.Point(420, 111);
            this.retiroLabel.Name = "retiroLabel";
            this.retiroLabel.Size = new System.Drawing.Size(199, 31);
            this.retiroLabel.TabIndex = 17;
            this.retiroLabel.Text = "- Realizar retiro";
            // 
            // estadoDispLabel
            // 
            this.estadoDispLabel.AutoSize = true;
            this.estadoDispLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.estadoDispLabel.Location = new System.Drawing.Point(420, 209);
            this.estadoDispLabel.Name = "estadoDispLabel";
            this.estadoDispLabel.Size = new System.Drawing.Size(250, 31);
            this.estadoDispLabel.TabIndex = 18;
            this.estadoDispLabel.Text = "- Estado dispositivo";
            // 
            // numInputPagar
            // 
            this.numInputPagar.DecimalPlaces = 2;
            this.numInputPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInputPagar.Location = new System.Drawing.Point(466, 45);
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
            this.numInputRetirar.Location = new System.Drawing.Point(466, 155);
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
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 323);
            this.Controls.Add(this.numInputRetirar);
            this.Controls.Add(this.numInputPagar);
            this.Controls.Add(this.estadoDispLabel);
            this.Controls.Add(this.retiroLabel);
            this.Controls.Add(this.compraLabel);
            this.Controls.Add(this.reabastecerLabel);
            this.Controls.Add(this.btnErrorRecovery);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnBeginCashout);
            this.Controls.Add(this.btnEndReplenish);
            this.Controls.Add(this.btnBeginReplenish);
            this.Controls.Add(this.btnBeginChange);
            this.Controls.Add(this.btnAcceptDeposit);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReturnDeposit);
            this.Controls.Add(this.btnBeginDeposit);
            this.Controls.Add(this.depositoLabel);
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
        private System.Windows.Forms.Label depositoLabel;
        private System.Windows.Forms.Button btnBeginCashout;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnErrorRecovery;
        private System.Windows.Forms.Label reabastecerLabel;
        private System.Windows.Forms.Label compraLabel;
        private System.Windows.Forms.Label retiroLabel;
        private System.Windows.Forms.Label estadoDispLabel;
        private System.Windows.Forms.NumericUpDown numInputPagar;
        private System.Windows.Forms.NumericUpDown numInputRetirar;
    }
}