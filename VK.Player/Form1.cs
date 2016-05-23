using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VK.Player
{
    public partial class Form1 : Form
    {
        private List<Audio> audioList;
        WMPLib.IWMPPlaylist playList;
        WMPLib.IWMPMedia media;
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Form2().Show();
            backgroundWorker.RunWorkerAsync();
        }

        public class Audio
        {
            public int aid { get; set; }
            public int owner_id { get; set; }
            public string artist { get; set; }
            public string title { get; set; }
            public int duration { get; set; }
            public string url { get; set; }
            public string lurlcs_id { get; set; }
            public int genre { get; set; }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!Settings1.Default.auth) { Thread.Sleep(500); }

            WebRequest request = WebRequest.Create("https://api.vk.com/method/audio.get?owner_id=" + Settings1.Default.id + "&need_user=0&access_token=" + Settings1.Default.token);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            responseFromServer = HttpUtility.HtmlDecode(responseFromServer);

            JToken token = JToken.Parse(responseFromServer);
            audioList = Enumerable.Skip(token["response"].Children(), 1).Select(c => c.ToObject<Audio>()).ToList();

            this.Invoke((MethodInvoker)delegate
            {
                playList = mediaPlayer.playlistCollection.newPlaylist("vkPlayList");

                for (int i = 0; i < audioList.Count(); i++)
                {
                    media = mediaPlayer.newMedia(audioList[i].url);
                    playList.appendItem(media);

                    songsList.Items.Add(audioList[i].artist + " - " + audioList[i].title);
                }
                mediaPlayer.currentPlaylist = playList;
                mediaPlayer.Ctlcontrols.stop();
            });
        }

        private void songsList_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mediaPlayer.Ctlcontrols.play();
                mediaPlayer.Ctlcontrols.currentItem = mediaPlayer.currentPlaylist.get_Item(songsList.SelectedIndex);
                index = songsList.SelectedIndex;
                CurrSong.Text = songsList.SelectedItem.ToString();
            }
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 3:    // Playing
                    CurrSong.Text = songsList.Items[index].ToString();
                    break;
                    
                case 8:    // MediaEnded
                    CurrSong.Text = " ";
                    index++;
                    break;
            }
        }
    }
}
