using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float P_health;
    public float DieAfterDelay;
    public GameObject GO;
    // Start is called before the first frame update
    void Start()
    {

        GO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        LoseHealth();
    }
    void LoseHealth()
    {
        if(P_health<=0)
        {
            Destroy(gameObject, DieAfterDelay);
            GO.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
