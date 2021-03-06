using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObj;
    public float fDifficulty = 40f;

    float fSpawn = 0;

    // Update is called once per frame
    void Update()
    {
        fSpawn += fDifficulty * Time.deltaTime;
        fDifficulty += Time.deltaTime * 4f;

        while (fSpawn > 1)
        {
            fSpawn -= 1;

            // Creating vector3 positions for objects
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 40f - 20f);
            Quaternion qRotate = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            Vector3 v3Scale = new Vector3(Random.value + 0.1f, 10f, Random.value + 0.1f);

            // Creates object clones
            GameObject createObj = Instantiate(spawnObj, v3Pos, qRotate);

            // Adjust for random scaling
            createObj.transform.localScale = v3Scale;

        }
    }
}
