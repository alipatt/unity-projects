using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballcontrol : MonoBehaviour {
    Rigidbody fizik;
    public int hiz=1;
    bool jump = false;
    private int allBall = 8 ;
    int counter = 0;
    public Text count;
    public Text gameOver;
	// Use this for initialization
	void Start () {
        fizik = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec * hiz);
        if (Input.GetKeyDown(KeyCode.Space) && jump )
        {
            vec = new Vector3(0, 200 , 0);
            GetComponent<Rigidbody>().AddForce(vec);
            jump = false;
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        jump = true;    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "box")
        {
            other.gameObject.SetActive(false);
            counter++;
            count.text = "Counter = " + counter ;
            if(allBall == counter)
            {
                gameOver.text = "GAME OVER";
            }
        }
    }


}
