using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class MessageController : MonoBehaviour {

    public static MessageController Instance;
    public GameObject TextPrefab;
	public List<Message> messages = new List<Message> ();					//список всех сообщений
	public List<MessagePanel> messagesPanels = new List<MessagePanel>();    //список панелей на которых будут размещатся сообщения(чтобы каждый раз не создавать новый объект)
	[SerializeField]
	private Transform messagesPanel;    //панель к которой сообщения являются дочерними



    void Awake()
    {
        Instance = this;
    }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void SortMessageByTime(){   									// сортировка списка по параметру Time(если понадобится)
		messages.Sort(delegate(Message m1, Message m2)
			{ return m2.Time.CompareTo(m1.Time); });
	}
    public void ReceiveMessage(Message m)
    {
        //Create Message On Scene
		messages.Insert(0,m);                                          //сообщение вставляется в начало списка messages
		for (int i = 0; i <messages.Count && i < 10; i++)				
			messagesPanels [i].GetMessage (messages [i]);   		   //на панелях записываются сообщения(панели не создаются)
    }
}

