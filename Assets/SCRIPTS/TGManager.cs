using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TGManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,hpTextMeshPro, statTextMeshPro;
    public string storyText;
    public int HPVAL, STAVAL;
    public GameObject Lvl1Choices, Lvl2Choices; //CALL LEVEL 1 BUTTONS
 
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText; // MAIN TEXT FOR STORY, THIS IS WHERE YOU INSERT BODY TEXT ETC ETC
        hpTextMeshPro.text = HPVAL.ToString(); //CALL FOR HP
        statTextMeshPro.text = STAVAL.ToString(); //CALL FOR STAMINA
    }
    public void GoToCottage() //BUTTON 1 
    {
        storyText = "you find yourself in somehwat of a witches hu, and its warm inside";
        HPVAL += 2;

        Lvl1Choices.SetActive(false); // level 1 buttons will disappear
        Lvl2Choices.SetActive(true); // shows second choices


    }
    public void Stare() //BUTTON 2
    {
        storyText = "*shivers, Its freezing";
        HPVAL -= 2;

        Lvl1Choices.SetActive(false);
    }
    public void TakeShelter() //BUTTON3 
    {
        storyText = "you have run from the rain, but you are cold";
        HPVAL -= 1;

        Lvl1Choices.SetActive(false);
    }
}
