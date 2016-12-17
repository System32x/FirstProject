using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessagePanel : MonoBehaviour {
	public GameObject visualPanelGO;   									 //для включения и выключения отображения панели(так как панели не создаются динамически,панели на которых нет сообщения не видны)
	public Text messageText;
	public Text timeText;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GetMessage(Message m){   								//Метод переписывает себе текст сообщения 		
		visualPanelGO.SetActive (true);									//при первом использовании панели,она становится видна
		messageText.text = m.Text;										//ну тут понятно)
		timeText.text = m.timeText;
	}

}
