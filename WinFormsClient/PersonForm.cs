﻿using DataAccessors.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class PersonForm : Form
    {
        public Person Result { get; set; }

        public PersonForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            DateTime dt = dateTimePicker.Value;

            Person p = new Person { ID = id, Name = name, LastName = lastName, DayOfBirth = dt };
            Result = p;

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
