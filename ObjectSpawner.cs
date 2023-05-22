using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float delay = 1;


    public int start_z;
    public int end_z;

    bool spawn = true;


    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            StartCoroutine(spawnobject());
        }

        IEnumerator spawnobject() //Code allows to spawn a obstacle and then make it disappear after a set amount of distance
        {
            spawn = false;
            yield return new WaitForSeconds(delay);
            int z = Random.Range(start_z, end_z);
            GameObject obstacle_clone = Instantiate(obstacle, new Vector3(transform.position.x, 6, z), Quaternion.identity);
            obstacle_clone.SetActive(true);

            spawn = true;
        }

    }
}