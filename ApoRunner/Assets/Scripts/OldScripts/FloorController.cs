using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{

    public GameObject Ground_1;
    public GameObject Ground_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Ground_1.transform.position -= new Vector3(GameMenager.instance.worldScrollingSpeed, 0f, 0f);
        Ground_2.transform.position -= new Vector3(GameMenager.instance.worldScrollingSpeed, 0f, 0f);

        if (Ground_1.transform.position.x < 0f)
        {
            Ground_1.transform.position += new Vector3(19.2f, 0f, 0f);

            var tmp = Ground_1;
            Ground_1 = Ground_2;
            Ground_2 = tmp;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
