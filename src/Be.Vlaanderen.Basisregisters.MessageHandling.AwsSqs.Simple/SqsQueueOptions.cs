namespace Be.Vlaanderen.Basisregisters.MessageHandling.AwsSqs.Simple
{
    public class SqsQueueOptions
    {
        public bool CreateQueueIfNotExists { get; set; } = false;
        public string MessageGroupId { get; set; } = string.Empty;
    }
}
