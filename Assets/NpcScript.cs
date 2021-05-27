using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NpcScript : MonoBehaviour
{
    AudioSource audioNpc;
    public PlayerMovement player;
    Animator animasi;
    // Start is called before the first frame update
    void Start()
    {
        audioNpc = GetComponent<AudioSource>();
        animasi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioNpc.isPlaying){
            animasi.SetBool("animNyanyi", false);
        }
    }

    public void PlaySound(){
        if(player.isMove ==false && !audioNpc.isPlaying){
            StartCoroutine(playAudio());
        }
    }

    public IEnumerator playAudio(){
        yield return new WaitForSeconds(player.timerLimit);
        audioNpc.Play();
        animasi.SetBool("animNyanyi", true);
    }

}
