using System;
using System.Linq;
using StackExchange.Redis;
public static class Connection
{
    private static ConnectionMultiplexer redis;
    private static IDatabase database;
    public static void Connect(string connectionString = "localhaost")
    {
        redis= ConnectionMultiplexer.Connect("redis - 13481.c278.us - east - 1 - 4.ec2.cloud.redislabs.com:13481,password=bZiUInqs8qRiC6vtR7GgmsooYY2cmczi,ConnectTimeout=10000,allowAdmin=true");
        database = redis.GetDatabase();
    } 
}
class Program
{
    

    static void Main()
    {
        string connectionString = "redis-13481.c278.us-east-1-4.ec2.cloud.redislabs.com:13481";
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis - 13481.c278.us - east - 1 - 4.ec2.cloud.redislabs.com:13481,password=bZiUInqs8qRiC6vtR7GgmsooYY2cmczi,ConnectionTimeOut=10000,allowAdmin=true");
        IDatabase database = redis.GetDatabase();
        IServer server = redis.GetServer(connectionString,13481);

    }

}
