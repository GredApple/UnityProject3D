using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameAnnouncer 
{
	private const int MaxLines = 5;

	private const int MessageTimeout = 10;

	private  List<string> messages = new List<string>();

	private  bool show;	

	private Timer timer;

	// Add new message to the announcer
	public  void AddMessage(string message)
	{
		if(this.messages.Count > 5)
		{
			this.messages.RemoveAt(0);
		}

		this.messages.Add(message);

		if(this.messages.Count == 1)
		{
			this.show = true;
			this.timer = new Timer(
				this.MessageLifetime, 
				null, 
				(int)System.TimeSpan.FromSeconds(MessageTimeout).TotalMilliseconds,
				(int)System.TimeSpan.FromSeconds(MessageTimeout).TotalMilliseconds);
		}
	}

	// Draw GUI
	public void DrawGUI (GUIStyle style) 
	{
		if (this.show)
        {
            string text = string.Empty;

            foreach(var message in this.messages)
            {
            	text += message + "\n";
            }

            GUI.Label(new Rect(Screen.width - 200, 20, 200, 150), text, style);
        }
	}

	// Message life time count down
	// - object
    private void MessageLifetime(object state)
	{
		if(this.messages.Count > 0)
		{
	    	this.messages.RemoveAt(0);
	    }

	    if(this.messages.Count == 0)
	    {
        	this.show = false;
        	this.timer.Dispose();
        }
	}
}
