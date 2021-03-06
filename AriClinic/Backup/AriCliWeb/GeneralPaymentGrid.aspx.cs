using AriCliModel;
using AriCliWeb;
using System;
using System.Linq;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class GeneralPaymentGrid : System.Web.UI.Page 
{
    AriClinicContext ctx = null;
    User user = null;
    HealthcareCompany hc = null;
    Patient pat = null;
    Ticket tck = null;
    Customer cus = null;
    GeneralPayment pay = null;
    ServiceNote serviceNote = null;
    int ticketId = 0;
    int patientId = 0;
    int customerId = 0;
    int paymentId = 0;
    int serviceNoteId = 0;
    string type = "";
    Permission per = null;

    #region Init Load Unload events
    protected void Page_Init(object sender, EventArgs e)
    {
        ctx = new AriClinicContext("AriClinicContext");
        // security control, it must be a user logged
        if (Session["User"] == null)
            Response.Redirect("Default.aspx");
        else
        {
            user = CntAriCli.GetUser((Session["User"] as User).UserId, ctx);
            Process proc = (from p in ctx.Processes
                            where p.Code == "policy"
                            select p).FirstOrDefault<Process>();
            per = CntAriCli.GetPermission(user.UserGroup, proc, ctx);
        }
        // cheks if is call from another form
        if (Request.QueryString["Type"] != null)
            type = Request.QueryString["Type"];
        // read the realated patient
        if (Request.QueryString["PatientId"] != null)
        {
            patientId = Int32.Parse(Request.QueryString["PatientId"]);
            pat = CntAriCli.GetPatient(patientId, ctx);
            cus = pat.Customer;
        }
        // read passed customer if any
        if (Request.QueryString["CustomerId"] != null)
        {
            customerId = Int32.Parse(Request.QueryString["CustomerId"]);
            cus = CntAriCli.GetCustomer(customerId, ctx);
        }
        // 
        if (type == "InTab")
        {
            HtmlControl tt = (HtmlControl)this.FindControl("TitleArea");
            tt.Attributes["class"] = "ghost";
            // hide patient column
            RadGrid1.Columns.FindByDataField("Ticket.Policy.Customer.FullName").Visible = false;
        }
        if (Request.QueryString["ServiceNoteId"] != null)
        {
            serviceNoteId = int.Parse(Request.QueryString["ServiceNoteId"]);
            serviceNote = CntAriCli.GetServiceNote(serviceNoteId, ctx);
            HtmlControl tt = (HtmlControl)this.FindControl("TitleArea");
            tt.Attributes["class"] = "ghost";
            RadGrid1.Columns.FindByDataField("ServiceNote.Customer.FullName").Visible = false;
            // Ticket.Description
            RadGrid1.Columns.FindByDataField("Ticket.Description").Visible = false;
            // Ticket.Amount
            RadGrid1.Columns.FindByDataField("Ticket.Amount").Visible = false;
            //Ticket.Paid
            RadGrid1.Columns.FindByDataField("Ticket.Paid").Visible = false;
            // to fit in iframe space
            RadGrid1.PageSize = 3;
            RadGrid1.AllowFilteringByColumn = false;
        }
        // translate filters
        CntWeb.TranslateRadGridFilters(RadGrid1);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        // close context to release resources
        if (ctx != null)
            ctx.Dispose();
    }

    #endregion Init Load Unload events
    #region Grid treatment
    protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        // load grid data
        RefreshGrid(false);
    }

    protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
    {
        if (e.Item is GridCommandItem)
        {
            ImageButton imgb = (ImageButton)e.Item.FindControl("New");
            imgb.Visible = per.Create;
            if (pat != null)
                imgb.OnClientClick = "NewGeneralPaymentRecordInTab();";
            if (serviceNote != null)
                imgb.OnClientClick = String.Format("NewGeneralPaymentRecordServiceNote({0})", serviceNote.ServiceNoteId);
        }
        if (e.Item is GridDataItem)
        {
            ImageButton imgb = null;
            string name = "";
            string command = "";
            GridDataItem gdi;
            int id = 0;
            
            id = (int)e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex][e.Item.OwnerTableView.DataKeyNames[0]];

            // assign javascript function to select button
            imgb = (ImageButton)e.Item.FindControl("Select");
            gdi = (GridDataItem)e.Item;
            // mounting policy column
            //string bDate = gdi["Policy.BeginDate"].Text;
            //if (bDate == "01/01/0001") bDate = "";
            //string eDate = gdi["Policy.EndDate"].Text;
            //if (eDate == "01/01/0001") eDate = "";
            //command = String.Format("{0} [{1} - {2}]", gdi["Policy.Insurance.Name"].Text, bDate, eDate);
            //gdi["Policy"].Text = command;
            name = String.Format("{0} ({1}: {2})"
                                 , gdi["ServiceNote.Customer.FullName"].Text
                                 , gdi["PaymentMethod.Name"].Text
                                 , gdi["Amount"].Text);
            command = String.Format("return Selection('{0}','{1}','{2}','{3}','{4}');"
                                    , id.ToString()
                                    , null
                                    , name
                                    , null
                                    , "Ticket");
            imgb.OnClientClick = command;
            if (type != "S") imgb.Visible = false; // not called from another form

            // assign javascript function to edit button
            imgb = (ImageButton)e.Item.FindControl("Edit");
            //if (pat == null)
            //    command = String.Format("return EditGeneralPaymentRecord({0});", id);
            //else
            //    command = String.Format("return EditGeneralPaymentRecordInTab({0});", id);
            command = String.Format("return EditGeneralPaymentRecord({0});", id);
            imgb.OnClientClick = command;

            // assigning javascript functions to delete button
            imgb = (ImageButton)e.Item.FindControl("Delete");
            command = String.Format("return confirm('{0} {1}');", Resources.GeneralResource.DeleteRecordQuestion, name);
            imgb.OnClientClick = command;
            imgb.Visible = per.Create;
        }
    }

    protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        // weonly process commands with a datasource (our image buttons)
        if (e.CommandSource == null)
            return;
        string typeOfControl = e.CommandSource.GetType().ToString();
        if (typeOfControl.Equals("System.Web.UI.WebControls.ImageButton"))
        {
            int id = 0;
            ImageButton imgb = (ImageButton)e.CommandSource;
            if (imgb.ID != "New" && imgb.ID != "Exit")
                id = (int)e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex][e.Item.OwnerTableView.DataKeyNames[0]];
            switch (imgb.ID)
            {
                case "Select":
                    break;
                case "Edit":
                    break;
                case "Delete":
                    pay = (from p in ctx.GeneralPayments
                           where p.GeneralPaymentId == id
                           select p).FirstOrDefault<GeneralPayment>();
                    CntAriCli.GeneralPaymentDelete(pay, ctx);
                    RefreshGrid(true);
                    break;
            }
        }
    }

    #endregion Grid treatment

    protected void RadAjaxManager1_AjaxRequest(object sender, AjaxRequestEventArgs e)
    {
        RefreshGrid(true);
        if (e.Argument == "new") 
        { 
            RadGrid1.CurrentPageIndex = RadGrid1.PageCount - 1;
            RadGrid1.Rebind();
        }
    }

    protected void RefreshGrid(bool rebind)
    {
        if (pat == null && cus == null)
            RadGrid1.DataSource = ctx.GeneralPayments;
        else
        {
            if (serviceNote != null)
            {
                RadAjaxManager1.ResponseScripts.Add("parent.updateTotal()");
                RadGrid1.DataSource = serviceNote.GeneralPayments;
            }
            else
            {
                RadGrid1.DataSource = CntAriCli.GetGeneralPayments(cus, ctx);
            }
        }
        if (serviceNote != null)
        {
            RadAjaxManager1.ResponseScripts.Add("parent.updateTotal()");
            RadGrid1.DataSource = serviceNote.GeneralPayments;
        }
        if (rebind) RadGrid1.Rebind();
    }
}
