using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;

namespace pashicev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double p, M, t_melt, t_boil, n, sigma, pdk, i1, i2, i3, i4, i5;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox13.Text = Convert.ToString(error1(pdk, i1, M));
            textBox14.Text = Convert.ToString(error2(pdk, i2, M));
            textBox15.Text = Convert.ToString(error3(pdk, i3, M));
            textBox16.Text = Convert.ToString(error4(pdk, i4, M));
            textBox17.Text = Convert.ToString(error5(pdk, i5, M));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            M = Convert.ToDouble(textBox2.Text);
            t_melt = Convert.ToDouble(textBox3.Text);
            t_boil = Convert.ToDouble(textBox4.Text);
            n = Convert.ToDouble(textBox5.Text);
            sigma = Convert.ToDouble(textBox6.Text);
            pdk = Convert.ToDouble(textBox12.Text);

            textBox7.Text = Convert.ToString(calc_pdk_1(p, M));
            textBox8.Text = Convert.ToString(calc_pdk_2(t_boil, M));
            textBox9.Text = Convert.ToString(calc_pdk_3(n, M));
            textBox10.Text = Convert.ToString(calc_pdk_4(sigma, M));
            textBox11.Text = Convert.ToString(calc_pdk_5(t_melt, M));

        }


        public double calc_pdk_1(double p, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction calc_pdk_pmFunc = luaState["calc_pdk_pm"] as LuaFunction;
                double result = (double)calc_pdk_pmFunc.Call(p, M)[0];
                i1 = (double)calc_pdk_pmFunc.Call(p, M)[0];
                return result;
            }
        }

        public double calc_pdk_2(double t_boil, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction calc_pdk_tboilFunc = luaState["calc_pdk_tboil"] as LuaFunction;
                double result = (double)calc_pdk_tboilFunc.Call(t_boil, M)[0];
                i2 = (double)calc_pdk_tboilFunc.Call(t_boil, M)[0];
                return result;
            }
        }
        public double calc_pdk_3(double n, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction calc_pdk_nFunc = luaState["calc_pdk_n"] as LuaFunction;
                double result = (double)calc_pdk_nFunc.Call(n, M)[0];
                i3 = (double)calc_pdk_nFunc.Call(n, M)[0];
                return result;
            }
        }
        public double calc_pdk_4(double sigma, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction calc_pdk_sigmaFunc = luaState["calc_pdk_sigma"] as LuaFunction;
                double result = (double)calc_pdk_sigmaFunc.Call(sigma, M)[0];
                i4 = (double)calc_pdk_sigmaFunc.Call(sigma, M)[0];
                return result;
            }
        }
        public double calc_pdk_5(double t_melt, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction calc_pdk_tmeltFunc = luaState["calc_pdk_tmelt"] as LuaFunction;
                double result = (double)calc_pdk_tmeltFunc.Call(t_melt, M)[0];
                i5 = (double)calc_pdk_tmeltFunc.Call(t_melt, M)[0];
                return result;
            }
        }
        public double error1(double pdk, double i1, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction error1fFunc = luaState["error1f"] as LuaFunction;
                double result = (double)error1fFunc.Call(pdk, i1, M)[0];
                return Math.Abs(result);
            }
        }
        public double error2(double pdk, double i2, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction error2fFunc = luaState["error2f"] as LuaFunction;
                double result = (double)error2fFunc.Call(pdk, i2, M)[0];
                return Math.Abs(result);
            }
        }
        public double error3(double pdk, double i3, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction error3fFunc = luaState["error3f"] as LuaFunction;
                double result = (double)error3fFunc.Call(pdk, i3, M)[0];
                return Math.Abs(result);
            }
        }
        public double error4(double pdk, double i4, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction error4fFunc = luaState["error4f"] as LuaFunction;
                double result = (double)error4fFunc.Call(pdk, i4, M)[0];
                return Math.Abs(result);
            }
        }
        public double error5(double pdk, double i5, double M)
        {
            using (Lua luaState = new Lua())
            {
                luaState.DoFile("C:\\Users\\Cukier\\Desktop\\Дистант(или не всегда дистант)\\5 семестр\\пашичев\\1\\pashicev1\\1.lua");
                LuaFunction error5fFunc = luaState["error5f"] as LuaFunction;
                double result = (double)error5fFunc.Call(pdk, i5, M)[0];
                return Math.Abs(result);
            }
        }

    }
}
