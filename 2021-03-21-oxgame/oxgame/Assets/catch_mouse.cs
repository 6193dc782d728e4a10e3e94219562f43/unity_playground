using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class catch_mouse : MonoBehaviour
{
    public Text my_text;
    
    // Start is called before the first frame update
    void Start()
    {
        my_text = GameObject.Find("my_Text").GetComponent<Text>();
        my_text.text = "圈方開始";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            my_text.text = "My text has now changed.";
        }
    }
}
