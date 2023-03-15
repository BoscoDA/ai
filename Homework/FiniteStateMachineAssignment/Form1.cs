using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiniteStateMachineAssignment
{
    public partial class Form1 : Form
    {
        State state = State.IDLE;
        public Dictionary<KeyValuePair<State, Input>, KeyValuePair<State, Output>> transistions;
        string vendOutput = "";
        decimal moneyInput = 0.00M;

        public Form1()
        {
            InitializeComponent();
            Run();
        }

        public void Run()
        {
            transistions = new Dictionary<KeyValuePair<State, Input>, KeyValuePair<State, Output>>();
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.GUM), new KeyValuePair<State, Output>(State.IDLE, Output.GUM));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.GRANOLA), new KeyValuePair<State, Output>(State.IDLE, Output.GRANOLA));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));

            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.GUM), new KeyValuePair<State, Output>(State.IDLE, Output.GUM));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.GRANOLA), new KeyValuePair<State, Output>(State.IDLE, Output.GRANOLA));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));

            tb_state.Text = state.ToString();
            tb_input_money.Text = moneyInput.ToString();
        }

        public void UpdateOutput(Output output)
        {
            vendOutput += $"{output.ToString()} ";

            tb_state.Text = state.ToString();
            tb_output.Text = vendOutput;
            tb_input_money.Text = moneyInput.ToString();
        }

        public void ChangeState(Input input)
        {
            KeyValuePair<State, Input> temp = new KeyValuePair<State, Input>(state, input);
            state = transistions[temp].Key;

            if(input == Input.PAY)
            {
                var tempMoney = moneyInput;
                moneyInput = tempMoney + 0.25M;
            }

            else if(input == Input.CANCEL)
            {
                moneyInput = 0;
            }

            else if(input == Input.GUM)
            {
                moneyInput = 0;
            }

            else if (input == Input.GRANOLA)
            {
                moneyInput = 0;
            }

            UpdateOutput(transistions[temp].Value);
        }

        private void btn_quarter_Click(object sender, EventArgs e)
        {
            ChangeState(Input.PAY);
        }

        private void btn_gum_Click(object sender, EventArgs e)
        {
            if(moneyInput >= 0.5M)
            {
                ChangeState(Input.GUM);
            }
        }

        private void btn_granola_Click(object sender, EventArgs e)
        {
            if(moneyInput >= 0.75M)
            {
                ChangeState(Input.GRANOLA);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ChangeState(Input.CANCEL);
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
        GUM,
        GRANOLA,
        CANCEL
    }

    public enum State
    {
        IDLE,
        SELECT,
        VEND
    }
}
