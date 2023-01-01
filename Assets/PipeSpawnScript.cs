using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 10;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else if (!logic.gameOverStatus)
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
            timer = 0;
        }
        
    }
}
