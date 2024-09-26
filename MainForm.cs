/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/26/2024
 * Time: 6:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace formuleDiverseMatematica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		public class returnboolint 
		{
			public bool x;
			public int i;
			public returnboolint(bool px, int pi)
			{
				this.x = px;
				this.i = pi;
			}
		}
		public returnboolint isPrime(int x)
		{
			
			for(int i = 2 ; i< x/2 ; i++)
			{
				if(x%i==0){return new returnboolint(false, i);}
			}
			return new returnboolint(true, x);
		}
		void Button1Click(object sender, EventArgs e)
		{
			int v = 0;
			try{
				v = int.Parse(this.textBox1.Text);
			}
			catch{};
			
			textBox2.Text ="";
			returnboolint r = isPrime(v);
			
			bool b = r.x;
			int i = r.i;
			
			if(r.x==true)
			{
				textBox2.Text += v.ToString() + " \r\t" + " is prime " + i.ToString() ;
					
			}
			else
			{
				textBox2.Text += v.ToString() + " \r\t" + " is not prime " + i.ToString() ;
					
			}
		}
		
		public void testknr()
		{
			for(int v = 0 ; v < 500; v++){
			
			
			returnboolint r = isPrime(v);
			
			bool b = r.x;
			int i = r.i;
			
			if(r.x==true)
			{
				textBox2.Text += v.ToString() + "\r\t" + " is prime " + i.ToString() ;
					
			}
			else
			{
				textBox2.Text += v.ToString() + " \r\t" + " is not prime " + i.ToString() ;
					
			}
			textBox2.Refresh();
			textBox2.Text += "\r\n";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			testknr();
		}
	}
}
