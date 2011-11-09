using System;
using AriCliModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;

public partial class PatientForm : System.Web.UI.Page 
{
    #region Variables declarations
    AriClinicContext ctx = null;
    User user = null;
    HealthcareCompany hc = null;
    Patient pat = null;
    Customer cus = null;
    int hcID = 0;
    int patientId = 0;
    Permission per = null;
    string type = "";

    #endregion Variables declarations
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
                            where p.Code == "patient"
                            select p).FirstOrDefault<Process>();
            per = CntAriCli.GetPermission(user.UserGroup, proc, ctx);
            btnAccept.Visible = per.Modify;
        }

        // 
        if (Request.QueryString["PatientId"] != null)
        {
            patientId = Int32.Parse(Request.QueryString["PatientId"]);
            pat = CntAriCli.GetPatient(patientId, ctx);
            LoadData(pat);
        }
        else
        {
            LoadSexCombo(null);
        }
        // 
        if (Request.QueryString["Type"] != null)
        {
            type = Request.QueryString["Type"];
            if (type == "InTab")
            {
                HtmlControl tt = (HtmlControl)this.FindControl("TitleArea");
                tt.Attributes["class"] = "ghost";
                tt = (HtmlControl)this.FindControl("Buttons0");
                tt.Attributes["class"] = "buttonsFomat0";
                btnCancel.Visible = false;
                btnCancel0.Visible = false;
            }
        }

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
    
    #region Page events (clics)
    protected void btnAccept_Click(object sender, ImageClickEventArgs e)
    {
        string command = "";
        if (pat == null)
            command = "CloseAndRebind('new')"; 
        else
            command = "CloseAndRebind('')"; 
        if (!CreateChange())
            return;
        if (type == "InTab")
        {
            lblMessage.Text = Resources.GeneralResource.RecordRefreshed;
            return;
        }
        RadAjaxManager1.ResponseScripts.Add(command);
    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        string command = "CancelEdit();";
        RadAjaxManager1.ResponseScripts.Add(command);
    }

    #endregion Page events (clics)

    #region Auxiliary functions
    protected bool DataOk()
    {
        if (rdcbSex.SelectedValue == "")
        {
            lblMessage.Text = Resources.GeneralResource.SexValueNeeded;
            return false;
        }
        if (rddpBornDate.SelectedDate == null) 
        {
            lblMessage.Text = Resources.GeneralResource.BornDateNeeded;
            return false;
        }
        return true;
    }

    /// <summary>
    /// As its name suggest if there isn't an object
    /// it'll create it. It exists modify it.
    /// </summary>
    /// <returns></returns>
    protected bool CreateChange()
    {
        if (!DataOk())
            return false;
        if (patientId == 0)
        {
            pat = new Patient();
            cus = new Customer();
            pat.Customer = cus;
            UnloadData(pat);
            ctx.Add(pat);
        }
        else
        {
            pat = CntAriCli.GetPatient(patientId, ctx);
            UnloadData(pat);
        }
        ctx.SaveChanges();
        return true;
    }

    protected void LoadData(Patient pat)
    {
        txtPatientId.Text = pat.PersonId.ToString();
        txtName.Text = pat.Name;
        txtSurname1.Text = pat.Surname1;
        txtSurname2.Text = pat.Surname2;
        rddpBornDate.SelectedDate = pat.BornDate;
        txtAge.Text = CntAriCli.CalulatedAge(pat.BornDate).ToString();
        LoadSexCombo(pat);
        txtVATIN.Text = pat.Customer.VATIN;
    }

    protected void UnloadData(Patient pat)
    {
        pat.Name = txtName.Text;
        pat.Surname1 = txtSurname1.Text;
        pat.Surname2 = txtSurname2.Text;
        pat.FullName = String.Format("{0} {1}, {2}", pat.Surname1, pat.Surname2, pat.Name);
        pat.Sex = rdcbSex.SelectedValue;
        pat.BornDate = (DateTime)rddpBornDate.SelectedDate;
        pat.Customer.VATIN = txtVATIN.Text;
        CntAriCli.UpdateCustomerRelatedData(pat, ctx);
    }

    protected void LoadSexCombo(Patient pat)
    {
        rdcbSex.Items.Clear();
        rdcbSex.Items.Add(new RadComboBoxItem(Resources.ConstantsResource.Man, "M"));
        rdcbSex.Items.Add(new RadComboBoxItem(Resources.ConstantsResource.Woman, "W"));
        rdcbSex.Items.Add(new RadComboBoxItem(Resources.ConstantsResource.Indeterminated, "I"));
        if (pat == null)
        {
            rdcbSex.Items.Add(new RadComboBoxItem(" ", ""));
            rdcbSex.SelectedValue = "";
        }
        else
        {
            rdcbSex.SelectedValue = pat.Sex;
        }
    }

    #endregion Auxiliary functions

    protected void RadAjaxManager1_AjaxRequest(object sender, AjaxRequestEventArgs e)
    {
        switch (e.Argument)
        {
            case "address":
                UscAddressGrid1.RefreshGrid(true);
                break;
            case "telephone":
                UscTelephoneGrid1.RefreshGrid(true);
                break;
            case "email":
                UscEmailGrid1.RefreshGrid(true);
                break;
        }
    }


}