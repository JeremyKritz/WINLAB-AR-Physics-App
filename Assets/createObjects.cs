using UnityEngine;
using System.Collections;

public class createObjects : MonoBehaviour {

    public GameObject createBaseBall;
    public GameObject createBasketball;
    public GameObject createTennisBall;
    public GameObject createVolleyBall;

    public void createBaseball()

    {
        GameObject go = Instantiate(createBaseBall, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }

    public void createBasketbball()

    {
        GameObject go = Instantiate(createBasketball, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }
    public void createTennisbball()

    {
        GameObject go = Instantiate(createTennisBall, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }

    public void createVolleyball()

    {
        GameObject go = Instantiate(createVolleyBall, new Vector3(1.08f, 2.5f, -0.48f), Quaternion.identity) as GameObject;
    }



    public void resetPositionofPlanet()

    {
        GameObject planet;
        planet = GameObject.Find("Planet");
        planet.transform.localPosition = new Vector3(.25f, 1.398f, -0.76f);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
