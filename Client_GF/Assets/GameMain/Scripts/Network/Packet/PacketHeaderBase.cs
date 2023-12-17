﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using GameFramework.Network;

public abstract class PacketHeaderBase : IPacketHeader, IReference {
    public abstract PacketType PacketType {
        get;
    }

    public ushort Id {
        get;
        set;
    }

    public int PacketLength {
        get;
        set;
    }

    public bool IsValid {
        get {
            return PacketType != PacketType.Undefined && Id > 0 && PacketLength >= 0;
        }
    }

    public void Clear() {
        Id = 0;
        PacketLength = 0;
    }
}
