﻿using System.Windows.Shapes;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Abstractions.DataSeries;
using LiveCharts.Core.Coordinates;
using LiveCharts.Core.Data;
using LiveCharts.Core.DataSeries.Data;
using LiveCharts.Core.ViewModels;
using LiveCharts.Wpf.Controls;
using LiveCharts.Wpf.Views;

namespace LiveCharts.Wpf.Providers
{
    /// <summary>
    /// The bar view provider class.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="ISeriesViewProvider{TModel,TCoordinate,TViewModel}" />
    public class BarSeriesViewProvider<TModel> : ISeriesViewProvider<TModel, Point, BarViewModel>
    {
        public void OnUpdateStarted(IChartView chart, ISeries series)
        {
        }

        public IPointView<TModel, Point<TModel, Point, BarViewModel>, Point, BarViewModel> GetNewPointView()
        {
            return new BarPointView<TModel, Point<TModel, Point, BarViewModel>, Rectangle, DataLabel>();
        }

        public void OnUpdateFinished(IChartView chart, ISeries series)
        {
        }
    }
}