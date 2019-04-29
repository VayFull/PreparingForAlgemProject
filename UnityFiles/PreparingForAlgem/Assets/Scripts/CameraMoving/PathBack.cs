using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathBack : MonoBehaviour
{
    public GameObject obj;
    public GameObject teacher;
    public GameObject newTeacher;
    public GameObject result;

    void Start()
    {
        Invoke("StandUp", 0.5f);
        Invoke("RotateFromPlace", 1.5f);
        Invoke("FromPlace", 2.5f);
        Invoke("Destroy", 3f);
        Invoke("ReRotate", 3.5f);
        Invoke("RotateToTeacher", 4.5f);
        Invoke("ToTeacher", 5f);
        Invoke("ToTeacherRotate", 6f);
        Invoke("GetResult", 8f);
    }


    public void StandUp()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-25.5f, 13, 0.5f);
    }

    public void RotateFromPlace()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = -1.8f;
    }

    public void FromPlace()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-34, 13, 0);
    }

    public void ReRotate()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = 2.5f;
    }

    public void ToTeacher()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-30, 13, 7.25f);
    }

    public void ToTeacherRotate()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = 1.2f;
    }

    public void Destroy()
    {
        Destroy(teacher);
        newTeacher.SetActive(true);
    }

    public void GetResult()
    {
        result.SetActive(true);
    }







}
