﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Obtain reference of selected item
            string item = checkedListBox1.SelectedItem.ToString();

            // If item checked, add to ListBox
            // otherwise remove from ListBox
            if (e.NewValue == CheckState.Checked)
            {
                displaylistBox.Items.Add(item);
            }
            else
            {
                displaylistBox.Items.Remove(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Green;
        }

        private void size12RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 12);
        }

        private void size16RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 16);
        }

        private void size20RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 20);
        }

        private void helloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!";
        }

        private void goodbyeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Goodbye!";
        }
    }
}
