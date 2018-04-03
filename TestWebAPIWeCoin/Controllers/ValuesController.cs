using System.Collections.Generic;
using System.Web.Http;
using TestWebAPIWeCoin.Models;

namespace TestWebAPIWeCoin.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<User> GetValues()
        {
            var post1 = new Post()
            {
                Content = "Vamos arrebentar no Projeto"
            };
            var post2 = new Post()
            {
                Content = "POOOORRRAAAAA, TA DE SACANAGEM"
            };
            var post3 = new Post()
            {
                Content = "SOU O MAIS FODA DA INFNET"
            };

            var post4 = new Post()
            {
                Content = "SÓ TEM FODA HOJE AQUI"
            };

            var user1 = new User()
            {
                ImgURL = "https://receitatodahora.com.br/wp-content/uploads/2017/10/pudim-de-pao-simples.jpg",
                Nome = "João Pedro",
                Email = "joaozinho@arrebenta.com.br"
            };

            var user2 = new User()
            {
                ImgURL = "https://i.pinimg.com/originals/c1/e7/1b/c1e71b5ef53387139eecb3ba1c2a0ff6.jpg",
                Nome = "Diego Victor de Jesus",
                Email = "diego.victor@dejesus.com.br"
            };

            var user3 = new User()
            {
                ImgURL = "https://i.pinimg.com/originals/d2/2b/c4/d22bc49c16e2ac8d85b832306bb598cb.jpg",
                Nome = "Eder Engenheiro",
                Email = "eder.engenheiro@senior.com.br"
            };

            user1.Posts.Add(post1);
            user2.Posts.Add(post2);
            user3.Posts.Add(post3);
            user3.Posts.Add(post4);

            return new List<User> { user1, user2, user3 };

        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
