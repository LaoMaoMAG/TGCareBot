namespace TGCareBot.Example;

public class Config
{
    // 机器人配置
    public static readonly DataBotConfig BotConfig = new DataBotConfig();
    
    // 是否开启调试模式
    public static readonly bool IsDebugMode  = true;
    
    
    
    static  Config()
    {
        BotConfig.Load();
    }
}