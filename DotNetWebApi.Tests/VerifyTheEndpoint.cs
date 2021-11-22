using System.Threading.Tasks;
using Alba;
using Xunit;

namespace DotNetWebApi.Tests
{
    public class VerifyTheEndpoint
    {
        [Fact]
        public async Task CheckItOut(){
            using(var system = SystemUnderTest.ForStartup<Startup>()){
                await system.Scenario(s => {
                    s.Get.Url("/");
                    s.ContentShouldBe("Hey, World");
                    s.ContentTypeShouldBe("text/plain; charset=utf-8");
                });
            }
        }
    }
}