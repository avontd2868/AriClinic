namespace AriCliReport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using AriCliModel;

    /// <summary>
    /// Summary description for RptTickets.
    /// </summary>
    public partial class RptTicketsPaid : Telerik.Reporting.Report
    {
        static DateTime fromDate;
        static DateTime toDate;

        public RptTicketsPaid()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

        }
        public RptTicketsPaid(DateTime fDate, DateTime tDate,int insuranceId, AriClinicContext ctx)
            : this()
        {
            ctx = new AriClinicContext("AriClinicContext");
            fromDate = fDate; toDate = tDate;
            this.DataSource = CntAriCli.GetTickets(fDate, tDate, insuranceId, "P", ctx);

        }
        public static string GetFromDate()
        {
            return String.Format("Desde: {0:dd/MM/yyyy}",fromDate);
        }
        public static string GetToDate()
        {
            return String.Format("Hasta: {0:dd/MM/yyyy}", toDate);
        }
    }
}