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


        gravityControl = (float)-11.15;
        
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture=Resources.Load("neptunemap") as Texture;
    }
    public void changeGravitySaturn(){

        gravityControl = (float)-10.44;
        
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("saturnmap") as Texture;
    }
    public void changeGravityEarth(){

        gravityControl = (float)-9.81;

      
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("earthmap1k") as Texture;
    }
    public void changeGravityMercury() {


        gravityControl = (float)-3.7;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("mercurymap") as Texture;
    }
    public void changeGravityMoon() {

        gravityControl = (float)-1.62;
        
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("moonmap1k") as Texture;
    }
    public void changeGravityPluto(){

        gravityControl = (float)-0.58;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("plutomap1k") as Texture;
    }

    public void changeGravityVenus() {

        gravityControl = (float)-8.87;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("venusmap") as Texture;
    }
    public void changeGravityUranus() {

        gravityControl = (float)-8.87;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("uranusmap") as Texture;
    }
    public void changeGravityJupiter() {

        gravityControl = (float)-24.92;
        planet = GameObject.Find("Planet");
        planet.GetComponent<Renderer>().material.mainTexture = Resources.Load("jupitermap") as Texture;
    }
    public void changeGravityNoGravity()
    {

        gravityControl = (float)0;
    }

































}

