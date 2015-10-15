using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace FasadConsole
{
	/// <summary>
	/// Summary description for TheaterLights.
	/// </summary>
	public class TheaterLights 
	{
		string description;

		public string Description
		{
			get { return description; }
		}
		
		public TheaterLights(string description) 
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
	  
		public string Dim(int level) 
		{
			return description + " dimming to " + level  + "%\n";
		}
	}
}
