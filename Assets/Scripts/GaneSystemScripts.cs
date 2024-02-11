using UnityEngine;

public class GaneSystemScripts : MonoBehaviour
{
    //GamePlayerMotionFunction
    public float PlayerControlSpeed; // Speed Control use UnityEditor
    private Rigidbody2D rb; //RigidBody2D Declatation

    public float jumpPower; //PrivateJumpPower Declatation
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //GamePlayerControlCode
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, PlayerControlSpeed * Time.deltaTime, 0); //ForwardKey
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-PlayerControlSpeed * Time.deltaTime, 0, 0); //LeftKey
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -PlayerControlSpeed * Time.deltaTime, 0); //BackKey
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(PlayerControlSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpPower, ForceMode2D.Impulse); //SpaceJumpKey

            //JumpAudio
            GetComponent<AudioSource>().Play();
        }
    }
}
