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

namespace try_application
{
    public partial class CaptureHuella : CaptureForm
    {
        public delegate void OnTemplateEventhandler(DPFP.Template template);
        public event OnTemplateEventhandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;
        protected override void Init()
        {
            base.Init();
            base.Text = "Trying this huella thing";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }
        protected override void Process(Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            if(features!=null) try
                {
                    MakeReport("The fingerprint featureset was created");
                    Enroller.AddFeatures(features);
                }
                finally
                {
                    UpdateStatus();
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready: //report success and stop capturing
                            OnTemplate(Enroller.Template);
                            SetPrompt("Click close, and then click fingerprint verification");
                            Stop();
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }
        private void UpdateStatus()
        {
            SetStatus(String.Format("FingerPrint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        public CaptureHuella()
        {
            InitializeComponent();
        }
    }
}
