using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class KeypadController : MonoBehaviour
{
    public List<int> correctPassword = new List<int>();
    private List<int> inputPasswordList = new List<int>();
    [SerializeField] private Text codeDisplay;
    [SerializeField] private float resetTime = 2f;
    [SerializeField] private string SuccessText;

    [Space(5f)]
    [Header("Keypad Entry Events")]
    public UnityEvent onCorrectPassword;
    public UnityEvent onInCorrectPassword;

    public bool allowMultipleActivations = false;
    private bool hasUsedCorrectCode = false;

    public bool HasUsedCorrectCode { get { return hasUsedCorrectCode; } }

    public GameObject blood;

    public void UserNumberEntry(int selectedNum)
    {
        if (inputPasswordList.Count >= 4)
            return;

        Debug.Log(selectedNum);
        inputPasswordList.Add(selectedNum);

        UpdateDisplay();

        if (inputPasswordList.Count >= 4)
            CheckPassword();

    }
    private void CheckPassword()
    {
        for (int i = 0; i < correctPassword.Count; i++)
        {
            if (inputPasswordList[i] != correctPassword[i])
            {
                InCorrectPassword();
                return;
            }else correctPasswordGiven();
        }
        // correctPasswordGiven();
    }


    private void correctPasswordGiven()
    {
        if (allowMultipleActivations)
        {
            onCorrectPassword.Invoke();
            codeDisplay.text = SuccessText;
            StartCoroutine(ResetKeyCode());
            blood.SetActive(true);
        }
        else if (!allowMultipleActivations && !hasUsedCorrectCode)
        {
            onCorrectPassword.Invoke();
            hasUsedCorrectCode = true;
            codeDisplay.text = SuccessText;
            blood.SetActive(true);
        }
    }
    private void InCorrectPassword()
    {
        onInCorrectPassword.Invoke();
        StartCoroutine(ResetKeyCode());
    }


    IEnumerator ResetKeyCode()
    {
        yield return new WaitForSeconds(resetTime);
        inputPasswordList.Clear();
        codeDisplay.text = "Enter code...";
    }
    private void UpdateDisplay()
    {
        codeDisplay.text = null;
        for (int i = 0; i < inputPasswordList.Count; i++)
        {
            codeDisplay.text += inputPasswordList[i].ToString();
        }
    }
    public void DeleteEntry()
    {
        if (inputPasswordList.Count <= 0)
            return;

        var listposition = inputPasswordList.Count - 1;
        inputPasswordList.RemoveAt(listposition);

        UpdateDisplay();
    }
}
