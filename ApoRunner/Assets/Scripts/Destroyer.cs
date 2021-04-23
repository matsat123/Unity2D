using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }



    //Yes i'm C# scrpit
    //My goal is to destroy object's
    //Have a nice day :)
    //
    //
    //PS. Why are u looking there?
}
