using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject Player;
    public GameObject Lever;
    private bool hasRun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.GetComponent<KeyMemory>().redKey && Player.GetComponent<KeyMemory>().blueKey && Player.GetComponent<KeyMemory>().greenKey)
            if (Lever.GetComponent<Lever>().activated && !hasRun)
                StartCoroutine("OpenDoor");
    }

    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(0);
        for (int i = 0; i <= 20; i++)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.0005f, this.transform.position.z);
            yield return new WaitForSeconds(0.1f);
        }

        for (int i = 0; i <= 15; i++)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.002f, this.transform.position.z);
            yield return new WaitForSeconds(0.1f);
        }

        for (int i = 0; i <= 10; i++)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.01f, this.transform.position.z);
            yield return new WaitForSeconds(0.1f);
        }
        hasRun = true;
        
    }
}
