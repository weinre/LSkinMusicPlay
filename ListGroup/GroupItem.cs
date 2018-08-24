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


    public partial class GroupItem : UserControl
    {


        public UserItem SelectItem;//选中的item
        public Tips tips;
        //public Image openItem = Resources.OpenItem; //展开的状态图片
        //public Image takeUp = Resources.TakeUp;//收起的状态图片

        public Image openItem = Resources.op01; //展开的状态图片
        public Image takeUp = Resources.up01;//收起的状态图片

        public bool down = false; //Items是否已经展开
        public KeyDown KeyDown;//键盘按下的对象
        public string baseNmae;

        public GroupItem() {
            InitializeComponent();
        }

        /// <summary>
        ///groupitem构造方法
        /// </summary>
        /// <param name="titleText">分组名称</param>
        /// <param name="list">数据list</param>
        public GroupItem(string titleText, List<UserItem> list)
        {
            InitializeComponent();
            this.GroupName.Enabled = false;

            this.GroupName.BorderStyle = BorderStyle.None;
            this.GroupName.KeyDown += new KeyEventHandler(GroupNmaeKeyDownEvent);
            this.GroupName.MouseDoubleClick += new MouseEventHandler(GroupNmaeMouseDoubleClick);
            this.panel1.MouseDoubleClick += new MouseEventHandler(GroupNmaeMouseDoubleClick);

            this.BackColor = Color.Transparent;
            this.baseNmae = titleText;
            this.DoubleBuffered = true;
            this.GroupName.Text = titleText;
            this.GroupItems.Hide();
            foreach (UserItem item in list)
            {
                AddItem(item);
            }
        }
        public TextBox ItemInfo;

        public void ShowItemInfo(string no, string name, string groupName)
        {

            if (ItemInfo != null)
            {
                ItemInfo.Text = "编号:" + no + "\r\n名称：" + name + "\r\n所属分组:" + groupName;
            }

        }
        string oldGroupNameText = "";
        private void GroupNmaeMouseDoubleClick(object sender, MouseEventArgs e)
        {

            TextBox tb = (sender as Panel).Controls[0] as TextBox;
            oldGroupNameText = tb.Text;
            tb.Enabled = true;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Focus();

        }
        private void GroupNmaeKeyDownEvent(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                baseNmae = tb.Text;
                tb.Enabled = false;
                tb.BorderStyle = BorderStyle.None;
                tips.ShowTips("修改名称：" + oldGroupNameText + " —> " + tb.Text);
                reFresh();
            }

        }
        public void itemMouseDown(object sender, MouseEventArgs e)
        {

            UserItem item = null;
            if (((Control)sender).GetType().Name == "UserItem")
            {
                item = sender as UserItem;
            }
            else
            {
                item = ((Control)sender).Parent as UserItem;
            }
            ShowItemInfo(item.TabIndex + "", item.title.Text, baseNmae);




            if (KeyDown != null && KeyDown.key == Keys.ControlKey)
            {
                if (item.Tag == null)
                {
                    item.Tag = "selected";
                    selectedUserItem.Add(item);
                }
                else
                {
                    item.Tag = null;
                    selectedUserItem.Remove(item);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    removeAllSelectedItems();


                    if (item.Tag == null)
                    {
                        item.Tag = "selected";
                        selectedUserItem.Add(item);
                    }
                }
            }
        }
        private void removeAllSelectedItems()
        {

            foreach (UserItem item in selectedUserItem)
            {
                item.Tag = null;
            }
            selectedUserItem.Clear();

        }

        public List<UserItem> selectedUserItem = new List<UserItem>();

        string oldText = "";
        private void UserDataTitleKeyDown(object sender, KeyEventArgs e)
        {

            TextBox tb = sender as TextBox;

            if (e.KeyCode == Keys.Enter)
            {

                tb.Enabled = false;
                tb.BorderStyle = BorderStyle.None;
                tips.ShowTips("修改名称：" + oldText + " —> " + tb.Text);

            }

        }
        private void UserDataEventMouseLeave(object sender, EventArgs e)
        {

            foreach (UserItem item in this.GroupItems.Controls)
            {
                if (selectedUserItem.IndexOf(item) != -1) continue; //如果是已经选择准备操作的item不改变样式
                item.BackColor = item.backgroundColor;
                item.title.BackColor = item.titleColor;
            }
        }
        /// <summary>
        /// 鼠标悬浮在数据上面的时候变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UserDataEventMouseMove(object sender, MouseEventArgs e)
        {
            if (sender.GetType().Name != "UserItem") sender = ((Control)sender).Parent;

            //foreach (GroupItem groupItem in this.Parent.Controls)
            //{
            //    //groupItem.removeAllSelectedItems();

            //    if (groupItem == this) continue;
            //    foreach (UserItem item in groupItem.GroupItems.Controls)
            //    {
            //        item.BackColor = item.backgroundColor;
            //        item.title.ForeColor = item.titleColor;
            //        item.showText.ForeColor = item.showTextColor;
            //    }
            //}

            foreach (UserItem item in this.GroupItems.Controls)
            {
                if (selectedUserItem.IndexOf(item) != -1) continue; //如果是已经选择准备操作的item不改变样式

                // if (item == (UserItem)MenuSourceControl) continue; //如果是已经选择准备操作的item不改变样式

                item.BackColor = item.backgroundColor;
                item.title.BackColor = item.titleColor;
            }
            UserItem u = sender as UserItem;
            u.BackColor = Color.FromArgb(200, 200, 200);
            u.title.BackColor = Color.FromArgb(200, 200, 200);
        }

        List<UserItem> allItem = new List<UserItem>();


        public void AddItemForOther(UserItem item) {
            //item.title.KeyDown += new KeyEventHandler(UserDataTitleKeyDown);
            //item.MouseLeave += new EventHandler(UserDataEventMouseLeave);
            //item.pictureBox1.MouseLeave += new EventHandler(UserDataEventMouseLeave);
            //item.title.MouseLeave += new EventHandler(UserDataEventMouseLeave);

            //item.MouseDoubleClick += new MouseEventHandler(ReNameDoubleClick);
            //item.title.MouseDoubleClick += new MouseEventHandler(ReNameDoubleClick);

            //item.MouseMove += new MouseEventHandler(UserDataEventMouseMove);
            //item.pictureBox1.MouseMove += new MouseEventHandler(UserDataEventMouseMove);
            //item.title.MouseMove += new MouseEventHandler(UserDataEventMouseMove);

            item.ContextMenuStrip = contextMenuStrip;
            this.GroupItems.Controls.Add(item);
            reFresh();

        }
        /// <summary>
        /// 添加一个item
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object AddItem(UserItem item)
        {
            item.Width = this.Width - 8;
            item.title.BorderStyle = BorderStyle.None;
            item.title.Enabled = false;

           
            //this.GroupItems.Controls.Add(item);

          
                item.title.KeyDown += new KeyEventHandler(UserDataTitleKeyDown);
                item.MouseLeave += new EventHandler(UserDataEventMouseLeave);
                item.pictureBox1.MouseLeave += new EventHandler(UserDataEventMouseLeave);
                item.title.MouseLeave += new EventHandler(UserDataEventMouseLeave);

                item.MouseDoubleClick += new MouseEventHandler(ReNameDoubleClick);
                item.title.MouseDoubleClick += new MouseEventHandler(ReNameDoubleClick);

                item.MouseMove += new MouseEventHandler(UserDataEventMouseMove);
                item.pictureBox1.MouseMove += new MouseEventHandler(UserDataEventMouseMove);
                item.title.MouseMove += new MouseEventHandler(UserDataEventMouseMove);

                item.MouseDown += new MouseEventHandler(itemMouseDown);
                item.title.MouseDown += new MouseEventHandler(itemMouseDown);
                item.pictureBox1.MouseDown += new MouseEventHandler(itemMouseDown);
      


            item.ContextMenuStrip = contextMenuStrip;
            this.GroupItems.Controls.Add(item);
            reFresh();
            return item;
        }

        public void reFresh()
        {
            this.GroupName.Text = this.baseNmae + " " + this.GroupItems.Controls.Count;
            if (GroupItems.Controls.Count == 0)
            {
                ItemsTakeup();
                return;
            }
        }

        private void ReNameDoubleClick(object sender, MouseEventArgs e)
        {
            UserItem u = null;
            if (((Control)sender).GetType().Name != "UserItem")
            {
                u = ((Control)sender).Parent as UserItem;
            }
            else
            {
                u = sender as UserItem;
            }

            u.title.Enabled = true;
            u.title.BorderStyle = BorderStyle.FixedSingle;
            u.title.Focus();
            oldText = u.title.Text;



        }
        /// <summary>
        /// 移除一个item
        /// </summary>
        /// <param name="obj"></param>
        public void RemoveItem(Control item)
        {

            GroupItems.Controls.Remove(item);
            reFresh();
            if (GroupItems.Controls.Count == 0)
            {
                ItemsTakeup();
                return;
            }

        }

        /// <summary>
        /// 数据展开&收起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            int count = this.GroupItems.Controls.Count;
            if (down == false && count > 0)
            {
                ItemsOpen();
            }
            else
            {
                ItemsTakeup();
            }
        }

        public void ItemsTakeup()
        {
            down = false;
            GroupItems.Hide();
            pictureBox.Image = openItem;
            //removeAllSelectedItems();
        }
        public void ItemsOpen()
        {
            down = true;
            GroupItems.Show();
            pictureBox.Image = takeUp;

            //removeAllSelectedItems();

        }

        bool mouseUp = true;

        private void GroupName_MouseDown(object sender, MouseEventArgs e)
        {
            //MousePoint = new Point(-e.X,-e.Y);
            MousePoint = e.Location;
            mouseUp = false;
        }
        public Point MousePoint { get; set; }

        private void GroupName_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Left) return;
            ////进入上下调整的移动模式
            //if (Math.Abs(e.Location.Y) != Math.Abs(MousePoint.Y) && mouseUp == false)
            //{
            //    this.Cursor = Cursors.SizeAll;
            //    ItemsTakeup();
            //}
            //this.Location = new Point(0, this.Location.Y + e.Location.Y - MousePoint.Y);
        }
        private void GroupName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp = true;
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            //if (multiple)
            //{
            tips.ShowTips("移除item:" + selectedUserItem.Count + "个对象。完成！");
            foreach (UserItem delitem in selectedUserItem)
            {
                RemoveItem(delitem);
            }
            removeAllSelectedItems();
            //}
            //else
            //{
            //    removeAllSelectedItems();
            //    UserItem UserItem = (UserItem)(contextMenuStrip.SourceControl as Control);
            //    RemoveItem(UserItem);
            //}
        }
        bool multiple = false;
        Control MenuSourceControl;
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            multiple = false;

            if (selectedUserItem.Count > 1) multiple = true;

            MenuSourceControl = (contextMenuStrip.SourceControl as Control);
            UserItem u = MenuSourceControl as UserItem;
            u.Tag = "selected";

            if (selectedUserItem.IndexOf(u) == -1) selectedUserItem.Add(u);

            cancelToolStripMenuItem.Visible = true;
            DelToolStripMenuItem.Text = "删除 " + selectedUserItem[0].title.Text + "..," + selectedUserItem.Count + "个对象";
            MoveToToolStripMenuItem.Text = "移动 " + selectedUserItem[0].title.Text + "..," + selectedUserItem.Count + "个对象";


            MoveToToolStripMenuItem.DropDownItems.Clear();
            foreach (GroupItem item in this.Parent.Controls)
            {

                if (item == this) continue;
                ToolStripMenuItem Group = new ToolStripMenuItem();
                Group.Text = item.baseNmae;
                Group.Tag = item;
                Group.Click += new EventHandler(MoveToOtherGroup);
                MoveToToolStripMenuItem.DropDownItems.Add(Group);
            }

        }

        public void MoveToOtherGroup(object sender, EventArgs e)
        {
            ToolStripMenuItem Menuitem = sender as ToolStripMenuItem;
            GroupItem groupItem = Menuitem.Tag as GroupItem;
           
            //if (multiple)
            //{
            tips.ShowTips("移动item:" + selectedUserItem.Count + "个对象到[" + groupItem.GroupName.Text + "]");
            foreach (UserItem item in selectedUserItem)
            {
                UserItem useritem = new UserItem(item.pictureBox1.Image, item.title.Text);
                groupItem.AddItem(useritem);
                GroupItems.Controls.Remove(item);
            }
            
            removeAllSelectedItems();
            //}
            //else
            //{
            //    UserItem UserItem = (UserItem)(MenuSourceControl);
            //    groupItem.AddItem(UserItem);
            //}
            reFresh();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeAllSelectedItems();
            reFresh();
        }

        private void GroupItem_Load(object sender, EventArgs e)
        {
            pictureBox.Image = openItem;
        }

        private void MoveToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    public class KeyDown
    {
        public Keys key;
    }
}
