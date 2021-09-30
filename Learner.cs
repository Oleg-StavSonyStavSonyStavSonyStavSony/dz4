using System;

namespace dz4
{ 
    public class Learner
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Years { get; set; } 
        public override string ToString()
        {
            return $"LastName: {LastName}, Name: {Name},LastName: {LastName}, Years: {Years}";
        }
        
    }

}