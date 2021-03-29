using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gamingCloud;
using gamingCloud.Network;

public class gc_network : GCMultiPlayer 
{

    string status;
    
    void Start()
    {
        ConnectToMultiPlayerServer();
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 800, 20), status);
    }

    public override void ConnectedToServer()
    {
        status = "Connected to GC server!";
        base.JoinToServer(new RoomSetting());
    }

    public override void OnJoined()
    {
        status = "Joined, roomId " + base.room.id;
    }
}
