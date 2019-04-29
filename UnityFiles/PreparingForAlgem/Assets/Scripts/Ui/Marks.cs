using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marks : MonoBehaviour
{
    public GameObject bad;
    public GameObject ok;
    public GameObject good;
    public GameObject excellent;
    public GameObject button;

    private int NumOfQuestions;
    private int NumOfMistakes;
    private float result;
    public GameObject controller;
    void Start()
    {
        NumOfMistakes = controller.GetComponent<QuestionsController>().WrongAnswers;
        NumOfQuestions = controller.GetComponent<QuestionsController>().numOfCurrAnswer;
        if (0.44f * NumOfQuestions < NumOfMistakes)
        {
            bad.SetActive(true);
        }

        if (0.44f *NumOfQuestions >= NumOfMistakes&& 0.29f * NumOfQuestions < NumOfMistakes)
        {
            ok.SetActive(true);
        }

        if (0.29f * NumOfQuestions >= NumOfMistakes&& 0.14f  * NumOfQuestions < NumOfMistakes)
        {
            good.SetActive(true);
        }

        if (0.14 * NumOfQuestions >= NumOfMistakes)
        {
            excellent.SetActive(true);
        }
       
        button.SetActive(true);
    }
}
