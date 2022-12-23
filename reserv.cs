/*using ServiceStack.OrmLite;
using System;
using System.Windows.Forms;
//using ToDo.DataAccess;
using System.Linq;
using System.Data;
using ToDo.DataAccess.Models;
using ServiceStack;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Data.SQLite;
using ServiceStack.DataAnnotations;
using DataGridViewExtensions;
using DGV.Utils;
using Kimtoo.BindingProvider;
using static ReaLTaiizor.Util.RoundInt;
using System.Drawing;

namespace ToDo
{

    public partial class FormMain : Form // Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db"; // db create debug folder

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        private Button currentButton;
        private string curBtnName;
        private int tempIndex;
        private string category;

        public FormMain()
        {
            InitializeComponent();

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    curBtnName = currentButton.Name;
                    currentButton.BackColor = Color.SeaGreen;
                    currentButton.ForeColor = Color.White;

                }
            }
        }


        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(72, 49, 212);
                    prevBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void byDefault()
        {
            btnToday.BackColor = Color.SeaGreen;
            btnToday.ForeColor = Color.White;
            curBtnName = "btnToday";
        }

        // show data in table
        private void data_show(string btnSender)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            //string stm = "SELECT * FROM table_TODO";
            string stm = @"SELECT * from table_TODO where category=@CATEGORY";
            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@CATEGORY", curBtnName);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var done = dr.GetValue(0);
                var task = dr.GetValue(1);
                var category = dr.GetValue(2);
                var date1 = dr.GetDateTime(3);
                var date2 = dr.GetDateTime(4);
                var status = dr.GetValue(5);
                gridToDo.Rows.Add(done, task, date1, date2, status);
            }
        }

        // create db and table

        private void createDB()
        {

            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = @"create table table_TODO(done INTEGER, taskinfo TEXT, category TEXT, start INTEGER, end INTEGER, status TEXT, id INTEGER PRIMARY KEY)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Error! DataBase cannot create!");
                return;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            byDefault();
            createDB();
            data_show(curBtnName);
        }

        bool isNotEmpty()
        {
            if (addTextTask.Text.Length > 0)
                return true;
            return false;
        }

        string[] getValues()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM table_TODO";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            string id = "";
            while (dr.Read())
            {
                id += dr.GetValue(6).ToString() + " ";
            }

            string[] idAr = id.Split(' ');
            return idAr;
        }

        private void addTask(object sender)
        {
            ToDoItem item = new ToDoItem();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            if (isNotEmpty())
            {
                try
                {
                    cmd.CommandText = "INSERT INTO table_TODO(done, taskinfo, category, start, end, status) VALUES(@Done, @taskDescription, @CategoryName, @StartDate, @EndTime, @Status)";
                    item.Description = addTextTask.Text;
                    cmd.Parameters.AddWithValue("@Done", item.Done);
                    cmd.Parameters.AddWithValue("@taskDescription", item.Description);
                    cmd.Parameters.AddWithValue("@StartDate", item.StartDate);
                    cmd.Parameters.AddWithValue("@EndTime", item.EndTime);
                    cmd.Parameters.AddWithValue("@CategoryName", curBtnName);
                    cmd.Parameters.AddWithValue("@Status", item.GetStatus());

                    gridToDo.ColumnCount = 6;
                    gridToDo.Columns[0].Name = "colChkbx";
                    gridToDo.Columns[1].Name = "colTask";
                    gridToDo.Columns[2].Name = "colCategory";
                    gridToDo.Columns[3].Name = "colStartDate";
                    gridToDo.Columns[4].Name = "colFinishDate";
                    gridToDo.Columns[5].Name = "colStatus";

                    gridToDo.Rows.Add(item.Done, item.Description, item.CategoryName, item.StartDate, item.EndTime, item.GetStatus());
                    cmd.ExecuteNonQuery();

                    bunifuSnackbar1.Show(this, "Добавлена новая задача", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                catch (Exception)
                {
                    Console.WriteLine("cannot insert data");
                    return;
                }


                addTextTask.Clear();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Напишите задачу", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            ToDoItem item = new ToDoItem();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            if (isNotEmpty())
            {
                try
                {
                    cmd.CommandText = "INSERT INTO table_TODO(done, taskinfo, category, start, end, status) VALUES(@Done, @taskDescription, @CategoryName, @StartDate, @EndTime, @Status)";
                    item.Description = addTextTask.Text;



                    cmd.Parameters.AddWithValue("@Done", item.Done);
                    cmd.Parameters.AddWithValue("@taskDescription", item.Description);
                    cmd.Parameters.AddWithValue("@StartDate", item.StartDate);
                    cmd.Parameters.AddWithValue("@EndTime", item.EndTime);
                    cmd.Parameters.AddWithValue("@CategoryName", curBtnName);
                    cmd.Parameters.AddWithValue("@Status", item.GetStatus());

                    gridToDo.ColumnCount = 6;
                    gridToDo.Columns[0].Name = "colChkbx";
                    gridToDo.Columns[1].Name = "colTask";
                    gridToDo.Columns[2].Name = "colCategory";
                    gridToDo.Columns[3].Name = "colStartDate";
                    gridToDo.Columns[4].Name = "colFinishDate";
                    gridToDo.Columns[5].Name = "colStatus";

                    gridToDo.Rows.Add(item.Done, item.Description, item.CategoryName, item.StartDate, item.EndTime, item.GetStatus());
                    cmd.ExecuteNonQuery();

                    bunifuSnackbar1.Show(this, "Добавлена новая задача", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                catch (Exception)
                {
                    Console.WriteLine("cannot insert data");
                    return;
                }


                addTextTask.Clear();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Напишите задачу", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }


        private void gridToDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ToDoItem item = new ToDoItem();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string[] val = getValues();
            int indexOfRow;

            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(gridToDo.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == true)
                {
                    try
                    {
                        foreach (DataGridViewRow row in gridToDo.SelectedRows)
                        {
                            int selInd = row.Index;
                            item.Done = true;
                            indexOfRow = val[selInd].ToInt();
                            cmd.CommandText = "UPDATE table_TODO Set done=@DONE, status=@STATUS where id=@ID";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@DONE", item.Done);
                            cmd.Parameters.AddWithValue("@ID", indexOfRow);
                            cmd.Parameters.AddWithValue("@STATUS", item.GetStatus());
                            cmd.ExecuteNonQuery();
                            gridToDo.Rows.Clear();
                            data_show(curBtnName);
                            gridToDo.Rows[e.RowIndex].Selected = true;
                            bunifuSnackbar1.Show(this, "Выполнено", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        }
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine(er.Message);
                    }


                }
                else
                {
                    try
                    {
                        foreach (DataGridViewRow row in gridToDo.SelectedRows)
                        {
                            int selInd = row.Index;
                            item.Done = false;
                            indexOfRow = val[selInd].ToInt();
                            cmd.CommandText = "UPDATE table_TODO Set done=@DONE, status=@STATUS where id=@ID";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@DONE", item.Done);
                            cmd.Parameters.AddWithValue("@ID", indexOfRow);
                            cmd.Parameters.AddWithValue("@STATUS", item.GetStatus());
                            cmd.ExecuteNonQuery();
                            gridToDo.Rows.Clear();
                            data_show(curBtnName);
                            gridToDo.Rows[e.RowIndex].Selected = true;
                            bunifuSnackbar1.Show(this, "Отменено", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                        }
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine(er.Message);
                    }
                }
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {

            ToDoItem item = new ToDoItem();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string[] val = getValues();
            int indexOfRow;

            if (isNotEmpty())
            {
                foreach (DataGridViewRow row in gridToDo.SelectedRows)
                {

                    int selInd = row.Index;
                    gridToDo.Rows.RemoveAt(row.Index);
                    indexOfRow = val[selInd].ToInt();
                    cmd.CommandText = "UPDATE table_TODO Set taskinfo=@task where id=@ID";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", indexOfRow);
                    cmd.Parameters.AddWithValue("@task", addTextTask.Text); ;
                    cmd.ExecuteNonQuery();
                    gridToDo.Rows.Clear();
                    data_show(curBtnName);
                    bunifuSnackbar1.Show(this, "Изменено", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                addTextTask.Clear();
            }

            else
            {
                bunifuSnackbar1.Show(this, "Напишите задачу!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            ToDoItem item = new ToDoItem();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string[] val = getValues();
            int indexOfRow;


            foreach (DataGridViewRow row in gridToDo.SelectedRows)
            {
                int selInd = row.Index;
                gridToDo.Rows.RemoveAt(selInd);
                indexOfRow = val[selInd].ToInt();
                cmd.CommandText = "DELETE FROM table_TODO WHERE id = @ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ID", indexOfRow);
                cmd.ExecuteNonQuery();
                gridToDo.Rows.Clear();
                data_show(curBtnName);
                bunifuSnackbar1.Show(this, "Удалено", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void addTextTask_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addTaskBtn_Click(sender, e);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            curBtnName = "btnToday";
            gridToDo.Rows.Clear();
            data_show(curBtnName);
            gridToDo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;

        }


        private void btnTomrw_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            curBtnName = "btnTomrw";
            gridToDo.Rows.Clear();
            data_show(curBtnName);
            gridToDo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;

        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            curBtnName = "btnImp";
            gridToDo.Rows.Clear();
            data_show(curBtnName);
            gridToDo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;

        }

        private void btnLate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            curBtnName = "btnLate";
            gridToDo.Rows.Clear();
            data_show(curBtnName);
            gridToDo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            addTaskBtn.Enabled = false;
            addTaskBtn.ToolTipText = "Недостопо в этом разделе";



        }
    }


}
*/