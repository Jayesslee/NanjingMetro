using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NanjingMetro.Models
{
    public class MetroQuery
    {
        [Required(ErrorMessage = "PLEASE ENTER THE STARTING STATION")]
        [RegularExpression("^迈皋桥$|^红山动物园$|^南京站$|^新模范马路$|^玄武门$|^鼓楼$|^珠江路$|^新街口$|^张府园$|^三山街$|^ 中华门$|^安德门$|^天龙寺$|^软件大道$|^花神庙$|^南京南站$|^双龙大道$|^河定桥$|^胜太路$|^百家湖$|^小龙湾$|^竹山路$|^天印大道$|^龙眠大道$|^南医大·江苏经贸学院$|^南京交院$|^中国药科大学$|^油坊桥$|^雨润大街$|^元通$|^奥体东$|^兴隆大街$|^集庆门大街$|^云锦路$|^莫愁湖$|^汉中门$|^上海路$|^大行宫$|^西安门$|^明故宫$|^苜蓿园$|^下马坊$|^孝陵卫$|^钟灵街$|^马群$|^金马路$|^仙鹤门$|^学则路$|^仙林中心$|^羊山公园$|^南大仙林校区$|^经天路$|^林场$|^星火路$|^东大成贤学院$|^泰冯路$|^天润城$|^柳州东路$|^上元门$|^五塘广场$|^小市$|^南京林业大学·新庄$|^鸡鸣寺$|^浮桥$|^常府街$|^夫子庙$|^武定门$|^雨花门$|^卡子门$|^大明路$|^明发广场$|^宏运大道$|^盛泰西路$|^天元西路$|^九龙湖$|^诚信大道$|^东大九龙湖校区$|^秣周东路$|^龙江$|^南艺·二师·草场门$|^云南路$|^九华山$|^岗子村$|^蒋王庙$|^王家湾$|^聚宝山$|^苏宁总部·徐庄$|^汇通路$|^灵山$|^东流$|^孟北$|^西岗桦墅$|^仙林湖$|^雨山路$|^文德路$|^龙华路$|^南京工业大学$|^浦口万汇城$|^临江$|^江心洲$|^绿博园$|^梦都大街$|^奥体中心$|^中胜$|^小行$|^翠屏山$|^河海大学·佛城西路$|^吉印大道$|^正方中路$|^翔宇路北$|^翔宇路南$|^禄口机场$|^高家冲$|^林山$|^桥林新城$|^石碛河$|^双垅$|^兰花塘$|^马骡圩$|^刘村$|^天宝$|^高庙路$|^吴侯街$|^平良大街$|^永初路$|^贾西$|^春江路$|^铁心桥$|^景明佳园$|^泰山新村$|^高新开发区$|^信息工程大学$|^卸甲甸$|^大厂$|^葛塘$|^长芦$|^化工园$|^六合开发区$|^龙池$|^雄州$|^凤凰山公园$|^方州广场$|^沈桥$|^八百桥$|^金牛湖$|^铜山$|^石湫$|^明觉$|^团结圩$|^高淳$", ErrorMessage = "PLEASE ENTER A CORRECT STARTING STATION")]
        public string Startname { get; set; }

        [Required(ErrorMessage = "PLEASE ENTER THE DESTINATION")]
        [RegularExpression("^迈皋桥$|^红山动物园$|^南京站$|^新模范马路$|^玄武门$|^鼓楼$|^珠江路$|^新街口$|^张府园$|^三山街$|^ 中华门$|^安德门$|^天龙寺$|^软件大道$|^花神庙$|^南京南站$|^双龙大道$|^河定桥$|^胜太路$|^百家湖$|^小龙湾$|^竹山路$|^天印大道$|^龙眠大道$|^南医大·江苏经贸学院$|^南京交院$|^中国药科大学$|^油坊桥$|^雨润大街$|^元通$|^奥体东$|^兴隆大街$|^集庆门大街$|^云锦路$|^莫愁湖$|^汉中门$|^上海路$|^大行宫$|^西安门$|^明故宫$|^苜蓿园$|^下马坊$|^孝陵卫$|^钟灵街$|^马群$|^金马路$|^仙鹤门$|^学则路$|^仙林中心$|^羊山公园$|^南大仙林校区$|^经天路$|^林场$|^星火路$|^东大成贤学院$|^泰冯路$|^天润城$|^柳州东路$|^上元门$|^五塘广场$|^小市$|^南京林业大学·新庄$|^鸡鸣寺$|^浮桥$|^常府街$|^夫子庙$|^武定门$|^雨花门$|^卡子门$|^大明路$|^明发广场$|^宏运大道$|^盛泰西路$|^天元西路$|^九龙湖$|^诚信大道$|^东大九龙湖校区$|^秣周东路$|^龙江$|^南艺·二师·草场门$|^云南路$|^九华山$|^岗子村$|^蒋王庙$|^王家湾$|^聚宝山$|^苏宁总部·徐庄$|^汇通路$|^灵山$|^东流$|^孟北$|^西岗桦墅$|^仙林湖$|^雨山路$|^文德路$|^龙华路$|^南京工业大学$|^浦口万汇城$|^临江$|^江心洲$|^绿博园$|^梦都大街$|^奥体中心$|^中胜$|^小行$|^翠屏山$|^河海大学·佛城西路$|^吉印大道$|^正方中路$|^翔宇路北$|^翔宇路南$|^禄口机场$|^高家冲$|^林山$|^桥林新城$|^石碛河$|^双垅$|^兰花塘$|^马骡圩$|^刘村$|^天宝$|^高庙路$|^吴侯街$|^平良大街$|^永初路$|^贾西$|^春江路$|^铁心桥$|^景明佳园$|^泰山新村$|^高新开发区$|^信息工程大学$|^卸甲甸$|^大厂$|^葛塘$|^长芦$|^化工园$|^六合开发区$|^龙池$|^雄州$|^凤凰山公园$|^方州广场$|^沈桥$|^八百桥$|^金牛湖$|^铜山$|^石湫$|^明觉$|^团结圩$|^高淳$", ErrorMessage = "PLEASE ENTER A CORRECT DESTINATION")]
        public string Endname { get; set; }


        public int Start { get; set; }
        public int End { get; set; }
        public string Result { get; set; }


        public void Query()
        {
            switch (Startname)
            {
                case "迈皋桥":
                    Start = 1;
                    break;
                case "红山动物园":
                    Start = 2;
                    break;
                case "南京站":
                    Start = 3;
                    break;
                case "新模范马路":
                    Start = 4;
                    break;
                case "玄武门":
                    Start = 5;
                    break;
                case "鼓楼":
                    Start = 6;
                    break;
                case "珠江路":
                    Start = 7;
                    break;
                case "新街口":
                    Start = 8;
                    break;
                case "张府园":
                    Start = 9;
                    break;
                case "三山街":
                    Start = 10;
                    break;
                case "中华门":
                    Start = 11;
                    break;
                case "安德门":
                    Start = 12;
                    break;
                case "天龙寺":
                    Start = 13;
                    break;
                case "软件大道":
                    Start = 14;
                    break;
                case "花神庙":
                    Start = 15;
                    break;
                case "南京南站":
                    Start = 16;
                    break;
                case "双龙大道":
                    Start = 17;
                    break;
                case "河定桥":
                    Start = 18;
                    break;
                case "胜太路":
                    Start = 19;
                    break;
                case "百家湖":
                    Start = 20;
                    break;
                case "小龙湾":
                    Start = 21;
                    break;
                case "竹山路":
                    Start = 22;
                    break;
                case "天印大道":
                    Start = 23;
                    break;
                case "龙眠大道":
                    Start = 24;
                    break;
                case "南医大·江苏经贸学院":
                    Start = 25;
                    break;
                case "南京交院":
                    Start = 26;
                    break;
                case "中国药科大学":
                    Start = 27;
                    break;
                case "油坊桥":
                    Start = 28;
                    break;
                case "雨润大街":
                    Start = 29;
                    break;
                case "元通":
                    Start = 30;
                    break;
                case "奥体东":
                    Start = 31;
                    break;
                case "兴隆大街":
                    Start = 32;
                    break;
                case "集庆门大街":
                    Start = 33;
                    break;
                case "云锦路":
                    Start = 34;
                    break;
                case "莫愁湖":
                    Start = 35;
                    break;
                case "汉中门":
                    Start = 36;
                    break;
                case "上海路":
                    Start = 37;
                    break;
                case "大行宫":
                    Start = 38;
                    break;
                case "西安门":
                    Start = 39;
                    break;
                case "明故宫":
                    Start = 40;
                    break;
                case "苜蓿园":
                    Start = 41;
                    break;
                case "下马坊":
                    Start = 42;
                    break;
                case "孝陵卫":
                    Start = 43;
                    break;
                case "钟灵街":
                    Start = 44;
                    break;
                case "马群":
                    Start = 45;
                    break;
                case "金马路":
                    Start = 46;
                    break;
                case "仙鹤门":
                    Start = 47;
                    break;
                case "学则路":
                    Start = 48;
                    break;
                case "仙林中心":
                    Start = 49;
                    break;
                case "羊山公园":
                    Start = 50;
                    break;
                case "南大仙林校区":
                    Start = 51;
                    break;
                case "经天路":
                    Start = 52;
                    break;
                case "林场":
                    Start = 53;
                    break;
                case "星火路":
                    Start = 54;
                    break;
                case "东大成贤学院":
                    Start = 55;
                    break;
                case "泰冯路":
                    Start = 56;
                    break;
                case "天润城":
                    Start = 57;
                    break;
                case "柳州东路":
                    Start = 58;
                    break;
                case "上元门":
                    Start = 59;
                    break;
                case "五塘广场":
                    Start = 60;
                    break;
                case "小市":
                    Start = 61;
                    break;
                case "南京林业大学·新庄":
                    Start = 62;
                    break;
                case "鸡鸣寺":
                    Start = 63;
                    break;
                case "浮桥":
                    Start = 64;
                    break;
                case "常府街":
                    Start = 65;
                    break;
                case "夫子庙":
                    Start = 66;
                    break;
                case "武定门":
                    Start = 67;
                    break;
                case "雨花门":
                    Start = 68;
                    break;
                case "卡子门":
                    Start = 69;
                    break;
                case "大明路":
                    Start = 70;
                    break;
                case "明发广场":
                    Start = 71;
                    break;
                case "宏运大道":
                    Start = 72;
                    break;
                case "盛泰西路":
                    Start = 73;
                    break;
                case "天元西路":
                    Start = 74;
                    break;
                case "九龙湖":
                    Start = 75;
                    break;
                case "诚信大道":
                    Start = 76;
                    break;
                case "东大九龙湖校区":
                    Start = 77;
                    break;
                case "秣周东路":
                    Start = 78;
                    break;
                case "龙江":
                    Start = 79;
                    break;
                case "南艺·二师·草场门":
                    Start = 80;
                    break;
                case "云南路":
                    Start = 81;
                    break;
                case "九华山":
                    Start = 82;
                    break;
                case "岗子村":
                    Start = 83;
                    break;
                case "蒋王庙":
                    Start = 84;
                    break;
                case "王家湾":
                    Start = 85;
                    break;
                case "聚宝山":
                    Start = 86;
                    break;
                case "苏宁总部·徐庄":
                    Start = 87;
                    break;
                case "汇通路":
                    Start = 88;
                    break;
                case "灵山":
                    Start = 89;
                    break;
                case "东流":
                    Start = 90;
                    break;
                case "孟北":
                    Start = 91;
                    break;
                case "西岗桦墅":
                    Start = 92;
                    break;
                case "仙林湖":
                    Start = 93;
                    break;
                case "雨山路":
                    Start = 94;
                    break;
                case "文德路":
                    Start = 95;
                    break;
                case "龙华路":
                    Start = 96;
                    break;
                case "南京工业大学":
                    Start = 97;
                    break;
                case "浦口万汇城":
                    Start = 98;
                    break;
                case "临江":
                    Start = 99;
                    break;
                case "江心洲":
                    Start = 100;
                    break;
                case "绿博园":
                    Start = 101;
                    break;
                case "梦都大街":
                    Start = 102;
                    break;
                case "奥体中心":
                    Start = 103;
                    break;
                case "中胜":
                    Start = 104;
                    break;
                case "小行":
                    Start = 105;
                    break;
                case "翠屏山":
                    Start = 106;
                    break;
                case "河海大学·佛城西路":
                    Start = 107;
                    break;
                case "吉印大道":
                    Start = 108;
                    break;
                case "正方中路":
                    Start = 109;
                    break;
                case "翔宇路北":
                    Start = 110;
                    break;
                case "翔宇路南":
                    Start = 111;
                    break;
                case "禄口机场":
                    Start = 112;
                    break;
                case "高家冲":
                    Start = 113;
                    break;
                case "林山":
                    Start = 114;
                    break;
                case "桥林新城":
                    Start = 115;
                    break;
                case "石碛河":
                    Start = 116;
                    break;
                case "双垅":
                    Start = 117;
                    break;
                case "兰花塘":
                    Start = 118;
                    break;
                case "马骡圩":
                    Start = 119;
                    break;
                case "刘村":
                    Start = 120;
                    break;
                case "天宝":
                    Start = 121;
                    break;
                case "高庙路":
                    Start = 122;
                    break;
                case "吴侯街":
                    Start = 123;
                    break;
                case "平良大街":
                    Start = 124;
                    break;
                case "永初路":
                    Start = 125;
                    break;
                case "贾西":
                    Start = 126;
                    break;
                case "春江路":
                    Start = 127;
                    break;
                case "铁心桥":
                    Start = 128;
                    break;
                case "景明佳园":
                    Start = 129;
                    break;
                case "泰山新村":
                    Start = 130;
                    break;
                case "高新开发区":
                    Start = 131;
                    break;
                case "信息工程大学":
                    Start = 132;
                    break;
                case "卸甲甸":
                    Start = 133;
                    break;
                case "大厂":
                    Start = 134;
                    break;
                case "葛塘":
                    Start = 135;
                    break;
                case "长芦":
                    Start = 136;
                    break;
                case "化工园":
                    Start = 137;
                    break;
                case "六合开发区":
                    Start = 138;
                    break;
                case "龙池":
                    Start = 139;
                    break;
                case "雄州":
                    Start = 140;
                    break;
                case "凤凰山公园":
                    Start = 141;
                    break;
                case "方州广场":
                    Start = 142;
                    break;
                case "沈桥":
                    Start = 143;
                    break;
                case "八百桥":
                    Start = 144;
                    break;
                case "金牛湖":
                    Start = 145;
                    break;
                case "铜山":
                    Start = 146;
                    break;
                case "石湫":
                    Start = 147;
                    break;
                case "明觉":
                    Start = 148;
                    break;
                case "团结圩":
                    Start = 149;
                    break;
                case "高淳":
                    Start = 150;
                    break;
                default:
                    Start = 200;
                    break;
            }

            switch (Endname)
            {
                case "迈皋桥":
                    End = 1;
                    break;
                case "红山动物园":
                    End = 2;
                    break;
                case "南京站":
                    End = 3;
                    break;
                case "新模范马路":
                    End = 4;
                    break;
                case "玄武门":
                    End = 5;
                    break;
                case "鼓楼":
                    End = 6;
                    break;
                case "珠江路":
                    End = 7;
                    break;
                case "新街口":
                    End = 8;
                    break;
                case "张府园":
                    End = 9;
                    break;
                case "三山街":
                    End = 10;
                    break;
                case "中华门":
                    End = 11;
                    break;
                case "安德门":
                    End = 12;
                    break;
                case "天龙寺":
                    End = 13;
                    break;
                case "软件大道":
                    End = 14;
                    break;
                case "花神庙":
                    End = 15;
                    break;
                case "南京南站":
                    End = 16;
                    break;
                case "双龙大道":
                    End = 17;
                    break;
                case "河定桥":
                    End = 18;
                    break;
                case "胜太路":
                    End = 19;
                    break;
                case "百家湖":
                    End = 20;
                    break;
                case "小龙湾":
                    End = 21;
                    break;
                case "竹山路":
                    End = 22;
                    break;
                case "天印大道":
                    End = 23;
                    break;
                case "龙眠大道":
                    End = 24;
                    break;
                case "南医大·江苏经贸学院":
                    End = 25;
                    break;
                case "南京交院":
                    End = 26;
                    break;
                case "中国药科大学":
                    End = 27;
                    break;
                case "油坊桥":
                    End = 28;
                    break;
                case "雨润大街":
                    End = 29;
                    break;
                case "元通":
                    End = 30;
                    break;
                case "奥体东":
                    End = 31;
                    break;
                case "兴隆大街":
                    End = 32;
                    break;
                case "集庆门大街":
                    End = 33;
                    break;
                case "云锦路":
                    End = 34;
                    break;
                case "莫愁湖":
                    End = 35;
                    break;
                case "汉中门":
                    End = 36;
                    break;
                case "上海路":
                    End = 37;
                    break;
                case "大行宫":
                    End = 38;
                    break;
                case "西安门":
                    End = 39;
                    break;
                case "明故宫":
                    End = 40;
                    break;
                case "苜蓿园":
                    End = 41;
                    break;
                case "下马坊":
                    End = 42;
                    break;
                case "孝陵卫":
                    End = 43;
                    break;
                case "钟灵街":
                    End = 44;
                    break;
                case "马群":
                    End = 45;
                    break;
                case "金马路":
                    End = 46;
                    break;
                case "仙鹤门":
                    End = 47;
                    break;
                case "学则路":
                    End = 48;
                    break;
                case "仙林中心":
                    End = 49;
                    break;
                case "羊山公园":
                    End = 50;
                    break;
                case "南大仙林校区":
                    End = 51;
                    break;
                case "经天路":
                    End = 52;
                    break;
                case "林场":
                    End = 53;
                    break;
                case "星火路":
                    End = 54;
                    break;
                case "东大成贤学院":
                    End = 55;
                    break;
                case "泰冯路":
                    End = 56;
                    break;
                case "天润城":
                    End = 57;
                    break;
                case "柳州东路":
                    End = 58;
                    break;
                case "上元门":
                    End = 59;
                    break;
                case "五塘广场":
                    End = 60;
                    break;
                case "小市":
                    End = 61;
                    break;
                case "南京林业大学·新庄":
                    End = 62;
                    break;
                case "鸡鸣寺":
                    End = 63;
                    break;
                case "浮桥":
                    End = 64;
                    break;
                case "常府街":
                    End = 65;
                    break;
                case "夫子庙":
                    End = 66;
                    break;
                case "武定门":
                    End = 67;
                    break;
                case "雨花门":
                    End = 68;
                    break;
                case "卡子门":
                    End = 69;
                    break;
                case "大明路":
                    End = 70;
                    break;
                case "明发广场":
                    End = 71;
                    break;
                case "宏运大道":
                    End = 72;
                    break;
                case "盛泰西路":
                    End = 73;
                    break;
                case "天元西路":
                    End = 74;
                    break;
                case "九龙湖":
                    End = 75;
                    break;
                case "诚信大道":
                    End = 76;
                    break;
                case "东大九龙湖校区":
                    End = 77;
                    break;
                case "秣周东路":
                    End = 78;
                    break;
                case "龙江":
                    End = 79;
                    break;
                case "南艺·二师·草场门":
                    End = 80;
                    break;
                case "云南路":
                    End = 81;
                    break;
                case "九华山":
                    End = 82;
                    break;
                case "岗子村":
                    End = 83;
                    break;
                case "蒋王庙":
                    End = 84;
                    break;
                case "王家湾":
                    End = 85;
                    break;
                case "聚宝山":
                    End = 86;
                    break;
                case "苏宁总部·徐庄":
                    End = 87;
                    break;
                case "汇通路":
                    End = 88;
                    break;
                case "灵山":
                    End = 89;
                    break;
                case "东流":
                    End = 90;
                    break;
                case "孟北":
                    End = 91;
                    break;
                case "西岗桦墅":
                    End = 92;
                    break;
                case "仙林湖":
                    End = 93;
                    break;
                case "雨山路":
                    End = 94;
                    break;
                case "文德路":
                    End = 95;
                    break;
                case "龙华路":
                    End = 96;
                    break;
                case "南京工业大学":
                    End = 97;
                    break;
                case "浦口万汇城":
                    End = 98;
                    break;
                case "临江":
                    End = 99;
                    break;
                case "江心洲":
                    End = 100;
                    break;
                case "绿博园":
                    End = 101;
                    break;
                case "梦都大街":
                    End = 102;
                    break;
                case "奥体中心":
                    End = 103;
                    break;
                case "中胜":
                    End = 104;
                    break;
                case "小行":
                    End = 105;
                    break;
                case "翠屏山":
                    End = 106;
                    break;
                case "河海大学·佛城西路":
                    End = 107;
                    break;
                case "吉印大道":
                    End = 108;
                    break;
                case "正方中路":
                    End = 109;
                    break;
                case "翔宇路北":
                    End = 110;
                    break;
                case "翔宇路南":
                    End = 111;
                    break;
                case "禄口机场":
                    End = 112;
                    break;
                case "高家冲":
                    End = 113;
                    break;
                case "林山":
                    End = 114;
                    break;
                case "桥林新城":
                    End = 115;
                    break;
                case "石碛河":
                    End = 116;
                    break;
                case "双垅":
                    End = 117;
                    break;
                case "兰花塘":
                    End = 118;
                    break;
                case "马骡圩":
                    End = 119;
                    break;
                case "刘村":
                    End = 120;
                    break;
                case "天宝":
                    End = 121;
                    break;
                case "高庙路":
                    End = 122;
                    break;
                case "吴侯街":
                    End = 123;
                    break;
                case "平良大街":
                    End = 124;
                    break;
                case "永初路":
                    End = 125;
                    break;
                case "贾西":
                    End = 126;
                    break;
                case "春江路":
                    End = 127;
                    break;
                case "铁心桥":
                    End = 128;
                    break;
                case "景明佳园":
                    End = 129;
                    break;
                case "泰山新村":
                    End = 130;
                    break;
                case "高新开发区":
                    End = 131;
                    break;
                case "信息工程大学":
                    End = 132;
                    break;
                case "卸甲甸":
                    End = 133;
                    break;
                case "大厂":
                    End = 134;
                    break;
                case "葛塘":
                    End = 135;
                    break;
                case "长芦":
                    End = 136;
                    break;
                case "化工园":
                    End = 137;
                    break;
                case "六合开发区":
                    End = 138;
                    break;
                case "龙池":
                    End = 139;
                    break;
                case "雄州":
                    End = 140;
                    break;
                case "凤凰山公园":
                    End = 141;
                    break;
                case "方州广场":
                    End = 142;
                    break;
                case "沈桥":
                    End = 143;
                    break;
                case "八百桥":
                    End = 144;
                    break;
                case "金牛湖":
                    End = 145;
                    break;
                case "铜山":
                    End = 146;
                    break;
                case "石湫":
                    End = 147;
                    break;
                case "明觉":
                    End = 148;
                    break;
                case "团结圩":
                    End = 149;
                    break;
                case "高淳":
                    End = 150;
                    break;
                default:
                    break;
            }

            StationSched stationSched = new StationSched();
            List<string> lines = stationSched.GetResult(Start, End);

            try
            {
                //foreach (var route in lines)
                //{
                //    Result = lines[0];
                //    if (Result.Length > route.Length)
                //    {
                //        Result = route;
                //    }
                //}

                //List<int> ResultLength = new List<int> { };
                //foreach (var route in lines)
                //{
                //    ResultLength.Add(route.Length);
                //}
                //Result = lines[ResultLength.Min()];

                //for (int i = 0; i < lines.Count; i++)
                //{
                //    Result = lines[0];
                //    if (Result.Length > lines[i].Length)
                //    {
                //        Result = lines[i];
                //    }
                //}

                if (lines[0].Length <= lines[1].Length && lines[0].Length <= lines[2].Length)
                {
                    Result = lines[0];
                }
                if (lines[1].Length <= lines[0].Length && lines[1].Length <= lines[2].Length)
                {
                    Result = lines[1];
                }
                if (lines[2].Length <= lines[0].Length && lines[2].Length <= lines[1].Length)
                {
                    Result = lines[2];
                }

                Result = Result
                .Replace("[1151号线]", "[S1号线]")
                .Replace("[1153号线]", "[S3号线]")
                .Replace("[1158号线]", "[S8号线]")
                .Replace("[1159号线]", "[S9号线]")
                .Replace("[1]", "[迈皋桥]")
                .Replace("[2]", "[红山动物园]")
                .Replace("[3]", "[南京站]")
                .Replace("[4]", "[新模范马路]")
                .Replace("[5]", "[玄武门]")
                .Replace("[6]", "[鼓楼]")
                .Replace("[7]", "[珠江路]")
                .Replace("[8]", "[新街口]")
                .Replace("[9]", "[张府园]")
                .Replace("[10]", "[三山街]")
                .Replace("[11]", "[中华门]")
                .Replace("[12]", "[安德门]")
                .Replace("[13]", "[天龙寺]")
                .Replace("[14]", "[软件大道]")
                .Replace("[15]", "[花神庙]")
                .Replace("[16]", "[南京南站]")
                .Replace("[17]", "[双龙大道]")
                .Replace("[18]", "[河定桥]")
                .Replace("[19]", "[胜太路]")
                .Replace("[20]", "[百家湖]")
                .Replace("[21]", "[小龙湾]")
                .Replace("[22]", "[竹山路]")
                .Replace("[23]", "[天印大道]")
                .Replace("[24]", "[龙眠大道]")
                .Replace("[25]", "[南医大·江苏经贸学院]")
                .Replace("[26]", "[南京交院]")
                .Replace("[27]", "[中国药科大学]")
                .Replace("[28]", "[油坊桥]")
                .Replace("[29]", "[雨润大街]")
                .Replace("[30]", "[元通]")
                .Replace("[31]", "[奥体东]")
                .Replace("[32]", "[兴隆大街]")
                .Replace("[33]", "[集庆门大街]")
                .Replace("[34]", "[云锦路]")
                .Replace("[35]", "[莫愁湖]")
                .Replace("[36]", "[汉中门]")
                .Replace("[37]", "[上海路]")
                .Replace("[38]", "[大行宫]")
                .Replace("[39]", "[西安门]")
                .Replace("[40]", "[明故宫]")
                .Replace("[41]", "[苜蓿园]")
                .Replace("[42]", "[下马坊]")
                .Replace("[43]", "[孝陵卫]")
                .Replace("[44]", "[钟灵街]")
                .Replace("[45]", "[马群]")
                .Replace("[46]", "[金马路]")
                .Replace("[47]", "[仙鹤门]")
                .Replace("[48]", "[学则路]")
                .Replace("[49]", "[仙林中心]")
                .Replace("[50]", "[羊山公园]")
                .Replace("[51]", "[南大仙林校区]")
                .Replace("[52]", "[经天路]")
                .Replace("[53]", "[林场]")
                .Replace("[54]", "[星火路]")
                .Replace("[55]", "[东大成贤学院]")
                .Replace("[56]", "[泰冯路]")
                .Replace("[57]", "[天润城]")
                .Replace("[58]", "[柳州东路]")
                .Replace("[59]", "[上元门]")
                .Replace("[60]", "[五塘广场]")
                .Replace("[61]", "[小市]")
                .Replace("[62]", "[南京林业大学·新庄]")
                .Replace("[63]", "[鸡鸣寺]")
                .Replace("[64]", "[浮桥]")
                .Replace("[65]", "[常府街]")
                .Replace("[66]", "[夫子庙]")
                .Replace("[67]", "[武定门]")
                .Replace("[68]", "[雨花门]")
                .Replace("[69]", "[卡子门]")
                .Replace("[70]", "[大明路]")
                .Replace("[71]", "[明发广场]")
                .Replace("[72]", "[宏运大道]")
                .Replace("[73]", "[盛泰西路]")
                .Replace("[74]", "[天元西路]")
                .Replace("[75]", "[九龙湖]")
                .Replace("[76]", "[诚信大道]")
                .Replace("[77]", "[东大九龙湖校区]")
                .Replace("[78]", "[秣周东路]")
                .Replace("[79]", "[龙江]")
                .Replace("[80]", "[南艺·二师·草场门]")
                .Replace("[81]", "[云南路]")
                .Replace("[82]", "[九华山]")
                .Replace("[83]", "[岗子村]")
                .Replace("[84]", "[蒋王庙]")
                .Replace("[85]", "[王家湾]")
                .Replace("[86]", "[聚宝山]")
                .Replace("[87]", "[苏宁总部·徐庄]")
                .Replace("[88]", "[汇通路]")
                .Replace("[89]", "[灵山]")
                .Replace("[90]", "[东流]")
                .Replace("[91]", "[孟北]")
                .Replace("[92]", "[西岗桦墅]")
                .Replace("[93]", "[仙林湖]")
                .Replace("[94]", "[雨山路]")
                .Replace("[95]", "[文德路]")
                .Replace("[96]", "[龙华路]")
                .Replace("[97]", "[南京工业大学]")
                .Replace("[98]", "[浦口万汇城]")
                .Replace("[99]", "[临江]")
                .Replace("[100]", "[江心洲]")
                .Replace("[101]", "[绿博园]")
                .Replace("[102]", "[梦都大街]")
                .Replace("[103]", "[奥体中心]")
                .Replace("[104]", "[中胜]")
                .Replace("[105]", "[小行]")
                .Replace("[106]", "[翠屏山]")
                .Replace("[107]", "[河海大学·佛城西路]")
                .Replace("[108]", "[吉印大道]")
                .Replace("[109]", "[正方中路]")
                .Replace("[110]", "[翔宇路北]")
                .Replace("[111]", "[翔宇路南]")
                .Replace("[112]", "[禄口机场]")
                .Replace("[113]", "[高家冲]")
                .Replace("[114]", "[林山]")
                .Replace("[115]", "[桥林新城]")
                .Replace("[116]", "[石碛河]")
                .Replace("[117]", "[双垅]")
                .Replace("[118]", "[兰花塘]")
                .Replace("[119]", "[马骡圩]")
                .Replace("[120]", "[刘村]")
                .Replace("[121]", "[天宝]")
                .Replace("[122]", "[高庙路]")
                .Replace("[123]", "[吴侯街]")
                .Replace("[124]", "[平良大街]")
                .Replace("[125]", "[永初路]")
                .Replace("[126]", "[贾西]")
                .Replace("[127]", "[春江路]")
                .Replace("[128]", "[铁心桥]")
                .Replace("[129]", "[景明佳园]")
                .Replace("[130]", "[泰山新村]")
                .Replace("[131]", "[高新开发区]")
                .Replace("[132]", "[信息工程大学]")
                .Replace("[133]", "[卸甲甸]")
                .Replace("[134]", "[大厂]")
                .Replace("[135]", "[葛塘]")
                .Replace("[136]", "[长芦]")
                .Replace("[137]", "[化工园]")
                .Replace("[138]", "[六合开发区]")
                .Replace("[139]", "[龙池]")
                .Replace("[140]", "[雄州]")
                .Replace("[141]", "[凤凰山公园]")
                .Replace("[142]", "[方州广场]")
                .Replace("[143]", "[沈桥]")
                .Replace("[144]", "[八百桥]")
                .Replace("[145]", "[金牛湖]")
                .Replace("[146]", "[铜山]")
                .Replace("[147]", "[石湫]")
                .Replace("[148]", "[明觉]")
                .Replace("[149]", "[团结圩]")
                .Replace("[150]", "[高淳]")
                ;

            }
            catch (ArgumentOutOfRangeException)
            {
                Result = lines[0];
                Result = Result
                .Replace("[1151号线]", "[S1号线]")
                .Replace("[1153号线]", "[S3号线]")
                .Replace("[1158号线]", "[S8号线]")
                .Replace("[1159号线]", "[S9号线]")
                .Replace("[1]", "[迈皋桥]")
                .Replace("[2]", "[红山动物园]")
                .Replace("[3]", "[南京站]")
                .Replace("[4]", "[新模范马路]")
                .Replace("[5]", "[玄武门]")
                .Replace("[6]", "[鼓楼]")
                .Replace("[7]", "[珠江路]")
                .Replace("[8]", "[新街口]")
                .Replace("[9]", "[张府园]")
                .Replace("[10]", "[三山街]")
                .Replace("[11]", "[中华门]")
                .Replace("[12]", "[安德门]")
                .Replace("[13]", "[天龙寺]")
                .Replace("[14]", "[软件大道]")
                .Replace("[15]", "[花神庙]")
                .Replace("[16]", "[南京南站]")
                .Replace("[17]", "[双龙大道]")
                .Replace("[18]", "[河定桥]")
                .Replace("[19]", "[胜太路]")
                .Replace("[20]", "[百家湖]")
                .Replace("[21]", "[小龙湾]")
                .Replace("[22]", "[竹山路]")
                .Replace("[23]", "[天印大道]")
                .Replace("[24]", "[龙眠大道]")
                .Replace("[25]", "[南医大·江苏经贸学院]")
                .Replace("[26]", "[南京交院]")
                .Replace("[27]", "[中国药科大学]")
                .Replace("[28]", "[油坊桥]")
                .Replace("[29]", "[雨润大街]")
                .Replace("[30]", "[元通]")
                .Replace("[31]", "[奥体东]")
                .Replace("[32]", "[兴隆大街]")
                .Replace("[33]", "[集庆门大街]")
                .Replace("[34]", "[云锦路]")
                .Replace("[35]", "[莫愁湖]")
                .Replace("[36]", "[汉中门]")
                .Replace("[37]", "[上海路]")
                .Replace("[38]", "[大行宫]")
                .Replace("[39]", "[西安门]")
                .Replace("[40]", "[明故宫]")
                .Replace("[41]", "[苜蓿园]")
                .Replace("[42]", "[下马坊]")
                .Replace("[43]", "[孝陵卫]")
                .Replace("[44]", "[钟灵街]")
                .Replace("[45]", "[马群]")
                .Replace("[46]", "[金马路]")
                .Replace("[47]", "[仙鹤门]")
                .Replace("[48]", "[学则路]")
                .Replace("[49]", "[仙林中心]")
                .Replace("[50]", "[羊山公园]")
                .Replace("[51]", "[南大仙林校区]")
                .Replace("[52]", "[经天路]")
                .Replace("[53]", "[林场]")
                .Replace("[54]", "[星火路]")
                .Replace("[55]", "[东大成贤学院]")
                .Replace("[56]", "[泰冯路]")
                .Replace("[57]", "[天润城]")
                .Replace("[58]", "[柳州东路]")
                .Replace("[59]", "[上元门]")
                .Replace("[60]", "[五塘广场]")
                .Replace("[61]", "[小市]")
                .Replace("[62]", "[南京林业大学·新庄]")
                .Replace("[63]", "[鸡鸣寺]")
                .Replace("[64]", "[浮桥]")
                .Replace("[65]", "[常府街]")
                .Replace("[66]", "[夫子庙]")
                .Replace("[67]", "[武定门]")
                .Replace("[68]", "[雨花门]")
                .Replace("[69]", "[卡子门]")
                .Replace("[70]", "[大明路]")
                .Replace("[71]", "[明发广场]")
                .Replace("[72]", "[宏运大道]")
                .Replace("[73]", "[盛泰西路]")
                .Replace("[74]", "[天元西路]")
                .Replace("[75]", "[九龙湖]")
                .Replace("[76]", "[诚信大道]")
                .Replace("[77]", "[东大九龙湖校区]")
                .Replace("[78]", "[秣周东路]")
                .Replace("[79]", "[龙江]")
                .Replace("[80]", "[南艺·二师·草场门]")
                .Replace("[81]", "[云南路]")
                .Replace("[82]", "[九华山]")
                .Replace("[83]", "[岗子村]")
                .Replace("[84]", "[蒋王庙]")
                .Replace("[85]", "[王家湾]")
                .Replace("[86]", "[聚宝山]")
                .Replace("[87]", "[苏宁总部·徐庄]")
                .Replace("[88]", "[汇通路]")
                .Replace("[89]", "[灵山]")
                .Replace("[90]", "[东流]")
                .Replace("[91]", "[孟北]")
                .Replace("[92]", "[西岗桦墅]")
                .Replace("[93]", "[仙林湖]")
                .Replace("[94]", "[雨山路]")
                .Replace("[95]", "[文德路]")
                .Replace("[96]", "[龙华路]")
                .Replace("[97]", "[南京工业大学]")
                .Replace("[98]", "[浦口万汇城]")
                .Replace("[99]", "[临江]")
                .Replace("[100]", "[江心洲]")
                .Replace("[101]", "[绿博园]")
                .Replace("[102]", "[梦都大街]")
                .Replace("[103]", "[奥体中心]")
                .Replace("[104]", "[中胜]")
                .Replace("[105]", "[小行]")
                .Replace("[106]", "[翠屏山]")
                .Replace("[107]", "[河海大学·佛城西路]")
                .Replace("[108]", "[吉印大道]")
                .Replace("[109]", "[正方中路]")
                .Replace("[110]", "[翔宇路北]")
                .Replace("[111]", "[翔宇路南]")
                .Replace("[112]", "[禄口机场]")
                .Replace("[113]", "[高家冲]")
                .Replace("[114]", "[林山]")
                .Replace("[115]", "[桥林新城]")
                .Replace("[116]", "[石碛河]")
                .Replace("[117]", "[双垅]")
                .Replace("[118]", "[兰花塘]")
                .Replace("[119]", "[马骡圩]")
                .Replace("[120]", "[刘村]")
                .Replace("[121]", "[天宝]")
                .Replace("[122]", "[高庙路]")
                .Replace("[123]", "[吴侯街]")
                .Replace("[124]", "[平良大街]")
                .Replace("[125]", "[永初路]")
                .Replace("[126]", "[贾西]")
                .Replace("[127]", "[春江路]")
                .Replace("[128]", "[铁心桥]")
                .Replace("[129]", "[景明佳园]")
                .Replace("[130]", "[泰山新村]")
                .Replace("[131]", "[高新开发区]")
                .Replace("[132]", "[信息工程大学]")
                .Replace("[133]", "[卸甲甸]")
                .Replace("[134]", "[大厂]")
                .Replace("[135]", "[葛塘]")
                .Replace("[136]", "[长芦]")
                .Replace("[137]", "[化工园]")
                .Replace("[138]", "[六合开发区]")
                .Replace("[139]", "[龙池]")
                .Replace("[140]", "[雄州]")
                .Replace("[141]", "[凤凰山公园]")
                .Replace("[142]", "[方州广场]")
                .Replace("[143]", "[沈桥]")
                .Replace("[144]", "[八百桥]")
                .Replace("[145]", "[金牛湖]")
                .Replace("[146]", "[铜山]")
                .Replace("[147]", "[石湫]")
                .Replace("[148]", "[明觉]")
                .Replace("[149]", "[团结圩]")
                .Replace("[150]", "[高淳]")
                ;
            }

        }
    }


}
