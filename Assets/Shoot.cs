using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float speed = 2f;
    public int count = 10;

    public Text txt;

    public GameObject restart;
    public GameObject fire;

    public AudioSource shootSound;

    public void shootBullet()
    {
        shootSound.GetComponent<AudioSource>();
        shootSound.Play();
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.right *  Time.deltaTime + bulletSpawnPoint.up * speed;
        Destroy(bullet.gameObject, 3f);
        count--;
        txt.text = "Ammo : " + count.ToString();
    }
    public void changeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    public void Update()
    {
        if(count <= 0)
        {
            Debug.Log("You Loosed");
            restart.GetComponent<GameObject>();
            fire.GetComponent<GameObject>();
            restart.SetActive(true);
            fire.SetActive(false);
        }
        else
        {
            restart.GetComponent<GameObject>();
            restart.SetActive(false);
            fire.GetComponent<GameObject>();
            fire.SetActive(true);
        }
    }
    public void onClickRestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
