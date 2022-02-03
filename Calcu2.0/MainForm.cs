/*
 * Created by SharpDevelop.
 * User: alumno
 * Date: 02/02/2022
 * Time: 08:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcu2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmCalculadora : Form
	{
		public frmCalculadora()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmCalculadoraLoad(object sender, EventArgs e)
		{
	
		}
		
		string op = " ";
		double var1 = 0;
		void Btn1Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "1";
		}
		void Btn2Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "2";
		}
		void Btn3Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "3";
		}
		void Btn4Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "4";
		}
		void Btn5Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "5";
		}
		void Btn6Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "6";
		}
		void Btn7Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "7";
		}
		void Btn8Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "8";
		}
		void Btn9Click(object sender, EventArgs e)
		{
			txtTextBox.Text += "9";
		}
		void Btn0Click(object sender, EventArgs e)
		{
			if (txtTextBox.Text!="0" && txtTextBox.Text!="") txtTextBox.Text += "0";
		}
		void BtnBorrarClick(object sender, EventArgs e)
		{
			var1=0;
			txtTextBox.Text = "";
		}
		void BtnSumarClick(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(txtTextBox.Text);
			txtTextBox.Text = "";
			op="+";
		}
		void BtnRestarClick(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(txtTextBox.Text);
			txtTextBox.Text = "";
			op="-";
		}
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(txtTextBox.Text);
			txtTextBox.Text = "";
			op="*";
		}
		void BtnDividirClick(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(txtTextBox.Text);
			txtTextBox.Text = "";
			op="/";
		}
		void BtnRaizClick(object sender, EventArgs e)
		{
			txtTextBox.Text = (Math.Sqrt(Convert.ToDouble(txtTextBox.Text))).ToString();
		}
		void BtnIgualClick(object sender, EventArgs e)
		{
			switch(op)
			{
					case "+": txtTextBox.Text = (var1+Convert.ToDouble(txtTextBox.Text)).ToString(); break;
					case "-": txtTextBox.Text = (var1-Convert.ToDouble(txtTextBox.Text)).ToString(); break;
					case "*": txtTextBox.Text = (var1*Convert.ToDouble(txtTextBox.Text)).ToString(); break;
					case "/": txtTextBox.Text = (var1/Convert.ToDouble(txtTextBox.Text)).ToString(); break;
			}
		}
		void BtnDecimalClick(object sender, EventArgs e)
		{
			if (!txtTextBox.Text.Contains(","))
			    {
			    	txtTextBox.Text += ",";
			    }
		}
		
	}
}
