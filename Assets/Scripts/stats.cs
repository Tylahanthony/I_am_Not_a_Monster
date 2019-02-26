public static class stats
{
    private static int deaths, assists, points;
    private static float speed;
    private static int paused;

    public static float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }

    public static int Deaths
    {
        get
        {
            return deaths;
        }
        set
        {
            deaths = value;
        }
    }

    public static int Assists
    {
        get
        {
            return assists;
        }
        set
        {
            assists = value;
        }
    }

    public static int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
        }
    }

    public static int Paused
    {
        get
        {
            return paused;
        }

        set
        {
            paused = value;
        }
    }
}