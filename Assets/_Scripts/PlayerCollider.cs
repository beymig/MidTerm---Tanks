using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    public GameController gameController;
    public EnemyController enemy;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

            this.gameController.LivesValue -= 1;
            this.enemy._Reset();

        }
        
    }
}
