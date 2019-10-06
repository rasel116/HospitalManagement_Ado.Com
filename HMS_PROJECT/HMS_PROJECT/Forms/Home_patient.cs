using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;


using System.IO;
//using System.Drawing.Imaging;


namespace HMS_PROJECT
{
    public partial class Home_patient : MetroFramework.Forms.MetroForm
    {
        //SqlConnection con = new SqlConnection("Data Source=DbCon;Initial Catalog=HMS_ProjectDB;Integrated Security=true;");
        //SqlCommand cmd;

        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        //SqlDataAdapter adapt;
        DataTable dtRasel;

        string imageLocation = "";
        public Home_patient(DataTable dt)
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(cs))
                if (txtName.Text !="" && txtAddress.Text !="" && mComboDepartPat.Text !="" && mComboReDocPat.Text!="" && mComboCreByPat.Text !="")
                {
                    con.Open();
                    string qry = " INSERT INTO Patient (PatName,PatAddress,AdmitDept,RefDoc,CreatedBy,PatImage) VALUES (@name,@pataddress,@admitdept,@refdoc,@createdby,@patimage)";
                    //string qry = " INSERT INTO Patient (PatName,PatAddress,AdmitDept,RefDoc,CreatedBy) VALUES (@name,@pataddress,@admitdept,@refdoc,@createdby)";

                    //INSERT INTO Patient VALUES('Mahfuz', 'CHITTAGONG',1,1,2,'')
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@pataddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@admitdept", Int32.Parse(mComboDepartPat.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@refdoc", Int32.Parse(mComboReDocPat.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@createdby", Int32.Parse(mComboCreByPat.SelectedValue.ToString()));

                   

                    //cmd.Parameters.AddWithValue("@patimage", PatIamge.Image);

                    //ADDING PHOTO AND SIGNATURE

                    byte[] images = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    cmd.Parameters.AddWithValue("@patimage", images);



                    //FileStream Se = new FileStream(imageLocation, FileMode);
                    //byte[] PhotoByte = null;
                    //PatIamge.Image.Save(ms, ImageFormat.Jpeg);
                    //PhotoByte = ms.ToArray();

                    //cmd.Parameters.AddWithValue("@patimage", PhotoByte);
                    ////cmd.Parameters.AddWithValue("@vlaue", metroTextBox8.Text);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!!!");



                    txtName.Text = "";
                    txtAddress.Text = "";
                    mComboDepartPat.Text = "";
                    mComboReDocPat.Text = "";
                    mComboCreByPat.Text = "";
                    //PatIamge.Image =

                    con.Close();

                    //Data Load 
                    con.Open();
                    //evabeu kora jai
                    //cmd = new SqlCommand('SELECT * FROM Trainee', con);

                    string showQry = "SELECT*FROM Patient";
                    cmd = new SqlCommand(showQry, con);
                     dtRasel = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtRasel);
                    grdPatientData.DataSource = dtRasel.DefaultView;
                    con.Close();


                }
                else
                {
                    MessageBox.Show("Something Wrong");
                }

        }

        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "SELECT * FROM Patient";
                SqlCommand cmd = new SqlCommand(qry, con);
                dtRasel = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtRasel);
                grdPatientData.DataSource = dtRasel.DefaultView;
                con.Close();
            }
        }

        private void Home_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMS_ProjectDBDataSet2.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.hMS_ProjectDBDataSet2.UserInfo);
            // TODO: This line of code loads data into the 'hMS_ProjectDBDataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hMS_ProjectDBDataSet1.Doctor);
            // TODO: This line of code loads data into the 'hMS_ProjectDBDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMS_ProjectDBDataSet.Department);

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                PatIamge.ImageLocation = imageLocation;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
                if (txtName.Text != "" && txtAddress.Text != "" && mComboDepartPat.Text != "" && mComboReDocPat.Text != "" && mComboCreByPat.Text != "")
                {
                    con.Open();
                    string qry = " UPDATE Patient SET PatName=@name,PatAddress=@pataddress,AdmitDept=@admitdept,RefDoc=@refdoc,CreatedBy=@createdby,PatImage=@patimage where PatientID=@patientid";
                    //string qry = " INSERT INTO Patient (PatName,PatAddress,AdmitDept,RefDoc,CreatedBy) VALUES (@name,@pataddress,@admitdept,@refdoc,@createdby)";

                    //INSERT INTO Patient VALUES('Mahfuz', 'CHITTAGONG',1,1,2,'')
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@patientid", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@pataddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@admitdept", Int32.Parse(mComboDepartPat.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@refdoc", Int32.Parse(mComboReDocPat.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@createdby", Int32.Parse(mComboCreByPat.SelectedValue.ToString()));


                    //ADDING PHOTO AND SIGNATURE

                    byte[] images = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    cmd.Parameters.AddWithValue("@patimage", images);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!!!");

                    txtName.Text = "";
                    txtAddress.Text = "";
                    mComboDepartPat.Text = "";
                    mComboReDocPat.Text = "";
                    mComboCreByPat.Text = "";
              

                    con.Close();

                    //Data Load 
                    con.Open();
                    //evabeu kora jai
                    //cmd = new SqlCommand('SELECT * FROM Trainee', con);

                    string showQry = "SELECT*FROM Patient";
                    cmd = new SqlCommand(showQry, con);
                    dtRasel = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtRasel);
                    grdPatientData.DataSource = dtRasel.DefaultView;
                    con.Close();
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
                
                {
                    con.Open();
                    string qry = " DELETE from Patient  where PatientID=@patientid";
                    //string qry = " INSERT INTO Patient (PatName,PatAddress,AdmitDept,RefDoc,CreatedBy) VALUES (@name,@pataddress,@admitdept,@refdoc,@createdby)";

                    //INSERT INTO Patient VALUES('Mahfuz', 'CHITTAGONG',1,1,2,'')
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@patientid", txtPatientID.Text);
                  

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted successfully!!!");

                    txtName.Text = "";
                    txtAddress.Text = "";
                    mComboDepartPat.Text = "";
                    mComboReDocPat.Text = "";
                    mComboCreByPat.Text = "";

                    con.Close();

                    //Data Load 
                    con.Open();
                    //evabeu kora jai
                    //cmd = new SqlCommand('SELECT * FROM Trainee', con);

                    string showQry = "SELECT*FROM Patient";
                    cmd = new SqlCommand(showQry, con);
                    dtRasel = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtRasel);
                    grdPatientData.DataSource = dtRasel.DefaultView;
                    con.Close();
                }
        }
    }
}
