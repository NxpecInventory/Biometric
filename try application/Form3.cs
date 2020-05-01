using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;

namespace try_application
{
    public partial class Form3 : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //private TaskModel context;
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Trying this huella thing";
           Verificator= new DPFP.Verification.Verification();
            UpdateStatus(0);
        }
        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept rate (FAR) - {0}",FAR));
        }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                Stream stream;
                //foreach (var item in context.Students)
                //{
                //    stream = new MemoryStream(item.Pattern);
                //    template = new DPFP.Template(stream);
                //        Verificator.Verify(features, template, ref result);
                    
                //    UpdateStatus(result.FARAchieved);
                //    if(result.Verified)
                //    {
                //        MakeReport("FingerPrint was verified" + item.Name);
                //        MessageBox.Show("User " + item.Name + " found.");
                //        break;
                //    }
                   
                //}
            }
        }
        public Form3()
        {
            //context =new TaskModel();
            //InitializeComponent();
        }
    }
}
