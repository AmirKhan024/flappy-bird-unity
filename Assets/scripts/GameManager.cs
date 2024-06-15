

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameover;
    public GameObject playbtn;
    public playerscript player;    
    public void GameOver(){
        gameover.SetActive(true);
        playbtn.SetActive(true);
        Pause();
    }
    public void IncreaseScore(){
        score++;
        scoretext.text=score.ToString();
    }
    
    public void Awake(){
        Application.targetFrameRate=60;
        Pause();
    }
    public void play(){
        score=0;
        scoretext.text=score.ToString();
        Time.timeScale=1f;
        player.enabled=true;
        gameover.SetActive(false);
        playbtn.SetActive(false);
        pipes[] Pipes=FindObjectsOfType<pipes>();

        for(int i=0; i<Pipes.Length; i++){
            Destroy(Pipes[i].gameObject);
        }
    }
    public void Pause(){
        Time.timeScale=0f;
        player.enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
