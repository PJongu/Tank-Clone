using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonaim : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public Vector3 RotateAngle;
    public float TargetDistance;
    public pewpew bullet;
    public LayerMask hitbox;
    public LayerMask mirror;
    

   void Update()
    {
        //this shit moves the cannon
        Vector3 hitLocation;
        Vector2 pos = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angle = Mathf.Atan2(pos.y - mouse.y, pos.x - mouse.x) * Mathf.Rad2Deg + 90;
        RotateAngle = new Vector3(0f, -angle, 0f);
        transform.eulerAngles = RotateAngle;
        if (Input.GetButton("Fire1")){
            
            RaycastHit TheHit;            
        //shoots shit
            GameObject newBullet = Instantiate(bullet.gameObject);
            
            newBullet.transform.position = transform.position;
            newBullet.GetComponent<pewpew>().direction = transform.forward;


        
            

        //raycast to kill shit
            if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward),  out TheHit, 1000, hitbox)){

                TargetDistance = TheHit.distance;
                if(TheHit.collider.GetComponent<enemy>()!= null){
                    TheHit.collider.GetComponent<enemy>().subHealth(1);
                }
            
            

            }
            //reflect things god damn it wont work
            if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward),  out TheHit, 1000, mirror)){

                TargetDistance = TheHit.distance;
                if(TheHit.collider.GetComponent<mirror>()!= null){
                    TheHit.collider.GetComponent<mirror>().shootLazer(TheHit.point, bullet.gameObject, transform.forward);
                }

            }

        }

    }

}
