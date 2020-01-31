using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    [Header("BackgroundBGM")]
    public AudioClip BGM_1;
    public AudioClip BGM_2;
    public AudioClip BGM_3;

    public GameObject scoreObject;

    private int scoreTotal;
    private AudioSource audioSource;
    private int currentBGM = 1;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = BGM_1;
        currentBGM = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTotal = scoreObject.GetComponent<Main>()._scoreTotal;


        if (scoreTotal > 300 && currentBGM !=2)
        {
            //Debug.Log("BGM_2");
            audioSource.clip = BGM_2;
            currentBGM = 2;
            audioSource.Play();
            return;
        }
        if (scoreTotal > 500 && currentBGM != 3)
        {
            audioSource.clip = BGM_3;
            currentBGM = 3;
            audioSource.Play();
            return;
        }
    }
}
