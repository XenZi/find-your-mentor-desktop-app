using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SR38_2021_POP2022.resources.views.Schools
{
    /// <summary>
    /// Interaction logic for CreateUpdateSchoolWindow.xaml
    /// </summary>
    public partial class CreateUpdateSchoolWindow : Window
    {
        private LanguageService languageService;
        private SchoolService schoolService;
        private EWindowStatus status;
        private School school;
        public CreateUpdateSchoolWindow(EWindowStatus status, School school = null)
        {
            InitializeComponent();
            languageService = new LanguageService();
            schoolService = new SchoolService();
            this.status = status;
            this.school = school;
            InitializeListBox();
            MakeWindowChangesBasedByStatus();
            InitializeTextBoxValues();
        }

        private void InitializeListBox()
        {
            listLanguages.ItemsSource = languageService.GetAllLanguages();
            if (school == null)
            {
                return;
            }

            var foundedMatchingLanguages = languageService.GetAllLanguages().Where(language => school.AllLanguages.Contains(language));
            foreach(Language lang in foundedMatchingLanguages)
            {
                listLanguages.SelectedItems.Add(lang);
            }
        }

        private void MakeWindowChangesBasedByStatus()
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                this.Title = "Create new school";
                btnSubmit.Content = "Create";
            }
            else
            {
                this.Title = "Update current school";
                btnSubmit.Content = "Update";
            }
        }

        private void InitializeTextBoxValues()
        {
            if (school == null)
            {
                return;
            }
            txtName.Text = school.Name;
            txtCity.Text = school.Address.City;
            txtCountry.Text = school.Address.Country;
            txtNumber.Text = school.Address.Number.ToString();
            txtStreet.Text = school.Address.Street;
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                CreateNewSchool();
            }
            else
            {
                UpdateSchool();
            }
            this.DialogResult = true;
            this.Close();
        }

        private void CreateNewSchool()
        {
            List<Language> languages = listLanguages.SelectedItems.Cast<Language>().ToList();
            schoolService.Create(txtName.Text, txtStreet.Text, Int16.Parse(txtNumber.Text), txtCity.Text, txtCity.Text, languages);
        }

        private void UpdateSchool()
        {
            List<Language> languages = listLanguages.SelectedItems.Cast<Language>().ToList();
            schoolService.Update(school.Id, txtName.Text, txtStreet.Text, Int16.Parse(txtNumber.Text), txtCity.Text, txtCity.Text, languages);
        }
    }
}
