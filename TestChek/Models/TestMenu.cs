using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class TestMenu
    {
        private List<IEnumerable<TestClass>> _TestMenuList { get; set; }

        public List<IEnumerable<TestClass>> TestMenuList { get { return _TestMenuList; } }

        //public TestMenu()
        //{
        //    TestPanel testPanel = new TestPanel();
        //    _TestMenuList.Add(testPanel.CBC());
        //    _TestMenuList.Add(testPanel.BasicMetPanel());
        //    _TestMenuList.Add(testPanel.UrineScreen());
        //}
    }
}