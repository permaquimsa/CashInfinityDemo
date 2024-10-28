using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CashInfinityDemo
{
    public class MultiArgsEvent : EventArgs
    {
        public MultiArgsEvent(params object[] args)
        {
            Args = args;
        }

        public object[] Args { get; set; }
    }

    public class ISPKEventHandled
    {
        // Eventos en ISPK Web Socket
        public event EventHandler<bool> MachineReporting;
        public event EventHandler<double> UpdateCounted;
        public event EventHandler<double> UpdateToDispensed;
        public event EventHandler<double> UpdatePayment;
        public event EventHandler<System.Xml.XmlNode> UpdateInventory;
        public event EventHandler<System.Xml.XmlNode> IncompleteTransaction;
        public event EventHandler<string> ErrorFound;
        public event EventHandler<string> OperationStatus;
        public event EventHandler<MultiArgsEvent> RecyclerStatus;

        public event EventHandler<string> WriteResponse;

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
        public const int STATUS_CODE_WAITREPLENISH = 16;
        public const int STATUS_CODE_CALCREPLENISH = 17;
        public const int STATUS_CODE_UNLOCKING = 18;
        public const int STATUS_CODE_OCCUPY = 20;

        // FCC_STATUS_CODE
        public const int FCC_SUCCESS = 0;
        public const int FCC_CANCEL = 1;
        public const int FCC_SHORTAGE_CANCEL = 9;
        public const int FCC_SHORTAGE = 10;
        public const int FCC_EXCLUSIVE_ERROR = 11;
        public const int FCC_INVENTORY_ERROR = 12;
        public const int FCC_VERIFICATION_ERROR = 32;
        public const int FCC_ILLEGAL_DENOMI_ERROR = 33;
        public const int FCC_SHORTAGE_STK_ERROR = 34;
        public const int FCC_INTERNAL_ERROR = 99;
        public const int FCC_MACHINE_ERROR = 100;

        // UNITNO
        public const int UNITNO_RBW_STK1 = 4043;
        public const int UNITNO_RBW_STK2 = 4044;
        public const int UNITNO_RBW_STK3 = 4045;
        public const int UNITNO_RBW_CTGY1 = 4056;
        public const int UNITNO_RBW_CTGY2 = 4057;
        public const int UNITNO_RBW_CTGY3 = 4058;
        public const int UNITNO_RBW_CTGY4A = 4059;
        public const int UNITNO_RBW_CTGY4B = 4060;
        public const int UNITNO_RBW_CAPBIN = 4069;
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

        // STATUS_REQ_VERIFY_TYPE
        public const int FCC_REQ_GETST_VERIFY_OFF = 0;
        public const int FCC_REQ_GETST_VERIFY_ON = 1;

        // STATUS_RES_VERIFY_TYPE
        public const int FCC_RES_GETST_VERIFY_OFF = 0;
        public const int FCC_RES_GETST_VERIFY_ON = 1;

        // COLLECT_REQ_OPTION_TYPE
        public const int FCC_REQ_COLLECTION_TO_CST = 0;
        public const int FCC_REQ_COLLECTION_TO_EXIT = 1;

        // COLLECT_REQ_MIX_TYPE
        public const int FCC_REQ_COLLECTION_MIX_OFF = 0;
        public const int FCC_REQ_COLLECTION_MIX_ON = 1;

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
        public const String COLLECT_CAS_NAME_MIX = "MIX";
        /*************/
        public const String ID_INV_RESPONSE = "ControlPanel";
        public const String SEQNO_INV_RESPONSE = "ControlPane";

        private int Port;
        private int HeartbeatTime;
        private int LastResponseTime;
        private bool KeepAlive = false;
        private DispatcherTimer MachineReportingTimer;

        private System.Threading.Thread objListenThread;
        private System.Diagnostics.TraceSource appTrace;

        //[System.Runtime.InteropServices.DllImport("KERNEL32.DLL")]
        //public static extern uint
        //        GetPrivateProfileString(string lpAppName,
        //                    string lpKeyName, string lpDefault,
        //                    StringBuilder lpReturnedString, uint nSize,
        //                    string lpFileName);

        public ISPKEventHandled(int port, int heartbeat)
        {
            Port = port;
            HeartbeatTime = heartbeat + 1;
            LastResponseTime = HeartbeatTime;
            KeepAlive = false;

            MachineReportingTimer = new DispatcherTimer();
            MachineReportingTimer.Tick += MachineReporting_Tick;
            MachineReportingTimer.Interval = TimeSpan.FromSeconds(1);
            MachineReportingTimer.Start();

            thread_init();
        }

        private void MachineReporting_Tick(object sender, EventArgs e)
        {
            if (LastResponseTime > 0)
            {
                LastResponseTime--;
            }
            else
            {
                if (KeepAlive)
                {
                    KeepAlive = false;
                    try
                    {
                        MachineReporting(this, KeepAlive);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void thread_init()
        {
            appTrace = new System.Diagnostics.TraceSource("BrueBoxPosDemo");
            if (objListenThread == null)
            {
                objListenThread = new System.Threading.Thread(new System.Threading.ThreadStart(thread_start));
            }
            if (objListenThread.ThreadState == System.Threading.ThreadState.Stopped)
            {
                objListenThread = new System.Threading.Thread(new System.Threading.ThreadStart(thread_start));
            }

            objListenThread.IsBackground = true;
            objListenThread.Start();
        }
        private void thread_start()
        {
            long nEventRecvCount = 0;

            appTrace.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 0, "[thread_start] IN");
            appTrace.TraceEvent(System.Diagnostics.TraceEventType.Information, 0, "[thread_start] IN");

            Encoding enc = Encoding.UTF8;
            System.Net.IPAddress ipAddsAny = System.Net.IPAddress.Any;
            System.Net.Sockets.TcpListener listener = new System.Net.Sockets.TcpListener(ipAddsAny, Port);

            try
            {
                while (true)
                {
                    listener.Start();

                    Console.WriteLine("Start listern on Port {0}", Port);

                    System.Net.Sockets.TcpClient tcp;
                    tcp = listener.AcceptTcpClient();
                    //Menu.setStatusConexion(true);//Mando un estatus de la conexion
                    Console.WriteLine("Client connected.");
                    appTrace.TraceInformation("Client connected.");

                    nEventRecvCount = 0;

                    System.Net.Sockets.NetworkStream ns = tcp.GetStream();

                    int resSize;
                    string cmd = "";
                    bool CloseSock = false;
                    do
                    {
                        byte[] bytes = new byte[tcp.ReceiveBufferSize];
                        resSize = ns.Read(bytes, 0, tcp.ReceiveBufferSize);

                        if (resSize == 0)
                        {
                            Console.WriteLine("Client is disconnected.");
                            appTrace.TraceInformation("Client is disconnected.");
                            CloseSock = true;
                            break;
                        }

                        long s = 0;
                        long e = 0;
                        for (e = 0; e < resSize; e++)
                        {
                            if (bytes[e] == 0)
                            {
                                cmd += System.Text.Encoding.ASCII.GetString(bytes, (int)s, (int)(e - s));
                                Console.WriteLine("cmd : " + cmd);
                                // Here the event handling should be located.>>>>>>>>>>>>>>>
                                CheckRecvComand(cmd, nEventRecvCount);

                                // if one packet includes several events, then the next event 
                                // also should be handled.
                                s = e + 1;

                                cmd = "";
                            }
                            else if (e == resSize - 1)
                            {
                                // If one event is separated to several packets, then they 
                                // should be merged to one string.
                                cmd += System.Text.Encoding.ASCII.GetString(bytes, (int)s, (int)(e - s + 1));
                            }
                        }
                    } while (true);

                    if (CloseSock == false)
                    {
                        tcp.Close();
                        Console.WriteLine("Disconnected");
                        appTrace.TraceEvent(System.Diagnostics.TraceEventType.Error, 0, "Disconnected");
                        //Menu.setStatusConexion(false);//Mando un estatus de la conexion
                        continue;
                    }

                    listener.Stop();
                    Console.WriteLine("Listener is closed.");
                    //Menu.setStatusConexion(false);//Mando un estatus de la conexion
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                appTrace.TraceEvent(System.Diagnostics.TraceEventType.Critical, 0, ex.Message.ToString());
                //Menu.setStatusConexion(false);//Mando un estatus de la conexion
            }
        }

        private void CheckRecvComand(string returndata, long nEventRecvCount)
        {
            try
            {
                if (WriteResponse == null)
                    return;
                WriteResponse(this, returndata);
                System.Xml.XmlDocument dom = new System.Xml.XmlDocument();
                dom.LoadXml(returndata);

                System.Xml.XmlNodeList nodelist1 = dom.SelectNodes("/BbxEventRequest/*");
                foreach (System.Xml.XmlNode node in nodelist1)
                {
                    String strName = node.Name;

                    //judge the kind of event
                    if (strName.Equals("HeartBeatEvent"))
                    {

                    }
                    else if (strName.Equals("ChangeInventoryStatus"))
                    {

                    }
                    else if (strName.Equals("StatusChangeEvent"))
                    {
                        //Get node object of each element
                        System.Xml.XmlNode nodeStatus = node.SelectSingleNode("./Status");
                        System.Xml.XmlNode nodeAmount = node.SelectSingleNode("./Amount");
                        System.Xml.XmlNode nodeError = node.SelectSingleNode("./Error");
                        System.Xml.XmlNode nodeUser = node.SelectSingleNode("./User");
                        System.Xml.XmlNode nodeSeqNo = node.SelectSingleNode("./SeqNo");

                        String convUser = "";

                        convUser = nodeUser.InnerText;

                        OperationStatus(this, NotificationsStatusCode(nodeStatus.InnerText));

                        //Check if the fcc is under change operation
                        if ((Int32.Parse(nodeStatus.InnerText)) == STATUS_CODE_IDLE)
                        {
                            UpdateCounted(this, 0);
                            UpdateToDispensed(this, 0);
                            UpdatePayment(this, 0);
                        }
                        if ((Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_DEPOSIT_WAIT) ||
                            (Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_DEPOSIT_COUNTING) ||
                            (Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_CALCREPLENISH))
                        {
                            //if doing change operation, then the amount should store deposit amount.
                            double dblCashin = (Double.Parse(nodeAmount.InnerText) / 100);
                            UpdateCounted(this, dblCashin);

                        }
                        else if (Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_DISPENSE)
                        {
                            //If doing dispensing, then the amount should be dispense amount.
                            //The dispense amount is not result value, it just a parameter of dispense command.
                            //Actual dispensed amount will be reported after dispense command has been done.
                            double dblCashOut = (Double.Parse(nodeAmount.InnerText) / 100);
                            UpdateToDispensed.Invoke(this, dblCashOut);
                        }
                        else if (Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_CHANGE)
                        {
                            double dblCashin = (Double.Parse(nodeAmount.InnerText) / 100);
                            UpdatePayment(this, dblCashin);
                        }

                        // In the case of a StartReplenishmentFromCassette
                        // If status becomes an idol after lock normalcy, start a ReplenishmentFromCassette
                        //if (Menu.repFC_state)
                        //{
                        //    if (Int32.Parse(nodeStatus.InnerText) == STATUS_CODE_IDLE)
                        //    {
                        //        Menu.StartReplenishmentFromCassette();
                        //    }
                        //}

                        //Menu.SetGuidance(CIMachine.FCCStatus[nodeStatus.InnerText]);//Menu.statuscode(nodeStatus.InnerText));
                    }
                    else if (strName.Equals("GlyCashierEvent"))
                    {
                        string strOutput = "";

                        //Device Event
                        String sDevID = node.Attributes["devid"].InnerText;
                        String sUser = node.Attributes["user"].InnerText;


                        System.Xml.XmlNode nEventTypeNode = node.FirstChild;
                        String strEventName = "undefined", TransactionID = "NA";
                        if (nEventTypeNode.Name.Equals("TransactionId"))
                        {
                            try
                            {
                                TransactionID = nEventTypeNode.InnerText;
                                nEventTypeNode = node.ChildNodes[1];
                                strEventName = nEventTypeNode.Name;
                                //CIGlobal.Logging.Info("se recibio transaction en eventInventoryOnRemoval ID: " + TransactionID);
                                TransactionID = TransactionID.Substring(5, 9);
                            }
                            catch (Exception e)
                            {
                                //CIGlobal.Logging.ErrorFormat("No fue posible leer un hijo uno al identificar un transaction ID en el xml Glycashier, error: " + e.Message + " mensaje: " + dom.ToString());

                            }
                        }
                        else
                        {
                            strEventName = nEventTypeNode.Name;
                        }

                        if (strEventName.Equals("eventWaitForRemoving"))
                        {
                            //Wait removeing notes from RBW
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            RecyclerStatus(this, new MultiArgsEvent(Convert.ToInt32(sDevID), $"REMOVER {strIDName}"));
                            //Menu.SetStatus(Int32.Parse(sDevID), "REMOVER " + strIDName);
                        }
                        else if (strEventName.Equals("eventRemoved"))
                        {
                            //Note was removed from RBW
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "REMOVIDO " + strIDName);
                        }
                        else if (strEventName.Equals("eventStatusChange"))
                        {
                            //Status Change
                            System.Xml.XmlNode nDeviceStatusID = nEventTypeNode.FirstChild;
                            string strIDName = GetDeviceStatusIDString(nDeviceStatusID.InnerText);
                            RecyclerStatus(this, new MultiArgsEvent(Convert.ToInt32(sDevID), strIDName));
                            //Menu.SetStatus(Int32.Parse(sDevID), strIDName);
                        }
                        else if (strEventName.Equals("eventEmpty"))
                        {
                            //Empty
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "VACIO " + strIDName);
                        }
                        else if (strEventName.Equals("eventLow"))
                        {
                            //Near Empty
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "CASI VACIO " + strIDName);
                        }
                        else if (strEventName.Equals("eventExist"))
                        {
                            //Exist 
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "NORMAL " + strIDName);
                        }
                        else if (strEventName.Equals("eventHigh"))
                        {
                            //Near Full
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "ALTO " + strIDName);
                        }
                        else if (strEventName.Equals("eventFull"))
                        {
                            //Full
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "LLENO " + strIDName);
                        }
                        else if (strEventName.Equals("eventMissing"))
                        {
                            //Missing unit.
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "FALTA DE " + strIDName);
                        }
                        else if (strEventName.Equals("eventDepositCountChange"))
                        {
                            //Depositing
                        }
                        else if (strEventName.Equals("eventDepositCountMonitor"))
                        {
                            //Depositing in the monitor
                            //Menu.setCountingMonitor(node);
                        }
                        else if (strEventName.Equals("eventReplenishCountChange"))
                        {
                            //Replenishing
                            //Evento de lo que se esta dotando al equipo.
                            //Menu.setCountingReplenishment(node);//Esta instrucción y en este codigo manda las piezas ingresadas al finalizar el conteo
                        }
                        else if (strEventName.Equals("eventError"))
                        {
                            //Error occurred
                            System.Xml.XmlNode nErrorCode = nEventTypeNode.FirstChild;
                            //Menu.SetStatus(Int32.Parse(sDevID), "Error " + nErrorCode.InnerText);
                            System.Xml.XmlNode nURL = nErrorCode.NextSibling;
                            String errCode = Int32.Parse(nErrorCode.InnerText).ToString("X");
                            int i;
                            for (i = 1; i <= 4 - errCode.Length; i++)
                                errCode = "0" + errCode;

                            if (!String.IsNullOrEmpty(nURL.InnerText))
                            {
                                //Menu.ErrorFound(errCode, sDevID, nURL.InnerText);
                            }

                        }
                        else if (strEventName.Equals("eventCassetteInserted"))
                        {
                            //Inserted cassette
                            System.Xml.XmlNode nCassetteID = nEventTypeNode.FirstChild;
                            //Menu.SetStatus(Int32.Parse(sDevID), "CASSETTE INSERTADO " + nCassetteID.InnerText);
                        }
                        else if (strEventName.Equals("eventPowerOffOnRequest"))
                        {
                            //Power off/on request
                        }
                        else if (strEventName.Equals("eventDownloadProgress"))
                        {
                            //Download progress
                        }
                        else if (strEventName.Equals("eventLogreadProgress"))
                        {
                            //Log Read progress
                        }
                        else if (strEventName == "eventRequireVerifyDenomination")
                        {
                            //RequireVerify
                            int i = 0;
                            System.Xml.XmlNode nCash = nEventTypeNode.FirstChild;
                            //Initialize
                            // Menu.SetWarningLabel(3, sDevID, "");
                            for (i = 0; i <= nCash.ChildNodes.Count - 1; i++)
                            {
                                System.Xml.XmlElement denomi = null;
                                string fv = null;

                                denomi = (System.Xml.XmlElement)nCash.ChildNodes.Item(i);
                                fv = denomi.GetAttribute("fv");
                                //  Menu.SetWarningLabel(1, sDevID, fv);
                            }
                        }
                        else if (strEventName == "eventRequireVerifyCollectionContainer")
                        {
                            //RequireVerify IF Cassette
                            //  Menu.SetWarningLabel(2, sDevID, "");
                        }
                        else if (strEventName == "eventRequireVerifyMixStacker")
                        {
                            //RequireVerify MIX Stacker
                            // Menu.SetWarningLabel(5, sDevID, "");
                        }
                        else if (strEventName == "eventExactDenomination")
                        {
                            //Exact
                            //Menu.SetWarningLabel(3, sDevID, "");
                        }
                        else if (strEventName == "eventExactCollectionContainer")
                        {
                            //Exact IF Cassette
                            // Menu.SetWarningLabel(4, sDevID, "");
                        }
                        else if (strEventName == "eventExactMixStacker")
                        {
                            //Exact MIX Stacker
                            // Menu.SetWarningLabel(6, sDevID, "");
                        }
                        else if (strEventName.Equals("eventWaitForOpening"))
                        {
                            //Wait For Opening
                            System.Xml.XmlNode nDoorID = nEventTypeNode.FirstChild;
                            string strIDName = GetDoorIDString(nDoorID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "ESPERANDO ABRIR " + strIDName);
                        }
                        else if (strEventName.Equals("eventOpened"))
                        {
                            //Opened
                            System.Xml.XmlNode nDoorID = nEventTypeNode.FirstChild;
                            string strIDName = GetDoorIDString(nDoorID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "ABIERTO " + strIDName);
                        }
                        else if (strEventName.Equals("eventClosed"))
                        {
                            //Closed
                            System.Xml.XmlNode nDoorID = nEventTypeNode.FirstChild;
                            string strIDName = GetDoorIDString(nDoorID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "CERRADO " + strIDName);
                        }
                        else if (strEventName.Equals("eventLocked"))
                        {
                            //Locked
                            System.Xml.XmlNode nDoorID = nEventTypeNode.FirstChild;
                            string strIDName = GetDoorIDString(nDoorID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "BLOQUEADO " + strIDName);
                        }
                        else if (strEventName.Equals("eventWaitForInsertion"))
                        {
                            //Wait For Insertion
                            System.Xml.XmlNode nDevicePositionID = nEventTypeNode.FirstChild;
                            string strIDName = GetDevicePositionIDString(nDevicePositionID.InnerText);
                            //Menu.SetStatus(Int32.Parse(sDevID), "ESPERANDO INSERTAR " + strIDName);
                        }
                        else if (strEventName.Equals("eventCassetteInventoryOnRemoval"))
                        {
                            String SeqNo = "NA";
                            try
                            {
                                //SeqNo = dom.FirstChild.SelectSingleNode("SerialNoOnHeader").InnerText;
                                SeqNo = dom.FirstChild.SelectSingleNode("SeqNo").InnerText;
                                if (SeqNo.Equals("NA"))
                                {
                                    //CIGlobal.Logging.ErrorFormat("No fue posible obtener SeqNo en eventCassetteInventoryOnRemoval");
                                }
                            }
                            catch
                            {
                                //CIGlobal.Logging.Fatal("Error al leer el nodo en EventHandleClass de eventCassetteInventoryOnRemoval, Se manda NA");
                            }

                            //Menu.Collected(sDevID, node, SeqNo);//Antes se enviaba transactionID
                        }
                        else
                        {
                            //Unknown
                            strOutput = "";
                            strOutput += strEventName + "\n";
                        }
                    }
                    else if (strName.Equals("InventoryResponse"))
                    {
                        //Get node object of each element
                        System.Xml.XmlNode nodeId = node.SelectSingleNode("./Id");
                        System.Xml.XmlNode nodeSeqNo = node.SelectSingleNode("./SeqNo");
                        if (nodeId.InnerText.Equals(ID_INV_RESPONSE) || nodeSeqNo.InnerText.Equals(SEQNO_INV_RESPONSE))
                        {
                            // SetInventory
                            //Menu.UpdateInventory(); //ACTUALIZAR INVENTARIO DESDE EVENTOS
                        }
                    }
                    else if (strName.Equals("ChangeResponse"))
                    {
                        String Result = node.Attributes["result"].InnerText;
                        //Menu.setSaveDespositDispense(node, Result);

                    }
                    else if (strName.Equals("IncompleteTransaction"))
                    {//se guarda transaccion de Dinero Incompleto
                     //Menu.IncompleteTransaction(node);
                    }
                    else if (strName.Equals("EndCashinResponse"))
                    {
                        String Result = node.Attributes["result"].InnerText;
                        //Menu.SaveEndCashInResponse(node, Result);
                    }
                    else if (strName.Equals("CashoutResponse"))
                    {
                        String Result = node.Attributes["result"].InnerText;
                        //Menu.SaveCashOutResponse(node, Result);
                    }
                    else if (strName.Equals("EndReplenishmentFromEntranceResponse"))
                    {
                        String Result = node.Attributes["result"].InnerText;
                        //Menu.saveDotacionrecarga(node, Result);
                    }
                    else if (strName.Equals("CollectResponse"))
                    {
                        String Result = node.Attributes["result"].InnerText;
                        //Menu.EnvioaCassette(node, Result);
                    }
                    else
                    {
                        String strOutput = "";

                        strOutput = "";
                        strOutput += ("(" + nEventRecvCount.ToString() + ")" + "\n");
                        strOutput += ("SOAP Completed." + "\n");

                        strOutput += (" res name  : " + strName + "\n");
                        strOutput += ("------------------------------" + "\n");

                    }
                }
                if (!KeepAlive)
                {
                    try
                    {
                        KeepAlive = true;
                        MachineReporting(this, KeepAlive);
                    }
                    catch
                    {
                    }
                }
                LastResponseTime = HeartbeatTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                appTrace.TraceEvent(System.Diagnostics.TraceEventType.Critical, 0, ex.Message.ToString());
            }
        }

        private string NotificationsStatusCode(String code)
        {
            switch (code)
            {
                case "0":
                    return "Inicializando".ToUpper();
                case "1":
                    return "Libre".ToUpper();
                case "2":
                    return "Cobrando".ToUpper();
                case "3":
                    return "Esperando efectivo".ToUpper();
                case "4":
                    return "Contando".ToUpper();
                case "5":
                    return "Dispensando".ToUpper();
                case "6":
                    return "Remover rechazos".ToUpper();
                case "7":
                    return "Remover dispensa".ToUpper();
                case "8":
                    return "Reiniciando".ToUpper();
                case "9":
                    return "Cancelando cobro".ToUpper();
                case "10":
                    return "Calculando cambio".ToUpper();
                case "11":
                    return "Cancelando Deposito".ToUpper();
                case "12":
                    return "Resguardando".ToUpper();
                case "13":
                    return "Error".ToUpper();
                case "14":
                    return "Cargando Firmware".ToUpper();
                case "15":
                    return "Recopilando históricos".ToUpper();
                case "16":
                    return "Dotación".ToUpper();
                case "17":
                    return "Dotando".ToUpper();
                case "18":
                    return "Liberando cerradura".ToUpper();
                case "19":
                    return "Validando Inventario".ToUpper();
                case "20":
                    return "Finalizando depósito".ToUpper();
                case "21":
                    return "Finalizando dispensa".ToUpper();
                case "23":
                    return "Cancelar cobro".ToUpper();
                case "24":
                    return "Billete categorpia 2 detectado".ToUpper();
                case "25":
                    return "Finalizar depósito".ToUpper();
                case "26":
                    return "Remover cassette de monedas".ToUpper();
                case "27":
                    return "Sellando".ToUpper();
                case "30":
                    return "Esperando a recuperar error".ToUpper();
                case "40":
                    return "Ocupado".ToUpper();
                case "41":
                    return "Esperando actualización".ToUpper();
                default:
                    return "Desconocido".ToUpper();


            }

        }

        public String GetDeviceStatusIDString(String strID)
        {
            String strRet;
            switch (Int32.Parse(strID))
            {
                case 0:
                    strRet = "ERROR INTERNO";
                    break;
                case 1:
                    strRet = "DISPONIBLE";
                    break;
                case 2:
                    strRet = "CONTANDO";
                    break;
                case 3:
                    strRet = "PROCESANDO";
                    break;
                case 4:
                    strRet = "OCUPADO";
                    break;
                case 5:
                    strRet = "ERROR";
                    break;
                case 6:
                    strRet = "ERROR DE COMUNICACIÓN";
                    break;
                case 7:
                    strRet = "DLL OCUPADO";
                    break;
                default:
                    strRet = "ERROR DESCONOCIDO:" + strID;
                    break;
            }
            return (strRet);
        }

        public String GetDevicePositionIDString(String strID)
        {
            String strRet;

            switch (Int32.Parse(strID))
            {
                case 1:
                    strRet = "ALIMENTADOR";
                    break;
                case 2:
                    strRet = "SALIDA";
                    break;
                case 3:
                    strRet = "CPS1_COUNTER";
                    break;
                case 4:
                    strRet = "CPS2_COUNTER";
                    break;
                case 5:
                    strRet = "CPS3_COUNTER";
                    break;
                case 6:
                    strRet = "CPS4_COUNTER";
                    break;
                case 7:
                    strRet = "CPS5_COUNTER";
                    break;
                case 8:
                    strRet = "CPS6_COUNTER";
                    break;
                case 9:
                    strRet = "CPS7_COUNTER";
                    break;
                case 10:
                    strRet = "CPS8_COUNTER";
                    break;
                case 11:
                    strRet = "CONTAINER_C1_COUNTER";
                    break;
                case 12:
                    strRet = "CONTAINER_C2_COUNTER";
                    break;
                case 13:
                    strRet = "CONTAINER_C3_COUNTER";
                    break;
                case 14:
                    strRet = "CONTAINER_C4A_COUNTER";
                    break;
                case 15:
                    strRet = "CONTAINER_C4B_COUNTER";
                    break;
                case 16:
                    strRet = "CPS1_C3_COUNTER";
                    break;
                case 17:
                    strRet = "CPS2_C3_COUNTER";
                    break;
                case 18:
                    strRet = "CPS3_C3_COUNTER";
                    break;
                case 19:
                    strRet = "CAPTUREBIN_COUNTER";
                    break;
                case 20:
                    strRet = "CONTAINER_FIT_COUNTER";
                    break;
                case 21:
                    strRet = "COLLECTION_BOX";
                    break;
                case 22:
                    strRet = "CPS4_C3_COUNTER";
                    break;
                case 23:
                    strRet = "CPS5_C3_COUNTER";
                    break;
                case 24:
                    strRet = "CPS6_C3_COUNTER";
                    break;
                case 25:
                    strRet = "CPS7_C3_COUNTER";
                    break;
                case 26:
                    strRet = "CPS8_C3_COUNTER";
                    break;
                case 27:
                    strRet = "ESCROW";
                    break;
                case 28:
                    strRet = "CPS9_COUNTER";
                    break;
                case 29:
                    strRet = "CPS10_COUNTER";
                    break;
                case 30:
                    strRet = "CPS9_C3_COUNTER";
                    break;
                case 31:
                    strRet = "CPS10_C3_COUNTER";
                    break;
                case 32:
                    strRet = "CPS1_C4B_COUNTER";
                    break;
                case 33:
                    strRet = "CPS2_C4B_COUNTER";
                    break;
                case 34:
                    strRet = "CPS3_C4B_COUNTER";
                    break;
                case 35:
                    strRet = "CPS4_C4B_COUNTER";
                    break;
                case 36:
                    strRet = "CPS5_C4B_COUNTER";
                    break;
                case 37:
                    strRet = "CPS6_C4B_COUNTER";
                    break;
                case 38:
                    strRet = "CPS7_C4B_COUNTER";
                    break;
                case 39:
                    strRet = "CPS8_C4B_COUNTER";
                    break;
                case 40:
                    strRet = "CPS9_C4B_COUNTER";
                    break;
                case 41:
                    strRet = "CPS10_C4B_COUNTER";
                    break;
                case 42:
                    strRet = "RCW100_JAM_DOOR";
                    break;
                case 43:
                    strRet = "RCW100_TRANSPORT_UNIT";
                    break;
                case 44:
                    strRet = "RCW100_ENTRANCE_UNIT";
                    break;
                case 45:
                    strRet = "RBW100_MAINTE_DOOR";
                    break;
                case 46:
                    strRet = "RBW100_UPPER_DOOR";
                    break;
                case 47:
                    strRet = "RBW100_IF_CASETTE";
                    break;
                case 48:
                    strRet = "RBW100_STACK_CASETTE";
                    break;
                case 49:
                    strRet = "CPS1_C2_COUNTER";
                    break;
                case 50:
                    strRet = "CPS2_C2_COUNTER";
                    break;
                case 51:
                    strRet = "CPS3_C2_COUNTER";
                    break;
                case 52:
                    strRet = "CPS4_C2_COUNTER";
                    break;
                case 53:
                    strRet = "CPS5_C2_COUNTER";
                    break;
                case 54:
                    strRet = "CPS6_C2_COUNTER";
                    break;
                case 55:
                    strRet = "CPS7_C2_COUNTER";
                    break;
                case 56:
                    strRet = "CPS8_C2_COUNTER";
                    break;
                case 57:
                    strRet = "CPS9_C2_COUNTER";
                    break;
                case 58:
                    strRet = "CPS10_C2_COUNTER";
                    break;
                case 64:
                    strRet = "UPPER_UNIT";
                    break;
                case 65:
                    strRet = "LOWER_UNIT";
                    break;
                case 73:
                    strRet = "COFB";
                    break;
                case 74:
                    strRet = "MIXED STACKER";
                    break;
                default:
                    strRet = "DESCONOCIDO:" + strID;
                    break;
            }
            return (strRet);
        }

        public String GetDoorIDString(String strID)
        {
            String strRet;

            switch (Int32.Parse(strID))
            {
                case 1:
                    strRet = "PUERTA DE RECOLECCIÓN";
                    break;
                case 2:
                    strRet = "PUERTA DE MANTENIMIENTO";
                    break;
                case 73:
                    strRet = "COFB";
                    break;
                default:
                    strRet = "DESCONOCIDO:" + strID;
                    break;
            }
            return (strRet);
        }
    }
}
