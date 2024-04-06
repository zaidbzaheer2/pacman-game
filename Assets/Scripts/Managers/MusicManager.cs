using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    //-------------------------------------------------------------------
    // singleton implementation
    private static MusicManager _instance;
    private AudioSource audPlayer;
    public static MusicManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MusicManager>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
                Destroy(gameObject);
        }

    }
    private void Start()
    {
        audPlayer = GetComponent<AudioSource>();
    }
   
    private void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "menu" && !audPlayer.isPlaying)
        {
           
            audPlayer.Play();
        }
        else if(SceneManager.GetActiveScene().name !="menu" && audPlayer.isPlaying)
        {
            audPlayer.Pause();
        }
        
    }



}
