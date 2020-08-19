using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public GameObject Bullet;
    public bool Activated;
    public bool rotationActivated;
    public float timeBtwShoots;
    public Transform gunPoint;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    private void Update()
    {
    }

    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeBtwShoots);
        if (Activated)
        {
            Instantiate(Bullet, gunPoint.transform.position, transform.rotation);
        }
        if (rotationActivated)
        {
            //rotate 90 degrees
        }
        StartCoroutine(Shoot());
    }
}