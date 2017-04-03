using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterbyLetter : MonoBehaviour {

    [SerializeField]
    protected Text Yuki;

    string message;

    private void Start()
    {
        message = Yuki.text;
        Yuki.text = "";
        StartCoroutine(Daisuki());

    }

    IEnumerator Daisuki()
    {
        foreach (char letter in message.ToCharArray())
        {
            Yuki.text += letter;
            yield return new WaitForSeconds(0.2f);
            
        }

    }

}
