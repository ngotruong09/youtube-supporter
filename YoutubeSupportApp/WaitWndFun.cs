﻿namespace YoutubeSupportApp
{
    public class WaitWndFun
    {
        WaitForm loadingForm;
        Thread loadthread;
        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }
        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(parent);
        }
        public void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new System.Threading.ThreadStart(loadingForm.CloseLoadingForm));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void LoadingProcessEx()
        {
            loadingForm = new WaitForm();
            loadingForm.ShowDialog();
        }
        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loadingForm = new WaitForm(Cparent);
            loadingForm.ShowDialog();
        }
    }
}
