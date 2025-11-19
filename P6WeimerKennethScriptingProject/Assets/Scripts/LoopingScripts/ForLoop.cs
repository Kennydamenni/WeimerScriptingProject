using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    public int numEnemeis = 3;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < numEnemeis; i++)
        {
            Debug.Log("Creatin enemy number: " + i);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
