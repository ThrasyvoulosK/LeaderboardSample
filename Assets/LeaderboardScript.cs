using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GenerateEntries();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create up to 2000 new entries for the leaderboard
    void GenerateEntries()
    {
        GameObject entry = transform.Find("Entries").Find("Entry").gameObject;
        GameObject newEntry=Instantiate(entry,entry.transform);
        newEntry.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, entry.GetComponent<RectTransform>().anchoredPosition.y- 100f);
    }
}
