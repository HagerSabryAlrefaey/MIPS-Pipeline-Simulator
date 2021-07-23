# MIPS-Pipeline-Simulator
This project is a simple simulation for the MIPS pipeline process on the R-Type instructions.

## Architecture for MIPS pipeline
![](MIPS.PNG)

## Code
  - Units Class: 
      This class cotains the main units for the MIPS system such as: the adder and the ALU unit, 
      I didn’t include MUX or control unit as they aren’t necessary for the R-Type instructions.
  - Register Class: 
      This class includes:
      -	all the registers needed for the project; memory registers(32 numbered registers) 
      And the pipeline registers(IF/ID, ID/EX, EX/MEM, MEM/WB).
      -	The functions needed to handle the registers, such as initializing the memory registers with their values,
      filling pilpeline registers with the needed data for each stage in the process and others more for minimal procedures.
  - Pipeline Class: 
      This is where the whole pipeline process is done; Fetch, Decode, Excute, Memory Access and Write Back.
## Run
    1. Fill the User Code TextBox with the instructions you need the MIPS to run in binary
    with the form: Address: Binary Instruction.
    Example
    Your instrustion: 1004: or $2, $3, $Zero
    The Run Code: 1004:00000000011000000001000000100101
    2. Fill the PC TextBox with the initial address (The first instruction’s address).
    3. Click Initialize button to show MIPS registers’ name and value.
    4. Click Run 1 Cycle button to run the first cycle and show the pipeline registers’ values
    5. To run each cycle till the pipeline process is finished keep clicking the Run 1 Cycle button.
