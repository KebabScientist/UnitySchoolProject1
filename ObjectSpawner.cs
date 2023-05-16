using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float delay = 1;


    public int start_x;
    public int end_x;

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
            int x = Random.Range(start_x, end_x);
            GameObject obstacle_clone = Instantiate(obstacle, new Vector3(transform.position.x, 0, x), Quaternion.identity);
            obstacle_clone.SetActive(true);

            float initialXPos = obstacle_clone.transform.position.x;
            float distanceThreshold = 50.0f; // The distance at which the obstacle should be destroyed

            while (obstacle_clone != null && obstacle_clone.transform.position.x - initialXPos < distanceThreshold)
            {
                yield return null;
            }

            if (obstacle_clone != null)
            {
                Destroy(obstacle_clone);
            }

            spawn = true;
        }

    }
}