/*
 * Thunder Unit conversion library
 * (C)Copyright 2005/2006 Robert Harwood <robharwood@runbox.com>
 * 
 * Please see included license.txt file for information on redistribution and usage.
 */
using System.Windows.Forms;
using Thor.Units;

namespace Thor.TestApp
{
	/// <summary>
	/// Summary description.
	/// </summary>
	public partial class MainForm : Form
	{
		#region Members

        IUnitConverter uc;

		#endregion

		#region Construction

		public MainForm()
		{
			// Required for Windows Form Designer support.
			InitializeComponent();

            uc = Thor.Units.InterfaceFactory.CreateUnitConverter();
			uc.OnError += new UnitEventHandler(uc_OnError);
			uc.LoadUnitsFile(@".\units.xml");

            /*DataString d1 = uc.CreateDataString("kg");
            DataString d2 = uc.CreateDataString("kg");

            d1.SetValue("5 kg");
            d2.SetValue("500 g");

            DataString d3 = d1 + d2;

            MessageBox.Show(d3.ToString( ));*/
		}

		#endregion

		#region Event Handlers

		private void uc_OnError(object sender, UnitEventArgs e)
		{
			lstOutput.Items.Add(e.Message);
		}

		private void txtInput_TextChanged(object sender, System.EventArgs e)
		{
			double	val;
			double	outval;
			string	in_unit;

			UnitResult res = UnitResult.NoError;

			res = uc.ParseUnitString(this.txtInput.Text, out val, out in_unit);

			if (res == UnitResult.BadUnit)
			{
				txtOutput.Text = "Bad input unit.";
				return;
			}
			else
			{
				if (res == UnitResult.BadValue)
				{
					txtOutput.Text = "Bad input value.";
					return;
				}
			}

			IUnitEntry out_unit = uc.GetUnitBySymbol(txtUnitTo.Text);

			if (out_unit == null)
			{
				txtOutput.Text = "Bad output unit.";
				return;
			}

			if (!uc.CompatibleUnits(in_unit, txtUnitTo.Text))
			{
				txtOutput.Text = "Units are of different types.";
				return;
			}

			res = uc.ConvertUnits(val, in_unit, txtUnitTo.Text, out outval);

			this.txtOutput.Text = outval.ToString( ) + " " + out_unit.DefaultSymbol;		
		}

		#endregion

	} // End class.
} // End namespace.
