using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGroup
{
  public  class Tips
    {
        public Label label { get; set; }
        public string TipsStr { get; set; }
        public void ShowTips(string message) {      
            label.Text = message;
        }
    }
}
