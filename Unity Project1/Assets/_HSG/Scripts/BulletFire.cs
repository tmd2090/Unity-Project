using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletFactory;    //총알 공장(프리팹)
    public Transform firePoint;         //총알 발사위치
    float time;

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        time += Time.deltaTime;

        if(time>0.5)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePoint.position;
            time = 0;
        }
    }

}
