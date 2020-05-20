using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace try_application
{
    public partial class RegisterPrints : UserControl
    {
        private DPFP.Template Template;
        Students Students = new Students();
        
        public RegisterPrints()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPrints_Load(object sender, EventArgs e)
        {
            SelectedName.Rows.Clear();
            dataGridView1.Rows.Clear();
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:12967/");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync("api/Students").Result;
            var Stu = httpResponseMessage.Content.ReadAsAsync<IEnumerable<Students>>().Result;

            int row = 0;
            
           
            foreach (var student in Stu)
            {
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["Ids", row].Value = student.Id;
                dataGridView1["Names", row].Value = student.StudentName;
                dataGridView1["GuardianNames", row].Value = student.GuardianName;
                dataGridView1["Addresses", row].Value = student.Address;
                dataGridView1["Contact", row].Value = student.ContactInfo;
                dataGridView1["Statuses", row].Value = student.Status;
                dataGridView1["AdmissionDates", row].Value = student.AddmissionDate;
                dataGridView1["ClassIds", row].Value = student.ClassId;
                dataGridView1["ProgramIds", row].Value = student.ProgramId;
                dataGridView1["CurrentSemclasses", row].Value = student.CurrentSemclass;
                dataGridView1["PrintBinaries", row].Value = student.PrintBinary;
                dataGridView1["AddedOns", row].Value = student.AddedOn;
                dataGridView1["Images", row].Value = student.Uploadimage;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:12967/");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync("api/Students/"+SearchStudent.Text).Result;
             
            Students Stu = httpResponseMessage.Content.ReadAsAsync<Students>().Result;
            List<Students> studentsList = new List<Students>();
            studentsList.Add(Stu);
            dataGridView1.Rows.Clear();
            int row = 0;


            foreach (var student in studentsList)
            {
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["Ids", row].Value = student.Id;
                dataGridView1["Names", row].Value = student.StudentName;
                dataGridView1["GuardianNames", row].Value = student.GuardianName;
                dataGridView1["Addresses", row].Value = student.Address;
                dataGridView1["Contact", row].Value = student.ContactInfo;
                dataGridView1["Statuses", row].Value = student.Status;
                dataGridView1["AdmissionDates", row].Value = student.AddmissionDate;
                dataGridView1["ClassIds", row].Value = student.ClassId;
                dataGridView1["ProgramIds", row].Value = student.ProgramId;
                dataGridView1["CurrentSemclasses", row].Value = student.CurrentSemclass;
                dataGridView1["PrintBinaries", row].Value = student.PrintBinary;
                dataGridView1["AddedOns", row].Value = student.AddedOn;
                dataGridView1["Images", row].Value = student.Uploadimage;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Students.PrintBinary != null) {
                Students SubmitStudents = new Students() { Id = Students.Id, StudentName = Students.StudentName, GuardianName = Students.GuardianName,
                    Address= Students.Address,AddmissionDate= Students.AddmissionDate,Status= Students.Status,ContactInfo= Students.ContactInfo,ClassId= Students.ClassId,
                    ProgramId= Students.ProgramId,PrintBinary= Students.PrintBinary,AddedOn=Students.AddedOn,Uploadimage=Students.Uploadimage

                };
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("http://localhost:12967/");
                HttpResponseMessage httpResponseMessage = httpClient.PostAsJsonAsync("api/Students",SubmitStudents).Result;
            }
            else
            {
                MessageBox.Show("Thumb impression not found");
            }
           
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke((Action)(delegate () {
                Template = template;
                
                if (Template != null)
                {
                    MessageBox.Show("FingerPrint template is ready for finger print verification");
                   
                }
                else
                {
                    MessageBox.Show("FingerPrint template is not valid");
                }
            }));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int row = 0;
            CaptureHuella capture = new CaptureHuella();
            capture.OnTemplate += this.OnTemplate;
            capture.ShowDialog();
            try
            {
                byte[] streamHuella = Template.Bytes;

                MessageBox.Show("Record saved successfully");
                Students.PrintBinary = streamHuella;
                SelectedName["Id", row].Value = Students.Id;
                SelectedName["Name", row].Value = Students.StudentName;
                SelectedName["GuardianName", row].Value = Students.GuardianName;
                SelectedName["Address", row].Value = Students.Address;
                SelectedName["ContactInfo", row].Value = Students.ContactInfo;
                SelectedName["Status", row].Value = Students.Status;
                SelectedName["AdmissionDate", row].Value = Students.AddmissionDate;
                SelectedName["ClassId", row].Value = Students.ClassId;
                SelectedName["ProgramId", row].Value = Students.ProgramId;
                SelectedName["CurrentSemclass", row].Value = Students.CurrentSemclass;
                SelectedName["PrintBinary", row].Value = Students.PrintBinary;
                SelectedName["AddedOn", row].Value = Students.AddedOn;
                SelectedName["Image", row].Value = Students.Uploadimage;

                Template = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectedName.Rows.Clear();
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int row = 0;
            SelectedName.Rows.Add();
            row = SelectedName.Rows.Count - 2;
            SelectedName["Id", row].Value = selectedRow.Cells[0].Value;
            SelectedName["Name", row].Value = selectedRow.Cells[1].Value;
            SelectedName["GuardianName", row].Value = selectedRow.Cells[2].Value;
            SelectedName["Address", row].Value = selectedRow.Cells[3].Value;
            SelectedName["ContactInfo", row].Value = selectedRow.Cells[4].Value;
            SelectedName["Status", row].Value = selectedRow.Cells[5].Value;
            SelectedName["AdmissionDate", row].Value = selectedRow.Cells[6].Value;
            SelectedName["ClassId", row].Value = selectedRow.Cells[7].Value;
            SelectedName["ProgramId", row].Value = selectedRow.Cells[8].Value;
            SelectedName["CurrentSemclass", row].Value = selectedRow.Cells[9].Value;
            try
            {
                SelectedName["PrintBinary", row].Value = selectedRow.Cells[10].Value;
            }
            catch (NullReferenceException)
            {

            }
            SelectedName["AddedOn", row].Value = selectedRow.Cells[11].Value;
            SelectedName["Image", row].Value = selectedRow.Cells[12].Value;
            Students.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
            Students.StudentName = selectedRow.Cells[1].Value.ToString();
            Students.GuardianName = selectedRow.Cells[2].Value.ToString();
            Students.Address = selectedRow.Cells[3].Value.ToString();
            Students.ContactInfo = selectedRow.Cells[4].Value.ToString();
            Students.Status = selectedRow.Cells[5].Value.ToString();
            Students.AddmissionDate = DateTime.Parse(selectedRow.Cells[6].Value.ToString());
            Students.ClassId = int.Parse(selectedRow.Cells[7].Value.ToString());
            Students.ProgramId = int.Parse(selectedRow.Cells[8].Value.ToString());
            try
            {
                Students.CurrentSemclass = selectedRow.Cells[9].Value.ToString();
            }
            catch(NullReferenceException ) { }
            Students.AddedOn =DateTime.Parse(selectedRow.Cells[11].Value.ToString());
            try
            {
                Students.Uploadimage = selectedRow.Cells[12].Value.ToString();
            }
            catch (NullReferenceException) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedName.Rows.Clear();
            dataGridView1.Rows.Clear();
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:12967/");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync("api/Students").Result;
            var Stu = httpResponseMessage.Content.ReadAsAsync<IEnumerable<Students>>().Result;

            int row = 0;


            foreach (var student in Stu)
            {
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["Ids", row].Value = student.Id;
                dataGridView1["Names", row].Value = student.StudentName;
                dataGridView1["GuardianNames", row].Value = student.GuardianName;
                dataGridView1["Addresses", row].Value = student.Address;
                dataGridView1["Contact", row].Value = student.ContactInfo;
                dataGridView1["Statuses", row].Value = student.Status;
                dataGridView1["AdmissionDates", row].Value = student.AddmissionDate;
                dataGridView1["ClassIds", row].Value = student.ClassId;
                dataGridView1["ProgramIds", row].Value = student.ProgramId;
                dataGridView1["CurrentSemclasses", row].Value = student.CurrentSemclass;
                dataGridView1["PrintBinaries", row].Value = student.PrintBinary;
                dataGridView1["AddedOns", row].Value = student.AddedOn;
                dataGridView1["Images", row].Value = student.Uploadimage;

            }
        }
    }
}
