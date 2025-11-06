using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaraibleAndFunction : MonoBehaviour
{
    //create an integar varaible 
    public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //run the varaible through my funtcion
        myInt = MultiplyByTwo(myInt);

        //display the result in the console
        Debug.Log (myInt);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //creating my function
    int MultiplyByTwo(int number)
    {
        //create a result varaible
        int result;
        result = number * 2;

        //return the result
        return result;
    }

}    



