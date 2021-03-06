<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminationAssignedGrid.aspx.cs" Inherits="ExaminationAssignedGrid" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>
      Exploraciones asignadas
    </title>
    <telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
    <link href="AriClinicStyle.css" rel="stylesheet" type="text/css" />
    <link href="dialog_box.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" type="image/x-icon" href="favicon.ico"/>
  </head>
  <body id="content">
    <form id="form1" runat="server">
      <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
          <%--Needed for JavaScript IntelliSense in VS2010--%>
          <%--For VS2008 replace RadScriptManager with ScriptManager--%>
          <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
          <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
          <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
      </telerik:RadScriptManager>
      <telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
                                meta:resourcekey="RadWindowManager1Resource1">
      </telerik:RadWindowManager>
      <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <script type ="text/javascript" src="GeneralFormFunctions.js"></script>
        <script type="text/javascript">
          // In order to show item changes in the grid
          function refreshGrid(arg)
          {
              //alert("Hello from refreshGrid");
              if (!arg)
              {
                  $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("");
              }
              else
              {
                  $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("new");
              }
          }
          function NewExaminationAssignedRecord()
          {
              var combo = $find("<%= rdcExaminationType.ClientID %>");
              var examType = combo.get_value();
              var w1;
              switch (examType)
              {
                  case "general":
                      w1 = window.open("ExaminationAssignedForm.aspx", "EAGRD", "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "refractometry":
                      w1 = window.open("RefractometryForm.aspx", "EAGRD", "width=800, height=700,resizable=1");
                      w1.focus();
                      break;
                  case "biometry":
                      w1 = window.open("BiometryForm.aspx", "EAGRD", "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "paquimetry":
                      w1 = window.open("PaquimetryForm.aspx", "EAGRD", "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "topography":
                      w1 = window.open("TopographyForm.aspx", "EAGRD", "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }
          }
          function EditExaminationAssignedRecord(id, examType)
          {
              var w2;
              switch (examType)
              {
                  case "general":
                      w2 = window.open("ExaminationAssignedForm.aspx?ExaminationAssignedId=" + id, "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "refractometry":
                      w2 = window.open("RefractometryForm.aspx?ExaminationAssignedId=" + id, "EAGRD",
                                       "width=800, height=700,resizable=1");
                      w2.focus();
                      break;
                  case "biometry":
                      w2 = window.open("BiometryForm.aspx?ExaminationAssignedId=" + id, "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "paquimetry":
                      w2 = window.open("PaquimetryForm.aspx?ExaminationAssignedId=" + id, "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "topography":
                      w2 = window.open("TopographyForm.aspx?ExaminationAssignedId=" + id, "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }

          }
          function NewExaminationAssignedRecordInTab()
          {
              var combo = $find("<%= rdcExaminationType.ClientID %>");
              var examType = combo.get_value();
              var w1;
              switch (examType)
              {
                  case "general":
                      w1 = window.open("ExaminationAssignedForm.aspx?PatientId=" + gup('PatientId'), "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "refractometry":
                      w1 = window.open("RefractometryForm.aspx?PatientId=" + gup('PatientId'), "EAGRD",
                                       "width=800, height=700,resizable=1");
                      w1.focus();
                      break;
                  case "biometry":
                      w1 = window.open("BiometryForm.aspx?PatientId=" + gup('PatientId'), "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "paquimetry":
                      w1 = window.open("PaquimetryForm.aspx?PatientId=" + gup('PatientId'), "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "topography":
                      w1 = window.open("TopographyForm.aspx?PatientId=" + gup('PatientId'), "EAGRD",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }

          }
          function EditExaminationAssignedRecordInTab(id, examType)
          {
              var w2;
              switch (examType)
              {
                  case "general":
                      w2 = window.open("ExaminationAssignedForm.aspx?PatientId=" + gup('PatientId') +
                                       "&ExaminationAssignedId=" + id, "EAGRD", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "refractometry":
                      w2 = window.open("RefractometryForm.aspx?PatientId=" + gup('PatientId') +
                                       "&ExaminationAssignedId=" + id, "EAGRD", "width=800, height=700,resizable=1");
                      w2.focus();
                      break;
                  case "biometry":
                      w2 = window.open("BiometryForm.aspx?PatientId=" + gup('PatientId') +
                                       "&ExaminationAssignedId=" + id, "EAGRD", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "paquimetry":
                      w2 = window.open("PaquimetryForm.aspx?PatientId=" + gup('PatientId') +
                                       "&ExaminationAssignedId=" + id, "EAGRD", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "topography":
                      w2 = window.open("TopographyForm.aspx?PatientId=" + gup('PatientId') +
                                       "&ExaminationAssignedId=" + id, "EAGRD", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }
          }

          function NewExaminationAssignedRecordInVisit()
          {
              var combo = $find("<%= rdcExaminationType.ClientID %>");
              var examType = combo.get_value();
              var w1;
              switch (examType)
              {
                  case "general":
                      w1 = window.open("ExaminationAssignedForm.aspx?VisitId=" + gup('VisitId'), "EXAMVISIT",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "refractometry":
                      w1 = window.open("RefractometryForm.aspx?VisitId=" + gup('VisitId'), "EXAMVISIT",
                                       "width=800, height=700,resizable=1");
                      w1.focus();
                      break;
                  case "biometry":
                      w1 = window.open("BiometryForm.aspx?VisitId=" + gup('VisitId'), "EXAMVISIT",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "paquimetry":
                      w1 = window.open("PaquimetryForm.aspx?VisitId=" + gup('VisitId'), "EXAMVISIT",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  case "topography":
                      w1 = window.open("TopographyForm.aspx?VisitId=" + gup('VisitId'), "EXAMVISIT",
                                       "width=600, height=500,resizable=1");
                      w1.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }

          }
          function EditExaminationAssignedRecordInVisit(id, examType)
          {
              var w2;
              switch (examType)
              {
                  case "general":
                      w2 = window.open("ExaminationAssignedForm.aspx?VisitId=" + gup('VisitId') +
                                       "&ExaminationAssignedId=" + id, "EXAMVISIT", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "refractometry":
                      w2 = window.open("RefractometryForm.aspx?VisitId=" + gup('VisitId') +
                                       "&ExaminationAssignedId=" + id, "EXAMVISIT", "width=800, height=700,resizable=1");
                      w2.focus();
                      break;
                  case "biometry":
                      w2 = window.open("BiometryForm.aspx?VisitId=" + gup('VisitId') +
                                       "&ExaminationAssignedId=" + id, "EXAMVISIT", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "paquimetry":
                      w2 = window.open("PaquimetryForm.aspx?VisitId=" + gup('VisitId') +
                                       "&ExaminationAssignedId=" + id, "EXAMVISIT", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  case "topography":
                      w2 = window.open("TopographyForm.aspx?VisitId=" + gup('VisitId') +
                                       "&ExaminationAssignedId=" + id, "EXAMVISIT", "width=600, height=500,resizable=1");
                      w2.focus();
                      break;
                  default:
                      alert("Type " + examType + " not defined");
              }
          }

          function CloseWindow()
          {
              window.close();
          }
          // To return selected values to caller 
          function Selection(v1, v2, v3, v4, type)
          {
              window.opener.refreshField(v1, v2, v3, v4, type);
              window.close();
              return false;
          }
        </script>
        <script type="text/javascript" src="dialog_box.js">
        </script>
        <script type="text/javascript">
          function ariDialog(title, message, type, modal, width, height)
          {
              showDialog(title, message, type, modal, width, height);
              setTimeout("ObtainSelected()", 100);
          }

          function ObtainSelected(tag)
          {
              if (DLGRESULT == 0)
                  setTimeout("ObtainSelected()", 100); // continue asking
              else if (DLGRESULT == 1) // accept
              {
                  //process value
                  $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("yes");
              }
              else //cancel;
              {
                  $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("no");
              }
              return;
          }
        </script>
      </telerik:RadScriptBlock>
      <telerik:RadToolTipManager ID="RadToolTipManager1" runat="server" 
                                 AutoTooltipify="True" RelativeTo="Element" 
                                 Position="TopCenter" meta:resourcekey="RadToolTipManager1Resource1" >
      </telerik:RadToolTipManager>
      <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                                   Skin="Office2007">
      </telerik:RadAjaxLoadingPanel>
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" 
                              onajaxrequest="RadAjaxManager1_AjaxRequest" 
                              meta:resourcekey="RadAjaxManager1Resource1">
        <AjaxSettings>
          <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
            <UpdatedControls>
              <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
            </UpdatedControls>
          </telerik:AjaxSetting>
        </AjaxSettings>
      </telerik:RadAjaxManager>
      <telerik:RadSkinManager ID="RadSkinManager1" Runat="server" Skin="Office2007">
      </telerik:RadSkinManager>
      <div ></div>
      <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Width="100%" 
                            HorizontalAlign="NotSet" 
                            meta:resourcekey="RadAjaxPanel1Resource1" LoadingPanelID="RadAjaxLoadingPanel1">
        <div id="TitleArea" class="titleBar2" runat="server">
          <img alt="minilogo" src="images/mini_logo.png" align="middle" />

          <asp:Label ID="lblTitle" runat="server" Text="Exploraciones asignadas" 
                     meta:resourcekey="lblTitleResource1"></asp:Label>
        </div>
        <div id="ExaminationType" class="optionsText">
          <asp:Label ID="lblExaminationType" runat="server" Text="Elija tipo para nuevos registros: "></asp:Label>
          <br />
          <telerik:RadComboBox ID="rdcExaminationType" runat="server" Width="100%" 
                               EnableLoadOnDemand="true" ShowMoreResultsBox="true" EnableVirtualScrolling="true"
                               ItemsPerRequest="10" Height="100px">
          </telerik:RadComboBox>
        </div>
        <div id="GridArea" class="normalText" style="width:100%">
          <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Office2007" 
                           AllowPaging="True" AllowFilteringByColumn="True" 
                           AllowSorting="True" ShowGroupPanel="True"
                           onitemcommand="RadGrid1_ItemCommand" onitemdatabound="RadGrid1_ItemDataBound" 
                           onneeddatasource="RadGrid1_NeedDataSource" GridLines="None"
                           meta:resourcekey="RadGrid1Resource1">
            <GroupingSettings CaseSensitive="False" />
            <ClientSettings AllowDragToGroup="True">
            </ClientSettings>
            <MasterTableView AutoGenerateColumns="False" CommandItemDisplay="Top" 
                             DataKeyNames="ExaminationAssignedId">
              <CommandItemSettings ExportToPdfText="Export to Pdf" />
              <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
              </RowIndicatorColumn>
              <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
              </ExpandCollapseColumn>
              <Columns>
                <telerik:GridBoundColumn DataField="ExaminationAssignedId" DataType="System.Int32" 
                                         FilterControlToolTip="Filtrar por ID" FilterImageToolTip="Filtro"
                                         HeaderText="ID" 
                                         meta:resourceKey="GridBoundColumnResource1" ReadOnly="True" 
                                         SortExpression="ExaminationAssignedId" UniqueName="ExaminationAssignedId">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Patient.FullName" 
                                         FilterControlToolTip="Filtrar por nombre" FilterImageToolTip="Filtro"
                                         HeaderText="Paciente" 
                                         meta:resourceKey="GridBoundColumnResource2" ReadOnly="True" 
                                         SortExpression="Patient.FullName" UniqueName="Patient.FullName">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="ExaminationDate" DataType="System.DateTime" DataFormatString="{0:dd/MM/yyyy}" 
                                         FilterControlToolTip="Filtrar por fecha de diagnóstico" FilterImageToolTip="Filtro"
                                         HeaderText="Fecha" 
                                         meta:resourceKey="GridBoundColumnResource2" ReadOnly="True" 
                                         SortExpression="ExaminationDate" UniqueName="ExaminationDate">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Examination.Name" 
                                         FilterControlToolTip="Filtrar por exploración" FilterImageToolTip="Filtro"
                                         HeaderText="Exploración" 
                                         meta:resourceKey="GridBoundColumnResource2" ReadOnly="True" 
                                         SortExpression="Examination.Name" UniqueName="Examination.Name">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Comments" 
                                         FilterControlToolTip="Filtrar por exploración" FilterImageToolTip="Filtro"
                                         HeaderText="Resumen" 
                                         meta:resourceKey="GridBoundColumnResource2" ReadOnly="True" 
                                         SortExpression="Comments" UniqueName="Comments">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Examination.ExaminationType.Code" 
                                         FilterControlToolTip="Filtrar por exploración" FilterImageToolTip="Filtro"
                                         HeaderText="Codigo Tipo" 
                                         meta:resourceKey="GridBoundColumnResource2" ReadOnly="True" Visible="false"
                                         SortExpression="Examination.ExaminationType.Code"
                                         UniqueName="Examination.ExaminationType.Code">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" 
                                            FilterControlAltText="Filter Template column" HeaderText="Acciones" 
                                            meta:resourceKey="GridTemplateColumnResource1" UniqueName="Template">
                  <ItemTemplate>
                    <asp:ImageButton ID="Select" runat="server" 
                                     ImageUrl="~/images/document_gear_16.png" meta:resourceKey="SelectResource1" 
                                     ToolTip="Seleccionar este registro y volver con su información" />
                    <asp:ImageButton ID="Edit" runat="server" 
                                     ImageUrl="~/images/document_edit_16.png" meta:resourceKey="EditResource1" 
                                     ToolTip="Editar este registro" />
                    <asp:ImageButton ID="Delete" runat="server" 
                                     ImageUrl="~/images/document_delete_16.png" meta:resourceKey="DeleteResource1" 
                                     ToolTip="Eliminar este registro" />
                  </ItemTemplate>
                </telerik:GridTemplateColumn>
              </Columns>
              <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
              </EditFormSettings>
              <CommandItemTemplate>
                <div ID="ButtonAdd" style="padding:2px;">
                  <asp:ImageButton ID="New" runat="server" ImageUrl="~/images/document_add.png" 
                                   meta:resourceKey="NewResource1" OnClientClick="NewExaminationAssignedRecord();" 
                                   ToolTip="Añadir un nuevo registro" />
                  <asp:ImageButton ID="Exit" runat="server" ImageUrl="~/images/document_out.png" 
                                   meta:resourceKey="ExitResource1" OnClientClick="CloseWindow();" 
                                   ToolTip="Salir sin cambios" />
                </div>
              </CommandItemTemplate>
            </MasterTableView>
            <FilterMenu EnableImageSprites="False">
            </FilterMenu>
            <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Office2007">
            </HeaderContextMenu>
          </telerik:RadGrid>
        </div>

        <div id="Separator">
          &nbsp;
        </div>
        <div id="Messages" class="messageText" style="width:100%">
          <asp:Label ID="lblMessage" runat="server" Text="Mensajes" 
                     meta:resourcekey="lblMessageResource1"></asp:Label>
        </div>
      </telerik:RadAjaxPanel>
    </form>
  </body>
</html>
