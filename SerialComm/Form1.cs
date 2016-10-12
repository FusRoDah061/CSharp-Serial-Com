using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System.IO.Ports;

namespace SerialComm
{
    public partial class Form1 : Form
    {
        IModbusSerialMaster modbus;
        Label lbParteVerde;

        public Form1()
        {
            InitializeComponent();

            Serial.PortName = "COM3";
            Serial.BaudRate = 19200;
            Serial.DataBits = 8;
            Serial.Parity = Parity.None;
            Serial.StopBits = StopBits.One;

            lbParteVerde = new Label();
            lbParteVerde.BackColor = Color.Green;
            lbParteVerde.AutoSize = false;
            lbParteVerde.Width = lbNivel.Width;
            lbParteVerde.Height = 0;
            lbParteVerde.CreateControl();
            lbNivel.Controls.Add(lbParteVerde);
            lbParteVerde.BringToFront();

        }

        private void btAbrirCon_Click(object sender, EventArgs e)
        {
            try
            {
                Serial.Open();
                modbus = ModbusSerialMaster.CreateRtu(Serial);
                lbConState.Text = "Conexão aberta.";
                timer1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Serial :" + ex.Message);
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ushort inicio = 0;
            ushort qnt = 1;
            byte slave = 1;

            ushort M1 = 0;

            try
            {
                ushort[] registers = modbus.ReadHoldingRegisters(slave, inicio, qnt);
                M1 = registers[0];

                double val = (M1 / 4)+1;

                if (val <= 15)
                {
                    lbParteVerde.Height = 0;
                }
                else if (val >= 1023)
                {

                }
                else
                {
                    lbParteVerde.Height = (int)Math.Floor(val);
                }
                
                lbParteVerde.Location = new Point(0, lbNivel.Height - lbParteVerde.Height);
                lbParteVerde.BringToFront();
                
                label1.Text = "Lido: " + M1.ToString();

            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                lbConState.Text = "Conexão fechada.";
                MessageBox.Show(ex.Message);
            }  
        }
    }
}