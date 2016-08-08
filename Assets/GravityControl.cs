using UnityEngine;
using System.Collections;

public class GravityControl : MonoBehaviour
{

    public float gravityControl = -9.81f;

    void Start()
    {
        Physics.gravity = new Vector3(0, gravityControl, 0);

    }

    void Update()
    {
        Physics.gravity = new Vector3(0, gravityControl, 0);

    }
    public void changeGravity(float newGravity)
    {
        gravityControl = newGravity;
    }


}

