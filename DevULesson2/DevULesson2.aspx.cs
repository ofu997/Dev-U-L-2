using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevULesson2
{
	public partial class DevULesson2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void firstTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		protected void addButton_Click(object sender, EventArgs e)
		{
			int first = int.Parse(firstTextBox.Text);
			int second = int.Parse(secondTextBox.Text);
			int result = first + second;
			resultLabel.Text = result.ToString();
		}

		protected void subtractButton_Click(object sender, EventArgs e)
		{
			int first = int.Parse(firstTextBox.Text);
			int second = int.Parse(secondTextBox.Text);
			int result = first - second;
			resultLabel.Text = result.ToString();
		}

		protected void multiply_Click(object sender, EventArgs e)
		{
			int first = int.Parse(firstTextBox.Text);
			int second = int.Parse(secondTextBox.Text);
			int result = first * second;
			resultLabel.Text = result.ToString();
		}

		protected void divideButton_Click(object sender, EventArgs e)
		{
			int first = int.Parse(firstTextBox.Text);
			int second = int.Parse(secondTextBox.Text);
			double result = (double)first / (double)second;
			resultLabel.Text = result.ToString();
		}
	}
}