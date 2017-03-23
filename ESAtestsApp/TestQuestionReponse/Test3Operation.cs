using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace ESAtestsApp
{
    public partial class Test3OperationForm : Form
    {
        private CalculTest TestEnCours;
        private string OperationChoisie;

        public Test3OperationForm()
        {
            InitializeComponent();
        }

        public Test3OperationForm(CalculTest LeTest)
        {
            InitializeComponent();
            TestEnCours = LeTest;
        }


        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //Affichage du form Menu Principal
            MenuForm Menu = new MenuForm();
            Menu.Show();
            this.Hide();
        }

        private void Test3OperationForm_Load(object sender, EventArgs e)
        {
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            OperationChoisie = "addition";
            Test3QuestionForm QR = new Test3QuestionForm(TestEnCours, OperationChoisie);
            QR.Show();
            this.Hide();
        }

        private void SoustractionBtn_Click(object sender, EventArgs e)
        {
            OperationChoisie = "soustraction";
            Test3QuestionForm QR = new Test3QuestionForm(TestEnCours, OperationChoisie);
            QR.Show();
            this.Hide();
        }

        private void Multiplicationbtn_Click(object sender, EventArgs e)
        {
            OperationChoisie = "multiplication";
            Test3QuestionForm QR = new Test3QuestionForm(TestEnCours, OperationChoisie);
            QR.Show();
            this.Hide();
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            OperationChoisie = "division";
            Test3QuestionForm QR = new Test3QuestionForm(TestEnCours, OperationChoisie);
            QR.Show();
            this.Hide();
        }
        private void Test3Operation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
