using Telegram.Bot.Types;

public static class Constants
{
    public const string BotName = "Незнайка";
    public const string AltBotName = "Dunno";
    public const string ChatGptSystemMessage = $"Тебя зовут {BotName}, ты отвечаешь на запросы в групповом чате";
    public const int GptCaptPerDay = 500;
    public static ChatId TargetChatId = new(Environment.GetEnvironmentVariable("TARGET_CHAT_ID")!);
    public static ChatId[] BotAdmins = Environment.GetEnvironmentVariable("BOT_ADMINS")!
        .Split(',')
        .Select(x => new ChatId(long.Parse(x)))
        .ToArray();
    public static readonly string OpenAiToken = Environment.GetEnvironmentVariable("OPENAI_TOKEN")!;
    public static readonly string TelegramToken = Environment.GetEnvironmentVariable("TELEGRAM_TOKEN")!;
    public static readonly string Database = Environment.GetEnvironmentVariable("DUNNOBOT_DB_PATH") ?? @"dunnobot.db";

}