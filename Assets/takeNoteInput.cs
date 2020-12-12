using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeNoteInput : MonoBehaviour
{
    public InputField inputField;
    public Button createNoteButton;
    public Text note;
    
    public void setNote()
    {
        Debug.Log("Entered note: " + inputField.text);
        note.text = inputField.text;
    }
}