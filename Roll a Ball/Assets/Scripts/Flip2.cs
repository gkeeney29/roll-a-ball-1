using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flip2 : MonoBehaviour
{
    public Text countText;

    void Update()
    {
        if (countText.text == "Count: 12")
        {
            transform.Rotate(new Vector3(90,0 ,90) * Time.deltaTime);
        }
    }
}
