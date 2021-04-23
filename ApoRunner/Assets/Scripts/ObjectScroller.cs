using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScroller : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position -= new Vector3(GameMenager.instance.worldScrollingSpeed,0f,0f);
    }

    void Update()
    {
        
    }
}
