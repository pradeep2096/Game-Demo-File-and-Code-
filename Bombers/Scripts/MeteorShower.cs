using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorShower : MonoBehaviour {
    public Transform White;
    public Transform Black;
    public Transform BShield;
    public Transform Wshield;
    public Transform bubble;
    public GameObject minspawndist;
    public GameObject maxspawndist;
    public GameObject minspawnx;
    public GameObject maxspawnx;
    float mindist;
    float maxdist;
    float minspawn;
    float maxspawn;
    float timestamp;
    public float speed;



    // Use this for initialization
    void Start() {

        if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene2 == true)
        {
            InvokeRepeating("spawnBubble", 1f, 10f);
            Debug.Log("Bubble Instantiated");
        }
            
        InvokeRepeating("spawn", 1.5f, 0.5f);

    }

    // Update is called once per frame
    void Update() {
        mindist = minspawndist.transform.position.x;
        maxdist = maxspawndist.transform.position.x;
        minspawn = minspawnx.transform.position.x;
        maxspawn = maxspawnx.transform.position.x;
        float t = (Mathf.Sin(Time.time - timestamp) * speed);
    }
    void spawn()
    {
        int rand = Random.Range(0, 2);
        switch (rand)
        {
            case 0:
                Instantiate(White, new Vector2(Random.Range(minspawn, maxspawn), 6f), Quaternion.identity);

                break;
            case 1:
                Instantiate(Black, new Vector2(Random.Range(minspawn, maxspawn), 6f), Quaternion.identity);

                break;
        }

    }
    void spawnBubble()
    {
        Instantiate(bubble, new Vector2(Random.Range(mindist, maxdist), 7f), Quaternion.identity);
    }



}
    /*void spawnset() {
        Instantiate(BShield, new Vector2(mindist, 0.5f), Quaternion.identity);
        Instantiate(Wshield, new Vector2(mindist, 0.5f), Quaternion.identity);
    }
     void spawnB()
     {
            Instantiate(BShield, new Vector2(mindist+2, 0.5f), Quaternion.identity);
     }
     void spawnW()
     {
            Instantiate(Wshield, new Vector2(mindist, 0.5f), Quaternion.identity);
     }
    

}    */

