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
                // 取得輸入的訓練重量和次數
                double weight = Convert.ToDouble(weightTextBox.Text);
                int reps = Convert.ToInt32(repsTextBox.Text);

                // 估算1RM
                double estimated1RM = Estimate1RMWeight(weight, reps);

                // 轉換為整數
                int int1RM = Convert.ToInt32(estimated1RM);

                // 顯示結果
                resultTextBlock.Text = $"根據您的訓練，估算的1RM重量為：{int1RM} kg";
            }
            catch (Exception ex)
            {
                resultTextBlock.Text = "輸入不合法，請確保輸入的是有效的數字。";
            }
        }

        private double Estimate1RMWeight(double weight, int reps)
        {
            // 根據次數的百分比估算1RM
            double percentage = 0;

            if (reps == 1)
                percentage = 1.0;
            else if (reps == 2)
                percentage = 0.96;
            else if (reps == 3)
                percentage = 0.92;
            else if (reps == 4)
                percentage = 0.89;
            else if (reps == 5)
                percentage = 0.86;
            else if (reps == 6)
                percentage = 0.84;
            else if (reps == 7)
                percentage = 0.81;
            else if (reps == 8)
                percentage = 0.78;
            else if (reps == 9)
                percentage = 0.76;
            else if (reps == 10)
                percentage = 0.74;

            // 直接轉換為整數部分
            return (int)((1/ percentage) * weight);
        }
    }
}
