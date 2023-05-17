using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodMoodApp
{
    public partial class FoodMoodForm : Form
    {
        public FoodMoodForm()
        {

            InitializeComponent();

            // FINAL PROJECT 
            // Hong K. Song 2110061
            // Michael Polizzi 2233832

            //Code to eliminate the automatic first row created
            dtFood.AllowUserToAddRows = false;
            dtMood.AllowUserToAddRows = false;


           

            //First Tab

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            // set the data field name for the column
            column1.DataPropertyName = "Name";
            // set the header text for the column
            column1.HeaderText = "Food Name";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            // set the data field name for the column
            column2.DataPropertyName = "Type";
            column2.HeaderText = "Type Of Food";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Portion";
            column3.HeaderText = "The Portion Size";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "Time";
            column4.HeaderText = "The Time";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "Mood";
            column5.HeaderText = "The Mood Before";

            // add the column to the dataFoodTable
            dtFood.Columns.Add(column1);
            dtFood.Columns.Add(column2);
            dtFood.Columns.Add(column3);
            dtFood.Columns.Add(column4);
            dtFood.Columns.Add(column5);


            //modified the DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
            dateTimePicker1.ShowUpDown = true;

            // Set the selection mode to FullRowSelect
            dtFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set the ReadOnly property to true to prevent editing
            dtFood.ReadOnly = true;


            //Second tab

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            // set the data field name for the column
            column6.DataPropertyName = "Name";
            // set the header text for the column
            column6.HeaderText = "Food Name";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            // set the data field name for the column
            column7.DataPropertyName = "Before";
            column7.HeaderText = "Before Eating";

            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.DataPropertyName = "After";
            column8.HeaderText = "After Eating";



            // add the column to the dataFoodTable
            dtMood.Columns.Add(column6);
            dtMood.Columns.Add(column7);
            dtMood.Columns.Add(column8);
        }

        private void btCheckMood_Click(object sender, EventArgs e)
        {
            // setting varible to call in the function button check mood 
            string Name = txtName.Text;
            string Type = txtType.Text;
            string Portion = txtPor.Text;
            TimeSpan Time = dateTimePicker1.Value.TimeOfDay;
         
            //alert for users didnt put any information to the box
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtType.Text) || string.IsNullOrEmpty(txtPor.Text) || cbMood.SelectedItem == null )
            {
                MessageBox.Show("Please input data for the following fields: "
                    + (string.IsNullOrEmpty(txtName.Text) ? "Name, " : "")
                +(string.IsNullOrEmpty(txtType.Text) ? "Type, " : "")
                + (string.IsNullOrEmpty(txtPor.Text) ? "Portion, " : "")
                + (cbMood.SelectedItem == null ? "Mood " : ""));

            }
            else
                   
            // else case for Mood 
            {
                //create varible to intilize the value into the table 
                string Mood = cbMood.SelectedItem.ToString();
                string Mood2 = cbMood.Text.ToLower();
                switch (Mood2)
                {
                    case "happy":
                        recommendationLabel.Text = "Have some chocolate cake!";
                        break;
                    case "sad":
                        recommendationLabel.Text = "Try some comforting mac and cheese.";
                        break;
                    case "stressed":
                        recommendationLabel.Text = "Some chamomile tea might help.";
                        break;
                    case "tired":
                        recommendationLabel.Text = "Get some energy with a smoothie.";
                        break;
                    default:
                        recommendationLabel.Text = "Sorry, we don't have a recommendation for that mood.";
                        break;

                }


                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtFood);
                row.Cells[0].Value = Name; // set the value of the first column to the data
                row.Cells[1].Value = Type; // set the value of the second column to the data
                row.Cells[2].Value = Portion; // set the value of the third column to the data
                row.Cells[3].Value = Time; // set the value of the four column to the data
                row.Cells[4].Value = Mood; // set the value of the fifth column to the data

                dtFood.Rows.Add(row);
                // Create a new row
                string selectedValue = cbMood.Text;
                int rowIndex = dtMood.Rows.Add();


                // Set the value of the first cell to the label's text
                dtMood.Rows[rowIndex].Cells[0].Value = txtName.Text;
                dtMood.Rows[rowIndex].Cells[1].Value = selectedValue;

            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            // Create a string to select the value to rate 
            string selectedValue2 = cbRate.Text;

            // Select the same row in the datagrid dtMood with if condition and alert
            if (dtMood.CurrentRow != null)
            {
                int rowIndex2 = dtMood.CurrentRow.Index;
                dtMood.Rows[rowIndex2].Cells[2].Value = selectedValue2;        
            }
            else
            {
                MessageBox.Show("There Is Nothing To Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            
        }

        private void ratingListButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            // iterate over all rows of the DataGridView
            int highestPortion = 0, lowestPortion = 11;
            string nameWithHighestPortion="None.", nameWithLowestPortion="None.";

            foreach (DataGridViewRow row in dtMood.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    break;
                }

                string name = row.Cells[0].Value.ToString();
                int portion = int.Parse(row.Cells[2].Value.ToString());


                // check if the dictionary already contains an entry with the same name
                if (dict.ContainsKey(name))
                {
                    // add the portion to the list associated with the name in the dictionary
                    dict[name].Add(portion);
                }
                else
                {
                    // add a new entry to the dictionary with the name and portion
                    dict[name] = new List<int> { portion };
                }
                // update the name with the highest portion
                if (portion > highestPortion)
                {
                    highestPortion = portion;
                    nameWithHighestPortion = name;
                }

                // update the name with the lowest portion
                if (portion < lowestPortion)
                {
                    lowestPortion = portion;
                    nameWithLowestPortion = name;
                }
            }

            // display a pop-up form window with the name with the highest portion and the name with the lowest portion
            string message = "Highest = " + nameWithHighestPortion + " - " + highestPortion + "\nLowest= " + nameWithLowestPortion + " - " + lowestPortion;
            MessageBox.Show(message, "The Highest Rating Food And The Lowest Rating Food For Mood");
        }

    }
}




