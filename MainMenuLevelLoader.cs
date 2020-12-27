using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuLevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    FindObjectOfType<AudioManager>().Play("MainSong");
    //}

    /*
    // Update is called once per frame
    void Update()
    {

    }*/

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadEndlessLevel() {
        SceneManager.LoadScene(7);
    }

    public void LoadEndlessShooter(){
        SceneManager.LoadScene(8);
    }

    public void PlayHype()
    {
        FindObjectOfType<AudioManager>().Stop("junglee");
        FindObjectOfType<AudioManager>().Stop("Lo-Fi");
        FindObjectOfType<AudioManager>().Play("Hype");
    }

    public void PlayJunglee()
    {
        FindObjectOfType<AudioManager>().Stop("Lo-Fi");
        FindObjectOfType<AudioManager>().Stop("Hype");
        FindObjectOfType<AudioManager>().Play("junglee");
    }

    public void PlayLofi()
    {
        FindObjectOfType<AudioManager>().Stop("junglee");
        FindObjectOfType<AudioManager>().Stop("Hype");
        FindObjectOfType<AudioManager>().Play("Lo-Fi");
    }

    public void VolumeChange() {
        FindObjectOfType<AudioManager>().ChangeVolume(FindObjectOfType<Slider>().value);
    }

    public void StopMusic(){
        FindObjectOfType<AudioManager>().Stop("junglee");
        FindObjectOfType<AudioManager>().Stop("Hype");
        FindObjectOfType<AudioManager>().Stop("Lo-Fi");
    }

}
