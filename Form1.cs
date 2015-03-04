using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreRecorder
{
    public partial class Form1 : Form
    {
        public string WEBSITE = "";
        public string COURSE = "";
        bool isCompleted = false;
        public class CNamestruct
        {
            public string first;
            public string last;
            public string account;
            public int group;
            public string score;
            public int no;
            override public string ToString()
            { 
                if (first != "" && last != "")
                {
                    string withoutScore = last + ", " + first + "(" + account + ")[" + group.ToString() + "]";
                    return withoutScore.PadRight(45) + score;
                }
                return "";
            }
        }
        public class CNameReport
        {
            public CNamestruct[] _namestructs = {null,null,null};
            public void add(CNamestruct newname, int index)
            {
                _namestructs[index] = newname;
            }
            public void Clear()
            {
                for (int i = 0; i < 3; i++)
                {
                    _namestructs[i] = null;
                }
            }
        }
        public class CNamelist
        {
            public System.Collections.ArrayList _namestructs;
            public CNamelist()
            {
                _namestructs = new System.Collections.ArrayList();
            }
            public CNamestruct look(string s1, string s2)
            {
                CNamestruct nullname = new CNamestruct();
                s1 = s1.ToUpper();
                s2 = s2.ToUpper();
                foreach (CNamestruct item in _namestructs)
                {
                    if ((item.first.ToUpper() == s1 && item.last.ToUpper() == s2) || (item.first.ToUpper() == s2 && item.last.ToUpper() == s1))
                    {
                        return item;
                    }
                }
                return nullname;
            }
            public CNamestruct findbyNo(int group, int num)
            { 
                CNamestruct nullname = new CNamestruct();
                foreach (CNamestruct item in _namestructs)
                {
                    if (item.group == group && item.no == num)
                    {
                        return item;
                    }
                }
                return nullname;
            }
            public void updateScore(CNamestruct name, string score)
            {
                foreach (CNamestruct item in _namestructs)
                {
                    if (item == name)
                    {
                        item.score = score;
                    }
                }
            }
            public void add(CNamestruct newname)
            {
                _namestructs.Add(newname);
            }
        }
        public string nameUpperCase(string name)
        {
            return name[0].ToString().ToUpper() + name.ToString().Substring(1).ToLower();
        }
        public Form1()
        {
            InitializeComponent();
            _namelist = new CNamelist();
            _currentReport = new CNameReport();
            //ReadNameList();
        }
        //public bool ReadNameList()
        //{
        //    _namelist = new CNamelist();

        //    foreach (object obj in lstName.Items)
        //    {
        //        string fullname = obj.ToString();
        //        string name = fullname.Split('(')[0];
        //        string account = fullname.Split('(')[1];
        //        account = account.Substring(0,account.Length - 1);
        //        string last = nameUpperCase(name.Split(',')[0].Trim());
        //        string first = nameUpperCase(name.Split(',')[1].Trim());
        //        CNamestruct newname = new CNamestruct();
        //        newname.first = first;
        //        newname.last = last;
        //        newname.account = account;
        //        newname.group = 29;
        //        _namelist.add(newname);
        //        cmbName1.AutoCompleteCustomSource.Add(first + "," + last);
        //        cmbName1.AutoCompleteCustomSource.Add(last + "," + first);
        //        cmbName2.AutoCompleteCustomSource.Add(first + "," + last);
        //        cmbName2.AutoCompleteCustomSource.Add(last + "," + first);
        //        cmbName3.AutoCompleteCustomSource.Add(first + "," + last);
        //        cmbName3.AutoCompleteCustomSource.Add(last + "," + first);
        //    }
        //    return true;
        //}
        public CNamelist _namelist;
        //public CNamelist _currentReport;
        public CNameReport _currentReport;


        public void addNametoGroup(string fullname, int groupNo, int No)
        {
            try
            {
                    fullname.Trim();
                    //lstName.Items.Add(fullname);
                    string name = fullname.Split('(')[0];
                    string account = fullname.Split('(')[1];
                    account = account.Substring(0, account.Length - 1);
                    string last = nameUpperCase(name.Split(',')[0].Trim());
                    string first = nameUpperCase(name.Split(',')[1].Trim());
                    CNamestruct newname = new CNamestruct();
                    newname.first = first;
                    newname.last = last;
                    newname.account = account;
                    newname.group = groupNo;
                    newname.no = No;
                    _namelist.add(newname);                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //public void addGroup(int groupNo)
        //{
        //    try
        //    {
        //        string[] strs = File.ReadAllLines("Name\\"+groupNo + @".txt");
        //        int totalno = 0;
        //        foreach (string fullname in strs)
        //        {
        //            fullname.Trim();
        //            //lstName.Items.Add(fullname);
        //            string name = fullname.Split('(')[0];
        //            string account = fullname.Split('(')[1];
        //            account = account.Substring(0, account.Length - 1);
        //            string last = nameUpperCase(name.Split(',')[0].Trim());
        //            string first = nameUpperCase(name.Split(',')[1].Trim());
        //            CNamestruct newname = new CNamestruct();
        //            newname.first = first;
        //            newname.last = last;
        //            newname.account = account;
        //            newname.group = groupNo;
        //            newname.no = totalno;
        //            totalno++;
        //            _namelist.add(newname);
        //            cmbName1.AutoCompleteCustomSource.Add(first + "," + last);
        //            cmbName1.AutoCompleteCustomSource.Add(last + "," + first);
        //            cmbName2.AutoCompleteCustomSource.Add(first + "," + last);
        //            cmbName2.AutoCompleteCustomSource.Add(last + "," + first);
        //            cmbName3.AutoCompleteCustomSource.Add(first + "," + last);
        //            cmbName3.AutoCompleteCustomSource.Add(last + "," + first);
        //        }
        //        refreshNamelist();
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        public void addAutoComplete()
        {
            foreach (CNamestruct name in _namelist._namestructs)
            {
                string first = name.first;
                string last = name.last;
                cmbName1.AutoCompleteCustomSource.Add(first + "," + last);
                cmbName1.AutoCompleteCustomSource.Add(last + "," + first);
                cmbName2.AutoCompleteCustomSource.Add(first + "," + last);
                cmbName2.AutoCompleteCustomSource.Add(last + "," + first);
                cmbName3.AutoCompleteCustomSource.Add(first + "," + last);
                cmbName3.AutoCompleteCustomSource.Add(last + "," + first);
            }
        }
        public void refreshNamelist()
        {
            lstName.Items.Clear();
            foreach (CNamestruct name in _namelist._namestructs)
            {
                lstName.Items.Add(name.ToString());
            }
        }

        private void txtScore_Leave(object sender, EventArgs e)
        {
            string score = txtScore.Text;
            txtScore.Text = "";
            foreach (CNamestruct name in _currentReport._namestructs)
            {
                _namelist.updateScore(name, score);
            }
            _currentReport.Clear();
            refreshNamelist();
            cmbName1.Focus();
        }

        private void cmbName1_Leave(object sender, EventArgs e)
        {
            string[] fields = cmbName1.Text.Split(',');
            try
            {
                CNamestruct foundname = _namelist.look(fields[0], fields[1]);
                _currentReport.add(foundname,0);
                cmbName1.Text = foundname.ToString();
                if (foundname.first == null)
                {
                    cmbName1.Text = "";
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmbName2_Leave(object sender, EventArgs e)
        {
            string[] fields = cmbName2.Text.Split(',');
            try
            {
                CNamestruct foundname = _namelist.look(fields[0], fields[1]);
                _currentReport.add(foundname,1);
                cmbName2.Text = foundname.ToString();
                if (foundname.first == null)
                {
                    cmbName2.Text = "";
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmbName3_Leave(object sender, EventArgs e)
        {
            string[] fields = cmbName3.Text.Split(',');
            try
            {
                CNamestruct foundname = _namelist.look(fields[0], fields[1]);
                _currentReport.add(foundname,2);
                cmbName3.Text = foundname.ToString();
                if (foundname.first == null)
                {
                    cmbName3.Text = "";
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://cms.psu.edu/section/Gradebook/Editor/EnterGrades/ByAssignment.aspx");
        }

        public bool finished = false;

        private void switchToGroup(int group)
        {
            try
            {
                HtmlElement droplist = webBrowser1.Document.GetElementById("droplistUsers");
                droplist.SetAttribute("value", COURSE + group.ToString("000"));

                HtmlElement button = webBrowser1.Document.GetElementById("btnUpdateUserList");
                button.InvokeMember("click");

                while (!isCompleted)
                {
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Log in and choose an assignment first.\nCheck the Section number.","Group droplist not found",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
        }
        int currentGroupNo = 0;
        private void push()
        {
            try
            {
                int totaloccupied = 0;
                int totalconflict = 0;
                foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("input"))
                {
                    string name = element.GetAttribute("name");
                    if (name.StartsWith("datalistUsersGrades$") && name.EndsWith("$txtPercentage"))
                    {
                        string Oldscore = element.GetAttribute("value");
                        if (Oldscore != null && Oldscore != "")
                        {
                            string strno = name.Substring(23, 2);
                            int convertNo = Int32.Parse(strno) - 2;
                            string Newscore = _namelist.findbyNo(currentGroupNo, convertNo).score;
                            if (Newscore!=null && Newscore != "") totalconflict++;
                            totaloccupied++;
                        }
                    }
                }

                if (totalconflict > 0)
                {
                    if (MessageBox.Show(totalconflict + " item(s) already exists, continue to overwrite?", "Conflict found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                }
                foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("input"))
                {
                    string name = element.GetAttribute("name");
                    if (name.StartsWith("datalistUsersGrades$") && name.EndsWith("$txtPercentage"))
                    {
                        //datalistUsersGrades$ctl02$txtPoints
                        string strno = name.Substring(23, 2);
                        int convertNo = Int32.Parse(strno) - 2;
                        string Newscore = _namelist.findbyNo(currentGroupNo, convertNo).score;
                        if (Newscore != null && Newscore != "") element.InnerText = Newscore;
                    }
                }
                if (totalconflict == 0 && totaloccupied > 0)
                    MessageBox.Show(totaloccupied + " existing item(s) found and preserved.", "Excused forms", MessageBoxButtons.OK, MessageBoxIcon.Question);
                
                currentGroupNo = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            currentGroupNo = Int32.Parse(cmbGroup.Text);
            switchToGroup(currentGroupNo);
            push();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://cms.psu.edu/default.asp");
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString() == "https://cms.psu.edu/default.asp")
            {
                //webBrowser1.Navigate("https://cms.psu.edu/section/default.asp?id=MRG-130823-144905-SJV11"); //2013 Fall
                //webBrowser1.Navigate("https://cms.psu.edu/section/default.asp?id=MRG-131204-172626-SJV11");  //2014 Spring
                webBrowser1.Navigate(this.WEBSITE);
            }
            //else if (webBrowser1.Url.ToString() == "https://cms.psu.edu/section/default.asp?id=MRG-130823-144905-SJV11") //2013 Fall
            //else if (webBrowser1.Url.ToString() == "https://cms.psu.edu/section/default.asp?id=MRG-131204-172626-SJV11")  //2014 Spring
            else if (webBrowser1.Url.ToString() == this.WEBSITE)
            {
                webBrowser1.Navigate("https://cms.psu.edu/section/Gradebook/Editor/EnterGrades/ByAssignment.aspx");
            }
            isCompleted = true;
        }

        private void btnClearGroup_Click(object sender, EventArgs e)
        {
            lstName.Items.Clear();
            _namelist = new CNamelist();
            _currentReport = new CNameReport();
            cmbName1.AutoCompleteCustomSource.Clear();
            cmbName2.AutoCompleteCustomSource.Clear();
            cmbName3.AutoCompleteCustomSource.Clear();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            try
            {
                currentGroupNo = Int32.Parse(cmbGroup.Text);
                switchToGroup(currentGroupNo);
                int totalno = 0;
                foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("a"))
                {
                    string href = element.GetAttribute("href");
                    if (href.StartsWith("https://cms.psu.edu/section/Gradebook/Editor/EnterGrades/ByStudent.aspx?UserID="))
                    {
                        string fullname = element.InnerText;
                        addNametoGroup(fullname, currentGroupNo, totalno);
                        totalno++;
                    }
                }
                addAutoComplete();
                refreshNamelist();
                currentGroupNo = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            isCompleted = false;
        }

        private void textCheckLeave_Enter(object sender, EventArgs e)
        {
            string score = txtScore.Text;
            txtScore.Text = "";
            foreach (CNamestruct name in _currentReport._namestructs)
            {
                _namelist.updateScore(name, score);
            }
            _currentReport.Clear();
            refreshNamelist();
            cmbName1.Focus();
        }


        private void cmbName1_Enter(object sender, EventArgs e)
        {
            cmbName1.SelectAll();
        }

        private void cmbName2_Enter(object sender, EventArgs e)
        {
            cmbName2.SelectAll();
        }

        private void cmbName3_Enter(object sender, EventArgs e)
        {
            cmbName3.SelectAll();
        }

        private void txtScore_Enter(object sender, EventArgs e)
        {
            txtScore.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("setting.txt"))
                {
                    this.WEBSITE = sr.ReadLine();
                    this.COURSE = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
