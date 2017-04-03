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

        dialogScript = 0;
        ImTalking.text = "";
        StartTalking(dialogScript);
		
	}
    
    //VN Style here
    public void StartTalking(int i)
    {

        switch (i)
        {

            case 0:
                //speech = "Hey";
                ImTalking.text = "Hey";
                Debug.Log("Zero");
                break;

            case 1:
                //speech = "Move you slowfeet...";
                ImTalking.text = "Move you slowfeet";
                Debug.Log("One");

                break;

            case 2:
                //speech = "it's not like i really want to talk to you";
                ImTalking.text = "it's not like i really want to talk to you!";
                Debug.Log("Two");

                break;

            default:
                break;
        }

        if (i >= 3)
        {
            dialogScript = 0;
            StartTalking(dialogScript);
        }

        //SpeechStart();

    }

    public void TapToContinue()
    {
        dialogScript += 1;
        StartTalking(dialogScript);
        Debug.Log(dialogScript.ToString());
    }

    IEnumerator SpeechStart()
    {

        foreach (char script in speech.ToCharArray())
        {
            ImTalking.text += script;
            yield return new WaitForSeconds(0.2f);
        }

    }

}
