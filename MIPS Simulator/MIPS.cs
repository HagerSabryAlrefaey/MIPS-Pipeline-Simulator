using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPS_Simulator
{
    /* THE INSTRUCTIONS BINARY CODE FOR THE RUN
         * REMOVE SPACES BEFORE RUN
         * 1004: or $2, $3, $Zero
         * 1004:000000 00011 00000 00010 00000 100101
         * 
         * 1008: add $5, $3, $4
         * 1008:000000 00011 00100 00101 00000 100000
         * 
         * 1012: and $6, $3, $Zero
         * 1012:000000 00011 00000 00110 00000 100100
         * 
         * 1016: add $9, $7, $8
         * 1016:000000 00111 01000 01001 00000 100000
         * 
         * 1020: sub $8, $2, $3
         * 1020:000000 00010 00011 01000 00000 100010
         * 
         * ALL
         * 
1004:00000000011000000001000000100101
1008:00000000011001000010100000100000
1012:00000000011000000011000000100100
1016:00000000111010000100100000100000
1020:00000000010000110100000000100010

            1000: add $10, $23, $25
            1000:000000 10111 11001 01010 00000 100000
            1004:or $21, $13, $8
            1004:000000 01101 01000 10101 00000 100101

         * */
    public partial class MIPS : Form
    {
        int pc;
        Pipeline PipeLineProcess;
        DataTable table;
        int numOfInstructions;
        int k;
        public MIPS()
        {
            InitializeComponent();
        }
        public void FillMipsRegisterGrid()
        {
            int[] tempRegisters = PipeLineProcess.PipelineReg.GetMEMRegisters();
            table = new DataTable();
            table.Columns.Add("Name", typeof(int));
            table.Columns.Add("Vlaue", typeof(string));
            MipsRegisterGrid.DataSource = table;
            MipsRegisterGrid.Refresh();
            for (int i = 0; i < tempRegisters.Length; i++)
            {
                table.Rows.Add(i, tempRegisters[i]);
            }
            MipsRegisterGrid.DataSource = table;
            MipsRegisterGrid.Refresh();
        }

        private void inializeBtn_Click(object sender, EventArgs e)
        {
            if (UserCodetxt.Text == "")
                MessageBox.Show("There are no Instructions, please fill the User Code box");
            else if (StartPCTxt.Text == "")
                MessageBox.Show("please fill the PC box with the first instruction's address");
            else
            {
                k = 1;
                pc = Convert.ToInt32(StartPCTxt.Text);
                PipeLineProcess = new Pipeline(pc);
                PipeLineProcess.PipelineReg.InitializeMEMRegisters();
                string[] userCode = UserCodetxt.Lines;
                int[] addresses = new int[userCode.Length];
                string[] instructions = new string[userCode.Length];
                numOfInstructions = userCode.Length;
                for (int i = 0; i < userCode.Length; i++)
                {
                    string[] uC = userCode[i].Split(':');
                    addresses[i] = Convert.ToInt32(uC[0]);
                    instructions[i] = uC[1];
                }
                PipeLineProcess.Start(addresses, instructions);
                PiplineGrid.Rows.Clear();
                PiplineGrid.Refresh();
                FillMipsRegisterGrid();

            }
        }

        private void runCycleBtn_Click(object sender, EventArgs e)
        {
            if (PipeLineProcess.CycleNum == numOfInstructions + 5 - 1)
                MessageBox.Show("No more Instructions to excute.");
            else
            {
                PipeLineProcess.CycleNum++;
                PiplineGrid.Rows.Add("******", "Cycle Number| " + PipeLineProcess.CycleNum.ToString());
                if (PipeLineProcess.CycleNum > 4 && PipeLineProcess.CycleNum <= numOfInstructions + 4)
                {                   
                    PipeLineProcess.process = "WB";
                    PipeLineProcess.WriteBack();
                    MessageBox.Show("Instruction No." + k + " is Finished Successfully!");

                    FillMipsRegisterGrid();
                    k++;

                }
                if (PipeLineProcess.CycleNum > 3 && PipeLineProcess.CycleNum <= numOfInstructions + 3)
                {
                    PipeLineProcess.process = "MEM";
                    PipeLineProcess.MemAccess();
                    PiplineGrid.Rows.Add("MEM/WB", "ALU RESULT: " + PipeLineProcess.PipelineReg.GetRegister("WB").ElementAt(0) + "//" + "RD: " + PipeLineProcess.PipelineReg.GetRegister("WB").ElementAt(1));
                }
                if (PipeLineProcess.CycleNum > 2 && PipeLineProcess.CycleNum <= numOfInstructions + 2)
                {
                    PipeLineProcess.process = "EX";
                    PipeLineProcess.Excute();
                    PiplineGrid.Rows.Add("EX/MEM: ", "ALU RESULT: " + PipeLineProcess.PipelineReg.GetRegister("MEM").ElementAt(0) + "//" + "RD: " + PipeLineProcess.PipelineReg.GetRegister("MEM").ElementAt(1));
                }
                if (PipeLineProcess.CycleNum > 1 && PipeLineProcess.CycleNum <= numOfInstructions + 1)
                {
                    PipeLineProcess.process = "ID";
                    PipeLineProcess.Decode();
                    PiplineGrid.Rows.Add("ID/EX: ", "RSValue: " + PipeLineProcess.PipelineReg.GetRegister("EX").ElementAt(0) + "//" + "RTValue: " + PipeLineProcess.PipelineReg.GetRegister("EX").ElementAt(1) + "//" + "RD: " + PipeLineProcess.PipelineReg.GetRegister("EX").ElementAt(2));
                }
                if (PipeLineProcess.CycleNum > 0 && PipeLineProcess.CycleNum <= numOfInstructions)
                {
                    PipeLineProcess.process = "IF";
                    PipeLineProcess.fetch();
                    PiplineGrid.Rows.Add("IF/ID: ", "Instruction: " + PipeLineProcess.PipelineReg.GetRegister("ID").ElementAt(0));
                }
            }
        }
    }
}
