using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5_UDPSocket
{
    public partial class UDP_Server : Form
    {
        public UDP_Server()
        {
            InitializeComponent();
        }

        private bool isListening = false;
        private UdpClient client;

        private async void btn_Listen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Port.Text))
            {
                MessageBox.Show("Vui lòng nhập số Port", "Số port trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int port = Convert.ToInt32(tb_Port.Text);

                if (port >= 0 && port <= 1023)
                {
                    MessageBox.Show("Đây là các Port chuẩn dành cho mạng\nVui lòng nhập ngoài khoảng này.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Bạn đã nhập ngoài phạm vi của port\nPhạm vi của port hợp lệ là 0 - 65535\nVui lòng nhập lại.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Server đang lắng nghe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        client = new UdpClient(port);
                        isListening = true;

                        // Lắng nghe tin nhắn trong một Task để không làm đóng băng UI
                        await Task.Run(() =>
                        {
                            while (isListening)
                            {
                                try
                                {
                                    IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 0);
                                    Byte[] receiveByte = client.Receive(ref ipEnd); // Nhận tin nhắn
                                    string data = Encoding.UTF8.GetString(receiveByte);
                                    tb_Status.Invoke((MethodInvoker)(() =>
                                    {
                                        string mess = $"{ipEnd.Address}:{ipEnd.Port}: {data}\n";
                                        tb_Status.Text += mess + Environment.NewLine;
                                    }));

                                    // Gửi phản hồi tới client
                                    MessageBox.Show("Đã nhận được tin nhắn!", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    string serverResponse = "Server: Đã nhận được tin nhắn!";
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                                    client.Send(sendBytes, sendBytes.Length, ipEnd); // Gửi phản hồi tới client

                                }
                                catch (SocketException)
                                {
                                    // Đóng kết nối, không cần báo lỗi
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "UDP Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                tb_Status.Text = "";
                isListening = false; // Ngừng vòng lặp lắng nghe
                client.Close(); // Đóng socket
                MessageBox.Show("Đã dừng lắng nghe và đóng kết nối.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
