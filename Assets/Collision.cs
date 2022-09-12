using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public EnemySpawn spawn;
    public countScore count;
    public SliderControlledFireScript change;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Bullets")
        {
            spawn.count = 0;
            count.increase();
            change.speed = Random.Range(100, 300);
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}
