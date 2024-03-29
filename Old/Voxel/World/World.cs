﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    public Dictionary<ChunkId, Chunk> Chunks = new Dictionary<ChunkId, Chunk>();

    public UInt16 this[int x, int y, int z]
    {
        get
        {
            var chunk = Chunks[ChunkId.FromWorldPosition(x, y, z)];
            return chunk[x & 0xF, y & 0xF, z & 0xF];
        }
        set
        {
            var chunk = Chunks[ChunkId.FromWorldPosition(x, y, z)];
            chunk[x & 0xF, y & 0xF, z & 0xF] = value;
        }
    }
}
