using UnityEngine;

public class UntiyFrameRateScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = 60; //フレームレートを60に制限
    }
}
