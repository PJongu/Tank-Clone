using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 100;
    // Start is called before the first frame update
    public void subHealth(int value){

        health -= value;

    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
