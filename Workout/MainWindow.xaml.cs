using System;
using System.Windows;

namespace OneRMEstimation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Estimate1RM(object sender, RoutedEventArgs e)
        {
            try
            {
                // 取得實際訓練重量和實際次數
                double actualWeight = Convert.ToDouble(actualWeightTextBox.Text);
                int actualReps = Convert.ToInt32(actualRepsTextBox.Text);

                // 計算1RM
                double calculated1RM = Calculate1RM(actualWeight, actualReps);

                // 取得預計訓練次數
                int predictedReps = Convert.ToInt32(predictedRepsTextBox.Text);

                // 列出不同RPE強度對應的1RM重量
                resultTextBlock.Text = "RPE強度對應的訓練重量為：\n";

                double[] specifiedRPEs = { 10, 9.5, 9, 8.5, 8, 7.5, 7, 5, 3 };

                foreach (double rpe in specifiedRPEs)
                {
                    double percentage = EstimatePercentage(rpe, predictedReps);
                    double estimated1RM = calculated1RM * percentage;

                    // 轉換為整數
                    int int1RM = Convert.ToInt32(estimated1RM);

                    resultTextBlock.Text += $"RPE {rpe}: {int1RM} kg\n";
                }
            }
            catch (Exception ex)
            {
                resultTextBlock.Text = "輸入不合法，請確保輸入的是有效的數字。";
            }
        }

        private double Calculate1RM(double weight, int reps)
        {
            // 使用您之前提供的1RM公式
            double percentage = 0;

            switch (reps)
            {
                case 1: percentage = 1.00; break;
                case 2: percentage = 0.96; break;
                case 3: percentage = 0.92; break;
                case 4: percentage = 0.89; break;
                case 5: percentage = 0.86; break;
                case 6: percentage = 0.84; break;
                case 7: percentage = 0.81; break;
                case 8: percentage = 0.78; break;
                case 9: percentage = 0.76; break;
                case 10: percentage = 0.74; break;
            }

            return (1 / percentage) * weight;
        }

        private double EstimatePercentage(double rpe, int reps)
        {
            // 根據RPE強度和預計訓練次數估算百分比
            double percentage = 0;

            switch (rpe)
            {
                case 10:
                    switch (reps)
                    {
                        case 1: percentage = 1.00; break;
                        case 2: percentage = 0.96; break;
                        case 3: percentage = 0.92; break;
                        case 4: percentage = 0.89; break;
                        case 5: percentage = 0.86; break;
                        case 6: percentage = 0.84; break;
                        case 7: percentage = 0.81; break;
                        case 8: percentage = 0.78; break;
                        case 9: percentage = 0.76; break;
                        case 10: percentage = 0.74; break;
                    }
                    break;
                // 其他RPE強度的百分比計算類似，可以自行擴展
                case 9.5:
                    switch (reps)
                    {
                        case 1: percentage = 0.98; break;
                        case 2: percentage = 0.94; break;
                        case 3: percentage = 0.91; break;
                        case 4: percentage = 0.88; break;
                        case 5: percentage = 0.85; break;
                        case 6: percentage = 0.82; break;
                        case 7: percentage = 0.80; break;
                        case 8: percentage = 0.77; break;
                        case 9: percentage = 0.75; break;
                        case 10: percentage = 0.72; break;
                    }
                    break;
                case 9:
                    switch (reps)
                    {
                        case 1: percentage = 0.96; break;
                        case 2: percentage = 0.92; break;
                        case 3: percentage = 0.89; break;
                        case 4: percentage = 0.86; break;
                        case 5: percentage = 0.84; break;
                        case 6: percentage = 0.81; break;
                        case 7: percentage = 0.79; break;
                        case 8: percentage = 0.76; break;
                        case 9: percentage = 0.74; break;
                        case 10: percentage = 0.71; break;
                    }
                    break;
                case 8.5:
                    switch (reps)
                    {
                        case 1: percentage = 0.94; break;
                        case 2: percentage = 0.91; break;
                        case 3: percentage = 0.88; break;
                        case 4: percentage = 0.85; break;
                        case 5: percentage = 0.82; break;
                        case 6: percentage = 0.80; break;
                        case 7: percentage = 0.77; break;
                        case 8: percentage = 0.75; break;
                        case 9: percentage = 0.72; break;
                        case 10: percentage = 0.69; break;
                    }
                    break;
                case 8:
                    switch (reps)
                    {
                        case 1: percentage = 0.92; break;
                        case 2: percentage = 0.89; break;
                        case 3: percentage = 0.86; break;
                        case 4: percentage = 0.84; break;
                        case 5: percentage = 0.81; break;
                        case 6: percentage = 0.79; break;
                        case 7: percentage = 0.76; break;
                        case 8: percentage = 0.74; break;
                        case 9: percentage = 0.71; break;
                        case 10: percentage = 0.68; break;
                    }
                    break;
                case 7.5:
                    switch (reps)
                    {
                        case 1: percentage = 0.91; break;
                        case 2: percentage = 0.88; break;
                        case 3: percentage = 0.85; break;
                        case 4: percentage = 0.82; break;
                        case 5: percentage = 0.80; break;
                        case 6: percentage = 0.77; break;
                        case 7: percentage = 0.75; break;
                        case 8: percentage = 0.72; break;
                        case 9: percentage = 0.69; break;
                        case 10: percentage = 0.67; break;
                    }
                    break;
                case 7:
                    switch (reps)
                    {
                        case 1: percentage = 0.89; break;
                        case 2: percentage = 0.86; break;
                        case 3: percentage = 0.84; break;
                        case 4: percentage = 0.81; break;
                        case 5: percentage = 0.79; break;
                        case 6: percentage = 0.76; break;
                        case 7: percentage = 0.74; break;
                        case 8: percentage = 0.71; break;
                        case 9: percentage = 0.68; break;
                        case 10: percentage = 0.65; break;
                    }
                    break;
                case 5:
                    switch (reps)
                    {
                        case 1: percentage = 0.83; break;
                        case 2: percentage = 0.80; break;
                        case 3: percentage = 0.78; break;
                        case 4: percentage = 0.75; break;
                        case 5: percentage = 0.73; break;
                        case 6: percentage = 0.70; break;
                        case 7: percentage = 0.68; break;
                        case 8: percentage = 0.65; break;
                        case 9: percentage = 0.62; break;
                        case 10: percentage = 0.59; break;
                    }
                    break;
                case 3:
                    switch (reps)
                    {
                        case 1: percentage = 0.77; break;
                        case 2: percentage = 0.74; break;
                        case 3: percentage = 0.72; break;
                        case 4: percentage = 0.69; break;
                        case 5: percentage = 0.67; break;
                        case 6: percentage = 0.64; break;
                        case 7: percentage = 0.62; break;
                        case 8: percentage = 0.59; break;
                        case 9: percentage = 0.56; break;
                        case 10: percentage = 0.53; break;
                    }
                    break;
            }

            return percentage;
        }
    }
}
