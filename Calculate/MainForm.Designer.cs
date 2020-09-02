/*
 * Created by SharpDevelop.
 * User: Елена
 * Date: 01.02.2020
 * Time: 12:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculate
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSub = new System.Windows.Forms.Button();
			this.buttonMul = new System.Windows.Forms.Button();
			this.buttonDiv = new System.Windows.Forms.Button();
			this.buttonResult = new System.Windows.Forms.Button();
			this.buttonAbs = new System.Windows.Forms.Button();
			this.buttonMax = new System.Windows.Forms.Button();
			this.buttonMin = new System.Windows.Forms.Button();
			this.buttonSqr = new System.Windows.Forms.Button();
			this.buttonCube = new System.Windows.Forms.Button();
			this.buttonPow = new System.Windows.Forms.Button();
			this.buttonFactor = new System.Windows.Forms.Button();
			this.buttonAddSub = new System.Windows.Forms.Button();
			this.buttonPi = new System.Windows.Forms.Button();
			this.buttonX = new System.Windows.Forms.Button();
			this.buttonSqrt = new System.Windows.Forms.Button();
			this.buttonCos = new System.Windows.Forms.Button();
			this.buttonSin = new System.Windows.Forms.Button();
			this.buttonE = new System.Windows.Forms.Button();
			this.buttonTg = new System.Windows.Forms.Button();
			this.buttonLog = new System.Windows.Forms.Button();
			this.buttonLn = new System.Windows.Forms.Button();
			this.buttonM = new System.Windows.Forms.Button();
			this.buttonMR = new System.Windows.Forms.Button();
			this.buttonMC = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonCE = new System.Windows.Forms.Button();
			this.buttonBackspace = new System.Windows.Forms.Button();
			this.buttonComma = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.textBox.Location = new System.Drawing.Point(20, 14);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(281, 32);
			this.textBox.TabIndex = 0;
			this.textBox.TabStop = false;
			this.textBox.Text = "0";
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.Location = new System.Drawing.Point(20, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.Location = new System.Drawing.Point(66, 60);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.Location = new System.Drawing.Point(112, 60);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button4.Location = new System.Drawing.Point(20, 108);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button5.Location = new System.Drawing.Point(66, 108);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button6.Location = new System.Drawing.Point(112, 108);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button7.Location = new System.Drawing.Point(20, 154);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button8.Location = new System.Drawing.Point(66, 154);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button9.Location = new System.Drawing.Point(112, 154);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button0.Location = new System.Drawing.Point(20, 200);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(40, 40);
			this.button0.TabIndex = 10;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button0Click);
			this.button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.button0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.MistyRose;
			this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonAdd.Location = new System.Drawing.Point(169, 60);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(40, 40);
			this.buttonAdd.TabIndex = 11;
			this.buttonAdd.Text = "+";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			this.buttonAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonSub
			// 
			this.buttonSub.BackColor = System.Drawing.Color.MistyRose;
			this.buttonSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSub.Location = new System.Drawing.Point(170, 108);
			this.buttonSub.Name = "buttonSub";
			this.buttonSub.Size = new System.Drawing.Size(40, 40);
			this.buttonSub.TabIndex = 12;
			this.buttonSub.Text = "-";
			this.buttonSub.UseVisualStyleBackColor = false;
			this.buttonSub.Click += new System.EventHandler(this.ButtonSubClick);
			this.buttonSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonMul
			// 
			this.buttonMul.BackColor = System.Drawing.Color.MistyRose;
			this.buttonMul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonMul.Location = new System.Drawing.Point(170, 154);
			this.buttonMul.Name = "buttonMul";
			this.buttonMul.Size = new System.Drawing.Size(40, 40);
			this.buttonMul.TabIndex = 13;
			this.buttonMul.Text = "*";
			this.buttonMul.UseVisualStyleBackColor = false;
			this.buttonMul.Click += new System.EventHandler(this.ButtonMulClick);
			this.buttonMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonMul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonDiv
			// 
			this.buttonDiv.BackColor = System.Drawing.Color.MistyRose;
			this.buttonDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDiv.Location = new System.Drawing.Point(169, 200);
			this.buttonDiv.Name = "buttonDiv";
			this.buttonDiv.Size = new System.Drawing.Size(40, 40);
			this.buttonDiv.TabIndex = 14;
			this.buttonDiv.Text = "/";
			this.buttonDiv.UseVisualStyleBackColor = false;
			this.buttonDiv.Click += new System.EventHandler(this.ButtonDivClick);
			this.buttonDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonDiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonResult
			// 
			this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonResult.Location = new System.Drawing.Point(112, 199);
			this.buttonResult.Name = "buttonResult";
			this.buttonResult.Size = new System.Drawing.Size(40, 40);
			this.buttonResult.TabIndex = 15;
			this.buttonResult.Text = "=";
			this.buttonResult.UseVisualStyleBackColor = false;
			this.buttonResult.Click += new System.EventHandler(this.ButtonResultClick);
			this.buttonResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonAbs
			// 
			this.buttonAbs.BackColor = System.Drawing.Color.MistyRose;
			this.buttonAbs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAbs.Location = new System.Drawing.Point(215, 60);
			this.buttonAbs.Name = "buttonAbs";
			this.buttonAbs.Size = new System.Drawing.Size(40, 40);
			this.buttonAbs.TabIndex = 16;
			this.buttonAbs.Text = "|x|\r\n";
			this.buttonAbs.UseVisualStyleBackColor = false;
			this.buttonAbs.Click += new System.EventHandler(this.ButtonAbsClick);
			this.buttonAbs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonAbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonMax
			// 
			this.buttonMax.BackColor = System.Drawing.Color.MistyRose;
			this.buttonMax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMax.Location = new System.Drawing.Point(216, 109);
			this.buttonMax.Name = "buttonMax";
			this.buttonMax.Size = new System.Drawing.Size(40, 40);
			this.buttonMax.TabIndex = 17;
			this.buttonMax.Text = "max";
			this.buttonMax.UseVisualStyleBackColor = false;
			this.buttonMax.Click += new System.EventHandler(this.ButtonMaxClick);
			this.buttonMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonMin
			// 
			this.buttonMin.BackColor = System.Drawing.Color.MistyRose;
			this.buttonMin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMin.Location = new System.Drawing.Point(216, 155);
			this.buttonMin.Name = "buttonMin";
			this.buttonMin.Size = new System.Drawing.Size(40, 40);
			this.buttonMin.TabIndex = 18;
			this.buttonMin.Text = "min";
			this.buttonMin.UseVisualStyleBackColor = false;
			this.buttonMin.Click += new System.EventHandler(this.ButtonMinClick);
			this.buttonMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonSqr
			// 
			this.buttonSqr.BackColor = System.Drawing.Color.MistyRose;
			this.buttonSqr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSqr.Location = new System.Drawing.Point(261, 109);
			this.buttonSqr.Name = "buttonSqr";
			this.buttonSqr.Size = new System.Drawing.Size(40, 40);
			this.buttonSqr.TabIndex = 19;
			this.buttonSqr.Text = "x²\r\n";
			this.toolTip1.SetToolTip(this.buttonSqr, "Квадрат числа (S)");
			this.buttonSqr.UseVisualStyleBackColor = false;
			this.buttonSqr.Click += new System.EventHandler(this.ButtonSqrClick);
			this.buttonSqr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonSqr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonCube
			// 
			this.buttonCube.BackColor = System.Drawing.Color.MistyRose;
			this.buttonCube.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCube.Location = new System.Drawing.Point(262, 155);
			this.buttonCube.Name = "buttonCube";
			this.buttonCube.Size = new System.Drawing.Size(40, 40);
			this.buttonCube.TabIndex = 20;
			this.buttonCube.Text = "x³";
			this.buttonCube.UseVisualStyleBackColor = false;
			this.buttonCube.Click += new System.EventHandler(this.ButtonCubeClick);
			this.buttonCube.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonCube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonPow
			// 
			this.buttonPow.BackColor = System.Drawing.Color.MistyRose;
			this.buttonPow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPow.Location = new System.Drawing.Point(261, 60);
			this.buttonPow.Name = "buttonPow";
			this.buttonPow.Size = new System.Drawing.Size(40, 40);
			this.buttonPow.TabIndex = 21;
			this.buttonPow.Text = "xʸ\r\n";
			this.buttonPow.UseVisualStyleBackColor = false;
			this.buttonPow.Click += new System.EventHandler(this.ButtonPowClick);
			this.buttonPow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonPow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonFactor
			// 
			this.buttonFactor.BackColor = System.Drawing.Color.MistyRose;
			this.buttonFactor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFactor.Location = new System.Drawing.Point(261, 201);
			this.buttonFactor.Name = "buttonFactor";
			this.buttonFactor.Size = new System.Drawing.Size(40, 40);
			this.buttonFactor.TabIndex = 22;
			this.buttonFactor.Text = "n!\r\n";
			this.buttonFactor.UseVisualStyleBackColor = false;
			this.buttonFactor.Click += new System.EventHandler(this.ButtonFactorClick);
			this.buttonFactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonAddSub
			// 
			this.buttonAddSub.BackColor = System.Drawing.Color.MistyRose;
			this.buttonAddSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddSub.Location = new System.Drawing.Point(215, 200);
			this.buttonAddSub.Name = "buttonAddSub";
			this.buttonAddSub.Size = new System.Drawing.Size(40, 40);
			this.buttonAddSub.TabIndex = 23;
			this.buttonAddSub.Text = "+/-";
			this.buttonAddSub.UseVisualStyleBackColor = false;
			this.buttonAddSub.Click += new System.EventHandler(this.ButtonAddSubClick);
			this.buttonAddSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonAddSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonPi
			// 
			this.buttonPi.BackColor = System.Drawing.Color.MistyRose;
			this.buttonPi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPi.Location = new System.Drawing.Point(307, 60);
			this.buttonPi.Name = "buttonPi";
			this.buttonPi.Size = new System.Drawing.Size(40, 40);
			this.buttonPi.TabIndex = 24;
			this.buttonPi.Text = "π";
			this.buttonPi.UseVisualStyleBackColor = false;
			this.buttonPi.Click += new System.EventHandler(this.ButtonPiClick);
			this.buttonPi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonPi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonX
			// 
			this.buttonX.BackColor = System.Drawing.Color.MistyRose;
			this.buttonX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonX.Location = new System.Drawing.Point(307, 109);
			this.buttonX.Name = "buttonX";
			this.buttonX.Size = new System.Drawing.Size(40, 40);
			this.buttonX.TabIndex = 25;
			this.buttonX.Text = "⅟x";
			this.buttonX.UseVisualStyleBackColor = false;
			this.buttonX.Click += new System.EventHandler(this.ButtonXClick);
			this.buttonX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonSqrt
			// 
			this.buttonSqrt.BackColor = System.Drawing.Color.MistyRose;
			this.buttonSqrt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSqrt.Location = new System.Drawing.Point(307, 155);
			this.buttonSqrt.Name = "buttonSqrt";
			this.buttonSqrt.Size = new System.Drawing.Size(40, 40);
			this.buttonSqrt.TabIndex = 26;
			this.buttonSqrt.Text = "√";
			this.buttonSqrt.UseVisualStyleBackColor = false;
			this.buttonSqrt.Click += new System.EventHandler(this.ButtonSqrtClick);
			this.buttonSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonSqrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonCos
			// 
			this.buttonCos.BackColor = System.Drawing.Color.MistyRose;
			this.buttonCos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCos.Location = new System.Drawing.Point(307, 201);
			this.buttonCos.Name = "buttonCos";
			this.buttonCos.Size = new System.Drawing.Size(40, 40);
			this.buttonCos.TabIndex = 27;
			this.buttonCos.Text = "cos";
			this.buttonCos.UseVisualStyleBackColor = false;
			this.buttonCos.Click += new System.EventHandler(this.ButtonCosClick);
			this.buttonCos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonCos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonSin
			// 
			this.buttonSin.BackColor = System.Drawing.Color.MistyRose;
			this.buttonSin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSin.Location = new System.Drawing.Point(353, 60);
			this.buttonSin.Name = "buttonSin";
			this.buttonSin.Size = new System.Drawing.Size(40, 40);
			this.buttonSin.TabIndex = 28;
			this.buttonSin.Text = "sin";
			this.buttonSin.UseVisualStyleBackColor = false;
			this.buttonSin.Click += new System.EventHandler(this.ButtonSinClick);
			this.buttonSin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonSin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonE
			// 
			this.buttonE.BackColor = System.Drawing.Color.MistyRose;
			this.buttonE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonE.Location = new System.Drawing.Point(353, 109);
			this.buttonE.Name = "buttonE";
			this.buttonE.Size = new System.Drawing.Size(40, 40);
			this.buttonE.TabIndex = 29;
			this.buttonE.Text = "e";
			this.buttonE.UseVisualStyleBackColor = false;
			this.buttonE.Click += new System.EventHandler(this.ButtonEClick);
			this.buttonE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonTg
			// 
			this.buttonTg.BackColor = System.Drawing.Color.MistyRose;
			this.buttonTg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonTg.Location = new System.Drawing.Point(353, 155);
			this.buttonTg.Name = "buttonTg";
			this.buttonTg.Size = new System.Drawing.Size(40, 40);
			this.buttonTg.TabIndex = 30;
			this.buttonTg.Text = "tg";
			this.buttonTg.UseVisualStyleBackColor = false;
			this.buttonTg.Click += new System.EventHandler(this.ButtonTgClick);
			this.buttonTg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonTg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonLog
			// 
			this.buttonLog.BackColor = System.Drawing.Color.MistyRose;
			this.buttonLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLog.Location = new System.Drawing.Point(353, 199);
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Size = new System.Drawing.Size(40, 40);
			this.buttonLog.TabIndex = 31;
			this.buttonLog.Text = "log";
			this.buttonLog.UseVisualStyleBackColor = false;
			this.buttonLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonLn
			// 
			this.buttonLn.BackColor = System.Drawing.Color.MistyRose;
			this.buttonLn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLn.Location = new System.Drawing.Point(399, 60);
			this.buttonLn.Name = "buttonLn";
			this.buttonLn.Size = new System.Drawing.Size(40, 40);
			this.buttonLn.TabIndex = 32;
			this.buttonLn.Text = "ln";
			this.buttonLn.UseVisualStyleBackColor = false;
			this.buttonLn.Click += new System.EventHandler(this.ButtonLnClick);
			this.buttonLn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonLn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonM
			// 
			this.buttonM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.buttonM.Location = new System.Drawing.Point(399, 109);
			this.buttonM.Name = "buttonM";
			this.buttonM.Size = new System.Drawing.Size(40, 40);
			this.buttonM.TabIndex = 33;
			this.buttonM.Text = "M";
			this.buttonM.UseVisualStyleBackColor = false;
			this.buttonM.Click += new System.EventHandler(this.ButtonMClick);
			this.buttonM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonMR
			// 
			this.buttonMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonMR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMR.Location = new System.Drawing.Point(399, 156);
			this.buttonMR.Name = "buttonMR";
			this.buttonMR.Size = new System.Drawing.Size(40, 40);
			this.buttonMR.TabIndex = 34;
			this.buttonMR.Text = "MR";
			this.buttonMR.UseVisualStyleBackColor = false;
			this.buttonMR.Click += new System.EventHandler(this.ButtonMRClick);
			this.buttonMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonMR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonMC
			// 
			this.buttonMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonMC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMC.Location = new System.Drawing.Point(399, 202);
			this.buttonMC.Name = "buttonMC";
			this.buttonMC.Size = new System.Drawing.Size(40, 40);
			this.buttonMC.TabIndex = 35;
			this.buttonMC.Text = "MC";
			this.buttonMC.UseVisualStyleBackColor = false;
			this.buttonMC.Click += new System.EventHandler(this.ButtonMCClick);
			this.buttonMC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonMC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.buttonC.Location = new System.Drawing.Point(307, 14);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(40, 40);
			this.buttonC.TabIndex = 36;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.ButtonCClick);
			this.buttonC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonCE
			// 
			this.buttonCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonCE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.buttonCE.Location = new System.Drawing.Point(353, 14);
			this.buttonCE.Name = "buttonCE";
			this.buttonCE.Size = new System.Drawing.Size(40, 40);
			this.buttonCE.TabIndex = 37;
			this.buttonCE.Text = "CE";
			this.buttonCE.UseVisualStyleBackColor = false;
			this.buttonCE.Click += new System.EventHandler(this.ButtonCEClick);
			this.buttonCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonBackspace
			// 
			this.buttonBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonBackspace.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBackspace.Location = new System.Drawing.Point(399, 14);
			this.buttonBackspace.Name = "buttonBackspace";
			this.buttonBackspace.Size = new System.Drawing.Size(40, 40);
			this.buttonBackspace.TabIndex = 38;
			this.buttonBackspace.Text = "←";
			this.buttonBackspace.UseVisualStyleBackColor = false;
			this.buttonBackspace.Click += new System.EventHandler(this.ButtonBackspaceClick);
			this.buttonBackspace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonBackspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// buttonComma
			// 
			this.buttonComma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.buttonComma.Location = new System.Drawing.Point(66, 199);
			this.buttonComma.Name = "buttonComma";
			this.buttonComma.Size = new System.Drawing.Size(40, 40);
			this.buttonComma.TabIndex = 39;
			this.buttonComma.Text = ",";
			this.buttonComma.UseVisualStyleBackColor = true;
			this.buttonComma.Click += new System.EventHandler(this.ButtonCommaClick);
			this.buttonComma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.buttonComma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(454, 261);
			this.Controls.Add(this.buttonComma);
			this.Controls.Add(this.buttonBackspace);
			this.Controls.Add(this.buttonCE);
			this.Controls.Add(this.buttonC);
			this.Controls.Add(this.buttonMC);
			this.Controls.Add(this.buttonMR);
			this.Controls.Add(this.buttonM);
			this.Controls.Add(this.buttonLn);
			this.Controls.Add(this.buttonLog);
			this.Controls.Add(this.buttonTg);
			this.Controls.Add(this.buttonE);
			this.Controls.Add(this.buttonSin);
			this.Controls.Add(this.buttonCos);
			this.Controls.Add(this.buttonSqrt);
			this.Controls.Add(this.buttonX);
			this.Controls.Add(this.buttonPi);
			this.Controls.Add(this.buttonAddSub);
			this.Controls.Add(this.buttonFactor);
			this.Controls.Add(this.buttonPow);
			this.Controls.Add(this.buttonCube);
			this.Controls.Add(this.buttonSqr);
			this.Controls.Add(this.buttonMin);
			this.Controls.Add(this.buttonMax);
			this.Controls.Add(this.buttonAbs);
			this.Controls.Add(this.buttonResult);
			this.Controls.Add(this.buttonDiv);
			this.Controls.Add(this.buttonMul);
			this.Controls.Add(this.buttonSub);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox);
			
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "calculate";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonComma;
		private System.Windows.Forms.Button buttonBackspace;
		private System.Windows.Forms.Button buttonCE;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonMC;
		private System.Windows.Forms.Button buttonMR;
		private System.Windows.Forms.Button buttonM;
		private System.Windows.Forms.Button buttonLn;
		private System.Windows.Forms.Button buttonLog;
		private System.Windows.Forms.Button buttonTg;
		private System.Windows.Forms.Button buttonE;
		private System.Windows.Forms.Button buttonSin;
		private System.Windows.Forms.Button buttonCos;
		private System.Windows.Forms.Button buttonSqrt;
		private System.Windows.Forms.Button buttonX;
		private System.Windows.Forms.Button buttonPi;
		private System.Windows.Forms.Button buttonAddSub;
		private System.Windows.Forms.Button buttonFactor;
		private System.Windows.Forms.Button buttonPow;
		private System.Windows.Forms.Button buttonCube;
		private System.Windows.Forms.Button buttonSqr;
		private System.Windows.Forms.Button buttonMin;
		private System.Windows.Forms.Button buttonMax;
		private System.Windows.Forms.Button buttonAbs;
		private System.Windows.Forms.Button buttonResult;
		private System.Windows.Forms.Button buttonDiv;
		private System.Windows.Forms.Button buttonMul;
		private System.Windows.Forms.Button buttonSub;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox;
	}
}
