using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA
{
    public class KeyValueData : Entity
    {
        /// <summary>
        /// 索引
        /// </summary>
        public int Key { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
    }

    public enum INDEX
    {
        wMSPositionBind,
        aGVBind,
        process1Position1Bind,
        process1Position2Bind,
        process2Position1Bind,
        process2Position2Bind,
        checkPosition1Bind,
        checkPosition2Bind
    }
}
