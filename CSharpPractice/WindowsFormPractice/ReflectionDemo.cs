using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class ReflectionDemo : Form
    {
        public ReflectionDemo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = txtbx_typename.Text.ToString();
            Type T = Type.GetType(TypeName);
            lstbx_methods.Items.Clear();
            lstbx_properties.Items.Clear();
            lstbx_constructors.Items.Clear();
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstbx_methods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstbx_properties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstbx_constructors.Items.Add(constructor.ToString());
            }
        }
    }
}
