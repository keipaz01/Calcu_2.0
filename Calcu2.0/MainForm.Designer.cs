/*
 * Created by SharpDevelop.
 * User: alumno
 * Date: 02/02/2022
 * Time: 08:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calcu2._
{
	partial class frmCalculadora
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtTextBox;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnIgual;
		private System.Windows.Forms.Button btnRaiz;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnDecimal;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
			this.txtTextBox = new System.Windows.Forms.TextBox();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btnRaiz = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnDecimal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTextBox
			// 
			this.txtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTextBox.Location = new System.Drawing.Point(38, 25);
			this.txtTextBox.Multiline = true;
			this.txtTextBox.Name = "txtTextBox";
			this.txtTextBox.Size = new System.Drawing.Size(351, 46);
			this.txtTextBox.TabIndex = 0;
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(38, 139);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(75, 40);
			this.btn7.TabIndex = 1;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(131, 139);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(75, 40);
			this.btn8.TabIndex = 2;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(223, 139);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(75, 40);
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(223, 185);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(75, 40);
			this.btn6.TabIndex = 6;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(131, 185);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(75, 40);
			this.btn5.TabIndex = 5;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(38, 185);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(75, 40);
			this.btn4.TabIndex = 4;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(224, 231);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 40);
			this.btn3.TabIndex = 9;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(132, 231);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 40);
			this.btn2.TabIndex = 8;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(39, 231);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 40);
			this.btn1.TabIndex = 7;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btnRestar
			// 
			this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestar.Location = new System.Drawing.Point(314, 167);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 40);
			this.btnRestar.TabIndex = 12;
			this.btnRestar.Text = "-";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnSumar
			// 
			this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSumar.Location = new System.Drawing.Point(314, 121);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 40);
			this.btnSumar.TabIndex = 11;
			this.btnSumar.Text = "+";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(314, 213);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(75, 40);
			this.btnMultiplicar.TabIndex = 10;
			this.btnMultiplicar.Text = "*";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(315, 259);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 40);
			this.btnDividir.TabIndex = 13;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnIgual
			// 
			this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.Location = new System.Drawing.Point(223, 277);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(75, 68);
			this.btnIgual.TabIndex = 15;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = true;
			this.btnIgual.Click += new System.EventHandler(this.BtnIgualClick);
			// 
			// btnRaiz
			// 
			this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaiz.Location = new System.Drawing.Point(314, 305);
			this.btnRaiz.Name = "btnRaiz";
			this.btnRaiz.Size = new System.Drawing.Size(75, 40);
			this.btnRaiz.TabIndex = 14;
			this.btnRaiz.Text = "√";
			this.btnRaiz.UseVisualStyleBackColor = true;
			this.btnRaiz.Click += new System.EventHandler(this.BtnRaizClick);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(132, 277);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(75, 40);
			this.btn0.TabIndex = 17;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.Btn0Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(38, 93);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 40);
			this.btnBorrar.TabIndex = 16;
			this.btnBorrar.Text = "C";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnDecimal
			// 
			this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDecimal.Location = new System.Drawing.Point(39, 277);
			this.btnDecimal.Name = "btnDecimal";
			this.btnDecimal.Size = new System.Drawing.Size(75, 40);
			this.btnDecimal.TabIndex = 18;
			this.btnDecimal.Text = ".";
			this.btnDecimal.UseVisualStyleBackColor = true;
			this.btnDecimal.Click += new System.EventHandler(this.BtnDecimalClick);
			// 
			// frmCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(421, 375);
			this.Controls.Add(this.btnDecimal);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnRaiz);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.txtTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCalculadora";
			this.Text = "Calcu2.0";
			this.Load += new System.EventHandler(this.FrmCalculadoraLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
