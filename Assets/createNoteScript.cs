using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createNoteScript : MonoBehaviour
{

    int currNote;
    public Button cnBtn;
    public InputField nInpFld;

    public GameObject note1;
    public GameObject note2;
    public GameObject note3;

    public TextMesh nt1;
    public TextMesh nt2;
    public TextMesh nt3;

    // Start is called before the first frame update
    void Start()
    {
        currNote = 0; //no note yet
        note1.SetActive(false);
        note2.SetActive(false);
        note3.SetActive(false);
    }

    public void createNote()
    {
        string noteText = nInpFld.text;
        nInpFld.text = ""; //clearing field
        ++currNote;

        if (currNote == 1)
        {
            nt1.text = noteText;
            note1.SetActive(true);
        }
        if(currNote == 2)
        {
            nt2.text = noteText;
            note2.SetActive(true);
        }
        if(currNote == 3)
        {
            nt3.text = noteText;
            note3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
