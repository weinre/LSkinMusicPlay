using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ListGroup.Properties;

namespace ListGroup
{
    public partial class ListGroup : UserControl
    {

        public Tips tips;


        public ListGroup()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Items = new List<GroupItem>();
            tips = new Tips();
            tips.label = this.log;
        }
        public TextBox ItemInfo;

        public List<GroupItem> Items;

        public object TakeDownImage { get; set; }

        /// <summary>
        /// 移除一个分组
        /// </summary>
        /// <param name="item"></param>
        public void RmoveItem(GroupItem item)
        {
            Items.Remove(item);
            flowLayoutPanel1.Controls.Remove(item);
        }
        /// <summary>
        /// 添加一个分组
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(GroupItem item)
        {
            item.ItemInfo = ItemInfo;
            item.tips = tips;
            item.Width = this.Width - 40;
            item.GroupName.Width = this.Width - 40;
            item.GroupItems.Width = this.Width - 40;
            item.ContextMenuStrip = contextMenuStrip;
            Items.Add(item);
            flowLayoutPanel1.Controls.Add(item);
        }
        /// <summary>
        /// 分组上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupItem item = (GroupItem)(contextMenuStrip.SourceControl as Control);
            int selectIndex = item.Parent.Controls.IndexOf(item);
            selectIndex--;
            if (selectIndex == -1)
            {
                selectIndex = item.Parent.Controls.Count - 1;
            }
            flowLayoutPanel1.Controls.SetChildIndex(item, selectIndex);
        }

        /// <summary>
        /// 分组下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupItem item = (GroupItem)(contextMenuStrip.SourceControl as Control);
            int selectIndex = item.Parent.Controls.IndexOf(item);
            selectIndex++;
            if (selectIndex == item.Parent.Controls.Count)
            {
                selectIndex = 0;
            }
            flowLayoutPanel1.Controls.SetChildIndex(item, selectIndex);
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupItem item = (GroupItem)(contextMenuStrip.SourceControl as Control);
            InputDiolog input = new InputDiolog();
            if (DialogResult.OK == input.ShowDialog())
            {
                item.AddItem(new UserItem(null, input.inputStr));
                tips.ShowTips("添加item:" + item.baseNmae + "[" + input.inputStr + "]");
            }
        }
    }
}
