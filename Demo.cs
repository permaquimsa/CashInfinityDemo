using CashInfinityDemo.com.glory.fcc.service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace CashInfinityDemo
{
    public partial class Demo : Form
    {
        private enum StatusCodeEnum
        {
            STATUS_CODE_INIT = 0,
            STATUS_CODE_IDLE = 1,
            STATUS_CODE_CHANGE = 2,
            STATUS_CODE_DEPOSIT_WAIT = 3,
            STATUS_CODE_DEPOSIT_COUNTING = 4,
            STATUS_CODE_DISPENSE = 5,
            STATUS_CODE_DEPOSITREMOVWAIT = 6,
            STATUS_CODE_DISPENSEREMOVWAIT = 7,
            STATUS_CODE_RESET = 8,
            STATUS_CODE_DEPOSITCANCEL = 9,
            STATUS_CODE_CALCAMOUNT = 10,
            STATUS_CODE_CASHINCANCEL = 11,
            STATUS_CODE_COLLECT = 12,
            STATUS_CODE_ERROR = 13,
            STATUS_CODE_UPFARMA = 14,
            STATUS_CODE_READLOG = 15,
            STATUS_CODE_WAITREFILL = 16,
            STATUS_CODE_CALCREFILL = 17,
            STATUS_CODE_FIX_DEPOSIT_AMOUNT = 20,
            STATUS_CODE_FIX_DISPENSE_AMOUNT = 21,
            STATUS_CODE_WAITING_DISPENSE = 22,
            STATUS_CODE_WAITING_CHANGE_CANCEL = 23,
            STATUS_CODE_COUNTED_CATEOGORY2_NOTE = 24,
            STATUS_CODE_WAITING_DEPOSIT_END = 25,
            STATUS_CODE_WAITING_ERROR_RECOVERY = 30
        }



        // STATUS_CODE
        public const int STATUS_CODE_INIT = 0;
        public const int STATUS_CODE_IDLE = 1;
        public const int STATUS_CODE_CHANGE = 2;
        public const int STATUS_CODE_DEPOSIT_WAIT = 3;
        public const int STATUS_CODE_DEPOSIT_COUNTING = 4;
        public const int STATUS_CODE_DISPENSE = 5;
        public const int STATUS_CODE_DEPOSITREMOVWAIT = 6;
        public const int STATUS_CODE_DISPENSEREMOVWAIT = 7;
        public const int STATUS_CODE_RESET = 8;
        public const int STATUS_CODE_DEPOSITCANCEL = 9;
        public const int STATUS_CODE_CALCAMOUNT = 10;
        public const int STATUS_CODE_CASHINCANCEL = 11;
        public const int STATUS_CODE_COLLECT = 12;
        public const int STATUS_CODE_ERROR = 13;
        public const int STATUS_CODE_UPFARMA = 14;
        public const int STATUS_CODE_READLOG = 15;
        public const int STATUS_CODE_WAITREFILL = 16;
        public const int STATUS_CODE_CALCREFILL = 17;
        public const int STATUS_CODE_FIX_DEPOSIT_AMOUNT = 20;
        public const int STATUS_CODE_FIX_DISPENSE_AMOUNT = 21;
        public const int STATUS_CODE_WAITING_DISPENSE = 22;
        public const int STATUS_CODE_WAITING_CHANGE_CANCEL = 23;
        public const int STATUS_CODE_COUNTED_CATEOGORY2_NOTE = 24;
        public const int STATUS_CODE_WAITING_DEPOSIT_END = 25;
        public const int STATUS_CODE_WAITING_ERROR_RECOVERY = 30;

        // FCC_STATUS_CODE
        public const int FCC_SUCCESS = 0;
        public const int FCC_CANCEL = 1;
        public const int FCC_SHORTAGE_CANCEL = 9;
        public const int FCC_SHORTAGE = 10;
        public const int FCC_EXCLUSIVE_ERROR = 11;
        public const int FCC_INVENTORY_ERROR = 12;
        public const int FCC_INTERNAL_ERROR = 99;
        public const int FCC_MACHINE_ERROR = 100;

        // UNITNO
        public const int UNITNO_RBW_STK1 = 4043;
        public const int UNITNO_RBW_STK2 = 4044;
        public const int UNITNO_RBW_STK3 = 4045;
        public const int UNITNO_RBW_STK4 = 4046;
        public const int UNITNO_RBW_STK5 = 4047;
        public const int UNITNO_RBW_STK6 = 4048;
        public const int UNITNO_RBW_CTGY1 = 4056;
        public const int UNITNO_RBW_CTGY2 = 4057;
        public const int UNITNO_RBW_CTGY3 = 4058;
        public const int UNITNO_RBW_CTGY4A = 4059;
        public const int UNITNO_RBW_CTGY4B = 4060;
        public const int UNITNO_RBW_CAPBIN = 4069;
        public const int UNITNO_RBW_UBOX1C1 = 4108;
        public const int UNITNO_RBW_UBOX1C2 = 4109;
        public const int UNITNO_RBW_UBOX1C3 = 4110;
        public const int UNITNO_RBW_UBOX1C4A = 4111;
        public const int UNITNO_RBW_UBOX1C4B = 4112;
        public const int UNITNO_RBW_UBOX2C1 = 4113;
        public const int UNITNO_RBW_UBOX2C2 = 4114;
        public const int UNITNO_RBW_UBOX2C3 = 4115;
        public const int UNITNO_RBW_UBOX2C4A = 4116;
        public const int UNITNO_RBW_UBOX2C4B = 4117;
        public const int UNITNO_RBW_MIXSTCK1 = 4118;
        public const int UNITNO_RBW_MIXSTCK2 = 4119;
        public const int UNITNO_RBW_MIXSTCK3 = 4120;
        public const int UNITNO_RBW_MIXSTCK4 = 4121;
        public const int UNITNO_RBW_MIXSTCK5 = 4122;
        public const int UNITNO_RBW_MIXSTCK6 = 4123;
        public const int UNITNO_RCW_STK1 = 4043;
        public const int UNITNO_RCW_STK2 = 4044;
        public const int UNITNO_RCW_STK3 = 4045;
        public const int UNITNO_RCW_STK4 = 4046;
        public const int UNITNO_RCW_STK5 = 4047;
        public const int UNITNO_RCW_STK6 = 4048;
        public const int UNITNO_RCW_STK7 = 4054;
        public const int UNITNO_RCW_STK8 = 4055;
        public const int UNITNO_RCW_OVF = 4084;
        public const int UNITNO_RCW_MIX = 4165;

        // DEVID
        public const int DEVID_RBW100 = 1;
        public const int DEVID_RCW100 = 2;

        // INVENTRY_REQ_TYPE
        public const int FCC_REQ_All_INV = 0;
        public const int FCC_REQ_MACHINE_INV = 1;
        public const int FCC_REQ_DISPENSABLE_INV = 2;
        public const int FCC_RES_CASSETTE_INV = 3;

        // INVENTRY_RES_TYPE
        public const int FCC_RES_BOTH_INV = 0;
        public const int FCC_RES_MACHINE_INV = 3;
        public const int FCC_RES_DISPENSABLE_INV = 4;

        // STATUS_REQ_TYPE
        public const int FCC_REQ_GETST_WITHOUT_CASH = 0;
        public const int FCC_REQ_GETST_WITH_CASH = 1;

        // COLLECT_REQ_OPTION_TYPE
        public const int FCC_REQ_COLLECTION_TO_CST = 0;
        public const int FCC_REQ_COLLECTION_TO_EXIT = 1;

        // COLLECT_REQ_CASH_TYPE
        public const int FCC_REQ_COLLECTION_CASH_INFO = 5;

        // CURRENCY_TYPE
        public const int CURRENCY_TYPE_OTHER = 0;
        public const int CURRENCY_TYPE_NOTE = 1;
        public const int CURRENCY_TYPE_COIN = 2;
        public const int CURRENCY_TYPE_CREDIT = 3;
        public const int CURRENCY_TYPE_CHECK = 4;
        public const int CURRENCY_TYPE_COUPON = 5;

        // COLLECT_PARTIAL_TYPE
        public const int COLLECT_PRTL_TYPE_CASH = 1;
        public const int COLLECT_PRTL_TYPE_FILE = 2;

        // COLLECT_CASSETTE_NAME
        public const String COLLECT_CAS_NAME_NOTE = "CST";
        public const String COLLECT_CAS_NAME_COIN = "COFB";
        public const String MIX_STK_NAME_NOTE = "SUB";
        public const String MIX_STK_NAME_COIN = "MIX";
        public const String UBOX1_NAME_NOTE = "BOX1";
        public const String UBOX2_NAME_NOTE = "BOX2";

        // COLLECT_SURPLUS_XMLFILE
        public const String COLLECT_LISTFILE_NAME = "CollectList.xml";

        public com.glory.fcc.service.BrueBoxService clsBrueBoxService = new com.glory.fcc.service.BrueBoxService();

        public com.glory.fcc.service.BrueBoxService clsBrueBoxService2 = new com.glory.fcc.service.BrueBoxService();

        int seqNumber;

        private void BloquearBotonesDistintosA(List<Button> botonesNoBloquear)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && !botonesNoBloquear.Contains(button))
                {
                    button.Enabled = false;
                }
            }
        }

        private void DesbloquearTodosLosBotones()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        private enum CashMovementEnum
        {
            NONE = 0,
            Payment = 1,
            Extraction = 2

        }

        private CashMovementEnum cashMovement = CashMovementEnum.NONE;
        public Demo()
        {
            InitializeComponent();
            clsBrueBoxService.CashinCancelOperationCompleted += new com.glory.fcc.service.CashinCancelOperationCompletedEventHandler(CashinCancelOperationCompletedEventHandler);
            clsBrueBoxService.EndCashinOperationCompleted += new EndCashinOperationCompletedEventHandler(EndCashinOperationOperationCompletedEventHandler);
            clsBrueBoxService.EndReplenishmentFromEntranceOperationCompleted += new EndReplenishmentFromEntranceOperationCompletedEventHandler(EndReplenishmentFromEntranceOperationCompletedEventHandler);
            clsBrueBoxService.ChangeOperationCompleted += new com.glory.fcc.service.ChangeOperationCompletedEventHandler(ChangeOperationCompletedEventHandler);
            clsBrueBoxService.InventoryOperationCompleted += new com.glory.fcc.service.InventoryOperationCompletedEventHandler(InventoryOperationCompletedEventHandler);
            clsBrueBoxService.ResetOperationCompleted += new ResetOperationCompletedEventHandler(ResetOperationCompletedEventHandler);
        }

        private void btnBeginDeposit_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.StartCashinRequestType objDepositRequest = new com.glory.fcc.service.StartCashinRequestType();

            objDepositRequest.Id = GetId();
            objDepositRequest.SeqNo = GetSequenceNumber();
            try
            {
                clsBrueBoxService.StartCashinOperationAsync(objDepositRequest);
                this.BloquearBotonesDistintosA(new List<Button> { btnAcceptDeposit, btnReturnDeposit });
                //exclusionProcessing(false);
                //printer.PrintHeader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnBeginChange_Click(object sender, EventArgs e)
        {
            cashMovement = CashMovementEnum.Payment;
            com.glory.fcc.service.ChangeRequestType objChangeRequest = new com.glory.fcc.service.ChangeRequestType();

            objChangeRequest.Id = GetId();
            objChangeRequest.SeqNo = GetSequenceNumber();

            objChangeRequest.Amount = txtPaymentAmount.Text + "00";  // Lo que hay que pagar

            try
            {
                clsBrueBoxService.ChangeOperationAsync(objChangeRequest);
                this.BloquearBotonesDistintosA(new List<Button>());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void ChangeOperationCompletedEventHandler(object sender, com.glory.fcc.service.ChangeOperationCompletedEventArgs arg)
        {
            DenominationType[] dineroIngresado = arg.Result.Cash[0]?.Denomination;
            DenominationType[] dineroSaliente = arg.Result.Cash[1]?.Denomination;

            string obtenerTextoListaDinero(CashInfinityDemo.com.glory.fcc.service.DenominationType[] listaDinero)
            {
                string strResumen = "";
                double total = 0;
                foreach (DenominationType denominacion in listaDinero)
                {
                    total += double.Parse(denominacion.fv) * int.Parse(denominacion.Piece);
                    strResumen += $"{denominacion.Piece} billete/s de {denominacion.cc} {double.Parse(denominacion.fv) / 100}\n";
                }
                return $"TOTAL={total / 100}\n{strResumen}";
            }

            switch (cashMovement)
            {
                case CashMovementEnum.NONE:
                    break;
                case CashMovementEnum.Payment:
                    string strTotalAPagar = $"A pagar: {txtPaymentAmount.Text}\n\n";
                    string strDineroIngresado = $"Dinero ingresado:\n{obtenerTextoListaDinero(dineroIngresado)}\n";
                    string strVuelto = $"Vuelto:\n{obtenerTextoListaDinero(dineroSaliente)}\n";

                    MessageBox.Show(strTotalAPagar + strDineroIngresado + strVuelto);

                    break;
                case CashMovementEnum.Extraction:
                    string strTotalARetirar = $"A retirar: {txtExtractionAmount.Text}\n\n";
                    string strDineroRetirado = $"Dinero retirado:\n{obtenerTextoListaDinero(dineroSaliente)}\n";


                    MessageBox.Show(strTotalARetirar + strDineroRetirado);

                    break;
                default:
                    break;
            }
            cashMovement = CashMovementEnum.NONE;
            this.DesbloquearTodosLosBotones();
        }

        private void btnReturnDeposit_Click(object sender, EventArgs e)
        {
            CancelCashIn();
        }

        void CashinCancelOperationCompletedEventHandler(object sender, com.glory.fcc.service.CashinCancelOperationCompletedEventArgs arg)
        {
            this.DesbloquearTodosLosBotones();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.ResetRequestType objResetRequest = new com.glory.fcc.service.ResetRequestType();
            com.glory.fcc.service.ResetResponseType objResetResponse = new com.glory.fcc.service.ResetResponseType();

            objResetRequest.Id = GetId();
            objResetRequest.SeqNo = GetSequenceNumber();

            try
            {
                clsBrueBoxService.ResetOperationAsync(objResetRequest);
                this.BloquearBotonesDistintosA(new List<Button>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ResetOperationCompletedEventHandler(object sender, com.glory.fcc.service.ResetOperationCompletedEventArgs arg)
        {
            this.DesbloquearTodosLosBotones();
        }

        private string GetId()
        {
            return DateTime.Now.ToString();
        }

        private String GetSequenceNumber()
        {
            String seqnum = DateTime.Today.ToString("yyyyMMdd");
            seqnum += seqNumber.ToString("000#");
            return seqnum;
        }

        private void AddSequenceNumber()
        {
            seqNumber++;
        }

        // Get String corresponding to status number
        public String GetStatusString(int st)
        {
            string[] strRet = new string[] {
                "INIT",
                "IDLE",
                "CHANGE",
                "DEPOSIT WAIT",
                "DEPOSIT COUNTING",
                "DISPENSE",
                "WAIT REMOVING REJECTS",
                "WAIT REMOVING DISPENSE",
                "RESET",
                "DEPOSIT CANCEL",
                "CALCULATING AMOUNT",
                "CASH IN CANCEL",
                "COLLECTING",
                "ERROR",
                "DOWNLOADING FARMWARE",
                "READING LOGS",
                "WAIT REFILL",
                "CALCULATING REFILL AMOUNT",
                "UNLOCK",
                "INVENTORY_WAIT",
                "FIX_DEPOSITAMOUNT",
                "FIX_DISPENSEAMOUNT",
                "DISPENSE_WAIT",
                "CHANGECANCEL_WAIT",
                "COUNTED_CATEGORY",
                "WAITING_DEPOSIT_END",
                "",
                "",
                "",
                "",
                "AUTORECOVERY"
            };

            if (strRet.Length <= st)
            {
                return "Unknown";
            }
            return strRet[st];
        }

        //'
        //' Get Status
        //'
        private string GetStatus()
        {
            com.glory.fcc.service.StatusRequestType objStatusRequest = new com.glory.fcc.service.StatusRequestType();
            objStatusRequest.Id = GetId();
            objStatusRequest.SeqNo = GetSequenceNumber();
            objStatusRequest.Option = new com.glory.fcc.service.StatusOptionType();
            objStatusRequest.Option.type = FCC_REQ_GETST_WITHOUT_CASH.ToString();

            try
            {
                com.glory.fcc.service.StatusResponseType objStatusResponse = clsBrueBoxService.GetStatus(objStatusRequest);
                if (int.Parse(objStatusResponse.result) == FCC_SUCCESS)
                {
                    var ret = Enum.GetName(typeof(StatusCodeEnum), Convert.ToInt16(objStatusResponse.Status.Code));

                    return ret;
                }
                else
                {
                    return "FCC Error";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        //'
        //' Get Status
        //'
        void GetStatusAsync()
        {
            com.glory.fcc.service.StatusRequestType objStatusRequest = new com.glory.fcc.service.StatusRequestType();
            objStatusRequest.Id = GetId();
            objStatusRequest.SeqNo = GetSequenceNumber();
            objStatusRequest.Option = new com.glory.fcc.service.StatusOptionType();
            objStatusRequest.Option.type = FCC_REQ_GETST_WITHOUT_CASH.ToString();

            try
            {
                clsBrueBoxService.GetStatusAsync(objStatusRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //'
        //' Get Status - Complete Event
        //'
        void GetStatusCompletedEventHandler(object sender, com.glory.fcc.service.GetStatusCompletedEventArgs arg)
        {
            if (arg.Error != null)
            {
                //txtGuidance.Text = "Device controller cannot be reached. Retrying...";
                System.Threading.Thread.Sleep(1000);
                GetStatusAsync();
            }
            else if (int.Parse(arg.Result.result) == FCC_SUCCESS)
            {

                if (int.Parse(arg.Result.Status.Code) > STATUS_CODE_IDLE &&
                         int.Parse(arg.Result.Status.Code) != STATUS_CODE_RESET)
                {
                    com.glory.fcc.service.ResetRequestType objResetRequestType = new com.glory.fcc.service.ResetRequestType();
                    objResetRequestType.Id = "Initial Reset";
                    objResetRequestType.SeqNo = GetSequenceNumber();

                    try
                    {
                        System.Threading.Thread.Sleep(1000);
                        clsBrueBoxService2.ResetOperationAsync(objResetRequestType);
                        GetStatusAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Exception:" + ex.Message.ToString() + "\n");
                    }
                }
                else if (int.Parse(arg.Result.Status.Code) != STATUS_CODE_IDLE)
                {
                    System.Threading.Thread.Sleep(1000);
                    GetStatusAsync();
                }
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                GetStatusAsync();
            }
        }
        private void CancelCashIn()
        {
            // Repay    
            com.glory.fcc.service.CashinCancelRequestType objDepositCancelRequest = new com.glory.fcc.service.CashinCancelRequestType();
            objDepositCancelRequest.Id = GetId();
            objDepositCancelRequest.SeqNo = GetSequenceNumber();
            try
            {
                clsBrueBoxService.CashinCancelOperationAsync(objDepositCancelRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            this.MainStatusStrip.Items[0].Text = GetStatus();
        }

        private void btnAcceptDeposit_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.EndCashinRequestType objDepositAcceptRequest = new com.glory.fcc.service.EndCashinRequestType();
            objDepositAcceptRequest.Id = GetId();
            objDepositAcceptRequest.SeqNo = GetSequenceNumber();

            try
            {
                clsBrueBoxService.EndCashinOperationAsync(objDepositAcceptRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        void EndCashinOperationOperationCompletedEventHandler(object sender, com.glory.fcc.service.EndCashinOperationCompletedEventArgs arg)
        {
            this.DesbloquearTodosLosBotones();
        }

        private void btnBeginReplenish_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.StartReplenishmentFromEntranceRequestType objCashinRequest = new com.glory.fcc.service.StartReplenishmentFromEntranceRequestType();
            com.glory.fcc.service.StartReplenishmentFromEntranceResponseType objCashinResponse = new com.glory.fcc.service.StartReplenishmentFromEntranceResponseType();


            objCashinRequest.Id = GetId();
            objCashinRequest.SeqNo = GetSequenceNumber();
            try
            {
                objCashinResponse = clsBrueBoxService.StartReplenishmentFromEntranceOperation(objCashinRequest);
                if (int.Parse(objCashinResponse.result) != FCC_SUCCESS)
                {
                    //error handling
                    MessageBox.Show("Start Replenishment failed." + objCashinResponse.result);
                }
                else
                {
                    this.BloquearBotonesDistintosA(new List<Button> { btnEndReplenish });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEndReplenish_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.EndReplenishmentFromEntranceRequestType objEndReplenishmentFromEntranceRequest = new com.glory.fcc.service.EndReplenishmentFromEntranceRequestType();
            com.glory.fcc.service.EndReplenishmentFromEntranceResponseType objEndReplenishmentFromEntranceResponse = new com.glory.fcc.service.EndReplenishmentFromEntranceResponseType();
            String str = "";
            int i;

            objEndReplenishmentFromEntranceRequest.Id = GetId();
            objEndReplenishmentFromEntranceRequest.SeqNo = GetSequenceNumber();
            try
            {
                clsBrueBoxService.EndReplenishmentFromEntranceOperationAsync(objEndReplenishmentFromEntranceRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void EndReplenishmentFromEntranceOperationCompletedEventHandler(object sender, com.glory.fcc.service.EndReplenishmentFromEntranceOperationCompletedEventArgs arg)
        {
            this.DesbloquearTodosLosBotones();
        }

        private void btnBeginCashout_Click(object sender, EventArgs e)
        {
            cashMovement = CashMovementEnum.Extraction;

            com.glory.fcc.service.ChangeRequestType objChangeRequest = new com.glory.fcc.service.ChangeRequestType();

            objChangeRequest.Id = GetId();
            objChangeRequest.SeqNo = GetSequenceNumber();

            objChangeRequest.Amount = "-" + txtExtractionAmount.Text + "00";  // Lo que hay que pagar

            try
            {
                clsBrueBoxService.ChangeOperationAsync(objChangeRequest);
                this.BloquearBotonesDistintosA(new List<Button>());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryRequestType objInventoryRequest = new InventoryRequestType();
            objInventoryRequest.Id = GetId();
            objInventoryRequest.SeqNo = GetSequenceNumber();
            objInventoryRequest.Option = new com.glory.fcc.service.InventoryOptionType();
            objInventoryRequest.Option.type = FCC_REQ_All_INV.ToString();

            try
            {
                clsBrueBoxService.InventoryOperationAsync(objInventoryRequest);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void InventoryOperationCompletedEventHandler(object sender, com.glory.fcc.service.InventoryOperationCompletedEventArgs arg)
        {
            DenominationType[] inventario = arg.Result.Cash[0].Denomination;

            string str = "";
            foreach (DenominationType denominacion in inventario)
            {
                str += $"{denominacion.cc} {double.Parse(denominacion.fv) / 100} x {denominacion.Piece}\n";
            }

            MessageBox.Show(str);
        }

        private void btnErrorRecovery_Click(object sender, EventArgs e)
        {
            com.glory.fcc.service.ResetRequestType objResetRequestType = new com.glory.fcc.service.ResetRequestType();

            objResetRequestType.Id = "Error Recovery";
            objResetRequestType.SeqNo = "00000000";

            try
            {
                clsBrueBoxService.ResetOperationAsync(objResetRequestType);
                this.BloquearBotonesDistintosA(new List<Button>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Exception:" + ex.Message.ToString() + "\n");
            }
        }
    }
}
