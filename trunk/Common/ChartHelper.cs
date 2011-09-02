using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnetCHARTING;
using System.Drawing;
using System.Data;
namespace Common
{
    public class ChartHelper
    {
        #region 属性
        public string PhaysicalImagePath{get;set;}//图片存放路径
        public string Title{get;set;} //图片标题
        public string XTitle { get; set; }//图片x座标名称
        public string YTitle { get; set; }//图片y座标名称
        public string SeriesName { get; set; }//图例名称
        public int PicWidth { get; set; }//图片宽度
        public int PicHight { get; set; }//图片高度
        public List<SortedList> DataSource { get; set; }//图片数据源
        #endregion

        #region 输出柱形图
        /**//// <summary>
        /// 柱形图
        /// </summary>
        /// <returns></returns>
        public void CreateColumn(Chart chart)
        { 
            chart.Title=this.Title;        
            chart.XAxis.Label.Text=this.XTitle;
            chart.YAxis.Label.Text=this.YTitle;
            chart.TempDirectory =this.PhaysicalImagePath;        
            chart.Width = this.PicWidth;
            chart.Height = this.PicHight;
            chart.Type = ChartType.Combo;
            chart.SeriesCollection.Add(getArrayData());
            chart.DefaultSeries.DefaultElement.ShowValue = true;   
            chart.ShadingEffect = true;    
            chart.Use3D = false;
            
            chart.Series.DefaultElement.ShowValue =true;
        }
        #endregion

        #region 输出饼图
        /**//// <summary>
        /// 饼图
        /// </summary>
        /// <returns></returns>
        public void CreatePie(Chart chart)
        {
            chart.Title=this.Title;    
            chart.TempDirectory =this.PhaysicalImagePath;        
            chart.Width = this.PicWidth;
            chart.Height = this.PicHight;
            chart.Type = ChartType.Pie;            
            chart.Series.Type =SeriesType.Cylinder;
            chart.ShadingEffect = true;
            chart.Use3D = false;            
            chart.DefaultSeries.DefaultElement.Transparency = 20; 
            chart.DefaultSeries.DefaultElement.ShowValue = true;
            chart.PieLabelMode = PieLabelMode.Outside;
            chart.SeriesCollection.Add(getArrayData());
            chart.Series.DefaultElement.ShowValue = true;　
        }

        private SeriesCollection getArrayData()　　　　　　　　
        {
            SeriesCollection SC = new SeriesCollection();


            foreach (SortedList item in DataSource) 
            {
                Series s = new Series();
                s.Name = item.GetKeyList()[0].ToString();
                IDictionaryEnumerator en = ((SortedList)item.GetValueList()[0]).GetEnumerator();
                while (en.MoveNext())
                {
                    Element el = new Element();
                    el.Name = en.Key.ToString();
                    el.YValue = (int)en.Value;
                    s.Elements.Add(el);
                }
                SC.Add(s);
            }
            return SC;
        }
        #endregion

        #region 输出曲线图
        /**//// <summary>
        /// 曲线图
        /// </summary>
        /// <returns></returns>
        public void CreateLine(Chart chart)
        {             
            chart.Title=this.Title;        
            chart.XAxis.Label.Text=this.XTitle;
            chart.YAxis.Label.Text=this.YTitle;
            chart.TempDirectory =this.PhaysicalImagePath;        
            chart.Width = this.PicWidth;
            chart.Height = this.PicHight;
            chart.Type = ChartType.Combo;
            chart.DefaultSeries.Type = SeriesType.Spline;

            chart.SeriesCollection.Add(getArrayData());   
            chart.DefaultSeries.DefaultElement.ShowValue = true;    
            chart.ShadingEffect = true;    
            chart.Use3D = false;    
            chart.Series.DefaultElement.ShowValue =true;
        }
        #endregion

        #region 输出图形总调度方法
        /**/
        /// <summary>
        /// 输出图形
        /// </summary>
        /// <returns></returns>
        public void CreateChart(Chart chart,cType ct)
        {
            switch (ct) { 
                case cType.柱状图:
                    CreateColumn(chart);
                    break;
                case cType.曲线图:
                    CreateLine(chart);
                    break;
                case cType.比例图:
                    CreatePie(chart);
                    break;
            }
        }
        #endregion

        #region 调用说明及范例
        //        在要显示统计图的页面代码直接调用，方法类似如下：
        //
//        ShowData show=new ShowData();   
//        show.Title ="2008年各月消费情况统计";
//        show.XTitle ="月份";
//        show.YTitle ="金额(万元)";
//        show.PicHight =300;
//        show.PicWidth =600;
//        show.SeriesName ="具体详情";
//        show.PhaysicalImagePath ="ChartImages";
//        show.DataSource =this.GetDataSource();
//        show.CreateColumn(this.Chart1);    
        #endregion

        public enum cType { 
            柱状图,
            曲线图,
            比例图
        }

    }
}
