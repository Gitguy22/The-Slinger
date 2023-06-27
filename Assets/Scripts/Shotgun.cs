using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    //variables
    public Transform spawnPoint;
    public float distance = 15f;

    public GameObject muzzle;
    public GameObject impact;

    public LayerMask enemy;
    public GameObject explosion;
   
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
        Shoot();}
    }

    private void Shoot()
    {
        RaycastHit hit;
        RaycastHit hit_1;
        RaycastHit hit_2;
        RaycastHit hit_3;
        RaycastHit hit_4;
        RaycastHit hit_5;
        RaycastHit hit_6;
        RaycastHit hit_7;
        RaycastHit hit_8;

        GameObject muzzleInstance = Instantiate (muzzle, spawnPoint.position, spawnPoint.localRotation);
        muzzleInstance.transform.parent = spawnPoint;

        //Bullet that goes forward
        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit, distance))
        {

            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));

            if (hit.transform.gameObject.tag == "enemy")
            {
                Destroy(hit.collider.gameObject);

                Instantiate(explosion, new Vector3 (hit.transform.position.x, hit.transform.position.y, hit.transform.position.z), transform.rotation);
            }
        }

         //Bullet that goes forward
        if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(-.2f, 0f, 0f), out hit_1, distance))
        {
            Instantiate(impact, hit_1.point, Quaternion.LookRotation(hit_1.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(0f, .1f, 0f), out hit_2, distance))
        {
            Instantiate(impact, hit_2.point, Quaternion.LookRotation(hit_2.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(-0f, .1f, 0f), out hit_3, distance))
        {
            Instantiate(impact, hit_3.point, Quaternion.LookRotation(hit_3.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(0f, -.3f, 0f), out hit_4, distance))
        {
            Instantiate(impact, hit_4.point, Quaternion.LookRotation(hit_4.normal));

            //Apply damage if you have a method that does it
        }

     if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(-.1f, -.1f, 0f), out hit_5, distance))
        {
            Instantiate(impact, hit_5.point, Quaternion.LookRotation(hit_5.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(.2f, -.1f, 0f), out hit_6, distance))
        {
            Instantiate(impact, hit_6.point, Quaternion.LookRotation(hit_6.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(-.1f, .1f, 0f), out hit_7, distance))
        {
            Instantiate(impact, hit_7.point, Quaternion.LookRotation(hit_7.normal));

            //Apply damage if you have a method that does it
        }

         if(Physics.Raycast(cam.transform.position,cam.transform.forward + new Vector3(0f, .2f, 0f), out hit_8, distance))
        {
            Instantiate(impact, hit_8.point, Quaternion.LookRotation(hit_8.normal));

            //Apply damage if you have a method that does it
        }
    }
}
