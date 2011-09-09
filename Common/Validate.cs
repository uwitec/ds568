using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Common
{
    public class Validate
    {
        /// <summary>
        /// 验证用户帐号，以字母开头，5-15位的字母或数字组合
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static bool RegUid(string uid) {
            return Regex.Match(uid,@"^[a-zA-Z]\w{5,15}$").Success;
        }

        /// <summary>
        /// 验证密码，6-20位字母或数字组合
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool RegPwd(string pwd) {
            return Regex.Match(pwd, @"^[a-zA-Z0-9]{6,20}$").Success;
        }
    }
}
