using System;
using UnityEngine;

public class colliderPoint : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public gameLogicHandler logic;
    void Start() {
        logic = GameObject.FindGameObjectWithTag("gameLogic").GetComponent<gameLogicHandler>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {
            logic.addScore(1);
        }
    }
}
