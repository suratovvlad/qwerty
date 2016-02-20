﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRostelecom.DAO;

namespace TestRostelecom
{
    public partial class AddWindow : Form
    {

        private SecondaryRepository secondRep;
        private RequestDatabaseDataContext requestDBContext;
        private RequestRepository requestRepo;
        private bool isEditMode;
        private Requests requestToEdit;

        private void InitializeMembers(RequestDatabaseDataContext _requestDbContext, RequestRepository _requestRepo, SecondaryRepository _secondaryRepo)
        {
            isEditMode = false;
            requestToEdit = null;
            requestDBContext = _requestDbContext;
            requestRepo = _requestRepo;
            secondRep = _secondaryRepo;
        }

        private void InitializeComboBoxes()
        {
            IList listServies = secondRep.GetServicesList();
            comboBoxServies.DataSource = listServies;
            comboBoxServies.DisplayMember = "Name";
            comboBoxServies.ValueMember = "Id";

            IList listOperations = secondRep.GetOperatorsList();
            comboBoxOperators.DataSource = listOperations;
            comboBoxOperators.DisplayMember = "FullName";
            comboBoxOperators.ValueMember = "Id";

            IList listMasters = secondRep.GetMastersList();
            comboBoxMasters.DataSource = listMasters;
            comboBoxMasters.DisplayMember = "FullName";
            comboBoxMasters.ValueMember = "Id";
        }

        public AddWindow(RequestDatabaseDataContext _requestDbContext, RequestRepository _requestRepo, SecondaryRepository _secondaryRepo)
        {
            InitializeComponent();
            InitializeMembers(_requestDbContext, _requestRepo, _secondaryRepo);
            InitializeComboBoxes();
        }

        public AddWindow(Requests request, RequestDatabaseDataContext _requestDbContext, RequestRepository _requestRepo, SecondaryRepository _secondaryRepo)
        {
            InitializeComponent();
            InitializeMembers(_requestDbContext, _requestRepo, _secondaryRepo);
            InitializeComboBoxes();
            
            // Fill TextBoxes
            textBoxClient.Text = request.Clients.FullName;
            textBoxAdress.Text = request.Address;
            textBoxComment.Text = request.Comment;

            // Fill ComboBoxes
            comboBoxServies.SelectedIndex = comboBoxServies.FindStringExact(request.Services.Name);
            comboBoxOperators.SelectedIndex = comboBoxOperators.FindStringExact(request.Operators.FullName);
            comboBoxMasters.SelectedIndex = comboBoxMasters.FindStringExact(request.Masters.FullName);

            // Fill DateTimePickers
            dateTimePicker1.Value = request.RequestDate;

            //! TODO: FIX IT
            //! NULLABLE TO DateTimePicker
            //dateTimePicker2.Value = request.CloseDate.GetValueOrDefault(null);
            //dateTimePicker3.Value = request.DateOfDeparture.Value;

            buttonAdd.Text = "Изменить";
            isEditMode = true;
            requestToEdit = request;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            //IList<Masters> masters = secondRep.GetMastersList();

            if ((textBoxClient.Text == "") || (textBoxAdress.Text == ""))
            {
                // TODO: CHANGE IT
                MessageBox.Show("!!!Блять напиши что нибудь в пустые текст боксы!!!");
            }
            else
            {
                Clients client = new Clients();
                client.FullName = textBoxClient.Text;

                if (secondRep.GetClientByFullName(textBoxClient.Text) == null)
                {
                    secondRep.CreateClient(client);
                }

                if (isEditMode)
                {
                    requestToEdit.Clients = requestDBContext.Clients.Single(x => x.Id == secondRep.GetClientByFullName(textBoxClient.Text).Id);
                    requestToEdit.Masters = requestDBContext.Masters.Single(x => x.Id == ((Masters)comboBoxMasters.SelectedItem).Id);
                    requestToEdit.Operators = requestDBContext.Operators.Single(x => x.Id == ((Operators)comboBoxOperators.SelectedItem).Id);
                    requestToEdit.Services = requestDBContext.Services.Single(x => x.Id == ((Services)comboBoxServies.SelectedItem).Id);

                    requestToEdit.Comment = textBoxComment.Text;
                    requestToEdit.Address = textBoxAdress.Text;
                    requestToEdit.RequestDate = dateTimePicker1.Value;
                    requestToEdit.CloseDate = dateTimePicker2.Value;
                    requestToEdit.DateOfDeparture = dateTimePicker3.Value;

                    requestDBContext.SubmitChanges();
                    //requestRepo.UpdateRequest(requestToEdit);
                }
                else
                {
                    Requests request = new Requests();

                    request.ClientId = secondRep.GetClientByFullName(textBoxClient.Text).Id;
                    request.MasterId = ((Masters)comboBoxMasters.SelectedItem).Id;
                    request.OperatorId = ((Operators)comboBoxOperators.SelectedItem).Id;
                    request.ServiceId = ((Services)comboBoxServies.SelectedItem).Id;
                    request.Comment = textBoxComment.Text;
                    request.Address = textBoxAdress.Text;
                    request.RequestDate = dateTimePicker1.Value;
                    request.CloseDate = dateTimePicker2.Value;
                    request.DateOfDeparture = dateTimePicker3.Value;

                    requestRepo.CreateRequest(request);
                }
                
            }
        }
    }
}
