using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TGManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,hpTextMeshPro, statTextMeshPro;
    public string storyText;
    public int HPVAL, STAVAL;
    public GameObject STRTandEXT, CHOICES, STAY, HPdisp, STATSdisp , Lvl1Choices, Lvl2Choices, Lvl3Choices, Lvl4Choices, Endings, Ending1, Ending2, Ending3, Ending4; //CALL LEVEL 1 BUTTONS
 
    // Start is called before the first frame update
    void Start()
    {
        CHOICES.SetActive(false);
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

        storyText = "it was raining, you are on your 4th month of being alone and almost a year into the apocalypse." +
            "you dont know what to do and yopu feel your insanity slowly fading as time passes by." +
            "Seeing your rations being down to  a can of peaches, you are in need to move out to look for sustinance, what do you do?";
        STRTandEXT.SetActive(false);// start and exit will disappear
        CHOICES.SetActive(true);
        Lvl1Choices.SetActive(true); // level 1 buttons will disappear
        Lvl2Choices.SetActive(false);
        Lvl3Choices.SetActive(false);
        Lvl4Choices.SetActive(false);
        Endings.SetActive(false);
        HPVAL= 5; HPdisp.SetActive(true);//HP display
        STAVAL= 3; STATSdisp.SetActive(true);//Stat display
        
    }
    public void EXITbot() //EXIT BUTTON
    {
        Application.Quit();
    }

 //A AND B BITTONS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void A1() //A 
    {
        storyText = "Waking up, you hear monsters banging on your door, looking around you see a window leading outside.";
        HPVAL += 2;

        CHOICES.SetActive(true) ;
        Lvl1Choices.SetActive(true); ; // level 1 buttons will disappear
        Lvl2Choices.SetActive(false); // shows second choices
        Lvl3Choices.SetActive(false);
        Lvl4Choices.SetActive(false);
        Endings.SetActive(false);

    }
    public void B1() //B
    {
        storyText = "Waking up, you hear monsters banging on your door, looking around you see a window leading outside." +
            "With your stomach begging for foof or the monsters outside, what do you do first?";
        HPVAL -= 2;

        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(false);
        Lvl3Choices.SetActive(true);
        Lvl4Choices.SetActive(false);
        Endings.SetActive(false);
    }

 //A.1 AND A.2 BITTONS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void A1_1() //A.1
    {
        
        storyText = "You ready you rwea[pon and your sanity to fight off the monsters" +
            "And an attempt to make things lighter, you level your head and slam your weapon on the monsters head ina rhythmic pattern" +
            "you feel something in your stomach and in an attempt to medicate, you eye the only remaining antibiotics you have";
        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(false);   
        Lvl3Choices.SetActive(false);
        Lvl4Choices.SetActive(true);

        HPVAL -= 1;
    }

    public void A1_2() 
    {
        storyText = "You Plummit to death due to the height of the building";
        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(false);
        Lvl3Choices.SetActive(false);
        Lvl4Choices.SetActive(false);
        Endings.SetActive(false);
        HPVAL = 0;
        STAVAL = 0;
    }
//B.1 and B.2//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void JumpB()
    {
        storyText = "You Plummit to death due to the height of the building";
        Endings.SetActive(true);
        Ending3.SetActive(true);

        HPVAL = 0;
        STAVAL = 0;
    }

    public void Eat()
    {
        storyText = "You feel something in your stomach and in an attempt to medicate, your eye the one remaining antibiotics you have";
        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(false);
        Lvl3Choices.SetActive(false);
        Lvl4Choices.SetActive(true);
        Endings.SetActive(false);
        HPVAL = 0;
        STAVAL = 0;
    }
    //ENDINGS////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void ENDING1()
    {
        storyText = "YOU GOT INFECTED BY THE VIRUS";
        Endings.SetActive(true);

        HPVAL = 0;
        STAVAL = 0;
    }

    public void ENDING2()
    {
        storyText = "YOU SURVIVED AND YOUR HEALTH IS AT BEST";
        Endings.SetActive(true);

        HPVAL = 0;
        STAVAL = 0;
    }

    public void ENDING3()
    {
        storyText = "DEATH";
        Endings.SetActive(true);

        HPVAL = 0;
        STAVAL = 0;
    }


    public void ENDING4()
    {
        storyText = "You Srvuved, but will have to look for your next food source in order to survive";
        Endings.SetActive(true);

        HPVAL = 0;
        STAVAL = 0;
    }
}
