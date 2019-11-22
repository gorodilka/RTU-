using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounterS : MonoBehaviour


{
    float score;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        float dist = 100 - (transform.position - collision.gameObject.transform.position).magnitude;
        score += dist;
        scoreText.GetComponent<TextMesh>().text = score.ToString();
    }
}
