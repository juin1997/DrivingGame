using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentTrack : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject[] Marks = new GameObject[11];
    public int MarkTracker;

	void Update ()
    {
        if(MarkTracker < 11)
        {
           TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
	}

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "opponent")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker++;
            if (MarkTracker == 11) MarkTracker = 0;
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        } 
        
    }
}
