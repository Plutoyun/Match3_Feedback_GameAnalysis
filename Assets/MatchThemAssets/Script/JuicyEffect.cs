using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuicyEffect : MonoBehaviour
{
    public bool IsJuicy = false;

    [Header("Mulitple Score Rewards")]
    public GameObject goodTextObject;
    public GameObject greatTextObject;
    public GameObject excellentTextObject;

    private GameObject rewardText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void juicyScoreText(int score)
    {
        if (!IsJuicy)
        {
            return;
        }
        if (score > 30 && score <= 40)
        {
            
           rewardText =  GameObject.Instantiate(goodTextObject);
            Destroy(rewardText, 1.5f);
        }
        else if (score > 40 && score <= 50)
        {
            rewardText = GameObject.Instantiate(greatTextObject);
            Destroy(rewardText, 1.5f);
        }
        else if (score > 50)
        {
            rewardText = GameObject.Instantiate(excellentTextObject);
                Destroy(rewardText, 1.5f);
        }
    }

}
