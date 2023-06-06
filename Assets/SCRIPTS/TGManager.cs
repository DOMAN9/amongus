using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TGManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,hpTextMeshPro, statTextMeshPro;
    public string storyText;
    public int HPVAL, STAVAL;
    public GameObject STRTandEXT, Lvl1Choices, Lvl2Choices; //CALL LEVEL 1 BUTTONS
 
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText; // MAIN TEXT FOR STORY, THIS IS WHERE YOU INSERT BODY TEXT ETC ETC
        hpTextMeshPro.text = HPVAL.ToString(); //CALL FOR HP VALUE
        statTextMeshPro.text = STAVAL.ToString(); //CALL FOR STAMINA VALUE


    }

//START AND EXIT BUTTONS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void STARTbot() //START BUTTON
    {

        storyText = "You are soaking in the rain and you see a cottage ahead, what do you do";
        STRTandEXT.SetActive(false);// start and exit will disappear
        Lvl1Choices.SetActive(true); // level 1 buttons will disappear
        Lvl2Choices.SetActive(false); // shows second choices
        
    }
    public void EXITbot() //EXIT BUTTON
    {
        Application.Quit();
    }

 //A AND B BITTONS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void GoToCottage() //A 
    {
        storyText = "you find yourself in somehwat of a witches hu, and its warm inside";
        HPVAL += 2;

        Lvl1Choices.SetActive(false); // level 1 buttons will disappear
        Lvl2Choices.SetActive(true); // shows second choices


    }
    public void Stare() //B
    {
        storyText = "*shivers, Its freezing";
        HPVAL -= 2;

        Lvl1Choices.SetActive(false);
    }

 //A.1 AND A.2 BITTONS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void A1() //A.1
    {
        Lvl1Choices.SetActive(false);
        storyText = "you have run from the rain, but you are cold";
        HPVAL -= 1;

        
    }
}
