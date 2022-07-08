namespace Be.Vlaanderen.Basisregisters.MessageHandling.AwsSqs.Simple.Tests
{
    using System.Threading.Tasks;
    using Amazon;
    using Xunit;

    public class SqsQueueTests
    {
        [Theory(Skip = "Needs theory data")]
        [InlineData("", "", "")]
        public async Task CreateListDeleteQueue(string accessKey, string secretKey, string sessionToken)
        {
            var options = new SqsOptions(accessKey, secretKey, sessionToken, RegionEndpoint.EUWest1);

            await SqsQueue.CreateQueue(options, nameof(SqsQueueTests), true);
            await SqsQueue.CreateQueue(options, nameof(SqsQueueTests), true);
            var topicNames = await SqsQueue.ListQueues(options);
            Assert.Contains(topicNames, x => x == nameof(SqsQueueTests));
            string queueUrl = string.Empty;
            try
            {
                queueUrl = await SqsQueue.GetQueueUrl(options, nameof(SqsQueueTests));
            }
            finally
            {
                if (Equals(!string.IsNullOrEmpty(queueUrl)))
                {
                    await SqsQueue.DeleteQueue(options, queueUrl);
                }
            }
        }

        [Theory]
        [InlineData("https://sqs.eu-west-1.amazonaws.com/123456789012/test-queue")]
        [InlineData("test-queue")]
        public void ParseQueueNameFromQueueUrl(string inputUrl)
        {
            var queueUrl = inputUrl;
            var queueName = SqsQueue.ParseQueueNameFromQueueUrl(queueUrl);
            Assert.Equal("test-queue", queueName);
        }
    }
}
