using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace DevDataGrid.UserControls
{
    public partial class TrueNorthDataGrid : UserControl
    {
        public TrueNorthDataGrid()
        {
            InitializeComponent();
        }

        // ItemsSource property
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
                "ItemsSource",
                typeof(IEnumerable),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(null, OnItemsSourceChanged));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TrueNorthDataGrid)d;
            control.MainDataGrid.ItemsSource = e.NewValue as IEnumerable;
        }

        // AutoGenerateColumns property
        public static readonly DependencyProperty AutoGenerateColumnsProperty =
            DependencyProperty.Register(
                "AutoGenerateColumns",
                typeof(bool),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(true, OnAutoGenerateColumnsChanged));

        public bool AutoGenerateColumns
        {
            get { return (bool)GetValue(AutoGenerateColumnsProperty); }
            set { SetValue(AutoGenerateColumnsProperty, value); }
        }

        private static void OnAutoGenerateColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TrueNorthDataGrid)d;
            control.MainDataGrid.AutoGenerateColumns = (bool)e.NewValue;
        }

        // Columns property
        public ObservableCollection<DataGridColumn> Columns
        {
            get { return MainDataGrid.Columns; }
        }
    }
}