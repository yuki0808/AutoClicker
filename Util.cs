using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker
{
  class Util
  {
    public Util() { }

    public int convStrToInt(String str)
    {
      int result = 0;
      if (chechNumeric(str))
      {
        if (int.TryParse(str, out result))
        { }
      }
      return result;
    }

    /// <summary>
    /// 数値チェックint型
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public Boolean chechNumeric(String str)
    {
      Boolean result = false;
      int convInt = 0;

      if (int.TryParse(str, out convInt))
      {
        result = true;
      }
      return result;
    }

    public Boolean checkTimeFormat(String str) {
      Boolean result = false;

      if (System.Text.RegularExpressions.Regex.IsMatch(str,
          //@"^((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))$|^([01]\d|2[0-3])(:[0-5]\d){0,2}$"))
         @"^(([1-9]{1})|([0-1][0-9])|([1-2][0-3])):([0-5][0-9])$"))
      {
        //パターンマッチ
        result = true;
      }
      return result;
    
    }

    public int[] getHourMin(String str) {

      int[] result = new int[2];
      
      int numOfColon = str.IndexOf(':');
      //時間
      result[0] = convStrToInt(str.Substring(0, numOfColon));
      //分
      string temp = str.Substring(numOfColon + 1);

      result[1] = convStrToInt(str.Substring(numOfColon+1));

      return result;
    }
  }
}
