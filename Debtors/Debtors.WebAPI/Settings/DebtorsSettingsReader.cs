namespace Debtors.WebAPI.Settings
{
    public static class DebtorsSettingsReader
    {
        public static DebtorsSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new DebtorsSettings();
        }
    }
}
