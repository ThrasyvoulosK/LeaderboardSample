using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class LeaderboardScript : MonoBehaviour
{
    public int originalScore = 1000000;
    public int numberOfEntries = 2000;

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
        for (int i = 1; i <= numberOfEntries; i++)
        {
            GameObject entry = transform.Find("EntriesBg").Find("Entries").Find("Entry").gameObject;
            GameObject newEntry = Instantiate(entry, entry.transform.parent);
            
            //Set new entry's position relatively to the original
            newEntry.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, entry.GetComponent<RectTransform>().anchoredPosition.y - i*30f);

            //Assign its attributes
            //1.Position
            newEntry.transform.Find("Position").GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();
            //2.Name
            newEntry.transform.Find("Name").GetComponent<TextMeshProUGUI>().text ="name"+(i + 1).ToString();
            //3.Score
            newEntry.transform.Find("Score").GetComponent<TextMeshProUGUI>().text =(originalScore-i*(originalScore/numberOfEntries)).ToString();
        }
    }
}
