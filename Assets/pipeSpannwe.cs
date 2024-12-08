using UnityEngine;

public class pipeSpannwe : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnRate = 10;
    public float time = 0;
    public float hightOffset = 6;
    public gameLogicHandler logic;

    int scoreUpdate = 10;
    void Start() {
        spawnPipe();
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        if (time > spawnRate) {
            spawnPipe();
            time = 0;
        }
        if(spawnRate >= 3 && logic.score == scoreUpdate) {
            scoreUpdate *= 2;
            spawnRate--;
        }
        
    }

    void spawnPipe() {
        float min = transform.position.y - hightOffset;
        float max = transform.position.y + hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(min , max) , transform.position.z), transform.rotation);
    }
}
