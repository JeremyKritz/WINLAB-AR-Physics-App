using UnityEngine;
using System.Collections;

public class GravityControl : MonoBehaviour
{

    public float gravityControl = -9.81f;
    private GameObject planet;

    void Start() {
        Physics.gravity = new Vector3(0, gravityControl, 0);
    }

    void Update(){
        Physics.gravity = new Vector3(0, gravityControl, 0);
    }
    public void changeGravity(float newGravity){
        gravityControl = newGravity;   
    }
    public void changeGravityNeptune() { 
        Physics.gravity = new Vector3(0, (float)-11.15, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture=Resources.Load("neptunemap") as Texture;
    }
    public void changeGravitySaturn(){
        Physics.gravity = new Vector3(0, (float)-10.44, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("saturnmap") as Texture;
    }
    public void changeGravityEarth(){
        Physics.gravity = new Vector3(0, (float)-9.81, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("earthmap1k") as Texture;
    }
    public void changeGravityMercury() { 
        Physics.gravity = new Vector3(0, (float)-3.7, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("mercurymap") as Texture;
    }
    public void changeGravityMoon() { 
        Physics.gravity = new Vector3(0, (float) - 1.62, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("moonmap1k") as Texture;
    }
    public void changeGravityPluto(){
        Physics.gravity = new Vector3(0, (float)-0.58, 0); 
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("plutomap1k") as Texture;
    }

    public void changeGravityVenus() { 
        Physics.gravity = new Vector3(0, (float)-8.87, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("venusmap") as Texture;
    }
    public void changeGravityUranus() { 
        Physics.gravity = new Vector3(0, (float)-8.87, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("uranusmap") as Texture;
    }
    public void changeGravityJupiter() {
        Physics.gravity = new Vector3(0, (float)-24.92, 0);
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("jupitermap") as Texture;
    }
    public void changeGravityNoGravity()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

































}

