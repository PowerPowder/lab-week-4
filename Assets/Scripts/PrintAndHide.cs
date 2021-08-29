using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    private int random;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(name + ":" + i);

        if (i == 100 && gameObject.tag == "Red")
            gameObject.SetActive(false);
        if (i == random && gameObject.tag == "Blue")
            rend.enabled = false;
    }
}
