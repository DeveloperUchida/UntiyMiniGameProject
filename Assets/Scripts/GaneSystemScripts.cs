using UnityEngine;

public class GaneSystemScripts : MonoBehaviour
{
    //GamePlayerMotionFunction
    public float PlayerControlSpeed; // Speed Control use UnityEditor
    private Rigidbody2D rb; //RigidBody2DDeclatation

    public float jumpPower; //PrivateJumpPowerDeclatation
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //GamePlayerControlCode
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,PlayerControlSpeed,0); //ForwardKey
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(PlayerControlSpeed,0,0); //LeftKey
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-PlayerControlSpeed,0); //BackKey
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0,0,0); //SpaceJumpKey
            rb.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
        }
    }
}
