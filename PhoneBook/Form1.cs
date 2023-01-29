using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Drawing.Printing;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        private static SQLiteConnection DB;
        SQLiteDataReader sqlread;
        SQLiteCommand CMD;
        string path;
        string path2;
        string fullpath;
        string searchtext;
        int sortcheck = 0;
        int searchcheck = 0;
        int depcheck = 0;
        int orgcheck = 0;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchtext = textBox1.Text;
            listView1.Items.Clear();

            CMD = DB.CreateCommand();
            CMD.CommandText =
                $"select users.FIO, department.department_name, organization.organization_name, positions.positions_name, 'ул. ' || addresses.street || ', д.' || addresses.number, rooms.room_name, external_phones.phone_number, internal_phone.internal_phone_number from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses where users.FIO like '%{searchtext}%' or department.department_name like '%{searchtext}%' or organization.organization_name like '%{searchtext}%' or positions.positions_name like '%{searchtext}%'";
            ShowData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //получаем путь к файлу базы данных на компьютере
            path = "PhoneBookMainDB.db";
            path2 = Path.GetFullPath(path);
            fullpath = path2.Replace(@"\", @"\\");

            //подключаемся к базе данных
            DB = new SQLiteConnection("Data Source = " + fullpath);
            DB.Open();

            //Заполняем ComboBox фильтра по организациям
            OrganizatrionFilter.Items.Clear();
            OrganizatrionFilter.Items.Add("Без фильтра по организациям");
            OrganizatrionFilter.SelectedItem = "Без фильтра по организациям";


            CMD = DB.CreateCommand();
            CMD.CommandText =
                "select organization.organization_name from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses";
            sqlread = CMD.ExecuteReader();

            while (sqlread.Read())
            {
                OrganizatrionFilter.Items.Add(Convert.ToString(sqlread["organization_name"]));
            }
            sqlread.Close();


            DepartmentFilter.Items.Clear();
            DepartmentFilter.Items.Add("Без фильтра по отделам");
            DepartmentFilter.SelectedItem = "Без фильтра по отделам";

            CMD = DB.CreateCommand();
            CMD.CommandText =
                "select department.department_name from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses";
            sqlread = CMD.ExecuteReader();

            while (sqlread.Read())
            {
                DepartmentFilter.Items.Add(Convert.ToString(sqlread["department_name"]));
            }
            sqlread.Close();


            comboBox2.Items.Clear();
            comboBox2.Items.Add("Без сортировки");
            comboBox2.Items.Add("Сортировка по алфавиту(ФИО)");
            comboBox2.SelectedItem = "Без сортировки";

            listView1.Items.Clear();
            CMD = DB.CreateCommand();
            CMDStandartText();
            ShowData();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            DB.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedItem)
            {
                case "Без сортировки":
                    listView1.Items.Clear();
                    CMDStandartText();
                    ShowData();
                    break;
                case "Сортировка по алфавиту(ФИО)":
                    sortcheck = 1;
                    listView1.Items.Clear();
                    AlphabetSort();
                    ShowData();
                    break;
            }
        }


        private void NoSort()
        {

        }

        private void CMDStandartText()
        {
            CMD = DB.CreateCommand();
            CMD.CommandText =
                "select users.FIO, department.department_name, organization.organization_name, positions.positions_name, 'ул. ' || addresses.street || ', д.' || addresses.number, rooms.room_name, external_phones.phone_number, internal_phone.internal_phone_number from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses";
        }

        private void AlphabetSort()
        {
            CMD = DB.CreateCommand();
            CMD.CommandText =
                "select users.FIO, department.department_name, organization.organization_name, positions.positions_name, 'ул. ' || addresses.street || ', д.' || addresses.number, rooms.room_name, external_phones.phone_number, internal_phone.internal_phone_number from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses Order by users.FIO";
        }

        private void Search()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrganizatrionFilter.SelectedItem == "Без фильтра по организациям")
            {
                listView1.Items.Clear();
                CMDStandartText();
                ShowData();
            }
            else
            {
                listView1.Items.Clear();
                string orgFilterSelect = OrganizatrionFilter.SelectedItem.ToString();
                CMD = DB.CreateCommand();
                CMD.CommandText =
                    $"select users.FIO, department.department_name, organization.organization_name, positions.positions_name, 'ул. ' || addresses.street || ', д.' || addresses.number, rooms.room_name, external_phones.phone_number, internal_phone.internal_phone_number from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses where organization.organization_name like '{orgFilterSelect}'";
                ShowData();
            }
        }

        private void DepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentFilter.SelectedItem == "Без фильтра по отделам")
            {
                listView1.Items.Clear();
                CMDStandartText();
                ShowData();
            }
            else
            {
                listView1.Items.Clear();
                string depFilterSelect = DepartmentFilter.SelectedItem.ToString();
                CMD = DB.CreateCommand();
                CMD.CommandText =
                    $"select users.FIO, department.department_name, organization.organization_name, positions.positions_name, 'ул. ' || addresses.street || ', д.' || addresses.number, rooms.room_name, external_phones.phone_number, internal_phone.internal_phone_number from users inner join phonebook on users.id_users = phonebook.id_users inner join organization on phonebook.id_organization = organization.id_organization inner join phonebook_external_phone on phonebook.id_phonebook = phonebook_external_phone.id_phonebook inner join external_phones on phonebook_external_phone.id_external_phones = external_phones.id_external inner join positions on users.id_positions = positions.id_posit inner join phonebook_internal_phone on phonebook.id_phonebook = phonebook_internal_phone.id_internal_phone inner join internal_phone on phonebook_internal_phone.id_internal_phone = internal_phone.id_internal_phone inner join department on users.id_users = department.id_users inner join rooms on phonebook.id_rooms = rooms.id_rooms inner join addresses on rooms.id_addresses = addresses.id_addresses where department_name like '{depFilterSelect}'";
                ShowData();
            }
        }

        private void ShowData()
        {
            sqlread = CMD.ExecuteReader();
            while (sqlread.Read())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(sqlread["FIO"]));
                item.SubItems.Add(Convert.ToString(sqlread["department_name"]));
                item.SubItems.Add(Convert.ToString(sqlread["organization_name"]));
                item.SubItems.Add(Convert.ToString(sqlread["positions_name"]));
                item.SubItems.Add(Convert.ToString(sqlread["'ул. ' || addresses.street || ', д.' || addresses.number"]));
                item.SubItems.Add(Convert.ToString(sqlread["room_name"]));
                item.SubItems.Add(Convert.ToString(sqlread["phone_number"]));
                item.SubItems.Add(Convert.ToString(sqlread["internal_phone_number"]));
                listView1.Items.Add(item);
            }
            sqlread.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void PrintHandler(object sender, PrintPageEventArgs e)
        {
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CMDStandartText();
            ShowData();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }
    }
}