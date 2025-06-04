using UnityEngine;

public class player_move : MonoBehaviour
{
    public FrameWork Phoenix;

    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (rb != null) {
            Move();
            Jump();
        }
        else
        {
            Debug.LogError("RigidBody is Null");
        }
    }
    void Move(){
        Phoenix.MovePlayer(rb, transform);

    }
    void Jump()
    {
        Phoenix.Jump(rb);
    }

    void OnCollisionEnter(Collision collision)
{
    Phoenix.CheckGround(collision);
}
}
