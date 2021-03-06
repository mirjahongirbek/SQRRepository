﻿using Joha.Interfaces;
using Joha.Interfaces.Enums;
using Joha.Interfaces.Logger;
using System;

namespace LiteLogger
{
    public class LiteLogger<TEntity> : ILogger<TEntity>
    {
        private string _path { get; set; }
        LiteLogger(string path)
        {
            _path = path;
           string name= typeof(TEntity).FullName;
        }
        public int Second { get; set; }
        public void Create(TEntity result, string text = "")
        {
           
        }

        public void Delete(TEntity result, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Delete(Func<TEntity, bool> func, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, TEntity result, MethodType type, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity result, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Read(string text = "")
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity old, TEntity newEntity, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, string text = "")
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, TEntity result, MethodType type, string text = "")
        {
            throw new NotImplementedException();
        }
    }
}
