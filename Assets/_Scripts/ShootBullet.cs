using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject gunTransform;

    public GameObject Bullet;
    public float spawnSpeed = 10f;

    
    public void Shoot()
    {

        GameObject spawnBall = Instantiate(Bullet, gunTransform.transform.position, Quaternion.identity);
        Rigidbody spawnedBallRB = spawnBall.GetComponent<Rigidbody>();
        spawnedBallRB.velocity = -gunTransform.transform.right * spawnSpeed;
        
    }
}
