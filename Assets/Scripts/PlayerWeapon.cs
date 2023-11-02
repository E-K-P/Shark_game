using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    public GameObject bullet;
    public Transform gun;
    public float bulletSpeed;

    public float fireRate = 0.1f;
    private float nextFire = 0.1f;

    void Update()
    {
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 lookAt = mouseScreenPosition;
        float AngleRad = Mathf.Atan2(lookAt.y - gun.transform.position.y, lookAt.x - gun.transform.position.x);
        float AngleDeg = (180/Mathf.PI) * AngleRad;
        gun.transform.rotation = Quaternion.Euler(0, 0, AngleDeg); //changes the rotation to face the mouse

        if (Input.GetMouseButton(0) && Time.time > nextFire) //check for player input and timer
        {
            nextFire = Time.time + fireRate; //timer update for new firerate
            GameObject bulletClone = Instantiate(bullet); //create bullet
            bulletClone.transform.position = gun.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, AngleDeg); //used to aim the bullet at the right direction
            bulletClone.GetComponent<Rigidbody2D>().velocity = gun.right * bulletSpeed; //apply movement into created bullet
            Destroy(bulletClone, 5f);
        }
    }
}
