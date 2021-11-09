using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour
{
    [SerializeField]
    private float delay = 0.5f;

    [SerializeField]    private GameObject bombPrefab;
    [SerializeField]    private GameObject bulletPrefab;

    private float lastTime;

    // Update is called once per frame
    private void Update()
    {
        if(Time.time - lastTime > delay){
            //SpawnBomb();
            SpawnBombFromPool();
            //SpawnBullet();
            //SpawnBulletFromPool();
        }
    }

    private void SpawnBomb(){
        lastTime = Time.time;

        Vector3 position = RandomPointInBox(transform.position, transform.localScale);

        var bomb = Instantiate(bombPrefab, position, Quaternion.identity);
    }

    private void SpawnBombFromPool(){
        lastTime = Time.time;

        Vector3 position = RandomPointInBox(transform.position, transform.localScale);

        var bomb = BasicPool.Instance.GetFromPool();
        bomb.transform.position = position;
    }

    private void SpawnBullet()
    {
        lastTime = Time.time;

        Vector3 position = this.transform.position;

        var bullet = Instantiate(bulletPrefab, position, Quaternion.identity);
    }

    private void SpawnBulletFromPool()
    {
        lastTime = Time.time;

        Vector3 position = this.transform.position;

        var bullet = BasicPool.Instance.GetFromPool();
        bullet.transform.position = position;
    }

    private static Vector3 RandomPointInBox(Vector3 center, Vector3 size) {
     
        return center + new Vector3(
            (Random.value - 0.5f) * size.x,
            (Random.value - 0.5f) * size.y,
            (Random.value - 0.5f) * size.z
        );
    }
}
