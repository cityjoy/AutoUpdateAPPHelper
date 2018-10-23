using KnightsWarriorAutoupdater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            //Config config = new Config
            //{
            //    Enabled = true,
            //    ServerUrl = "",
            //    UpdateFileList = new UpdateFileList { 
            //    new LocalFile(){ LastVer="", Path="" , Size=1000}  }
            //};
            //XmlSerializer ser = new XmlSerializer(typeof(Config));

            //TextWriter writer = new StreamWriter(@"E:\Work\Projects\Career\Career.FileStore\Templates\test.xml");
            //ser.Serialize(writer, config);//要序列化的对象
            //writer.Close();

            #region check and download new version program
            bool bHasError = false;
            IAutoUpdater autoUpdater = new AutoUpdater();
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                MessageBox.Show("Can not find the specified resource");
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                MessageBox.Show("Download the upgrade file error");
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                MessageBox.Show("Upgrade address configuration error");
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                MessageBox.Show("Download the upgrade file error");
            }
            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("An error occurred during the upgrade process");
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                        //Log the message to your file or database
                    }
                }
            }
            #endregion
            InitializeComponent();
        }
    }

}
