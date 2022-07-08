namespace Be.Vlaanderen.Basisregisters.MessageHandling.AwsSqs.Simple
{
    public record SqsQueueOptions(string MessageGroupId = "", bool CreateQueueIfNotExists = false);
}
