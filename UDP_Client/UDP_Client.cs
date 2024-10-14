using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Client
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private async void btn_Listen_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                // Kiểm tra các điều kiện đầu vào
                int port = Convert.ToInt32(tb_Port.Text);
                IPAddress ipAdd;

                if (port >= 0 && port <= 1023)
                {
                    MessageBox.Show("Đây là các Port chuẩn dành cho mạng\nVui lòng nhập ngoài khoảng này.", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Bạn đã nhập ngoài phạm vi của port\nPhạm vi của port hợp lệ là 0 - 65535\nVui lòng nhập ngoài khoảng này.", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tb_IPAddress.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ IP của server", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tb_Port.Text))
                {
                    MessageBox.Show("Vui lòng nhập số Port của server", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tb_Message.Text))
                {
                    MessageBox.Show("Vui lòng nhập message", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!IPAddress.TryParse(tb_IPAddress.Text, out ipAdd))
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ.", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!IPAddress.IsLoopback(ipAdd))
                {
                    MessageBox.Show("Địa chỉ IP không thuộc dãy loopback (127.0.0.1).\nVui lòng kiểm tra lại.", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Tạo điểm cuối và gửi message
                    IPEndPoint ipEnd = new IPEndPoint(ipAdd, port);
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(tb_Message.Text);

                    // Gửi message tới server
                    udpClient.Send(sendBytes, sendBytes.Length, ipEnd);

                    tb_Message.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng socket để giải phóng tài nguyên
                udpClient.Close();
                MessageBox.Show("Socket đã được đóng.", "Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btb_Clear_Click(object sender, EventArgs e)
        {
            tb_IPAddress.Text = "";
            tb_Port.Text = "";
            tb_Message.Text = "";
        }
    }
}
