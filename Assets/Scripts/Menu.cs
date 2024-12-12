using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    [SerializeField] private AudioSource target;

    private void Start()
    {
        target = GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("jogo");
    }

    public void PlaySoundGame()
    {
        target.PlayOneShot(clip);
        Invoke("PlayGame", 1.0f);
    }
}