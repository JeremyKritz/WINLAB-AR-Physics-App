using UnityEngine;
using System.Collections;

public class KEtest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        GameObject sphObj;

        sphObj = GameObject.Find("Sphere");
        Rigidbody sph = sphObj.GetComponent<Rigidbody>();

        GameObject KEsph = GameObject.Find("KEball"); // this needs to be name of thingy
        Rigidbody KE = KEsph.GetComponent<Rigidbody>();

        Vector3 vel3 = sph.velocity;
        float mass = sph.mass;

        double vx = vel3.x;
        double vy = vel3.y;
        double vz = vel3.z;
        double vel = System.Math.Sqrt(System.Math.Pow(vx, 2) + System.Math.Pow(vy, 2) + System.Math.Pow(vz, 2));
        double velsq = System.Math.Pow(vel, 2);
        float velsqf = (float)velsq;
        //Debug.Log(velsqf);
        float KEf = (float).5 * mass * velsqf;




        Vector3 oldPos = KEsph.transform.position;
        transform.position = new Vector3(oldPos.x + (float).05, KEf * (float).05, oldPos.z);


    }
}
