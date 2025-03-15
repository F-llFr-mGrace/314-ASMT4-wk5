using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CombinationLock : MonoBehaviour
{
    [SerializeField] TMP_Text userInputText;

    [SerializeField] XrButtonInteractable[] comboButtons;

    // Start is called before the first frame update
    void Start()
    {
        userInputText.text = "";
        for (int i = 0; i < comboButtons.Length; i++)
        {
            comboButtons[i].selectEntered.AddListener(OnComboButtonPressed);
        }
    }

    private void OnComboButtonPressed(SelectEnterEventArgs arg0)
    {
        for (int i = 0; i < comboButtons.Length; i++)
        {
            if (arg0.interactableObject.transform.name == comboButtons[i].transform.name)
            {
                userInputText.text += i.ToString();
            }
            else
            {
                comboButtons[i].ResetColor();
            }
        }
    }
}
