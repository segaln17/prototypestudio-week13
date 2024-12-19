using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using Yarn.Unity;

public class CustomCommands : MonoBehaviour
{
    public AudioSource soundSource;
    public AudioClip ding;

    public Animator susieAnim;
    
    public PlayableDirector endTimeline;
    public GameObject myLetter;

    public GameObject enemyLetter;
    
    //things it will be changed to
    public TextMeshProUGUI enemyLetterText1;

    public TextMeshProUGUI enemyLetterText2;

    public TextMeshProUGUI directorText;

    public TextMeshProUGUI myLetterText1;

    public TextMeshProUGUI myLetterText2;
    
    //the one that gets changed
    public TextMeshProUGUI myLetterText;
    public TextMeshProUGUI enemyLetterText;
    
    // Start is called before the first frame update
    void Start()
    {
        myLetter.SetActive(false);
        enemyLetter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("revealMyLetter")]
    public void RevealMyLetter()
    {
        myLetter.SetActive(true);
    }

    [YarnCommand("hideMyLetter")]
    public void HideMyLetter()
    {
        myLetter.SetActive(false);
    }
    
    [YarnCommand("revealEnemyLetter")]
    public void RevealEnemyLetter()
    {
        enemyLetter.SetActive(true);
    }

    [YarnCommand("hideEnemyLetter")]
    public void HideEnemyLetter()
    {
        enemyLetter.SetActive(false);
    }
    
    [YarnCommand("GeraldineLetter2")]
    public void ChangeLetterGeraldine2()
    {
        enemyLetterText1.gameObject.SetActive(false);
        enemyLetterText2.gameObject.SetActive(true);
    }

    [YarnCommand("myLetter1")]
    public void ChangeMyLetter1()
    {
        myLetterText1.gameObject.SetActive(true);
    }
    
    [YarnCommand("myLetter2")]
    public void ChangeMyLetter2()
    {
        myLetterText1.gameObject.SetActive(false);
        myLetterText2.gameObject.SetActive(true);
    }
    
    [YarnCommand("directorLetter")]
    public void ChangeDirectorLetter()
    {
        myLetterText2.gameObject.SetActive(false);
        directorText.gameObject.SetActive(true);
    }

    [YarnCommand("playTimeline")]
    public void PlayTimeline()
    {
        endTimeline.Play();
        susieAnim.SetBool("Active", true);
    }

    [YarnCommand("playDing")]
    public void PlayDing()
    {
        soundSource.PlayOneShot(ding);
    }
}
