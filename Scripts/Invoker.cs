using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private Command comm;
    public bool disableLog = false;

    public void SetCommand(Command command)
    {
        comm = command;
    }

    public void ExeCommand()
    {
        if (!disableLog)
        {
            CommandLog.commands.Enqueue(comm);
        }
        comm.Exe();
    }
}

