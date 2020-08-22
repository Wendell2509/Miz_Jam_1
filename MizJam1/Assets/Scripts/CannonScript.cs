using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public GameObject Bullet;
    public bool Activated;
    public float timeBtwShoots;
    public Transform gunPoint;

    public int pooledAmount = 30;
    public List<GameObject> Bullets;

    private void Start()
    {
        Bullets = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(Bullet);
            obj.SetActive(false);
            Bullets.Add(obj);
        }

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
            for (int i = 0; i < Bullets.Count; i++)
            {
                if (!Bullets[i].activeInHierarchy)
                {
                    Bullets[i].transform.position = gunPoint.transform.position;
                    Bullets[i].transform.rotation = gunPoint.transform.rotation;
                    Bullets[i].SetActive(true);
                    break;
                }
            }

            //Instantiate(Bullet, gunPoint.transform.position, transform.rotation);
        }

        StartCoroutine(Shoot());
    }
}