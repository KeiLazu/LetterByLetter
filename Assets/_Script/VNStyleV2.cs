using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * next time, i need to do this slowly and carefully, since there's no references left that could help me anymore to the goal that i want to achieve
 * trial and error, also lots of commit will be a bad things......
 */

public class VNStyleV2 : MonoBehaviour
{

    [SerializeField]
    Text txt_TestSubject;

    string dialogComplete; //for complete dialog placement
    int switchingDialog; //for switching between dialog placement, incrementing, but in here, i set 'em for loop-loop-loop-loop-loop-loop-...
    bool stillWalking, makeEmRunning; //observer that look into the text, is it still walking?, or just reach the end of text length?

    //init
    private void Start()
    {
        switchingDialog = 0;
        stillWalking = true;
    }

    //put text here
    public void StartTalking(int i)
    {

        switch (i)
        {

            case 0:
                dialogComplete = "Hey you, Move you slowpoke";
                //ImTalking.text = "Hey";
                //Debug.Log("Zero");
                break;

            case 1:
                dialogComplete = "It's not like really want to talk to you";
                //ImTalking.text = "Move you slowfeet";
                //Debug.Log("One");

                break;

            case 2:
                dialogComplete = "Blushing? humph, i'm not blushing, it's not because i have a crush to you or something (/// ///)";
                //ImTalking.text = "it's not like i really want to talk to you!";
                //Debug.Log("Two");

                break;

            case 3:
                switchingDialog = 0;
                StartTalking(switchingDialog);
                break;

        }

    }

    //show text here
    public void TapToContinue()
    {
        //StartTalking(switchingDialog);
        //txt_TestSubject.text = dialogComplete.ToString();

        if (stillWalking == true)
        {
            makeEmRunning = false;
            txt_TestSubject.text = "";

            StartCoroutine(AnimationText());

            //counting up
            switchingDialog += 1;
            Debug.Log("status for stillwalking: " + stillWalking);
            stillWalking = false;
        }
        else
        {
            SkipforNext();
            Debug.Log("status for stillwalking: " + stillWalking);
        }

    }

    protected void SkipforNext()
    {
        IEnumerator animatingText = AnimationText();

        makeEmRunning = true;
        StopCoroutine(animatingText);

    }

    //typing here
    IEnumerator AnimationText()
    {
        StartTalking(switchingDialog);

        foreach (char script in dialogComplete.ToCharArray())
        {
            txt_TestSubject.text += script;

            if (makeEmRunning == true)
            {
                yield return new WaitForSeconds(.01f / dialogComplete.Length);
            } else
            {
                yield return new WaitForSeconds(.2f);
            }

        }

        makeEmRunning = false;
        stillWalking = true;

    }

}

/**
 * FINALLY! HERE'S WHAT I WANT LOL!
 */ 
