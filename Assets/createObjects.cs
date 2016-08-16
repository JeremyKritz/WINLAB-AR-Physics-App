using UnityEngine;
using System.Collections;

public class createObjects : MonoBehaviour {

    public GameObject createBaseBall;
    public GameObject createBasketball;
    public GameObject createTennisBall;
    public GameObject createVolleyBall;

    public void createBaseball()

    {
        GameObject go = Instantiate(createBaseBall, new Vector3(0.016f, 1.511f, -0.126f), Quaternion.identity) as GameObject;
    }

    public void createBasketbball()

    {
        GameObject go = Instantiate(createBasketball, new Vector3(0.016f, 1.511f, -0.126f), Quaternion.identity) as GameObject;
    }
    public void createTennisbball()

    {
        GameObject go = Instantiate(createTennisBall, new Vector3(0.016f, 1.511f, -0.126f), Quaternion.identity) as GameObject;
    }

    public void createVolleyball()

    {
        GameObject go = Instantiate(createVolleyBall, new Vector3(0.016f, 1.511f, -0.126f), Quaternion.identity) as GameObject;
    }



    public void resetPositionofPlanet()

    {
        GameObject planet;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        planet.transform.position = new Vector3(0.016f, 1.511f, -0.110f);
        planet.GetComponent<Rigidbody>().ResetInertiaTensor();


    }
    // Update is called once per frame
    void Update () {
	
	}
}
