using M7Coverage.SystemTest;
using System.Net.Http.Json;

namespace M7Coverage;

[TestClass]
public class APITest
{
    private static HttpClient client;

    [ClassInitialize]
    public static void Setup(TestContext context)
    {
        client = new HttpClient();
    }

    [TestMethod]
    public async Task GetPostById_SuccesStatusCode_ReturnsExpectedPost()
    {
        // Arrange
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Act
        var response = await client.GetAsync(url);
        var post = await response.Content.ReadFromJsonAsync<Post>();

        // Assert
        Assert.IsTrue(response.IsSuccessStatusCode, "La respuesta no fue exitosa.");
        Assert.IsNotNull(post);
        Assert.AreEqual(1, post.id);
    }
}
