using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
  
        //Member variables can be referred to as feilds
        private int experience;

        public  int Experience
        {
            get
            {
                //Some other code 
                return experience; 
            }
            set
            {
                //Some other code
                experience = value;

            }
        }
    //Level is a property that convertts experience points into a level of a player automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //This is an exapmle of an auto-impplemented property
    public int Health { get; set; } 
}
