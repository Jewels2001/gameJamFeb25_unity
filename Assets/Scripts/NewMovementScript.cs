using UnityEngine;
using UnityEngine.InputSystem;

public class NewMovementScript : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public float speed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue movementVal)
    {
        Vector2 movementVec = movementVal.Get<Vector2>();


        movementX = movementVec.x;
        movementY = movementVec.y;

    }
    private void FixedUpdate() {

        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }


}
