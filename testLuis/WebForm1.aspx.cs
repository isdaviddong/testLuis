using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testLuis
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //建立LuisClient
            Microsoft.Cognitive.LUIS.LuisClient lc =
                new Microsoft.Cognitive.LUIS.LuisClient(
                    this.textBoxAppID.Text.Trim(), this.textBoxKey.Text.Trim(), //請務必置換成你自己的AppID與Key
                    true, "southeastasia");                                                           //請留意domain位置
            this.textBoxResult.Text = "分析中...";
            //Call Luis API 查詢
            var ret = lc.Predict(textBoxQuery.Text).Result;
            if (ret.Intents.Count() <= 0) return;

            var msg = "<br><br>  ---- Intents :";
            foreach (var item in ret.Intents) //顯示intent
            {
                msg += $"<br> intent {item.Name}  score:{item.Score} ";
            }
            msg += "<br><br> ---- Entities :";
            foreach (var item in ret.Entities)  //Entities
            {
                msg += $"<br> Entities {item.Value[0].Name} score:{ item.Value[0].Score} ";
            }
            //顯示於TextBox
            this.textBoxResult.Text = msg;
        }
    }
}