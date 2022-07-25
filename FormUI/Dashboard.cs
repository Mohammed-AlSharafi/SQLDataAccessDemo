using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        IPersonRepository personRepository;
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            personRepository = new PersonRepository();

            people = personRepository.GetPeople(lastNameText.Text);

            UpdateBinding();
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            personRepository = new PersonRepository();

            personRepository.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }
    }
}