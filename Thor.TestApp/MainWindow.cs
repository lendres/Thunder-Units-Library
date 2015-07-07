/*
 * Thunder Unit conversion library
 * (C)Copyright 2005/2006 Robert Harwood <robharwood@runbox.com>
 * 
 * Please see included license.txt file for information on redistribution and usage.
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using Thor.Units;

namespace Thor.TestApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUnitTo;
		private System.Windows.Forms.TextBox txtOutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        IUnitConverter uc;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            uc = Thor.Units.InterfaceFactory.CreateUnitConverter( );
			uc.OnError += new UnitEventHandler(uc_OnError);
			uc.LoadUnitsFile(@".\units.xml");

            /*DataString d1 = uc.CreateDataString("kg");
            DataString d2 = uc.CreateDataString("kg");

            d1.SetValue("5 kg");
            d2.SetValue("500 g");

            DataString d3 = d1 + d2;

            MessageBox.Show(d3.ToString( ));*/
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lstOutput = new System.Windows.Forms.ListBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.txtInput = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.txtUnitTo = new System.Windows.Forms.TextBox( );
            this.txtOutput = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // lstOutput
            // 
            this.lstOutput.HorizontalScrollbar = true;
            this.lstOutput.Location = new System.Drawing.Point(8, 24);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.ScrollAlwaysVisible = true;
            this.lstOutput.Size = new System.Drawing.Size(304, 108);
            this.lstOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 24);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(192, 21);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit to convert to:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUnitTo
            // 
            this.txtUnitTo.Location = new System.Drawing.Point(120, 64);
            this.txtUnitTo.Name = "txtUnitTo";
            this.txtUnitTo.Size = new System.Drawing.Size(192, 21);
            this.txtUnitTo.TabIndex = 5;
            this.txtUnitTo.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(120, 104);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(192, 21);
            this.txtOutput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.txtUnitTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit converter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstOutput);
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(338, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Unit Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void uc_OnError(object sender, UnitEventArgs e)
		{
			lstOutput.Items.Add(e.Message);
		}

		private void txtInput_TextChanged(object sender, System.EventArgs e)
		{
			double val, outval;
			string in_unit;
			UnitResult res = UnitResult.NoError;

			res = uc.ParseUnitString(this.txtInput.Text, out val, out in_unit);

			if(res == UnitResult.BadUnit)
			{
				txtOutput.Text = "Bad input unit.";
				return;
			}
			else if(res == UnitResult.BadValue)
			{
				txtOutput.Text = "Bad input value.";
				return;
			}

			IUnitEntry out_unit = uc.GetUnitBySymbol(txtUnitTo.Text);

			if(out_unit == null)
			{
				txtOutput.Text = "Bad output unit.";
				return;
			}

			if(!uc.CompatibleUnits(in_unit, txtUnitTo.Text))
			{
				txtOutput.Text = "Units are of different types.";
				return;
			}

			res = uc.ConvertUnits(val, in_unit, txtUnitTo.Text, out outval);

			this.txtOutput.Text = outval.ToString( ) + " " + out_unit.DefaultSymbol;		
		}
	}
}
