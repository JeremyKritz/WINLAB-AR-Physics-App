using UnityEngine;
using System.Collections;

public class createObjects : MonoBehaviour {

    public GameObject createBaseBall;
    public GameObject createBasketball;

    public void createBaseball()

    {
        GameObject go = Instantiate(createBaseBall, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }

    public void createBasketbball()

    {
        GameObject go = Instantiate(createBasketball, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }


    // Update is called once per frame
    void Update () {
	
	}
}
