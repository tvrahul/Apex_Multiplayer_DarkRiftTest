using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class SuccessResult<T>
    {
        public int Code { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
        public T Item { get; set; }
    }
}
