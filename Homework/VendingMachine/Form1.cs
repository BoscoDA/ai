﻿using System;
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

        /// <summary>
        /// Adds transitions to the transition dictionary and output starting state and money values on screen
        /// </summary>
        public void FSMSetup()
        {
            transistions = new Dictionary<KeyValuePair<State, Input>, KeyValuePair<State, Output>>();
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.SELECT), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.IDLE, Input.RETRIEVE), new KeyValuePair<State, Output>(State.IDLE, Output.NONE));

            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.PAY), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.SELECT), new KeyValuePair<State, Output>(State.VENDED, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.CANCEL), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.SELECT, Input.RETRIEVE), new KeyValuePair<State, Output>(State.SELECT, Output.NONE));

            transistions.Add(new KeyValuePair<State, Input>(State.VENDED, Input.PAY), new KeyValuePair<State, Output>(State.VENDED, Output.QUARTER));
            transistions.Add(new KeyValuePair<State, Input>(State.VENDED, Input.SELECT), new KeyValuePair<State, Output>(State.VENDED, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.VENDED, Input.CANCEL), new KeyValuePair<State, Output>(State.VENDED, Output.NONE));
            transistions.Add(new KeyValuePair<State, Input>(State.VENDED, Input.RETRIEVE), new KeyValuePair<State, Output>(State.IDLE, Output.QUARTER));

            tb_state.Text = state.ToString();
            tb_money.Text = moneyInput.ToString();

            UpdateScreen();
        }

        /// <summary>
        /// Updates the global variable for the current output after a transition
        /// </summary>
        /// <param name="output"></param>
        public void UpdateOutput(Output output)
        {
            this.output = output.ToString();
        }

        /// <summary>
        /// Updates the VendOutput varibale used for keeping track of what is in the vending machine tray
        /// </summary>
        public void UpdateVendOutput()
        {
            vendOutput = output;
        }

        /// <summary>
        /// Updates the number of quarters that are in the change tray
        /// </summary>
        private void UpdateChange()
        {
            int temp = (int)(moneyInput / Quarter.Instance.Value);

            if(state == State.VENDED)
            {
                quarterReturnNum++;
            }

            else if (temp > 0)
            {
                quarterReturnNum += temp;
                moneyInput = 0.00M;
            }
            else
            {
                output = Output.NONE.ToString();
            }
        }

        /// <summary>
        /// Used to update the information presented on the screen (state, outputs, money input, and change)
        /// </summary>
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

        /// <summary>
        /// Add most recent actions output to the output log
        /// </summary>
        public void UpdateOutputLog()
        {
            //reference this stack overflow post for this code: https://stackoverflow.com/questions/13505248/how-to-make-autoscroll-multiline-textbox-in-winforms
            tb_output_log.Text += output + Environment.NewLine;
            tb_output_log.SelectionStart = tb_output_log.TextLength;
            tb_output_log.ScrollToCaret();
        }


        /// <summary>
        /// Changes state based on the input passed into the method
        /// </summary>
        /// <param name="input"></param>
        public void ChangeState(Input input)
        {
            KeyValuePair<State, Input> temp = new KeyValuePair<State, Input>(state, input);
            state = transistions[temp].Key;

            UpdateOutput(transistions[temp].Value);
            UpdateScreen();
            UpdateOutputLog();
        }

        /// <summary>
        /// Updates how much money is inputed to the machine
        /// </summary>
        /// <param name="quarter"></param>
        private void AddMoney(Quarter quarter)
        {
            if(state != State.VENDED)
            {
                moneyInput += quarter.Value;
            }
        }

        /// <summary>
        /// Updates money in machine based off of the price of the item pruchased
        /// </summary>
        /// <param name="purchasePrice"></param>
        private void UpdateMoney(decimal purchasePrice)
        {
            moneyInput -= purchasePrice;
        }

        /// <summary>
        /// Determine what item was selected when using a select input
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the transtions revolving around the select input to have the proper output for the given transition
        /// </summary>
        /// <param name="outputObject"></param>
        /// <returns></returns>
        private bool DetermineOutput(OutputBase outputObject)
        {
            Input input = Input.SELECT;
            KeyValuePair<State, Input> temp = new KeyValuePair<State, Input>(state, input);

            Output output = Output.NONE;

            if (moneyInput >= outputObject.Value && state != State.VENDED)
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

                transistions.Add(new KeyValuePair<State, Input>(state, Input.SELECT), new KeyValuePair<State, Output>(State.VENDED, output));

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
            UpdateChange();
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
        VENDED
    }
}
