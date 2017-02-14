using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCalc
{
    public partial class Form1 : Form
    {

        private Solution solution;
        private Dilution dilution;
        public Form1()
        {
            InitializeComponent();
            comboBox_TargetVolume.SelectedIndex = 0;
            comboBox_TargetConc.SelectedIndex = 0;
            comboBox_dilution_SouceConc.SelectedIndex = 0;
            comboBox_dilution_TargetConc.SelectedIndex = 0;
            comboBox_dilution_TargetVolume.SelectedIndex = 0;
            PrintLine("Ready");
        }

        private void PrintLine(string str)
        {
            toolStripStatusLabel1.Text = str;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (solution.GetValues(true) == 0)
            {
                Solution.TargetWeight = Solution.MolWeight * Solution.TargetConc * Solution.ConcUnit * Solution.TargetVolume * Solution.VolUnit;
                textBox_Result.Text = Solution.TargetWeight.ToString();
            }
            else
            {
                PrintLine("Invalid input");
            }

            if(solution.GetSolubilityValue() == 0)
            {
                Solution.MaximumWeight = Solution.Solubility * 10 * Solution.TargetVolume * Solution.VolUnit;
                textBox_solution_MaximumWeight.Text = Solution.MaximumWeight.ToString();
                if(Solution.MaximumWeight > Solution.TargetWeight)
                {
                    textBox_solution_MaximumWeight.ForeColor = Color.Green;
                } else
                {
                    textBox_solution_MaximumWeight.ForeColor = Color.Red;
                }
            }
                
        }

        private void button_Reverse_Click(object sender, EventArgs e)
        {
            if (solution.GetValues(false) == 0)
            {
                Solution.TargetVolume = Solution.TargetWeight / (Solution.MolWeight * Solution.TargetConc * Solution.ConcUnit * Solution.VolUnit);
                textBox_TargetVolume.Text = Solution.TargetVolume.ToString();
            }
            else
            {
                PrintLine("Invalid input");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            solution = new Solution(this);
            dilution = new Dilution(this);
        }

        private void button_dilution_Convert_Click(object sender, EventArgs e)
        {
            if(dilution.GetValues() == 0)
            {
                Dilution.SoluteVolume = Dilution.TargetConc * Dilution.TargetConcUnit * Dilution.TargetVolume * Dilution.TargetVolUnit / (Dilution.SourceConc * Dilution.SourceConcUnit);               
                Dilution.SolventVolume = Dilution.TargetVolume * Dilution.TargetVolUnit - Dilution.SoluteVolume;
                Dilution.ChangeUnit(label_dilution_Solute, ref Dilution.SoluteVolume);
                Dilution.ChangeUnit(label_dilution_solvent, ref Dilution.SolventVolume);
                textBox_dilution_SoluteVolume.Text = Dilution.SoluteVolume.ToString();
                textBox_dilution_SolventVolume.Text = Dilution.SolventVolume.ToString();
            }
            else
            {
                PrintLine("Invalid input");
            }
            
        }
    }


    public class Solution:Form1
    {
        public const int UNIT_VOL_MILLI = 0;
        public const int UNIT_VOL_MICRO = 1;
        public const int UNIT_CONC_NONE = 0;
        public const int UNIT_CONC_MILLI = 1;
        public static double MolWeight;
        public static double TargetVolume;
        public static double TargetConc;
        public static double TargetWeight;
        public static double ConcUnit;
        public static double VolUnit;
        public static double Solubility;
        public static double MaximumWeight;

        private Form1 form1;

        public Solution(Form1 f)
        {
            this.form1 = f;
        }
        public int GetValues(bool isForward)
        {
            try
            {
                MolWeight = double.Parse(form1.textBox_MolWeight.Text);
                TargetConc = double.Parse(form1.textBox_TargetConc.Text);
                if (isForward)
                {
                    TargetVolume = double.Parse(form1.textBox_TargetVolume.Text);
                }
                else
                {
                    TargetWeight = double.Parse(form1.textBox_Result.Text);
                }

            }
            catch (Exception)
            {
                return -1;
            }

            VolUnit = 0;
            ConcUnit = 0;

            switch (form1.comboBox_TargetVolume.SelectedIndex)
            {
                case UNIT_VOL_MILLI:
                    VolUnit = 1.0e-3;
                    break;
                case UNIT_VOL_MICRO:
                    VolUnit = 1.0e-6;
                    break;
            }
            switch (form1.comboBox_TargetConc.SelectedIndex)
            {
                case UNIT_CONC_NONE:
                    ConcUnit = 1.0;
                    break;
                case UNIT_CONC_MILLI:
                    ConcUnit = 1.0e-3;
                    break;
            }
            return 0;
        }
        public int GetSolubilityValue()
        {
            try
            {
                Solubility = double.Parse(form1.textBox_solution_Solubility.Text);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static void ChangeUnit(Label l, ref double val)
        {
            if(1.0 <= val)
            {
                l.Text = "g";
            } else if (1.0e-3 <= val)
            {
                l.Text = "mg";
                val *= 1.0e3;
            }
        }
    }

    public class Dilution: Form1
    {
        public const int UNIT_VOL_MILLI = 0;
        public const int UNIT_VOL_MICRO = 1;
        public const int UNIT_CONC_NONE = 0;
        public const int UNIT_CONC_MILLI = 1;
        public static double MolWeight;
        public static double TargetVolume;
        public static double TargetConc;
        public static double TargetWeight;
        public static double SourceConc;
        public static double SourceConcUnit;
        public static double TargetVolUnit;
        public static double TargetConcUnit;
        public static double SoluteVolume;
        public static double SolventVolume;

        private Form1 form1;

        public Dilution(Form1 f)
        {
            this.form1 = f;
        }

        public int GetValues()
        {
            try
            {
                SourceConc = double.Parse(form1.textBox_dilution_SourceConc.Text);
                TargetVolume = double.Parse(form1.textBox_dilution_TargetVolume.Text);
                TargetConc = double.Parse(form1.textBox_dilution_TargetConc.Text);
            }
            catch (Exception)
            {
                return -1;
            }
            SourceConcUnit = 0;
            TargetConcUnit = 0;
            TargetVolUnit = 0;

            switch (form1.comboBox_dilution_SouceConc.SelectedIndex)
            {
                case UNIT_CONC_NONE:
                    SourceConcUnit = 1.0;
                    break;
                case UNIT_CONC_MILLI:
                    SourceConcUnit = 1.0e-3;
                    break;
            }
            switch (form1.comboBox_dilution_TargetConc.SelectedIndex)
            {
                case UNIT_CONC_NONE:
                    TargetConcUnit = 1.0;
                    break;
                case UNIT_CONC_MILLI:
                    TargetConcUnit = 1.0e-3;
                    break;
            }
            switch (form1.comboBox_dilution_TargetVolume.SelectedIndex)
            {
                case UNIT_VOL_MILLI:
                    TargetVolUnit = 1.0e-3;
                    break;
                case UNIT_VOL_MICRO:
                    TargetVolUnit = 1.0e-6;
                    break;
            }
            return 0;
        }
        public static void ChangeUnit(Label l, ref double val)
        {
            if (1.0e-3 <= val)
            {
                l.Text = "mL";
                val *= 1.0e3;
            }
            else if (val < 1.0e-3)
            {
                l.Text = "μL";
                val *= 1.0e6;
            }
        }
    }
}