using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCountScripts : MonoBehaviour
{
    public Text textObj;

    private int Score;

    public void AddScore(int Point)
    {
        Score += Point;
        textObj.text = "" + Score;
    }
}
