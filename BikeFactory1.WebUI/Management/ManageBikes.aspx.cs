using BikeFactory1.WebUI.BikeService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Policy;
using System.Web.Security;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.ServiceModel.Security;
using System.Net;

namespace BikeFactory1.WebUI.Management
{
    public partial class ManageBikes : System.Web.UI.Page
    {
        #region Support methods

        private void DisplayListOfBike()
        {
            var listOfBikes = new List<Bike>();
            try 
            { 
                listOfBikes = GetListOfBike_WS();
            } catch (Exception ex)
            {
                StaticMethods.DisplayMessage(ex.Message, this);
            }
            
            dgBikes.DataSource = listOfBikes;
            dgBikes.DataBind();

        }

        private void DisplayBike(Bike bike)
        {
            txtName.Text = bike.Name;
            ddlSuspensionType.SelectedIndex = (int)bike.SuspensionType;
            ddlTireType.SelectedIndex = (int)bike.TireType;

        }

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            ddlSuspensionType.SelectedIndex = 0;
            ddlTireType.SelectedIndex = 0;
        }

        private int FindColumn(string name)
        {
            int result = -1;
            for (int i = 0; i < dgBikes.Columns.Count; i++)
            {
                if (dgBikes.Columns[i] is BoundColumn)
                {
                    var boundColumn = (BoundColumn)dgBikes.Columns[i];
                    if (boundColumn.DataField == name)
                    {
                        result = i; break;
                    }
                }
            }
            return result;

        }
        #endregion

        #region WS proxy methods 

        private List<Bike> GetListOfBike_WS() 
        {
            var wsClient = new BikeServiceSoapClient();
            var wsResult = wsClient.GetList();
            return wsResult.ToList();
        }

        private void Insert(Bike bike)
        {
            var wsClient = new BikeServiceSoapClient();
            wsClient.Insert(bike);
        }

        private void Update(Bike bike)
        {
            var wsClient = new BikeServiceSoapClient();
            wsClient.Update(bike);
        }

        private void Delete(int bikeId)
        {
            var wsClient = new BikeServiceSoapClient();
            wsClient.Delete(bikeId);
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                DisplayListOfBike();
        }

        #region Buttons
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            var bike = new Bike();
            bike.Name = txtName.Text;
            bike.SuspensionType = (ESuspensionType)ddlSuspensionType.SelectedIndex;
            bike.TireType = (ETireType)ddlTireType.SelectedIndex;

            try
            {
                Insert(bike);
                ClearFields();
            }
            catch (Exception ex)
            {
                StaticMethods.DisplayMessage(ex.Message, this);

            }
            DisplayListOfBike();

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (dgBikes.SelectedIndex < 0)
            {
                StaticMethods.DisplayMessage("Please select a Bike", this);
                return;
            }
            try
            {
                var bike = new Bike();
                bike.Id = Convert.ToInt32(dgBikes.SelectedItem.Cells[FindColumn("Id")].Text);
                bike.Name = txtName.Text;
                bike.SuspensionType = (ESuspensionType)ddlSuspensionType.SelectedIndex;
                bike.TireType = (ETireType)ddlTireType.SelectedIndex;
                Update(bike);
                dgBikes.SelectedItem.Cells[FindColumn("Name")].Text = txtName.Text;
                dgBikes.SelectedItem.Cells[FindColumn("SuspensionType")].Text = ddlSuspensionType.Text;
                dgBikes.SelectedItem.Cells[FindColumn("TireType")].Text = ddlTireType.Text;

            }
            catch (Exception ex)
            {
                StaticMethods.DisplayMessage(ex.Message, this);
            }
        }
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgBikes.SelectedIndex < 0)
            {
                StaticMethods.DisplayMessage("Please select a bike", this);
                return;
            }

            try
            {
                int bikeId = Convert.ToInt32(dgBikes.SelectedItem.Cells[1].Text);
                Delete(bikeId);
                DisplayListOfBike();
                ClearFields();
            }
            catch (Exception ex)
            {
                StaticMethods.DisplayMessage(ex.Message, this);
            }
        }
        protected void lkbSignOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("/Default.aspx");
        }
        #endregion

        #region Validation
        protected void cvTireType_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = ddlTireType.SelectedIndex > 0;

        }
        protected void cvSuspensionType_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = ddlSuspensionType.SelectedIndex > 0;

        }
        #endregion
        protected void dgBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgBikes.SelectedIndex < 0)
                return;

            int bikeId = Convert.ToInt32(dgBikes.SelectedItem.Cells[FindColumn("Id")].Text);
            txtName.Text = dgBikes.SelectedItem.Cells[FindColumn("Name")].Text;
            var suspensionType = Enum.Parse(typeof(ESuspensionType), dgBikes.SelectedItem.Cells[FindColumn("SuspensionType")].Text);
            ddlSuspensionType.SelectedValue = (suspensionType).ToString();
            var tireType = Enum.Parse(typeof(ETireType), dgBikes.SelectedItem.Cells[FindColumn("TireType")].Text);
            ddlTireType.SelectedValue = (tireType).ToString();



        }
    }
}