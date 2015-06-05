using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlServerCe;
using System.Collections;
using System.Diagnostics;
using ChartFX.WinForms;
using ChartFX.WinForms.Annotation;
using ChartFX.WinForms.Adornments;
using ChartFX.WinForms.Galleries;
using ChartFX.WinForms.Internal.UI;
using SoftwareFX.WinForms;
using SoftwareFX.WinForms.Data;
using SoftwareFX.WinForms.Data.Expressions;

namespace SoftwareFX.Samples._Business_CLR_Objects
{
    public partial class Form1 : Form
    {
	

        public Form1()
        {
            InitializeComponent();

            //Cosmetic code
            new SampleTemplate.TemplateForm(this, "Business (CLR) Objects", "Chart FX supports reading data from a Business Object. In this case, we have created a class containing the&nbsp;data (Department) and used the ListProvider to populate Chart FX with multiple instances of the class.");
            DoubleBuffered = true;
        }

        #region Data Population Functions
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSamples.Items.Clear();
            comboBoxSamples.Items.Add("Business Objects");
            
            comboBoxSamples.SelectedIndex = 0;
        }

        private void comboBoxSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Reset();
            string sampleName = comboBoxSamples.Items[comboBoxSamples.SelectedIndex].ToString();
            string functionName = getFunctionName(sampleName);
            Type thisClass = typeof(Form1);
            thisClass.InvokeMember(functionName,BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,null,this,null);
        }

        private string getFunctionName(string sampleName)
        {
            string functionName = "";
            sampleName = sampleName.Replace("-", " ").Trim();
            string[] words = sampleName.Split(' ');
            foreach (string word in words)
                functionName += char.ToUpper(word[0]) + word.Substring(1);

            return functionName;
        }

        #region Chart Functions
        private void BusinessObjects()
	{
            chart1.Gallery = Gallery.Bar;
            chart1.Titles.Add(new TitleDockable("Expenses vs. Budget by Department"));
            chart1.AxisY.LabelsFormat.Format = AxisFormat.Currency;
            
            Department[] departments = new Department[5];
            departments[0] = new Department("Human Resources", 1500000, 1000000);
            departments[1] = new Department("Sales", 1200000, 800000);
            departments[2] = new Department("Marketing", 4500000, 5000000);
            departments[3] = new Department("Development", 7320000, 5310000);
            departments[4] = new Department("Other", 150000, 100000);
            
            ListProvider lstProvider = new ListProvider(departments);
            chart1.DataSourceSettings.DataSource = lstProvider;
        }

                
        #endregion

    }

    #region Data Classes
    class Department
        {
            private string _name;
            private double _budget;
            private double _expenses;
    
            public Department(string name, double budget, double expenses)
            {
                _name = name;
                _budget = budget;
                _expenses = expenses;
            }
    
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
    
            public double Budget
            {
                get { return _budget; }
                set { _budget = value; }
            }
    
            public double Expenses
            {
                get { return _expenses; }
                set { _expenses = value; }
            }
        }

    
    #endregion
}