﻿using System;

class Solution
{

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip = (tip_percent  * .01) * meal_cost;

        double tax = (tax_percent  * .01) * meal_cost;

        double meal_total = meal_cost + tip + tax;

        Console.WriteLine(Math.Round(meal_total));

    }

    static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);

    }
}