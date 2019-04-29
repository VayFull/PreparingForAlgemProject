using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleverRotater : MonoBehaviour
{
    public float TimeToRotate;
    public float SpeedAndSite;
    CleverRotater rotater;
    [SerializeField]
    float range;
    void Start()
    {
        TimeToRotate = 1f;
        rotater = GetComponent<CleverRotater>();
        Invoke("Destroyer", TimeToRotate);
        range = System.Math.Abs(TimeToRotate * SpeedAndSite);
    }

    public CleverRotater(float TimeToRotate, float SpeedAndSite)
    {
        this.TimeToRotate = TimeToRotate;
        this.SpeedAndSite = SpeedAndSite;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, SpeedAndSite, 0);
    }

    void Destroyer()
    {
        Destroy(rotater);
    }
}
