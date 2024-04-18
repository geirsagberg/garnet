﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Garnet.server;

namespace CommandInfoUpdater
{
    /// <summary>
    /// Defines a command supported by Garnet
    /// </summary>
    public class SupportedCommand
    {
        /// <summary>
        /// Map between a supported command's name and its SupportedCommand object
        /// </summary>
        public static IReadOnlyDictionary<string, SupportedCommand> SupportedCommandsMap => _supportedCommandsMap.Value;

        private static readonly Lazy<IReadOnlyDictionary<string, SupportedCommand>> _supportedCommandsMap =
            new(() =>
                {
                    return AllSupportedCommands.ToDictionary(sc => sc.Command, sc => sc);
                });

        private static readonly SupportedCommand[] AllSupportedCommands = {
            new("ACL", RespCommand.ACL, 0, new[]
            {
                "ACL|CAT",
                "ACL|DELUSER",
                "ACL|LIST",
                "ACL|LOAD",
                "ACL|SETUSER",
                "ACL|USERS",
                "ACL|WHOAMI",
            }),
            new("APPEND", RespCommand.APPEND),
            new("ASKING", RespCommand.ASKING),
            new("AUTH", RespCommand.AUTH),
            new("BGSAVE", RespCommand.BGSAVE),
            new("BITCOUNT", RespCommand.BITCOUNT),
            new("BITFIELD", RespCommand.BITFIELD),
            new("BITOP", RespCommand.BITOP),
            new("BITPOS", RespCommand.BITPOS),
            new("CLIENT", RespCommand.CLIENT),
            new("CLUSTER", RespCommand.CLUSTER, 0, new []
            {
                "CLUSTER|ADDSLOTS",
                "CLUSTER|ADDSLOTSRANGE",
                "CLUSTER|BUMPEPOCH",
                "CLUSTER|COUNTKEYSINSLOT",
                "CLUSTER|DELSLOTS",
                "CLUSTER|DELSLOTSRANGE",
                "CLUSTER|FAILOVER",
                "CLUSTER|FORGET",
                "CLUSTER|GETKEYSINSLOT",
                "CLUSTER|INFO",
                "CLUSTER|KEYSLOT",
                "CLUSTER|MEET",
                "CLUSTER|MYID",
                "CLUSTER|NODES",
                "CLUSTER|REPLICAS",
                "CLUSTER|REPLICATE",
                "CLUSTER|RESET",
                "CLUSTER|SET-CONFIG-EPOCH",
                "CLUSTER|SETSLOT",
                "CLUSTER|SLOTS"

            }),
            new("COMMAND", RespCommand.COMMAND, 0, new []
            {
                "COMMAND|INFO",
                "COMMAND|COUNT",
            }),
            new("COMMITAOF", RespCommand.COMMITAOF),
            new("CONFIG", RespCommand.CONFIG, 0, new []
            {
                "CONFIG|GET",
                "CONFIG|SET",
                "CONFIG|REWRITE"
            }),
            new("COSCAN", RespCommand.All, (byte)RespCommand.COSCAN),
            new("DBSIZE", RespCommand.DBSIZE),
            new("DECR", RespCommand.DECR),
            new("DECRBY", RespCommand.DECRBY),
            new("DEL", RespCommand.DEL),
            new("DISCARD", RespCommand.DISCARD),
            new("ECHO", RespCommand.ECHO),
            new("EXEC", RespCommand.EXEC),
            new("EXISTS", RespCommand.EXISTS),
            new("EXPIRE", RespCommand.EXPIRE),
            new("FLUSHDB", RespCommand.FLUSHDB),
            new("GEOADD", RespCommand.SortedSet, (byte) SortedSetOperation.GEOADD),
            new("GEODIST", RespCommand.SortedSet, (byte) SortedSetOperation.GEODIST),
            new("GEOHASH", RespCommand.SortedSet, (byte) SortedSetOperation.GEOHASH),
            new("GEOPOS", RespCommand.SortedSet, (byte) SortedSetOperation.GEOPOS),
            new("GEOSEARCH", RespCommand.SortedSet, (byte) SortedSetOperation.GEOSEARCH),
            new("GET", RespCommand.GET),
            new("GETBIT", RespCommand.GETBIT),
            new("GETDEL", RespCommand.GETDEL),
            new("GETRANGE", RespCommand.GETRANGE),
            new("HDEL", RespCommand.Hash, (byte) HashOperation.HDEL),
            new("HEXISTS", RespCommand.Hash, (byte) HashOperation.HEXISTS),
            new("HGET", RespCommand.Hash, (byte) HashOperation.HGET),
            new("HGETALL", RespCommand.Hash, (byte) HashOperation.HGETALL),
            new("HINCRBY", RespCommand.Hash, (byte) HashOperation.HINCRBY),
            new("HINCRBYFLOAT", RespCommand.Hash, (byte) HashOperation.HINCRBYFLOAT),
            new("HKEYS", RespCommand.Hash, (byte) HashOperation.HKEYS),
            new("HLEN", RespCommand.Hash, (byte) HashOperation.HLEN),
            new("HMGET", RespCommand.Hash, (byte) HashOperation.HMGET),
            new("HMSET", RespCommand.Hash, (byte) HashOperation.HMSET),
            new("HRANDFIELD", RespCommand.Hash, (byte) HashOperation.HRANDFIELD),
            new("HSCAN", RespCommand.Hash, (byte) HashOperation.HSCAN),
            new("HSET", RespCommand.Hash, (byte) HashOperation.HSET),
            new("HSETNX", RespCommand.Hash, (byte) HashOperation.HSETNX),
            new("HSTRLEN", RespCommand.Hash, (byte) HashOperation.HSTRLEN),
            new("HVALS", RespCommand.Hash, (byte) HashOperation.HVALS),
            new("INCR", RespCommand.INCR),
            new("INCRBY", RespCommand.INCRBY),
            new("INFO", RespCommand.INFO),
            new("KEYS", RespCommand.KEYS),
            new("LASTSAVE", RespCommand.LASTSAVE),
            new("LATENCY", RespCommand.LATENCY, 0, new []
            {
                "LATENCY|HISTOGRAM",
                "LATENCY|RESET"
            }),
            new("LINDEX", RespCommand.List, (byte) ListOperation.LINDEX),
            new("LINSERT", RespCommand.List, (byte) ListOperation.LINSERT),
            new("LLEN", RespCommand.List, (byte) ListOperation.LLEN),
            new("LMOVE", RespCommand.List, (byte) ListOperation.LMOVE),
            new("LPOP", RespCommand.List, (byte) ListOperation.LPOP),
            new("LPUSH", RespCommand.List, (byte) ListOperation.LPUSH),
            new("LPUSHX", RespCommand.List, (byte) ListOperation.LPUSHX),
            new("LRANGE", RespCommand.List, (byte) ListOperation.LRANGE),
            new("LREM", RespCommand.List, (byte) ListOperation.LREM),
            new("LTRIM", RespCommand.List, (byte) ListOperation.LTRIM),
            new("MEMORY", RespCommand.MEMORY, 0, new []
            {
                "MEMORY|USAGE"
            }),
            new("MGET", RespCommand.MGET),
            new("MIGRATE", RespCommand.MIGRATE),
            new("MODULE", RespCommand.MODULE),
            new("MONITOR", RespCommand.MONITOR),
            new("MSET", RespCommand.MSET),
            new("MSETNX", RespCommand.MSETNX),
            new("MULTI", RespCommand.MULTI),
            new("PERSIST", RespCommand.PERSIST),
            new("PEXPIRE", RespCommand.PEXPIRE),
            new("PFADD", RespCommand.PFADD),
            new("PFCOUNT", RespCommand.PFCOUNT),
            new("PFMERGE", RespCommand.PFMERGE),
            new("PING", RespCommand.PING),
            new("PSETEX", RespCommand.PSETEX),
            new("PSUBSCRIBE", RespCommand.PSUBSCRIBE),
            new("PTTL", RespCommand.PTTL),
            new("PUBLISH", RespCommand.PUBLISH),
            new("PUNSUBSCRIBE", RespCommand.PUNSUBSCRIBE),
            new("REGISTERCS", RespCommand.REGISTERCS),
            new("QUIT", RespCommand.QUIT),
            new("READONLY", RespCommand.READONLY),
            new("RENAME", RespCommand.RENAME),
            new("REPLICAOF", RespCommand.REPLICAOF),
            new("RESET", RespCommand.RESET),
            new("RPOP", RespCommand.List, (byte) ListOperation.RPOP),
            new("RPOPLPUSH", RespCommand.List, (byte) ListOperation.RPOPLPUSH),
            new("RPUSH", RespCommand.List, (byte) ListOperation.RPUSH),
            new("RPUSHX", RespCommand.List, (byte) ListOperation.RPUSHX),
            new("SADD", RespCommand.Set, (byte) SetOperation.SADD),
            new("SCARD", RespCommand.Set, (byte) SetOperation.SCARD),
            new("SAVE", RespCommand.SAVE),
            new("SCAN", RespCommand.SCAN),
            new("SELECT", RespCommand.SELECT),
            new("SET", RespCommand.SET),
            new("SETBIT", RespCommand.SETBIT),
            new("SETEX", RespCommand.SETEX),
            new("SETEXNX", RespCommand.SETEXNX),
            new("SETEXXX", RespCommand.SETEXXX),
            new("SETRANGE", RespCommand.SETRANGE),
            new("SISMEMBER", RespCommand.Set, (byte) SetOperation.SISMEMBER),
            new("SLAVEOF", RespCommand.SECONDARYOF),
            new("SMEMBERS", RespCommand.Set, (byte) SetOperation.SMEMBERS),
            new("SPOP", RespCommand.Set, (byte) SetOperation.SPOP),
            new("SRANDMEMBER", RespCommand.Set, (byte) SetOperation.SRANDMEMBER),
            new("SREM", RespCommand.Set, (byte) SetOperation.SREM),
            new("SSCAN", RespCommand.Set, (byte) SetOperation.SSCAN),
            new("STRLEN", RespCommand.STRLEN),
            new("SUBSCRIBE", RespCommand.SUBSCRIBE),
            new("TIME", RespCommand.TIME),
            new("TTL", RespCommand.TTL),
            new("TYPE", RespCommand.TYPE),
            new("UNLINK", RespCommand.UNLINK),
            new("UNSUBSCRIBE", RespCommand.UNSUBSCRIBE),
            new("UNWATCH", RespCommand.UNWATCH),
            new("WATCH", RespCommand.WATCH),
            new("ZADD", RespCommand.SortedSet, (byte) SortedSetOperation.ZADD),
            new("ZCARD", RespCommand.SortedSet, (byte) SortedSetOperation.ZCARD),
            new("ZCOUNT", RespCommand.SortedSet, (byte) SortedSetOperation.ZCOUNT),
            new("ZDIFF", RespCommand.SortedSet, (byte) SortedSetOperation.ZDIFF),
            new("ZINCRBY", RespCommand.SortedSet, (byte) SortedSetOperation.ZINCRBY),
            new("ZLEXCOUNT", RespCommand.SortedSet, (byte) SortedSetOperation.ZLEXCOUNT),
            new("ZMSCORE", RespCommand.SortedSet, (byte) SortedSetOperation.ZMSCORE),
            new("ZPOPMAX", RespCommand.SortedSet, (byte) SortedSetOperation.ZPOPMAX),
            new("ZPOPMIN", RespCommand.SortedSet, (byte) SortedSetOperation.ZPOPMIN),
            new("ZRANDMEMBER", RespCommand.SortedSet, (byte) SortedSetOperation.ZRANDMEMBER),
            new("ZRANGE", RespCommand.SortedSet, (byte) SortedSetOperation.ZRANGE),
            new("ZRANGEBYSCORE", RespCommand.SortedSet, (byte) SortedSetOperation.ZRANGEBYSCORE),
            new("ZRANK", RespCommand.SortedSet, (byte) SortedSetOperation.ZRANK),
            new("ZREM", RespCommand.SortedSet, (byte) SortedSetOperation.ZREM),
            new("ZREMRANGEBYLEX", RespCommand.SortedSet, (byte) SortedSetOperation.ZREMRANGEBYLEX),
            new("ZREMRANGEBYRANK", RespCommand.SortedSet, (byte) SortedSetOperation.ZREMRANGEBYRANK),
            new("ZREMRANGEBYSCORE", RespCommand.SortedSet, (byte) SortedSetOperation.ZREMRANGEBYSCORE),
            new("ZREVRANGE", RespCommand.SortedSet, (byte) SortedSetOperation.ZREVRANGE),
            new("ZREVRANK", RespCommand.SortedSet, (byte) SortedSetOperation.ZREVRANK),
            new("ZSCAN", RespCommand.SortedSet, (byte) SortedSetOperation.ZSCAN),
            new("ZSCORE", RespCommand.SortedSet, (byte) SortedSetOperation.ZSCORE),
        };

        /// <summary>
        /// Supported command's name
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Supported command's sub-commands' names
        /// </summary>
        public HashSet<string>? SubCommands { get; set; }

        /// <summary>
        /// Garnet RespCommand
        /// </summary>
        public RespCommand RespCommand { get; set; }

        /// <summary>
        /// Garnet ArrayCommand
        /// </summary>
        public byte? ArrayCommand { get; set; }

        public SupportedCommand()
        {

        }

        public SupportedCommand(string command, RespCommand respCommand = RespCommand.NONE, byte? arrayCommand = null, IEnumerable<string>? subCommands = null)
        {
            this.Command = command;
            this.SubCommands = subCommands == null ? null : new HashSet<string>(subCommands);
            this.RespCommand = respCommand;
            this.ArrayCommand = arrayCommand;
        }
    }
}