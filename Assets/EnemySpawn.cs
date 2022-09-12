using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemyPrefab;
    public int count;
    public int xPos;
    public int zPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawnTarget());
    }
    public IEnumerator spawnTarget()
    {
        while(count < 1)
        {
            xPos = Random.Range(0, 8);
            zPos = Random.Range(-3, 3);
            var enemy = Instantiate(enemyPrefab, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.00010f);
            count += 1;
        }
    }
}
