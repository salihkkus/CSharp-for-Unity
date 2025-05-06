using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool Instance;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize = 20;

    private List<GameObject> bulletPool = new List<GameObject>();

    private void Awake()
    {
        // Singleton kur
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject bullet in bulletPool)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        // Eğer havuzda aktif olmayan mermi yoksa, yeni mermi ekle (opsiyonel)
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.SetActive(true);
        bulletPool.Add(newBullet);
        return newBullet;
    }
}
--------------------------------------------------------------------------------------------------
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = BulletPool.Instance.GetBullet();
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
        }
    }
}
