using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mirror : MonoBehaviour
{
    public void shootLazer(Vector3 point, GameObject bullet, Vector3 angle){
        GameObject pewpew = Instantiate(bullet);
        pewpew.transform.position = point;
        Vector3 updateAngle = Vector3.Reflect(angle, point);
        updateAngle.y = 0;
        pewpew.GetComponent<pewpew>().direction = updateAngle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
