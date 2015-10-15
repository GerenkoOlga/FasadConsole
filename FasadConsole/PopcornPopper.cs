using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace FasadConsole
{
	/// <summary>
	/// Summary description for PopcornPopper.
	/// </summary>
	public class PopcornPopper 
	{
		string description;

		public string Description
		{
			get { return description; }
		}
		
		public PopcornPopper(string description) 
		{
			this.description = description;
		}
	 
		public string On() 
		{
			return description + " on\n";
		}
	 
		public string Off() 
		{
			return description + " off\n";
		}

		public string Pop() 
		{
			return description + " popping popcorn!\n";
		}
	}
}