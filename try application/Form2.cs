using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;

namespace try_application
{
    public partial class Form2 : Form 
    {
        //private TaskModel TaskModel;
        private DPFP.Template Template;
        
        public Form2()
        {
            InitializeComponent();
            //cp.StartCapture();
            //cp.EventHandler=this;

        }
 
        
            private void Register_Click(object sender, EventArgs e)
        {
            CaptureHuella capture = new CaptureHuella();
            capture.OnTemplate += this.OnTemplate;
            capture.ShowDialog();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke((Action)(delegate () {
                Template = template;
                btnAgregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("FingerPrint template is ready for finger print verification");
                    textBox1.Text = "Correct";
                }
                else
                {
                    MessageBox.Show("FingerPrint template is not valid");
                }
            }));
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  cp.StopCapture();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //TaskModel = new TaskModel();
            Listar();
        }
        private void Listar()
        {
            try
            {
                //var employee = from emp in TaskModel.Students
                //               select new
                //               {
                //                   ID = emp.ID,
                //                   Name=emp.Name
                //               };
                //if(employee!=null)
                //{
                //    dataGridView1.DataSource = employee.ToList();
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] streamHuella = Template.Bytes;
                //Student student = new Student
                //{
                //    Name=Name.Text,
                //    Pattern=streamHuella
                //};
                //TaskModel.Students.Add(student);
                //TaskModel.SaveChanges();
                MessageBox.Show("Record saved successfully");
                Listar();
                Template = null;
                btnAgregar.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
