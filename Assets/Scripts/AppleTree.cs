
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    public GameObject branchPrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;
    public float branchDropChance = 10f;
    public float appleDropDelay = 1f;
    void Start()
    {
        //start dropping apples
        Invoke("DropApple", 2f);
    }

    void DropApple(){
        
        if(Random.Range(0f, 100f) <= branchDropChance){
            GameObject branch = Instantiate<GameObject>(branchPrefab);
            branch.transform.position = transform.position;
            Invoke("DropApple", appleDropDelay);
        }else{
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", appleDropDelay);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction
        if(pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed);
        }else if(pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate(){

        if(Random.value < changeDirChance){
            speed *= -1;
        }
    }
}
