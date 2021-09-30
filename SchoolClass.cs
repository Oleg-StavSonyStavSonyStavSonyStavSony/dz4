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
           get 
            {

                foreach (var item in Room)
                { 
                    if(item.Name == name)
                    return item ;
                }
            }
           // set
           // {
           //     Room ["name"] = value;
           // }
        }



    }
}