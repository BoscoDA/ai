using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        string output;
        State state = State.IDLE;
        string vendOutput = "";
        decimal moneyInput = 0.00M;

        public Dictionary<KeyValuePair<State, Input>, KeyValuePair<State, Output>> transistions;
        OutputBase[] OutputObjects = { Gum.Instance,  Granola.Instance, Quarter.Instance};


        int quarterReturnNum = 0;


        public Form1()
        {
            InitializeComponent();
            FSMSetup();
        }

        public void FSMSetup()
        {
            transistions = new Dictionary<KeyValuePair<State, Input>, KeyValuePair<State, Output>>();
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.SELECT), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.RETRIEVE), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));

            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.SELECT), new KeyValuePair<State, Output>(State.VEND, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.RETRIEVE), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));

            transistions.Add(new KeyValuePair<State, Input>(State.VEND, Input.PAY), new KeyValuePair<State, Output>(State.VEND, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.VEND, Input.SELECT), new KeyValuePair<State, Output>(State.VEND, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.VEND, Input.CANCEL), new KeyValuePair<State, Output>(State.VEND, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.VEND, Input.RETRIEVE), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));

            tb_state.Text = state.ToString();
            tb_money.Text = moneyInput.ToString();
        }

        public void UpdateOutput(Output output)
        {
            this.output = output.ToString();
        }

        public void UpdateVendOutput()
        {
            vendOutput = output;
        }

        private void UpdateChange()
        {
            int temp = (int)(moneyInput / Quarter.Instance.Value);

            if (temp > 0)
            {
                quarterReturnNum += temp;
                moneyInput = 0.00M;
            }
            else
            {
                output = Output.NONE.ToString();
            }
        }

        public void UpdateScreen()
        {
            if (output == Output.GUM.ToString() || output == Output.GRANOLA.ToString())
            {
                UpdateVendOutput();
            }

            else if (output == Output.QUARTER.ToString())
            {
                UpdateChange();
            }

            tb_state.Text = state.ToString();
            tb_money.Text = moneyInput.ToString();
            tb_change.Text = quarterReturnNum + " " + "Quarters";
            tb_output.Text = vendOutput;

        } 

        public void UpdateOutputLog()
        {
            tb_output_log.Text += output + Environment.NewLine;
            tb_output_log.SelectionStart = tb_output_log.TextLength;
            tb_output_log.ScrollToCaret();
        }

        public void ChangeState(Input input)
        {
            KeyValuePair<State, Input> temp = new KeyValuePair<State, Input>(state, input);
            state = transistions[temp].Key;

            UpdateOutput(transistions[temp].Value);
            UpdateScreen();
            UpdateOutputLog();
        }

        private void AddMoney(Quarter quarter)
        {
            moneyInput += quarter.Value;
        }

        private void UpdateMoney(decimal purchasePrice)
        {
            moneyInput -= purchasePrice;
        }

        private OutputBase DetermineInput()
        {
            string temp = "";
            foreach(RadioButton btn in gbox_select.Controls)
            {
                if (btn.Checked)
                {
                    temp = btn.Text.ToUpper().Trim();
                    break;
                }
            }

            var input = OutputObjects.Where(x => x.Name.ToUpper() == temp).FirstOrDefault();

            return input;
        }

        private bool DetermineOutput(OutputBase outputObject)
        {
            Input input = Input.SELECT;
            KeyValuePair<State, Input> temp = new KeyValuePair<State, Input>(state, input);

            Output output = Output.NONE;

            if (moneyInput >= outputObject.Value && state != State.VEND)
            {
                try
                {
                    Enum.TryParse(outputObject.Name.ToUpper(), out output);
                }
                catch
                {
                    output = Output.NONE;
                }

                transistions.Remove(temp);

                transistions.Add(new KeyValuePair<State, Input>(state, Input.SELECT), new KeyValuePair<State, Output>(State.VEND, output));

                return true;
            }

            else
            {

                transistions.Remove(temp);

                transistions.Add(new KeyValuePair<State, Input>(state, Input.SELECT), new KeyValuePair<State, Output>(state, output));

                return false;
            }
        }


        private void btn_quarter_Click(object sender, EventArgs e)
        {
            AddMoney(Quarter.Instance);
            ChangeState(Input.PAY);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ChangeState(Input.CANCEL);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            var input = DetermineInput();
            var output = DetermineOutput(input);

            ChangeState(Input.SELECT);
            if(output)
            {
                UpdateMoney(input.Value);
            }
            UpdateScreen();
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            vendOutput = "";
            ChangeState(Input.RETRIEVE);
        }

        private void tb_take_change_Click(object sender, EventArgs e)
        {
            quarterReturnNum = 0;
            UpdateScreen();
        }
    }

    public enum Output
    {
        GUM,
        GRANOLA,
        QUARTER,
        NONE
    }

    public enum Input
    {
        PAY,
        SELECT,
        CANCEL,
        RETRIEVE
    }

    public enum State
    {
        IDLE,
        SELECT,
        VEND
    }
}
