﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 信息系统集成方案
{
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            string str_name = "";
            string str_type = "";
            string str_department = "";
            string str_des = "";

            switch (MainForm.bt_name)
            {
                case "bt_part01":
                    str_name = "综合整治数据库信息管理系统";
                    str_type = "业务类系统";
                    str_department = "上海海洋大学";
                    str_des = "        综合整治数据信息管理系统需要整合处理30余年北戴河海洋环境监测中心站承担的重大专项海洋调查、国际海洋合作、勘测、监测资料与成果信息；整理了北戴河周边多个海洋观测站20余年的观测数据与报表。在整理、处理、整合和改造的基础上，统一存储在综合整治数据库系统，最终形成一个由100多个数据表的综合数据库，为研究北戴河海域海洋环境长周期变化规律提供重要的、珍贵的数据依据，为保护北戴河海域海洋生态与环境、提高海洋资源利用水平，促进海洋经济发展、提高海域使用管理提供数据服务支撑。\n        综合整治数据库信息管理系统主要包括数据库和数据的组织与管理系统，涉及海洋地质、海洋气象、海洋生物、海洋化学、海洋水文、力学、数学、物理等多领域多学科的专业知识。通过数据总线，整合各种异构数据库系统，集成多元、多源、异构的海洋数据内容，实现海洋数据的逻辑集中管理，以及远程数据交换与共享和对外信息交换。";
                    break;
                case "bt_part02_decision":
                    str_name = "灾害应急响应决策额支持系统";
                    str_type = "业务类系统";
                    str_department = "国家海洋环境监测中心";
                    str_des = "        灾害应急响应决策额支持系统是海洋公益性科研专项“北戴河邻近海域典型生态灾害与污染监控关键技术集成应用”的一部分，主要研究内容是灾害应急响应决策额支持系统研究。项目研究区域涵盖北戴河及周边整个秦皇岛市所辖海岸带和海域。北戴河是享誉中外的休闲度假胜地，也是中央国家机关暑期办公所在地。\n        系统根据研究区域（北戴河邻近海域）的数据来源特点，进行有针对性的设计，该区域能够获取卫星遥感数据，该数据能够实现大面积的监测，得到整体的结果；针对项目的需求，该区域增加不同类别的现场调查，根据系统的需求来选取不同的现场调查数据进行评价；该区域布设3个浮标，能够实时监测海水中的要素变化；通过多次走航数据，得到不同时间断面的监测数据。赤潮灾害应急划分为灾前、临灾、灾中和灾后四个阶段，针对每个阶段提供不同的结果，而结果的获取则是通过以上的数据来源。";
                    break;
                case "bt_part02_risk":
                    str_name = "赤潮灾害风险评估系统";
                    str_type = "业务类系统";
                    str_department = "国家海洋环境监测中心";
                    str_des = "        赤潮灾害风险评估系统是海洋公益性科研专项“北戴河邻近海域典型生态灾害与污染监控关键技术集成应用”的一部分。本系统根据多年来在赤潮灾害风险评估理论体系和系统建设经验，同时结合海洋赤潮业务监测需求，集成赤潮灾害风险评估方法和模型，研发基于GIS的赤潮灾害风险评估系统，实现评估结果的空间可视化。\n        赤潮灾害风险评估系统括在赤潮灾害风险评估指标体系、赤潮灾害风险评估技术的研究基础上，利用ArcEngine二次开发平台开发数据输出输出、数据处理、危险度计算、风险评估计算、专题产品制作、可视化显示等相关功能。本系统在赤潮发生时，能迅速提取赤潮信息，对赤潮发生所造成风险情况快速做出评估结果，为政府部门提供辅助决策和技术支撑。";
                    break;
                case "bt_part02_evaluation":
                    str_name = "综合整治评价专题应用系统";
                    str_type = "业务类系统";
                    str_department = "国家海洋环境监测中心";
                    str_des = "        综合整治评价专题应用系统是科研专项“北戴河邻近海域典型生态灾害与污染监控关键技术集成应用”的一部分，主要研究内容是综合整治评价专题应用系统研究。项目研究区域涵盖北戴河及周边整个秦皇岛市所辖海岸带和海域。北戴河是享誉中外的休闲度假胜地，也是中央国家机关暑期办公所在地。\n        通过综合整治评价专题应用系统的建立，首先是实现多源监测数据的融合，包括卫星遥感数据、现场调查数据和浮标实时数据，通过海水浴场评价的方法、滨海旅游度假区环境评价的方法以及海水环境质量评价的方法进行系统的设计，系统能够实现日评价、周评价、旬评价、月评价、季评价和年评价的结果，针对不同时间尺度的评价结果则是以不同的形式进行显示，包括等值线图、柱状图、饼状图以及相关专题图等。";
                    break;
                case "bt_part02_loss":
                    str_name = "赤潮灾害损失评估系统";
                    str_type = "业务类系统";
                    str_department = "国家海洋环境监测中心";
                    str_des = "        由于赤潮灾害损失评估涉及的范围很广泛，包括实物损失、人员伤亡、生态损失及各种经济影响因素等，特别是生态损失评估的困难较大，因此各国对赤潮灾害损失评估并没有统一的标准，各国对赤潮灾害损失评估的分类及评估方法也有所不同。由于赤潮类型、发生海域、范围和持续时间不同，不同赤潮事件所对应的灾害承灾体和损失程度可能存在很大差异，所以对不同赤潮事件的灾害损失评估模式需因地而异。\n        包括海水养殖业经济损失业务评估模型、滨海旅游业经济损失业务评估模型、赤潮灾害业务与应急监测费用评估模型、赤潮灾害处置费用评估模型、赤潮灾害总经济损失业务应用评估模型";
                    break;
                case "bt_part02_redTide":
                    str_name = "赤潮运移轨迹可视化预警信息服务平台";
                    str_type = "业务类系统";
                    str_department = "同济大学";
                    str_des = "        本课题主要研究目标是将GIS、科学计算可视化和数据库等先进的信息化技术与海洋灾害赤潮与溢油数值预报模型有机地集成，构建赤潮与溢油海洋灾害快速预报预警信息服务平台，实现赤潮与溢油灾害实测监测信息和数值预报数据的数字化、可视化管理，为实时测监测信息和数值预报可视化产品数据等信息的快速浏览、查询、分析等提供一个信息平台，最终实现为北戴河海洋经济发展和防灾减灾辅助决策提供综合信息服务保障。";
                    break;
                case "bt_part02_oil":
                    str_name = "溢油运移轨迹可视化预警信息服务平台";
                    str_type = "业务类系统";
                    str_department = "同济大学";
                    str_des = "        本课题主要研究目标是将GIS、科学计算可视化和数据库等先进的信息化技术与海洋灾害赤潮与溢油数值预报模型有机地集成，构建赤潮与溢油海洋灾害快速预报预警信息服务平台，实现赤潮与溢油灾害实测监测信息和数值预报数据的数字化、可视化管理，为实时测监测信息和数值预报可视化产品数据等信息的快速浏览、查询、分析等提供一个信息平台，最终实现为北戴河海洋经济发展和防灾减灾辅助决策提供综合信息服务保障。";
                    break;
                case "bt_part03":
                    str_name = "综合整治信息发布系统";
                    str_type = "业务类系统";
                    str_department = "上海海洋大学";
                    str_des = "        在现有已开展的整治工作基础上，针对亟待解决的问题，按照海陆统筹思想，通过北戴河邻近陆域补充调查与污染压力评价、海洋环境立体化监测预警系统能力建设、海洋环境整治成效监测与评估、海洋环境综合整治信息服务系统建设、北戴河及邻近海域标准规程体系建设任务的实施，保障北戴河及邻近海域环境综合整治目标的顺利实现。\n        本专题完成综合整治信息发布系统开发建设，建立北戴河海洋环境数据库，利用GIS技术，实现对海洋环境数据有效管理与维护等功能。";
                    break;
                case "bt_show_land":
                    str_name = "陆域产业结构减排应用系统";
                    str_type = "展示类系统";
                    str_department = "河北省宏观经济研究所";
                    str_des = "        立项开展“北戴河陆域入海污染物总量控制和产业优化关键技术应用研究”的目的，在于：界定北戴河近岸海域污染的陆域范围，回顾秦皇岛地区经济社会发展过程，剖析陆源污染的结构和布局特点，探索陆源污染物排放总量变化规律，寻求结构调整、布局优化、方式转变的突破口，设计陆源污染的最佳结构、布局优化调整实施方案，提出产业和空间优化关键技术及实施方案。开展这项研究工作，对于有效控制北戴河海域入海污染物总量，恢复北戴河近岸海域海洋生态系统，迅速改善北戴河近岸海域的环境状况，如期达到海洋环境功能区规划目标，发挥北戴河地区的旅游功能，促进北戴河近岸陆域经济社会的发展，理顺北戴河近岸海域和陆域发展关系，都具有重要的现实意义和深远的历史影响。";
                    break;
                case "bt_show_pollution":
                    str_name = "污染物总量控制数据库建设";
                    str_type = "展示类系统";
                    str_department = "同济大学";
                    str_des = "        污染物总量控制是以环境质量目标为基本依据，对区域内各污染源的污染物的排放总量实施控制的管理制度。污染物总量以控制一定时段内一定区域内排污单位排放污染物总量为核心的环境管理方法体系。它包含了三个方面的内容：一是排放污染物的总量；二是排放污染物总量的地域范围；三是排放污染物的时间跨度。通常有三种类型：目标总量控制、容量总量控制和行业总量控制。目前我国的总量控制基本上是目标总量控制。";
                    break;
                case "bt_show_query":
                    str_name = "河北近海生态资本查询系统";
                    str_type = "展示类系统";
                    str_department = "国家海洋局第一海洋研究所";
                    str_des = "        海洋生态资本对于沿海地市海洋持续开发利用、生态文明示范区建设具有重要的支撑作用，识别并量化海洋生态资本对于编制沿海地市的社会经济规划、海岸带空间规划、生态环境规划、生态修复和开展生态补偿赔偿具有重要的支撑作用。由于海洋生态环境和人类开发利用的空间差异，海洋生态资本也具有空间异质性。明确海洋生态资本的空间分布特征和规律，可促进海洋生态资本的精细化管理，可提升资本的利用效率。因此，本任务拟基于GIS技术设计并开发河北省近海生态资本查询系统，以满足生态资本的浏览、查询、统计分析、自定义区生态资本提取、专题图编制等功能，以促进河北近海生态资本在海洋生态环境保护、资源开发利用中的地位和作用。";
                    break;
                case "bt_show_redTide":
                    str_name = "赤潮漂移预测系统";
                    str_type = "展示类系统";
                    str_department = "北海预报中心";
                    str_des = "无。";
                    break;
            }

            lb_name.Text = str_name;
            lb_type.Text = str_type;
            lb_department.Text = str_department;
            richTextBox1.Text = str_des;
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
