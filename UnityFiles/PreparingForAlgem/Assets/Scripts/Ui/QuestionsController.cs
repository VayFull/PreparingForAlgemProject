using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class QuestionsController : MonoBehaviour
{
    public Text Question;
    public Text Btn1Text;
    public Text Btn2Text;
    public Text Btn3Text;
    public Text Btn4Text;
    public GameObject GameLogicUI;
    public GameObject PathBack;
    [SerializeField]
    List<string> questions = new List<string>();
    [SerializeField]
    List<string> answer1 = new List<string>();
    [SerializeField]
    List<string> answer2 = new List<string>();
    [SerializeField]
    List<string> answer3 = new List<string>();
    [SerializeField]
    List<string> answer4 = new List<string>();
    [SerializeField]
    List<string> argument1 = new List<string>();
    [SerializeField]
    List<string> argument2 = new List<string>();
    [SerializeField]
    List<string> argument3 = new List<string>();
    [SerializeField]
    List<string> argument4 = new List<string>();
    [SerializeField]
    List<string> rightAnwser = new List<string>();

    [SerializeField]
    private string pathToQuestions;
    [SerializeField]
    private int RightAnswer;
    [SerializeField]
    public int numOfCurrAnswer;

    public int WrongAnswers;

    public void Btn1Pushed()
    {
        GetAnswer(1);
    }

    public void Btn2Pushed()
    {
        GetAnswer(2);
    }

    public void Btn3Pushed()
    {
        GetAnswer(3);
    }

    public void Btn4Pushed()
    {
        GetAnswer(4);
    }
    /// <summary>
    /// 0 индекс: вопрос
    /// 1-4: ответы
    /// 5-8: пояснения
    /// 9: (число, правильный вариант ответа)
    /// </summary>
    public void Parser()
    {
        #region Input
        var answers=File.ReadAllLines(pathToQuestions);
        for (int i = 0; i < answers.Length-1; i++)
        {
            switch (i%10)
            {
                case 0:
                    questions.Add(answers[i]);
                    break;
                case 1:
                    answer1.Add(answers[i]);
                    break;
                case 2:
                    answer2.Add(answers[i]);
                    break;
                case 3:
                    answer3.Add(answers[i]);
                    break;
                case 4:
                    answer4.Add(answers[i]);
                    break;
                case 5:
                    argument1.Add(answers[i]);
                    break;
                case 6:
                    argument2.Add(answers[i]);
                    break;
                case 7:
                    argument3.Add(answers[i]);
                    break;
                case 8:
                    argument4.Add(answers[i]);
                    break;
                case 9:
                    rightAnwser.Add(answers[i]);
                    break;

            }
        }
        #endregion
    }

    public void GetAnswer(int answer)
    {
        if (numOfCurrAnswer == rightAnwser.Count)
        {
            GameLogicUI.SetActive(false);
            PathBack.SetActive(true);
        } //в конце должен быть вопрос, на который все ответы правильные
            
        Debug.Log(numOfCurrAnswer.ToString());
        var k = answer;
        var l = rightAnwser[numOfCurrAnswer];
        Debug.Log("GetAnswer");
        if (k == int.Parse(l))
        {
            numOfCurrAnswer++;
            NextQuestion();
            Debug.Log("TrueAnswer");
        }
        else
        {
            WrongAnswers++;
            Debug.Log("WrongAnswer");
            WriteUnderstanding();
        }
    }

    void Start()
    {
        pathToQuestions=Application.dataPath + "/StreamingAssets/Questions.txt";
        Parser();
        Question.text = questions[0];
        Btn1Text.text = answer1[0];
        Btn2Text.text = answer2[0];
        Btn3Text.text = answer3[0];
        Btn4Text.text = answer4[0];
        RightAnswer = int.Parse(rightAnwser[0]);
    }

    public void NextQuestion()
    {
        Question.text = questions[numOfCurrAnswer];
        Btn1Text.text = answer1[numOfCurrAnswer];
        Btn2Text.text = answer2[numOfCurrAnswer];
        Btn3Text.text = answer3[numOfCurrAnswer];
        Btn4Text.text = answer4[numOfCurrAnswer];
        RightAnswer = int.Parse(rightAnwser[numOfCurrAnswer]);
    }

    public void WriteUnderstanding()
    {
        Btn1Text.text = argument1[numOfCurrAnswer];
        Btn2Text.text = argument2[numOfCurrAnswer];
        Btn3Text.text = argument3[numOfCurrAnswer];
        Btn4Text.text = argument4[numOfCurrAnswer];
    }
}
