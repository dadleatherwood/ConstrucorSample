using System;
using System.Collections.Generic;

namespace ConstructorSample
{

	public class Customer

	{
		public int Id;
		public string Name;
        public List<Order> Orders; //make sure the list is initialized!!!

        public Customer()
        {
            Orders = new List<Order>();
        }
        //overloading constructors (different contructors with different parameters offered
        public Customer(int Id)
            : this() //runs the contructor from above with NO parameters
        {
            this.Id = Id;
        }

        public Customer(string name)
            : this(Id) //runs the contructor from above with the ID parameter
        {
            this.Name = name;
        }

        //this is not best practice, but need to know what it is doing.  
	}

}
