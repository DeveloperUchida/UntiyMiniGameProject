using UnityEngine;
using UnityEngine.UI;
public class ScoreCountScripts : MonoBehaviour
{
    public Text textObj;

    private int Score;
    void Start()
    {
        Score = 0;
    }
    void Update()
    {
        textObj.text = "現在の点数" + Score.ToString();
    }
    void OnMouseDown()
    {
        Score++;
    }

}
