using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPos : MonoBehaviour
{
    public GameObject pipePrefab;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            var Clone = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            Destroy(Clone, 2f);
        }
    }
}
