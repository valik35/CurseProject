using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;

namespace GestureCam
{
    class Logic
    {
        FilterInfoCollection videodevices;
        VideoCaptureDevice videoSource;

        public Logic()
        {
            videodevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videodevices[0].MonikerString);

            videoSource.NewFrame += videoSource_NewFrame;
            videoSource.Start();
        }

        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            
        }
    }
}
