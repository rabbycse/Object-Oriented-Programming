using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Person
    {
        private string name;
        private int age;
        
        public string getName  
        {
            get
            {
                return name;
            }
    
        }
        public void setName(string name) 
        {
            this.name = name;
        }

        public int getAge 
        {
            get
            {
                return age;
            }
            
        }
        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
