using MeowToolsLib.Config.FileConfig;

namespace TGCareBot.Example;

public class DataBotConfig : FileConfigBase<DataBotConfig>
{
    // 配置文件配置项
    public override string FilePath { get; set; } = "bot-config.toml"; // 配置文件路径
    public override FileConfigEnum.EnumFileType FileType { get; set; } = FileConfigEnum.EnumFileType.Yaml; // 配置文件类型
    
    // 机器人 Token
    public string? BotToken { get; set; }
    
    // 群组 ID
    public string? GroupId  { get; set; }
    
    // 服务器端口
    public int? ServerPort { get; set; }
    
    // 消息配置
    public DataMessage Message { get; set; } = new DataMessage();
    
    // 消息配置数据
    public class DataMessage
    {
        // 欢迎信息
        public string? WelcomeMessage { get; set; }
            
        // 是否启用验证码
        public string? IsEnableCaptcha { get; set; }
        
        // 用户发送消息的间隔
        public string? UserSendingInterval { get; set; }
    }
}