
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnrate=1f;
    public float minheight=-1f;
    public float maxheight=3f;
    
    void OnEnable(){
        InvokeRepeating(nameof(spawn),spawnrate,spawnrate);
    }
    public void OnDisable(){
        CancelInvoke(nameof(spawn));
    }
    public void spawn(){
        GameObject pipes=Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position+= Vector3.up  * Random.Range(minheight,maxheight);
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
