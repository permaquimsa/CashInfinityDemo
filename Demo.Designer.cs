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
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.btnAcceptDeposit = new System.Windows.Forms.Button();
            this.btnBeginChange = new System.Windows.Forms.Button();
            this.btnBeginCashout = new System.Windows.Forms.Button();
            this.numInputPagar = new System.Windows.Forms.NumericUpDown();
            this.numInputRetirar = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDeposito = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRetiro = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSocket = new System.Windows.Forms.CheckBox();
            this.eventTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOtros = new System.Windows.Forms.GroupBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnErrorRecovery = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxReabastecimiento = new System.Windows.Forms.GroupBox();
            this.btnBeginReplenish = new System.Windows.Forms.Button();
            this.btnEndReplenish = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInputPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputRetirar)).BeginInit();
            this.groupBoxDeposito.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxRetiro.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxOtros.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxReabastecimiento.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginDeposit
            // 
            this.btnBeginDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginDeposit.Location = new System.Drawing.Point(23, 42);
            this.btnBeginDeposit.Name = "btnBeginDeposit";
            this.btnBeginDeposit.Size = new System.Drawing.Size(446, 44);
            this.btnBeginDeposit.TabIndex = 0;
            this.btnBeginDeposit.Text = "Depositar";
            this.btnBeginDeposit.UseVisualStyleBackColor = true;
            this.btnBeginDeposit.Click += new System.EventHandler(this.btnBeginDeposit_Click);
            // 
            // btnReturnDeposit
            // 
            this.btnReturnDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDeposit.Location = new System.Drawing.Point(226, 3);
            this.btnReturnDeposit.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnReturnDeposit.Name = "btnReturnDeposit";
            this.btnReturnDeposit.Size = new System.Drawing.Size(220, 44);
            this.btnReturnDeposit.TabIndex = 1;
            this.btnReturnDeposit.Text = "Cancelar Deposito";
            this.btnReturnDeposit.UseVisualStyleBackColor = true;
            this.btnReturnDeposit.Click += new System.EventHandler(this.btnReturnDeposit_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 787);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1006, 26);
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
            this.btnAcceptDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAcceptDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDeposit.Location = new System.Drawing.Point(0, 3);
            this.btnAcceptDeposit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAcceptDeposit.Name = "btnAcceptDeposit";
            this.btnAcceptDeposit.Size = new System.Drawing.Size(220, 44);
            this.btnAcceptDeposit.TabIndex = 4;
            this.btnAcceptDeposit.Text = "Confirmar deposito";
            this.btnAcceptDeposit.UseVisualStyleBackColor = true;
            this.btnAcceptDeposit.Click += new System.EventHandler(this.btnAcceptDeposit_Click);
            // 
            // btnBeginChange
            // 
            this.btnBeginChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBeginChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginChange.Location = new System.Drawing.Point(156, 3);
            this.btnBeginChange.Name = "btnBeginChange";
            this.btnBeginChange.Size = new System.Drawing.Size(280, 44);
            this.btnBeginChange.TabIndex = 7;
            this.btnBeginChange.Text = "Pagar";
            this.btnBeginChange.UseVisualStyleBackColor = true;
            this.btnBeginChange.Click += new System.EventHandler(this.btnBeginChange_Click);
            // 
            // btnBeginCashout
            // 
            this.btnBeginCashout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBeginCashout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginCashout.Location = new System.Drawing.Point(156, 3);
            this.btnBeginCashout.Name = "btnBeginCashout";
            this.btnBeginCashout.Size = new System.Drawing.Size(280, 44);
            this.btnBeginCashout.TabIndex = 11;
            this.btnBeginCashout.Text = "Retirar";
            this.btnBeginCashout.UseVisualStyleBackColor = true;
            this.btnBeginCashout.Click += new System.EventHandler(this.btnBeginCashout_Click);
            // 
            // numInputPagar
            // 
            this.numInputPagar.DecimalPlaces = 2;
            this.numInputPagar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numInputPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInputPagar.Location = new System.Drawing.Point(3, 9);
            this.numInputPagar.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numInputPagar.Name = "numInputPagar";
            this.numInputPagar.Size = new System.Drawing.Size(147, 38);
            this.numInputPagar.TabIndex = 19;
            this.numInputPagar.ThousandsSeparator = true;
            // 
            // numInputRetirar
            // 
            this.numInputRetirar.DecimalPlaces = 2;
            this.numInputRetirar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numInputRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInputRetirar.Location = new System.Drawing.Point(3, 9);
            this.numInputRetirar.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numInputRetirar.Name = "numInputRetirar";
            this.numInputRetirar.Size = new System.Drawing.Size(147, 38);
            this.numInputRetirar.TabIndex = 20;
            this.numInputRetirar.ThousandsSeparator = true;
            // 
            // groupBoxDeposito
            // 
            this.groupBoxDeposito.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxDeposito.Controls.Add(this.btnBeginDeposit);
            this.groupBoxDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeposito.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDeposito.Name = "groupBoxDeposito";
            this.groupBoxDeposito.Size = new System.Drawing.Size(494, 188);
            this.groupBoxDeposito.TabIndex = 23;
            this.groupBoxDeposito.TabStop = false;
            this.groupBoxDeposito.Text = "Depósito";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnReturnDeposit, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAcceptDeposit, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 88);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(446, 50);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCompra.Location = new System.Drawing.Point(503, 3);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(494, 188);
            this.groupBoxCompra.TabIndex = 25;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Compra";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel6.Controls.Add(this.btnBeginChange, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.numInputPagar, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(29, 36);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(439, 50);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // groupBoxRetiro
            // 
            this.groupBoxRetiro.Controls.Add(this.tableLayoutPanel7);
            this.groupBoxRetiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRetiro.Location = new System.Drawing.Point(503, 3);
            this.groupBoxRetiro.Name = "groupBoxRetiro";
            this.groupBoxRetiro.Size = new System.Drawing.Size(494, 188);
            this.groupBoxRetiro.TabIndex = 26;
            this.groupBoxRetiro.TabStop = false;
            this.groupBoxRetiro.Text = "Retiro";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel7.Controls.Add(this.numInputRetirar, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnBeginCashout, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(29, 38);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(439, 50);
            this.tableLayoutPanel7.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSocket);
            this.groupBox1.Controls.Add(this.eventTextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 268);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // checkBoxSocket
            // 
            this.checkBoxSocket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSocket.AutoSize = true;
            this.checkBoxSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSocket.Location = new System.Drawing.Point(864, 0);
            this.checkBoxSocket.Name = "checkBoxSocket";
            this.checkBoxSocket.Size = new System.Drawing.Size(130, 26);
            this.checkBoxSocket.TabIndex = 1;
            this.checkBoxSocket.Text = "Ver Eventos";
            this.checkBoxSocket.UseVisualStyleBackColor = true;
            this.checkBoxSocket.CheckedChanged += new System.EventHandler(this.checkBoxSocket_CheckedChanged);
            // 
            // eventTextbox
            // 
            this.eventTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTextbox.Location = new System.Drawing.Point(26, 47);
            this.eventTextbox.Multiline = true;
            this.eventTextbox.Name = "eventTextbox";
            this.eventTextbox.Size = new System.Drawing.Size(945, 215);
            this.eventTextbox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.37309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.65852F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 787);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.groupBoxOtros, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1000, 107);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupBoxOtros
            // 
            this.groupBoxOtros.Controls.Add(this.btnInventory);
            this.groupBoxOtros.Controls.Add(this.btnReset);
            this.groupBoxOtros.Controls.Add(this.btnErrorRecovery);
            this.groupBoxOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOtros.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOtros.Name = "groupBoxOtros";
            this.groupBoxOtros.Size = new System.Drawing.Size(994, 101);
            this.groupBoxOtros.TabIndex = 29;
            this.groupBoxOtros.TabStop = false;
            this.groupBoxOtros.Text = "Otros";
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(23, 43);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 44);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Ver inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(229, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 44);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Dispositivo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnErrorRecovery
            // 
            this.btnErrorRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorRecovery.Location = new System.Drawing.Point(435, 43);
            this.btnErrorRecovery.Name = "btnErrorRecovery";
            this.btnErrorRecovery.Size = new System.Drawing.Size(200, 44);
            this.btnErrorRecovery.TabIndex = 14;
            this.btnErrorRecovery.Text = "Recuperar Error";
            this.btnErrorRecovery.UseVisualStyleBackColor = true;
            this.btnErrorRecovery.Click += new System.EventHandler(this.btnErrorRecovery_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxReabastecimiento, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxRetiro, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1000, 194);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBoxReabastecimiento
            // 
            this.groupBoxReabastecimiento.Controls.Add(this.btnBeginReplenish);
            this.groupBoxReabastecimiento.Controls.Add(this.btnEndReplenish);
            this.groupBoxReabastecimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReabastecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReabastecimiento.Location = new System.Drawing.Point(3, 3);
            this.groupBoxReabastecimiento.Name = "groupBoxReabastecimiento";
            this.groupBoxReabastecimiento.Size = new System.Drawing.Size(494, 188);
            this.groupBoxReabastecimiento.TabIndex = 27;
            this.groupBoxReabastecimiento.TabStop = false;
            this.groupBoxReabastecimiento.Text = "Reabastecimiento";
            // 
            // btnBeginReplenish
            // 
            this.btnBeginReplenish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginReplenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginReplenish.Location = new System.Drawing.Point(23, 44);
            this.btnBeginReplenish.Name = "btnBeginReplenish";
            this.btnBeginReplenish.Size = new System.Drawing.Size(446, 44);
            this.btnBeginReplenish.TabIndex = 8;
            this.btnBeginReplenish.Text = "Reabastecer";
            this.btnBeginReplenish.UseVisualStyleBackColor = true;
            this.btnBeginReplenish.Click += new System.EventHandler(this.btnBeginReplenish_Click);
            // 
            // btnEndReplenish
            // 
            this.btnEndReplenish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndReplenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndReplenish.Location = new System.Drawing.Point(23, 94);
            this.btnEndReplenish.Name = "btnEndReplenish";
            this.btnEndReplenish.Size = new System.Drawing.Size(446, 44);
            this.btnEndReplenish.TabIndex = 9;
            this.btnEndReplenish.Text = "Finalizar reabastecimiento";
            this.btnEndReplenish.UseVisualStyleBackColor = true;
            this.btnEndReplenish.Click += new System.EventHandler(this.btnEndReplenish_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDeposito, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxCompra, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 194);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 813);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxCompra.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBoxRetiro.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBoxOtros.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxReabastecimiento.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginDeposit;
        private System.Windows.Forms.Button btnReturnDeposit;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.Button btnAcceptDeposit;
        private System.Windows.Forms.Button btnBeginChange;
        private System.Windows.Forms.Button btnBeginCashout;
        private System.Windows.Forms.NumericUpDown numInputPagar;
        private System.Windows.Forms.NumericUpDown numInputRetirar;
        private System.Windows.Forms.GroupBox groupBoxDeposito;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.GroupBox groupBoxRetiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSocket;
        private System.Windows.Forms.TextBox eventTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxOtros;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnErrorRecovery;
        private System.Windows.Forms.GroupBox groupBoxReabastecimiento;
        private System.Windows.Forms.Button btnBeginReplenish;
        private System.Windows.Forms.Button btnEndReplenish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}