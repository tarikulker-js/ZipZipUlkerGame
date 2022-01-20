using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Spawner : MonoBehaviour
{
    public Joystick_Controller CharacterScript;
    Transform tr;
    public GameObject ground;
    public int groundNumber;
    public float groundInterval;
    public float minimumy, maxy;

    void Start()
    {
        tr = ground.GetComponent<Transform>();

        Vector3 spawnLocation = new Vector3();
        Vector2 newScale = new Vector2();

        StartCoroutine(SpawnObject());

    }

    public IEnumerator SpawnObject(){
                tr = ground.GetComponent<Transform>();

        Vector3 spawnLocation = new Vector3();
        Vector2 newScale = new Vector2();


        while (!CharacterScript.isDead){
            //ground genislik ve yukseklik randoma baglandi:

            newScale.x = Random.Range(2f, 3.5f);
            newScale.y = Random.Range(0.5f, 0.6f);

            tr.localScale = newScale;

            //spawn konumu radnoma baglanmasi
            spawnLocation.y += Random.Range(minimumy, maxy);
            spawnLocation.x += Random.Range(-groundInterval, groundInterval);

            //Spawn islemi
            Instantiate(ground, spawnLocation,  Quaternion.identity);

            yield return new WaitForSeconds(0.5f);
        }

        while (CharacterScript.isDead){
            //ground genislik ve yukseklik randoma baglandi:

            newScale.x = Random.Range(2f, 3.5f);
            newScale.y = Random.Range(0.5f, 0.6f);

            tr.localScale = newScale;

            //spawn konumu radnoma baglanmasi
            spawnLocation.y += Random.Range(minimumy, maxy);
            spawnLocation.x += Random.Range(-groundInterval, groundInterval);

            //Spawn islemi
            Instantiate(ground, spawnLocation,  Quaternion.identity);

            yield return new WaitForSeconds(0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
