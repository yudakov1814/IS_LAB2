using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_LAB2
{
    public partial class Form1 : Form
    {
        // алфавит
        const string GA_TABLE = " абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string GA_TARGET; // целевое слово
        private int GA_SIZE; // размер популяции
        private int GA_MAXITER; // максимальное число итераций
        private double GA_BEST; // лучшие
        private double GA_MUT; // мутации

        private Random random = new Random();
        List<GaStruct> cur_population;
        List<GaStruct> next_population;
        int i;

        class GaStruct
        {
            public StringBuilder str; // строка
            public int rating = 0; // пригодность
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            GA_TARGET = WordTextBox.Text;
            GA_SIZE = (int)SizeNumericUpDown.Value;
            GA_MAXITER = (int)IterNumericUpDown.Value;
            GA_BEST = (double)BestNumericUpDown.Value;
            GA_MUT = (double)MutNumericUpDown.Value;

            Chart.Series[0].Points.Clear();
            LogListBox.Items.Clear();

            cur_population = new List<GaStruct>();
            next_population = new List<GaStruct>();

            FirstPopulation(cur_population, next_population); // формирование первой (начальной) популяции
            i = 0;

            Timer.Enabled = true;
        }

        private void UpdateForm(List<GaStruct> pop, int iter_num)
        {
            Chart.Series[0].Points.AddXY(iter_num, pop[0].rating);
            CurIterNum.Text = iter_num.ToString();
            CurrentWord.Text = pop[0].str + " (" + pop[0].rating + ")";
            LogListBox.Items.Add(CurIterNum.Text + ": " + CurrentWord.Text);
        }

        // формирование первой (начальной) популяции
        private void FirstPopulation(List<GaStruct> cur_population, List<GaStruct> next_population)
        {
            var target_size = GA_TARGET.Length;

            for (int i = 0; i < GA_SIZE; i++)
            {
                // формиирование хромосом
                var chromosoma_str = new StringBuilder("");
                for (int j = 0; j < target_size; j++)
                {
                    chromosoma_str.Append(GA_TABLE[(int)(random.NextDouble() * GA_TABLE.Length)]);
                }

                var chromosoma = new GaStruct
                {
                    str = chromosoma_str
                };

                cur_population.Add(chromosoma);
                next_population.Add(chromosoma);
            }
        }

        // оценка популяции (пригодность)
        private void CalcRating(List<GaStruct> population)
        {
            for (var i = 0; i < GA_SIZE; i++)
            {
                var rating = 0;
                for (var j = 0; j < GA_TARGET.Length; j++)
                {
                    // Округляем результат до целого для ускорения вычислений
                    rating += Math.Abs((population[i].str[j] - GA_TARGET[j]));
                }

                population[i].rating = rating;
            }
        }

        // селекция
        private void Selection(List<GaStruct> cur_population, List<GaStruct> next_population, int best_size)
        {
            for (var i = 0; i < best_size; i++)
            {
                next_population[i].str = cur_population[i].str;
                next_population[i].rating = cur_population[i].rating;
            }
        }

        // мутация
        private void Mutate(GaStruct member)
        {
            var ipos = (int)random.NextDouble() * GA_TARGET.Length;
            member.str[ipos] = GA_TABLE[(int)(random.NextDouble() * GA_TARGET.Length)];
        }

        // селекция, скрещивание, мутация
        private void Mate(List<GaStruct> cur_population, List<GaStruct> next_population)
        {
            var best_size = (int)(GA_SIZE * GA_BEST);
            var target_size = GA_TARGET.Length;
            int rand_target;
            int p1;
            int p2;

            // селекция
            Selection(cur_population, next_population, best_size);


            for (int i = best_size; i < GA_SIZE; i++)
            {
                p1 = (int)(random.NextDouble() * (GA_SIZE / 2));
                p2 = (int)(random.NextDouble() * (GA_SIZE / 2));
                rand_target = (int)(random.NextDouble() * target_size);

                // скрещивание
                var left = cur_population[p1].str.ToString(0, rand_target);
                var right = cur_population[p2].str.ToString(rand_target, GA_TARGET.Length - rand_target);

                next_population[i].str = new StringBuilder(left);
                next_population[i].str.Append(right);

                // мутация
                if (random.NextDouble() < GA_MUT)
                {
                    Mutate(next_population[i]);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i == GA_MAXITER)
            {
                Timer.Enabled = false;
            }

            CalcRating(cur_population); // оцениваем популяцию
                                         // сортируем популяцию по пригодности
            cur_population.Sort(delegate (GaStruct x, GaStruct y)
            {
                return x.rating.CompareTo(y.rating);
            });

            UpdateForm(cur_population, i); // выводим лучшую популяцию

            if ((cur_population)[0].rating == 0)
            {
                Timer.Enabled = false;
            }

            Mate(cur_population, next_population); // спариваем популяции
            (cur_population, next_population) = (next_population, cur_population); // очищаем буферы

            i++;
        }
    }
}
