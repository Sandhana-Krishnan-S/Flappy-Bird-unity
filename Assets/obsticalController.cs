using UnityEngine;
using UnityEngine.UIElements;

public class obsticalController : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5;
    public float killTime = -33;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        if(transform.position.x < killTime) Destroy(gameObject);
    }
}
