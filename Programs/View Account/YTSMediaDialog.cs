using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTS;
using YTS.Models;

namespace View_Account
{
    public partial class YTSMediaDialog : Form
    {
        // Written, 14.09.2020

        public const string YTS_URL_SUFFIX="api/v2/";
        private string ytsDomain = "https://www.yst.am/";
        private Services ytsServices = null;

        public YTSMediaDialog()
        {
            InitializeComponent();
            this.initializeService();
        }

        private void initializeService() 
        {
            // Written, 14.09.2020

            this.ytsServices = new Services(Path.Combine(this.ytsDomain, YTS_URL_SUFFIX));
        }
    }
}
