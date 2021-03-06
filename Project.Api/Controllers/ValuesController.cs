﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Model;

namespace Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5

        /// <summary>
        /// 根据id获取数据详情
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values

        /// <summary>
        /// 向服务器post数据
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5

        /// <summary>
        /// 向服务器put数据
        /// </summary>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5

        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// 根据用户信息获取列表
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get(MyUser user)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
