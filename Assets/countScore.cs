using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countScore : MonoBehaviour
{
    public int count = 0;
    public Text txt;
    public Text ammo;
    public Shoot ammoScore;
    public int temp;
    // Start is called before the first frame update
    void Start()
    {
        ammoScore.GetComponent<Shoot>();
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<Text>();
        txt.text = "Score : " + count.ToString();
        temp = ammoScore.count;
    }
    public void increase()
    {
        count++;
        temp++;
        ammoScore.count = temp;
        ammo.text = "Ammo : " + temp.ToString();
    }
}
