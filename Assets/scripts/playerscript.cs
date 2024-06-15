
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite[] sprites;
    public int spriteIndex=0;
    // Start is called before the first frame update
    public Vector3 direction;
    public float gravity=-9.8f;
    public float strength=5f;

    
    public void OnEnable(){
        Vector3 position=transform.position;
        position.y=0f;
        transform.position=position;
        direction=Vector3.zero;
    }
    void Awake(){
        spriterenderer=GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        InvokeRepeating(nameof(Animatesprite),0.15f,0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            direction=Vector3.up*strength;
        }

        if(Input.touchCount>0){
            Touch touch=Input.GetTouch(0);
            if(touch.phase==TouchPhase.Began){
                direction=Vector3.up*strength;
            }
        }
        direction.y += gravity*Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    public void Animatesprite(){
        spriteIndex++;
        if(spriteIndex>(sprites.Length-1)){
            spriteIndex=0;
        }
        spriterenderer.sprite=sprites[spriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "obstacle"){
            FindObjectOfType<GameManager>().GameOver();
        }else if(other.gameObject.tag== "scoring"){
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
