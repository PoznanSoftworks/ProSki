using UnityEngine;

public class PointForCollsion : MonoBehaviour
{

    private Rigidbody rb;

    float speed = new float();

    // Use this for initialization
    void OnTriggerEnter(Collider colli)
    {

        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity =
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity.normalized * speed;
        if (colli.gameObject.name == "Coin" || colli.gameObject.name == "Coin(Clone)")
        {

            print("placki");
            Destroy(colli.gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().points += 1;
            Debug.Log("Rozjebany w chuj");
        }

    }




    // Update is called once per frame
    void Update()
    {
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity.magnitude;
    }


}