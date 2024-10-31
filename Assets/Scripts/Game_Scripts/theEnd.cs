using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class theEnd : MonoBehaviour
{
    int count = 0;
    List<string> userInput = new List<string>();
    public List<string> code = new List<string>();
    [SerializeField] AudioSource error;
    [SerializeField] AudioSource clicks;

    private void Awake()
    {
        code.Add("g");
        code.Add("b");
        code.Add("r");
        code.Add("y");
    }

    bool codeIsCorrect = true;

    private void Update()
    {
        if (count == 4)
        {
            codeIsCorrect = true;

            for (int i = 0; i < code.Count; i++)
            {
                if (code[i] != userInput[i])
                {
                    codeIsCorrect = false;
                }
            }

            if (codeIsCorrect == false)
            {
                count = 0;
                userInput.Clear();
                error.Play();
            }
            else
            {
                SceneManager.LoadScene("theEnd");
            }
        }
    }
    public void AddUserInput(string color)
    {
        count += 1;
        userInput.Add(color);
        clicks.Play();
    }
}