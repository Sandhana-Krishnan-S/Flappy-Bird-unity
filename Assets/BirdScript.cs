using UnityEngine;

public class BirdScript : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D Rigidbody2D;
    public float flapStrength;
    public gameLogicHandler logic;
    public bool isAlive = true;
    void Start() {
        logic = GameObject.FindGameObjectWithTag("gameLogic").GetComponent<gameLogicHandler>();
    }

    // Update is called once per frame
    void Update() {
        if((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && isAlive) {
            Rigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y <= -18 || transform.position.y >= 18) {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isAlive = false;
        logic.gameOver();
    }
}
