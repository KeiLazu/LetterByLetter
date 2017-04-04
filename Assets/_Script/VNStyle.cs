using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VNStyle : MonoBehaviour {

    [SerializeField]
    Text ImTalking;

    int dialogScript;
    string speech;

	// Use this for initialization
	void Start () {

        ImTalking.text = "";
		
	}
    
    //VN Style here
    public void StartTalking(int i)
    {

        switch (i)
        {

            case 0:
                speech = "Hey you";
                //ImTalking.text = "Hey";
                Debug.Log("Zero");
                break;

            case 1:
                speech = "Move you slowfeet...";
                //ImTalking.text = "Move you slowfeet";
                Debug.Log("One");

                break;

            case 2:
                speech = "it's not like i really want to talk to you";
                //ImTalking.text = "it's not like i really want to talk to you!";
                Debug.Log("Two");

                break;
                
        }

    }

    public void TapToContinue()
    {

        if (dialogScript > 2)
        {

            dialogScript = 0;

        }

        ImTalking.text = "";

        StartCoroutine(SpeechStart());

        dialogScript += 1;
        Debug.Log(dialogScript.ToString());

    }

    IEnumerator SpeechStart()
    {
        StartTalking(dialogScript);

        foreach (char script in speech.ToCharArray())
        {

            ImTalking.text += script;
            yield return new WaitForSeconds(0.05f);
        }

    }

}
