using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShareOnline : MonoBehaviour
{
    private string _twitterUrl = "http://twitter.com/intent/tweet";
    private string _twitterLanguage = "en";
    private string _twitterDisplay = "My Solitaire High Score: ";

    public void ShareScore()
    {
        Application.OpenURL(_twitterUrl + "?text=" + WWW.EscapeURL(_twitterDisplay) + ScoreManager.HIGH_SCORE + "&amp;lang=" + WWW.EscapeURL(_twitterLanguage));
    }
}
