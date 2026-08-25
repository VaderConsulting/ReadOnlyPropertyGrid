using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadOnlyPropertyGridTest
{
    public partial class Form1 : Form
    {
        Test1 test1;
        Test test = new Test();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            test1 = new Test1();
            test1.Test4 = new Test4();
            test1.Test4.Test3.Test2.Test1 = new Test1 { Form1 = this, Name = "hello", Test4 = new Test4() };
            test1.Form1 = this;

            //rPropertyGrid1.SelectedObjects = new object[] { test1, new Test() };
            rPropertyGrid1.SelectedObject = test1;
        }

        private void CheckBoxReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            rPropertyGrid1.ReadOnly = checkBoxReadOnly.Checked;            
        }

        private void CheckBoxChangeObject_CheckedChanged(object sender, EventArgs e)
        {
            if (rPropertyGrid1.OriginalSelectedObject is Test1)
            {
                rPropertyGrid1.SelectedObject = test;
            }
            else
            {
                rPropertyGrid1.SelectedObject = test1;
            }
        }
    }

    class Test
    {
        private string _name;
        private Test4 _test4;
        private Point _point;

        public Point Point
        {
            get { return _point; }
            set { _point = value; }
        }

        public Test4 Test4
        {
            get { return _test4; }
            set { _test4 = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    class Test1
    {
        private Test4 _test4;
        private string _name;
        private Form _form1;
        private Point _point;

        public Point Point
        {
            get { return _point; }
            set { _point = value; }
        }

        public Form Form1
        {
            get { return _form1; }
            set { _form1 = value; }
        }

        public Test4 Test4
        {
            get { return _test4; }
            set { _test4 = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    class Test2
    {
        private Test1 _test1 = new Test1();

        public Test1 Test1
        {
            get { return _test1; }
            set { _test1 = value; }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    class Test3
    {
        private Test2 _test2 = new Test2();

        public Test2 Test2
        {
            get { return _test2; }
            set { _test2 = value; }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    class Test4
    {
        private Test3 _test3 = new Test3();

        public Test3 Test3
        {
            get { return _test3; }
            set { _test3 = value; }
        }
    }
}
