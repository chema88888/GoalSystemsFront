using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GoalSystemsFront.Dtos
{
    public class Response
    {
        public string Message { get; set; }
        public HttpStatusCode HttpCode { get; set; }

        public object Data { get; set; }
    }
}