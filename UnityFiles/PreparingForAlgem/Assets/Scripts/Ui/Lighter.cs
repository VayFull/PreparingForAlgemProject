using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lighter : MonoBehaviour
{
    Color color;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<Image>().material.color;
        color = Color.Lerp(Color.black, Color.white, 3f);
        Invoke("Destroyer", 3);
    }

    void Update()
    {
        color.a -= 0.1f;
    }

    void Destroyer()
    {
        Destroy(parent);
    }
}
