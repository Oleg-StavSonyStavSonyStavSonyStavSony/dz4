using System;

namespace dz4
{
    public class SchoolClass
    {
        public Learner [] Room {set;get;}
        
        public SchoolClass (int coll)
        {
            Room = new Learner [coll];
        }
        public Learner this[int index] 
        {
            get 
            {
                return Room [index];
            }
            set
            {
                Room [index] = value;
            }
        }
        public Learner this[string  name] 
        {
             get  {   
                        for (int i = 0; i < Room.Length; i++)
                        {
                            if(Room[i].Name == name){
                               Console.WriteLine(Room[i]);
                            }
                        }
                        return new Learner {Name = "end", LastName = "end", MiddleName = "end", Years = 0};
                   }
        }
    }

}