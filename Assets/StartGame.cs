using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject fire;
    public GameObject start;
    public GameObject rules;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickStartGame()
    {
        fire.GetComponent<GameObject>();
        fire.SetActive(true);
        start.GetComponent<GameObject>();
        start.SetActive(false);
        rules.GetComponent<GameObject>();
        rules.SetActive(false);
    }
}
