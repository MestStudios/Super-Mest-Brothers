using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour
{

    public float Speed = 0f;
    public float jumpForce =  500f;
    private float movex = 0f;
    public bool grounded = true;

    // Use this for initialization
    void Start() {
        Application.targetFrameRate = 100;
    }

    public void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            grounded = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movex = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(movex * Speed, 0);
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            grounded = false;
        }
    }
}
