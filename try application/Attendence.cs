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
    public partial class Attendence : UserControl
    {
        private DPFP.Template Template;
        MarkAttendence markAttendence = new MarkAttendence();
        public Attendence()
        {
            InitializeComponent();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke((Action)(delegate ()
            {
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
        private void Attendence_Load(object sender, EventArgs e)
        {

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

            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int row = 0;
            
            StudentId.Text = selectedRow.Cells[0].Value.ToString();
            Name.Text = selectedRow.Cells[1].Value.ToString();

          
        }

        private void GetPrint_Click(object sender, EventArgs e)
        {
            markAttendence = new MarkAttendence();
            CaptureHuella capture = new CaptureHuella();
            capture.OnTemplate += this.OnTemplate;
            capture.ShowDialog();
            try
            {
                byte[] streamHuella = Template.Bytes;
                Status.Text = "Captured";
                markAttendence.Studentid = StudentId.Text;
                markAttendence.Name = Name.Text;
                markAttendence.PrintBinary = Template.Bytes;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MarkAttendence_Click(object sender, EventArgs e)
        {
            if (markAttendence.PrintBinary != null&&markAttendence.Name!=null&&markAttendence.Studentid!=null)
            {
                MarkAttendence Mark = new MarkAttendence()
                {
                    Studentid = markAttendence.Studentid,
                    Name=markAttendence.Name,
                    PrintBinary=markAttendence.PrintBinary,
                    dataofattendance=DateTime.Now
                   

                };
                try
                {
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri("http://localhost:12967/");
                    HttpResponseMessage httpResponseMessage = httpClient.PostAsJsonAsync("api/AttendanceRecordsdatas", Mark).Result;
                    MessageBox.Show("Attendence has been marked on live system");
                }
                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
             
            }
            else
            {
                MessageBox.Show("Please fill all the fields and make sure finger print status has changed to captured");
            }
        }
    }
}
