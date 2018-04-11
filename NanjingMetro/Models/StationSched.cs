using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NanjingMetro.Models;

namespace NanjingMetro.Models
{
    public class StationSched
    {
        /// <summary>
        /// 所有的站点信息
        /// </summary>
        List<StationInfo> stations = new List<StationInfo>();

        /// <summary>
        /// 线路信息
        /// </summary>
        List<ShipInfo> lines = new List<ShipInfo>();

        /// <summary>
        /// 构造函数，初始化站点和线路信息
        /// </summary>
        public StationSched()
        {
            stations.Add(new StationInfo() { Sid = 1, Lid = 1 });//0
            stations.Add(new StationInfo() { Sid = 2, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 3, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 4, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 5, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 6, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 7, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 8, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 9, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 10, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 11, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 12, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 13, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 14, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 15, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 16, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 17, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 18, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 19, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 20, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 21, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 22, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 23, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 24, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 25, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 26, Lid = 1 });
            stations.Add(new StationInfo() { Sid = 27, Lid = 1 });//26

            stations.Add(new StationInfo() { Sid = 28, Lid = 2 });//27
            stations.Add(new StationInfo() { Sid = 29, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 30, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 31, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 32, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 33, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 34, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 35, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 36, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 37, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 8, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 38, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 39, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 40, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 41, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 42, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 43, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 44, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 45, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 46, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 47, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 48, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 49, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 50, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 51, Lid = 2 });
            stations.Add(new StationInfo() { Sid = 52, Lid = 2 });//52


            stations.Add(new StationInfo() { Sid = 53, Lid = 3 });//53
            stations.Add(new StationInfo() { Sid = 54, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 55, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 56, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 57, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 58, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 59, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 60, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 61, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 3, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 62, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 63, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 64, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 38, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 65, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 66, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 67, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 68, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 69, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 70, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 71, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 16, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 72, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 73, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 74, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 75, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 76, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 77, Lid = 3 });
            stations.Add(new StationInfo() { Sid = 78, Lid = 3 });//81

            stations.Add(new StationInfo() { Sid = 79, Lid = 4 });//82
            stations.Add(new StationInfo() { Sid = 80, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 81, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 6, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 63, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 82, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 83, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 84, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 85, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 86, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 87, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 46, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 88, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 89, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 90, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 91, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 92, Lid = 4 });
            stations.Add(new StationInfo() { Sid = 93, Lid = 4 });//99

            stations.Add(new StationInfo() { Sid = 94, Lid = 10 });//100
            stations.Add(new StationInfo() { Sid = 95, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 96, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 97, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 98, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 99, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 100, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 101, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 102, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 103, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 30, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 104, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 105, Lid = 10 });
            stations.Add(new StationInfo() { Sid = 12, Lid = 10 });//113

            stations.Add(new StationInfo() { Sid = 16, Lid = 1151 });//114
            stations.Add(new StationInfo() { Sid = 106, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 107, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 108, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 109, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 110, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 111, Lid = 1151 });
            stations.Add(new StationInfo() { Sid = 112, Lid = 1151 });//121

            stations.Add(new StationInfo() { Sid = 113, Lid = 1153 });//122
            stations.Add(new StationInfo() { Sid = 114, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 115, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 116, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 117, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 118, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 119, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 120, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 121, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 122, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 123, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 124, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 125, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 28, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 126, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 127, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 128, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 129, Lid = 1153 });
            stations.Add(new StationInfo() { Sid = 16, Lid = 1153 });//140

            stations.Add(new StationInfo() { Sid = 130, Lid = 1158 });//141
            stations.Add(new StationInfo() { Sid = 56, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 131, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 132, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 133, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 134, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 135, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 136, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 137, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 138, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 139, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 140, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 141, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 142, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 143, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 144, Lid = 1158 });
            stations.Add(new StationInfo() { Sid = 145, Lid = 1158 });//157

            stations.Add(new StationInfo() { Sid = 111, Lid = 1159 });//158
            stations.Add(new StationInfo() { Sid = 146, Lid = 1159 });
            stations.Add(new StationInfo() { Sid = 147, Lid = 1159 });
            stations.Add(new StationInfo() { Sid = 148, Lid = 1159 });
            stations.Add(new StationInfo() { Sid = 149, Lid = 1159 });
            stations.Add(new StationInfo() { Sid = 150, Lid = 1159 });//163






            for (int i = 0; i < 26; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 26; i > 0; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 27; i < 52; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 52; i > 27; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 53; i < 81; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 81; i > 53; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 82; i < 99; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 99; i > 82; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 100; i < 113; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 113; i > 100; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 114; i < 121; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 121; i > 114; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 122; i < 140; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 140; i > 122; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 141; i < 157; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 157; i > 141; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }

            for (int i = 158; i < 163; i++)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i + 1] });
            }
            for (int i = 163; i > 158; i--)
            {
                lines.Add(new ShipInfo() { Curr = stations[i], Next = stations[i - 1] });
            }



        }

        /// <summary>
        /// 获取sid站点可以到达的站点信息，去除已经计算过的preid站点
        /// </summary>
        /// <param name="preid"></param>
        /// <param name="sid"></param>
        /// <returns></returns>
        public List<StationInfo> GetNext(int preid, int sid)
        {
            List<StationInfo> list = new List<StationInfo>();
            foreach (var item in lines)
            {
                if (item.Curr.Sid == sid && item.Next.Sid != preid) list.Add(item.Next);
            }
            return list;
        }

        /// <summary>
        /// 获取线路信息
        /// </summary>
        /// <param name="s">起始站点编号</param>
        /// <param name="e">结束站点编号</param>
        /// <returns></returns>
        public List<string> GetResult(int s, int e)
        {
            List<List<int>> temp = GetLine(s, e);
            List<string> result = new List<string>();
            List<List<int>> line = new List<List<int>>();
            foreach (var item in temp)
            {
                if (item.Count > 0 && item[item.Count - 1] == e)
                    line.Add(item);
            }
            string src = "";
            int currLine = -1;
            foreach (var item in line)
            {
                currLine = GetLineNumber(item[0], item[1]);
                src += "在[" + currLine + "号线]的[" + item[0] + "]站上车";
                for (int i = 1; i < item.Count; i++)
                {
                    if (i == item.Count - 1)
                    {
                        src += " ，在[" + item[i] + "]站下车 。";
                        result.Add(src);
                        src = "";
                        break;
                    }
                    int tempLine = GetLineNumber(item[i], item[i + 1]);
                    if (tempLine != currLine)
                    {
                        currLine = tempLine;
                        src += " ，在[" + item[i] + "]站换乘[" + currLine + "号线]";
                    }
                }

            }

            return result;
        }

        /// <summary>
        /// 根据相邻的两个点取当前的线路
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int GetLineNumber(int l, int r)
        {
            foreach (var item in lines)
            {
                if ((item.Curr.Sid == l && item.Next.Sid == r) || (item.Curr.Sid == r && item.Next.Sid == l))
                    return item.Next.Lid;
            }
            return -1;
        }

        /// <summary>
        /// 获取线路的ID集合
        /// </summary>
        /// <param name="s">起始站点编号</param>
        /// <param name="e">结束站点编号</param>
        /// <returns></returns>
        private List<List<int>> GetLine(int s, int e)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> curr = new List<int>();
            curr.Add(s);
            result.Add(curr);
            int currLine = 0;
            int preSid = s;
            int currSid = s;
            while (true)
            {
                if (currLine >= result.Count) return result;
                currSid = result[currLine][result[currLine].Count - 1];
                if (currSid == e)
                {
                    currLine += 1;
                    continue;
                }
                if (result[currLine].Count > 1)
                    preSid = result[currLine][result[currLine].Count - 2];
                if (currSid <= 0)
                {
                    currLine += 1;
                    continue;
                }
                List<StationInfo> temp = GetNext(preSid, currSid);

                if (temp.Count == 0)
                {//某条线路到头
                    currLine += 1;
                }
                else if (temp.Count == 1)
                {//不需要换乘继续前进
                    result[currLine].Add(temp[0].Sid);
                }
                else
                {//需要换乘了。
                    for (int i = 1; i < temp.Count; i++)
                    {
                        if (!result[currLine].Contains(temp[i].Sid))
                        {//防止死循环，过滤掉已经计算过的站点。
                            result.Add(result[currLine].GetRange(0, result[currLine].Count));
                            result[result.Count - 1].Add(temp[i].Sid);
                        }
                    }
                    result[currLine].Add(temp[0].Sid);
                }
            }
        }
    }
}