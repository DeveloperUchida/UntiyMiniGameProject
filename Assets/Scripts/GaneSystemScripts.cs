using UnityEngine;

public class GaneSystemScripts : MonoBehaviour
{
    //GamePlayerMotionFunction
    public float PlayerControlSpeed; // Speed Control use UnityEditor

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GamePlayerControlCode
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,PlayerControlSpeed,0);
        }
    }
}
