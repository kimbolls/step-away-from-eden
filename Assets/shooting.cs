using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    
    public GameObject BeamProjectile;
    public Transform firepoint;

    GameObject Beam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        Beam = Instantiate(BeamProjectile,firepoint.position,firepoint.rotation);

    }
}
