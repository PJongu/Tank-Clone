using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpew : MonoBehaviour


{
    public float speed = 5;
    // Start is called before the first frame update
    public Vector3 direction;
    void Start()
    {
        StartCoroutine(destroy());
    }
    public IEnumerator destroy(){

        yield return new WaitForSeconds(.05f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);
        
        
    }
}
