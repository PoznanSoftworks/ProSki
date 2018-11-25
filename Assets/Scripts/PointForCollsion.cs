using UnityEngine;

public class PointForCollsion : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision colli) {
        print(colli.gameObject.name);
        if (colli.gameObject.name == "Coin" || colli.gameObject.name == "Coin(Clone)")
        {
            print("placki");
            Destroy(colli.gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().points += 1;
            Debug.Log("Rozjebany w chuj");
        }
		
	}


    // Update is called once per frame
    void Update () {
		
	}
}
