using UnityEngine;
using System.Collections;

public class PEtest : MonoBehaviour //COPIED FROM KE, BE CAREFUL
{
    public float reset = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        GameObject sphObj;
        sphObj = GameObject.Find("Planet");
        Rigidbody sph = sphObj.GetComponent<Rigidbody>();

        GameObject PEsph = GameObject.Find("PEball"); // this needs to be name of thingy


        Vector3 vel3 = sph.velocity;
        Vector3 pos3 = sph.position;

        float h = pos3.y; // THIS MAY NEED TO BE CHANGED TO BE SCENE SPECIFIC
        float mass = sph.mass;




        //Debug.Log(velsqf);
        float PEf = h * mass * Physics.gravity.y * (float)-1; //CHANGE TO FORMULA




        Vector3 oldPos = PEsph.transform.position;
        reset = reset + (float).05;
        if (reset >= 20)
        {
            reset = 0;
            oldPos.x = oldPos.x - 20;
        }

        transform.position = new Vector3(oldPos.x + (float).05, PEf * (float).1, oldPos.z );


    }
}

