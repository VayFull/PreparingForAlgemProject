using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToExam : MonoBehaviour
{
    public Vector3 fromPosition1;
    public Vector3 toPosition1;
    public float speed = 1;
    private float progress;

    void Update()
    {
        progress += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(fromPosition1, toPosition1, progress);
        if (transform.position==toPosition1) Destroy(GetComponent<EnterToExam>());
    }

    void Start()
    {
        fromPosition1 = transform.position;
    }
}
