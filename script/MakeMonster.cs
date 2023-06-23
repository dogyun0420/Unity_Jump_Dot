using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMonster : MonoBehaviour
{
    public GameObject Monster;
    public float sec;
    public float Movespeed;
    float min = 0.3f;
    float max = 2.0f;
    float Timer = 0;
    public static float Speed = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        Speed += Time.deltaTime;

        if (Timer > sec)
        {
            GameObject newMonster = Instantiate(Monster);
            if (Speed < 6)
            {
                Move.speed = Movespeed;
                newMonster.transform.position = new Vector3(10, Random.Range(-5.0f, 5.0f), 0);
                newMonster.transform.localScale = new Vector3(Random.Range(0.3f, 2.0f), Random.Range(0.3f, 2.0f), 0);
            }
            else if (6 < Speed && Speed < 9)
            {
                Move.speed = (Movespeed * 1.2f);
                newMonster.transform.position = new Vector3(10, Random.Range(-5.0f, 5.0f), 0);
                newMonster.transform.localScale = new Vector3(Random.Range(0.6f, 3.0f), Random.Range(0.6f, 3.0f), 0);
            }
            else if (9 < Speed && Speed < 12)
            {
                Move.speed = (Movespeed * 1.4f);
                newMonster.transform.position = new Vector3(10, Random.Range(-5.0f, 5.0f), 0);
                newMonster.transform.localScale = new Vector3(Random.Range(1.0f, 4.0f), Random.Range(1.0f, 4.0f), 0);
            }
            else if (12 < Speed && Speed < 15)
            {
                Move.speed = (Movespeed * 1.6f);
                newMonster.transform.position = new Vector3(10, Random.Range(-5.0f, 5.0f), 0);
                newMonster.transform.localScale = new Vector3(Random.Range(1.5f,5.0f), Random.Range(1.5f, 5.0f), 0);
            }
            else
            {
                Move.speed = (Movespeed * 1.8f);
                newMonster.transform.position = new Vector3(10, Random.Range(-5.0f, 5.0f), 0);
                newMonster.transform.localScale = new Vector3(Random.Range(2.0f, 6.0f), Random.Range(2.0f, 6.0f), 0);
            }

           
            Timer = 0;
            Destroy(newMonster, 7.0f);
        }
        
    }
    
}
