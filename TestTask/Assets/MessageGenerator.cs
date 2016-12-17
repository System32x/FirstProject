using UnityEngine;
using System.Collections.Generic;

public class MessageGenerator : MonoBehaviour {

    public List<string> TextList = new List<string>();

	// Use this for initialization

	void Start () {

        InvokeRepeating("Stream1", 0f, 0.01f);
        InvokeRepeating("Stream2", 0f, 0.01f);
	}


    void Stream1()
    {
        CreateMessage();
    }

    void Stream2()
    {
        CreateMessage();
    }

    void CreateMessage()
    {
			Message newMessage = new Message ();
      
			int index = Random.Range (0, TextList.Count);
			string text = TextList [index];

			newMessage.Text = text;
			newMessage.ID = index;
			newMessage.Time = Time.time;



			string min = System.DateTime.Now.Minute.ToString();						
			string sec = System.DateTime.Now.Second.ToString();
			//Блок добавления нолика)--------										//немного нагрузит процесс, зато красивше
			if (System.DateTime.Now.Minute < 10)
				min = "0" + min;

			if (System.DateTime.Now.Second < 10)
				sec = "0" + sec;
			//--------------------------------
			newMessage.timeText = System.DateTime.Now.Hour + ":" + min + ":" + sec;	//записывается время отправки сообщения


			MessageController.Instance.ReceiveMessage (newMessage);

    }
}
