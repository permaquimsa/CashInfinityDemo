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
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.btnBeginChange = new System.Windows.Forms.Button();
            this.btnBeginReplenish = new System.Windows.Forms.Button();
            this.btnEndReplenish = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.btnBeginCashout = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.txtExtractionAmount = new System.Windows.Forms.TextBox();
            this.btnErrorRecovery = new System.Windows.Forms.Button();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginDeposit
            // 
            this.btnBeginDeposit.Location = new System.Drawing.Point(32, 16);
            this.btnBeginDeposit.Name = "btnBeginDeposit";
            this.btnBeginDeposit.Size = new System.Drawing.Size(280, 40);
            this.btnBeginDeposit.TabIndex = 0;
            this.btnBeginDeposit.Text = "Depositar";
            this.btnBeginDeposit.UseVisualStyleBackColor = true;
            this.btnBeginDeposit.Click += new System.EventHandler(this.btnBeginDeposit_Click);
            // 
            // btnReturnDeposit
            // 
            this.btnReturnDeposit.Location = new System.Drawing.Point(184, 62);
            this.btnReturnDeposit.Name = "btnReturnDeposit";
            this.btnReturnDeposit.Size = new System.Drawing.Size(128, 40);
            this.btnReturnDeposit.TabIndex = 1;
            this.btnReturnDeposit.Text = "Cancelar Deposito";
            this.btnReturnDeposit.UseVisualStyleBackColor = true;
            this.btnReturnDeposit.Click += new System.EventHandler(this.btnReturnDeposit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(472, 240);
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
            this.btnAcceptDeposit.Location = new System.Drawing.Point(32, 62);
            this.btnAcceptDeposit.Name = "btnAcceptDeposit";
            this.btnAcceptDeposit.Size = new System.Drawing.Size(136, 40);
            this.btnAcceptDeposit.TabIndex = 4;
            this.btnAcceptDeposit.Text = "Confirmar deposito";
            this.btnAcceptDeposit.UseVisualStyleBackColor = true;
            this.btnAcceptDeposit.Click += new System.EventHandler(this.btnAcceptDeposit_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(463, 64);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(144, 30);
            this.txtPaymentAmount.TabIndex = 5;
            this.txtPaymentAmount.Text = "0.00";
            this.txtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBeginChange
            // 
            this.btnBeginChange.Location = new System.Drawing.Point(613, 54);
            this.btnBeginChange.Name = "btnBeginChange";
            this.btnBeginChange.Size = new System.Drawing.Size(144, 48);
            this.btnBeginChange.TabIndex = 7;
            this.btnBeginChange.Text = "Pagar";
            this.btnBeginChange.UseVisualStyleBackColor = true;
            this.btnBeginChange.Click += new System.EventHandler(this.btnBeginChange_Click);
            // 
            // btnBeginReplenish
            // 
            this.btnBeginReplenish.Location = new System.Drawing.Point(32, 190);
            this.btnBeginReplenish.Name = "btnBeginReplenish";
            this.btnBeginReplenish.Size = new System.Drawing.Size(280, 44);
            this.btnBeginReplenish.TabIndex = 8;
            this.btnBeginReplenish.Text = "Reabastecer";
            this.btnBeginReplenish.UseVisualStyleBackColor = true;
            this.btnBeginReplenish.Click += new System.EventHandler(this.btnBeginReplenish_Click);
            // 
            // btnEndReplenish
            // 
            this.btnEndReplenish.Location = new System.Drawing.Point(32, 240);
            this.btnEndReplenish.Name = "btnEndReplenish";
            this.btnEndReplenish.Size = new System.Drawing.Size(280, 40);
            this.btnEndReplenish.TabIndex = 9;
            this.btnEndReplenish.Text = "Finalizar reabastecimiento";
            this.btnEndReplenish.UseVisualStyleBackColor = true;
            this.btnEndReplenish.Click += new System.EventHandler(this.btnEndReplenish_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceLabel.Location = new System.Drawing.Point(457, 16);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(287, 31);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Indique precio del Item";
            // 
            // btnBeginCashout
            // 
            this.btnBeginCashout.Location = new System.Drawing.Point(613, 136);
            this.btnBeginCashout.Name = "btnBeginCashout";
            this.btnBeginCashout.Size = new System.Drawing.Size(144, 48);
            this.btnBeginCashout.TabIndex = 11;
            this.btnBeginCashout.Text = "Retirar";
            this.btnBeginCashout.UseVisualStyleBackColor = true;
            this.btnBeginCashout.Click += new System.EventHandler(this.btnBeginCashout_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(344, 240);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 40);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Ver inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // txtExtractionAmount
            // 
            this.txtExtractionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtractionAmount.Location = new System.Drawing.Point(463, 144);
            this.txtExtractionAmount.Name = "txtExtractionAmount";
            this.txtExtractionAmount.Size = new System.Drawing.Size(144, 30);
            this.txtExtractionAmount.TabIndex = 13;
            this.txtExtractionAmount.Text = "0.00";
            this.txtExtractionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnErrorRecovery
            // 
            this.btnErrorRecovery.Location = new System.Drawing.Point(619, 240);
            this.btnErrorRecovery.Name = "btnErrorRecovery";
            this.btnErrorRecovery.Size = new System.Drawing.Size(144, 40);
            this.btnErrorRecovery.TabIndex = 14;
            this.btnErrorRecovery.Text = "Recuperar Error";
            this.btnErrorRecovery.UseVisualStyleBackColor = true;
            this.btnErrorRecovery.Click += new System.EventHandler(this.btnErrorRecovery_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 323);
            this.Controls.Add(this.btnErrorRecovery);
            this.Controls.Add(this.txtExtractionAmount);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnBeginCashout);
            this.Controls.Add(this.btnEndReplenish);
            this.Controls.Add(this.btnBeginReplenish);
            this.Controls.Add(this.btnBeginChange);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.btnAcceptDeposit);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReturnDeposit);
            this.Controls.Add(this.btnBeginDeposit);
            this.Controls.Add(this.priceLabel);
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
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Button btnBeginChange;
        private System.Windows.Forms.Button btnBeginReplenish;
        private System.Windows.Forms.Button btnEndReplenish;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button btnBeginCashout;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.TextBox txtExtractionAmount;
        private System.Windows.Forms.Button btnErrorRecovery;
    }
}