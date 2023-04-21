using UnityEngine;
using System.Collections;
using DarkRift.Client.Unity;
using System.Collections.Generic;
using DarkRift.Client;
using System;
using DarkRift;

public class NetworkPlayerManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The DarkRift client to communicate on.")]
    UnityClient client;

    Dictionary<ushort, AgarObject> networkPlayers = new Dictionary<ushort, AgarObject>();

    public void Awake()
    {
        client.MessageReceived += MessageReceived;
    }

    void MessageReceived(object sender, MessageReceivedEventArgs e)
    {
        using (Message message = e.GetMessage() as Message)
        {
            if (message.Tag == Tags.MovePlayerTag)
            {
                using (DarkRiftReader reader = message.GetReader())
                {
                    ushort id = reader.ReadUInt16();
                    
                    Vector3 newPosition = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

                    //21-04-2023
                    //int animIDJump = reader.ReadInt32();
                    //bool animationBlend = reader.ReadBoolean();
                    //int animID = reader.ReadInt32();
                    //float grounded = reader.ReadSingle();

                    print("::::::::::::: Move Set Position ::::::::::::::::::");
                    if (networkPlayers.ContainsKey(id))
                    {
                        networkPlayers[id].SetMovePosition(newPosition);

                        //21-04-2023
                        //networkPlayers[id].SetAnimation(animIDJump, animationBlend);
                        //networkPlayers[id].SetAnimation(animID, grounded);
                    }
                }
            }
        }
    }

    public void Add(ushort id, AgarObject player)
    {
        networkPlayers.Add(id, player);
    }

    public void DestroyPlayer(ushort id)
    {
        AgarObject o = networkPlayers[id];

        Destroy(o.gameObject);

        networkPlayers.Remove(id);
    }
}
