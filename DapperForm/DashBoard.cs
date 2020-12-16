using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperForm
{
    public partial class DashBoard : Form
    {
        List<Person> people = new List<Person>();

        public DashBoard()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);

            UpdateBinding();
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            {
                db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAdressInsText.Text, phoneNumberInsText.Text);
                firstNameInsText.Text = "";
                lastNameInsText.Text = "";
                emailAdressInsText.Text = "";
                phoneNumberInsText.Text =  "";
            }
        }
    }
}
