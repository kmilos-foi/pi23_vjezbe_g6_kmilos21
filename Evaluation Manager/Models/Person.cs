using System;

namespace Evaluation_Manager.Models {
	public abstract class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string FirstName { get; set; } 
		
		public override string ToString() {
			return FirstName + " " + LastName;
		}
    }
}


