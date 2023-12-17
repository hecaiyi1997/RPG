/****************************************************
	文件：ServerStart.cs


	
	功能：服务器入口
*****************************************************/

using System;
using System.IO;
using System.Threading;

class ServerStart
{
    private static Thread m_MsgThread;

    static void Main(string[] args)
    {
        //m_MsgThread = new Thread(MsgThread);
        //m_MsgThread.IsBackground = true;
        //m_MsgThread.Start();

        ServerRoot.Instance.Init();
        while (true)
        {
            ServerRoot.Instance.Update();
            Thread.Sleep(20);
        }
        //Debug.LogError("jjj");
    }
}