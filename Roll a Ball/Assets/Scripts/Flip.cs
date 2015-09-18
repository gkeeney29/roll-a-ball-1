using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flip : MonoBehaviour {
    public Text countText;

    void Update()
    {
        if (countText.text =="Count: 12")
        {
            transform.Rotate(new Vector2(90, 0) * Time.deltaTime);
        }
    }
}
