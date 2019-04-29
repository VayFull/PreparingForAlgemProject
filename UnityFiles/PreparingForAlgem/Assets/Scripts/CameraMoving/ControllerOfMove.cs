using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControllerOfMove : MonoBehaviour
{
    public GameObject obj;
    public GameObject teacher;
    public GameObject newTeacher;
    public GameObject GameLogicUI;
    public GameObject Dialog;
    void Start()
    {
        ToRoom(-37, 13, 7.5f);
        Invoke("RotateToTeacher", 1);
        Invoke("ToTeacher", 2.2f);
        Invoke("GetNotices", 2.5f);
        Invoke("FixTeacher", 5.7f);
        Invoke("ReRotate", 5);
        Invoke("ToPlace", 6);
        Invoke("RotateToPlace", 7);
        Invoke("ToTable", 8);
        Invoke("ToTeacherSite", 9);
        Invoke("SitDown", 10);
        Invoke("StartGame", 11);
    }


    public void GetNotices()
    {
        Dialog.SetActive(true);
    }

    public void ToRoom(float x, float y, float z)
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(x, y, z);
    }

    public void ToTeacher()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-30, 13, 7.25f);
    }

    public void RotateToTeacher()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = -1.8f;
    }

    public void ReRotate()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = 2.37f;
        Dialog.SetActive(false);
    }

    public void ToPlace()
    {
        obj.AddComponent<EnterToExam>().toPosition1=new Vector3(-34, 13, 0);
    }

    public void RotateToPlace()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = -2.4f;
    }

    public void ToTable()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-25.5f, 13, 0.5f);
    }

    public void ToTeacherSite()
    {
        obj.AddComponent<CleverRotater>().SpeedAndSite = -1.8f;
    }

    public void SitDown()
    {
        obj.AddComponent<EnterToExam>().toPosition1 = new Vector3(-25.5f, 12, 0.5f);
    }

    public void FixTeacher()
    {
        Destroy(teacher);
        newTeacher.SetActive(true);
    }

    public void StartGame()
    {
        GameLogicUI.SetActive(true);
    }
}
