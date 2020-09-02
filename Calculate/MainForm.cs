/*
 * Created by SharpDevelop.
 * User: Елена
 * Date: 01.02.2020
 * Time: 12:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace calculate
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private static double Number1 = 0;//из любого класса можеи обращаться к этой переменной public, if private будет то если у на несколько форм, каждый раз будет создаваться новое число и мы потеряем старое 
		//static поле не будет автоматическии обновляться сохраняя старое значение
		private static byte Operation = 0;
		private static double Memory = 0;
		private static bool Comma = false;
		
		// 0 - add
		// 1 - sub
		// 2 - mul
		// 3 - div
		// 4 - pow
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	#region ButtonsForNumbers
		// Button 1
		void Button1Click(object sender, EventArgs e)
		{
			//double Number = double.Parse(textBox.Text);
			//Number*=10;
			//Number+=1;
			//textBox.Text = Number.ToString();
			if(textBox.Text == "0")
				textBox.Text = "1";
			else
				textBox.Text = textBox.Text + "1";
			
			
			
		}
		
		//Button 2
		void Button2Click(object sender, EventArgs e)
		{
			//double Number = double.Parse(textBox.Text);
			//Number*=10;
			//Number+=2;
			//textBox.Text = Number.ToString();
			if(textBox.Text == "0")
				textBox.Text = "2";
			else
				textBox.Text = textBox.Text + "2";
			
		}
		
		//Button 3
		void Button3Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "3";
			else
				textBox.Text = textBox.Text + "3";
			
		}
		
		//Button 4
		void Button4Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "4";
			else
				textBox.Text = textBox.Text + "4";
			
		}
		
		//Button 5
		void Button5Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "5";
			else
				textBox.Text = textBox.Text + "5";
			
		}
		
		//Button 6
		void Button6Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "6";
			else
				textBox.Text = textBox.Text + "6";
			
		}
		
		//Button 7
		void Button7Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "7";
			else
				textBox.Text = textBox.Text + "7";
			
		}
		
		//Button 8
		void Button8Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "8";
			else
				textBox.Text = textBox.Text + "8";
			
		}
		
		//Button 9
		void Button9Click(object sender, EventArgs e)
		{
			if(textBox.Text == "0")
				textBox.Text = "9";
			else
				textBox.Text = textBox.Text + "9";
			
		}
		
		//Button 0
		void Button0Click(object sender, EventArgs e)
		{
			if(textBox.Text != "0")
				textBox.Text = textBox.Text + "0";
			
		}
	#endregion
	
	#region mathOperations
	    // Add
		void ButtonAddClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 0;
			Comma = false;
		}
		
		// Sub
		void ButtonSubClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 1;
			Comma = false;
		}
		
		// Mul
		void ButtonMulClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 2;
			Comma = false;
		}
		
		// Div
		void ButtonDivClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 3;
			Comma = false;
		}
		
		void ButtonAddSubClick(object sender, EventArgs e)
		{
			double Number = double.Parse(textBox.Text);
			Number = Number*(-1);
			textBox.Text = Number.ToString();
			Comma = false;
		}
		
		void ButtonAbsClick(object sender, EventArgs e)
		{
			double NumberAbs = double.Parse(textBox.Text);
			NumberAbs = Math.Abs(NumberAbs);
			textBox.Text = NumberAbs.ToString();
			Comma = false;
		}
		
		void ButtonSqrClick(object sender, EventArgs e)
		{
			double Number = double.Parse(textBox.Text);
			Number = Math.Pow(Number,2);
			textBox.Text = Number.ToString();
			Comma = false;
		}
		
		void ButtonCubeClick(object sender, EventArgs e)
		{
			double Number = double.Parse(textBox.Text);
			Number = Math.Pow(Number,3);
			textBox.Text = Number.ToString();
			Comma = false;
		}
		
		void ButtonPowClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 4;
			Comma = false;
		}
		
		void ButtonMaxClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 5;
			Comma = false;
		}
		
		void ButtonMinClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			
			textBox.Text = "0";
			Operation = 6;
			Comma = false;
		}
		
		void ButtonFactorClick(object sender, EventArgs e)
		{
			Comma = false;
			double Number = double.Parse(textBox.Text);
			double Result = 1;
			
			for(double i = 2;i<=Number;i++)
				Result= Result*i; 
			
			textBox.Text = Result.ToString();
		}
		void ButtonPiClick(object sender, EventArgs e)
		{
			textBox.Text = Math.PI.ToString();
			Comma = false;
		}
		
		void ButtonXClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = 1/Number1;
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		
		void ButtonSqrtClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = Math.Sqrt(Number1);
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		
		void ButtonCosClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = Math.Cos(Number1);
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		
		void ButtonSinClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = Math.Sin(Number1);
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		
		void ButtonEClick(object sender, EventArgs e)
		{
			textBox.Text = Math.E.ToString();
			Comma = false;
		}
		
		void ButtonTgClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = Math.Tan(Number1);
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		
		void ButtonLnClick(object sender, EventArgs e)
		{
			Number1 = double.Parse(textBox.Text);
			Number1 = Math.Log(Number1);
			textBox.Text = Number1.ToString();
			Comma = false;
		}
		#endregion
		
	#region forMemoryButtons
		// write to memory
		void ButtonMClick(object sender, EventArgs e)
		{
			// get the number from textBox.Text end store it in the  Memory
			// textBox.Text = 0
			Memory = double.Parse(textBox.Text);
			textBox.Text = "0";
		}
		
		// read from memory
		void ButtonMRClick(object sender, EventArgs e)
		{
			textBox.Text = Memory.ToString();
		}
		
		// memory cleaning
		void ButtonMCClick(object sender, EventArgs e)
		{
			Memory=0;
		}
		#endregion	
		
	#region DeleteButtons		
		void ButtonCClick(object sender, EventArgs e)
		{
			textBox.Text = "0";
			Number1 = 0;
			Operation = 0;
			Memory = 0;
			Comma = false;
		}
		
		void ButtonCEClick(object sender, EventArgs e)
		{
			textBox.Text = "0";
			Comma = false;
		}
		
		void ButtonBackspaceClick(object sender, EventArgs e)
		{
			StringBuilder str = new StringBuilder(textBox.Text);
			str.Remove(str.Length - 1,1); // delete tne last character
			if(str.ToString() == "")
				str = new StringBuilder("0");
			
			textBox.Text =str.ToString();
		}
#endregion
		
		
		void ButtonResultClick(object sender, EventArgs e)
		{
			double Number2 = double.Parse(textBox.Text);
			Comma = false;
			switch(Operation)
			{
				case 0: Number2 = Number1 + Number2; break;
				case 1: Number2 = Number1 - Number2; break;
				case 2: Number2 = Number1*Number2; break;
				case 3: Number2 = Number1/Number2; break;
				case 4: Number2 = Math.Pow(Number1, Number2); break;
				case 5 :Number2 = Math.Max(Number1, Number2); break;
				case 6 :Number2 = Math.Min(Number1, Number2); break;
			    
			}
			textBox.Text = Number2.ToString();
		}
		
		void ButtonCommaClick(object sender, EventArgs e)
		{
			
			if(!Comma)
			{
				textBox.Text = textBox.Text + ",";
				Comma = true;
			}
		}
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			char symbol = e.KeyChar;
			
			switch(symbol)
			{
					case '1' : Button1Click(button1,null); break;
					case '2' : Button2Click(button2,null); break;
					case '3' : Button3Click(button3,null); break;
					case '4' : Button4Click(button4,null); break;
					case '5' : Button5Click(button5,null); break;
					case '6' : Button6Click(button6,null); break;
					case '7' : Button7Click(button7,null); break;
					case '8' : Button8Click(button8,null); break;
					case '9' : Button9Click(button9,null); break;
					case '0' : Button0Click(button0,null); break;
					
					case '+' : ButtonAddClick(buttonAdd, null); break;
					case '-' : ButtonSubClick(buttonSub, null); break;
					case '*' : ButtonMulClick(buttonMul, null); break;
					case '/' : ButtonDivClick(buttonDiv, null); break;
					case '.' : 
					case ',' : ButtonCommaClick(buttonComma,null); break;
					case '=' : ButtonResultClick(buttonResult,null); break;
					
					case 'S' :
					case 's' : ButtonSqrClick(buttonSqrt,null); break;// ToolTip всплывающая подсказка
					
					//case '\b' : ButtonBackspaceClick(buttonBackspace, null) ; break;
					
					
			}
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
					case Keys.Back: ButtonBackspaceClick(buttonBackspace, null); break;
					case Keys.Escape : ButtonCClick(buttonC, null); break;
					// wrong case Keys.Enter : ButtonResultClick(buttonResult, null); break;
			}
		}
		// лучше использовать какой-то один (2 верхних ) программа дольше работает и всегда вызывает оба метода
	}
	
}
