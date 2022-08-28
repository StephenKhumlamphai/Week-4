using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public int i = 3;
    public int randInt;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        randInt = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (gameObject.tag == "Red" && i == 100) {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == randInt) {
            rend.enabled = !rend.enabled;
        }
    }
}
