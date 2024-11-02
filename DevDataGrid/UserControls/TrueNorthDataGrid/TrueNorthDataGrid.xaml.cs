using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevDataGrid.UserControls
{
    public partial class TrueNorthDataGrid : UserControl
    {
        public TrueNorthDataGrid()
        {
            InitializeComponent();
        }

        #region Original Properties
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

        public ObservableCollection<DataGridColumn> Columns
        {
            get { return MainDataGrid.Columns; }
        }
        #endregion

        #region Layout Properties
        public static readonly DependencyProperty GridBorderThicknessProperty =
            DependencyProperty.Register(
                "GridBorderThickness",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(0)));

        public Thickness GridBorderThickness
        {
            get { return (Thickness)GetValue(GridBorderThicknessProperty); }
            set { SetValue(GridBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty RowHeightProperty =
            DependencyProperty.Register(
                "RowHeight",
                typeof(double),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(40.0));

        public double RowHeight
        {
            get { return (double)GetValue(RowHeightProperty); }
            set { SetValue(RowHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderCornerRadiusProperty =
            DependencyProperty.Register(
                "HeaderCornerRadius",
                typeof(CornerRadius),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new CornerRadius(8)));

        public CornerRadius HeaderCornerRadius
        {
            get { return (CornerRadius)GetValue(HeaderCornerRadiusProperty); }
            set { SetValue(HeaderCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty RowCornerRadiusProperty =
            DependencyProperty.Register(
                "RowCornerRadius",
                typeof(CornerRadius),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new CornerRadius(8)));

        public CornerRadius RowCornerRadius
        {
            get { return (CornerRadius)GetValue(RowCornerRadiusProperty); }
            set { SetValue(RowCornerRadiusProperty, value); }
        }
        #endregion

        #region Margin Properties
        public static readonly DependencyProperty GridMarginProperty =
            DependencyProperty.Register(
                "GridMargin",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(10)));

        public Thickness GridMargin
        {
            get { return (Thickness)GetValue(GridMarginProperty); }
            set { SetValue(GridMarginProperty, value); }
        }

        public static readonly DependencyProperty HeaderMarginProperty =
            DependencyProperty.Register(
                "HeaderMargin",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(5, 3, 5, 3)));

        public Thickness HeaderMargin
        {
            get { return (Thickness)GetValue(HeaderMarginProperty); }
            set { SetValue(HeaderMarginProperty, value); }
        }

        public static readonly DependencyProperty HeaderContentMarginProperty =
            DependencyProperty.Register(
                "HeaderContentMargin",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(10, 10, 10, 10)));

        public Thickness HeaderContentMargin
        {
            get { return (Thickness)GetValue(HeaderContentMarginProperty); }
            set { SetValue(HeaderContentMarginProperty, value); }
        }

        public static readonly DependencyProperty RowMarginProperty =
            DependencyProperty.Register(
                "RowMargin",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(5, 3, 5, 3)));

        public Thickness RowMargin
        {
            get { return (Thickness)GetValue(RowMarginProperty); }
            set { SetValue(RowMarginProperty, value); }
        }

        public static readonly DependencyProperty CellPaddingProperty =
            DependencyProperty.Register(
                "CellPadding",
                typeof(Thickness),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new Thickness(10, 0, 10, 0)));

        public Thickness CellPadding
        {
            get { return (Thickness)GetValue(CellPaddingProperty); }
            set { SetValue(CellPaddingProperty, value); }
        }
        #endregion


        #region Color Properties
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.Register(
                "BackgroundColor",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(18, 18, 18)));

        public Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public static readonly DependencyProperty ForegroundColorProperty =
            DependencyProperty.Register(
                "ForegroundColor",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(221, 221, 221)));

        public Color ForegroundColor
        {
            get { return (Color)GetValue(ForegroundColorProperty); }
            set { SetValue(ForegroundColorProperty, value); }
        }

        public static readonly DependencyProperty HeaderBackgroundColorProperty =
            DependencyProperty.Register(
                "HeaderBackgroundColor",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(107, 91, 197)));

        public Color HeaderBackgroundColor
        {
            get { return (Color)GetValue(HeaderBackgroundColorProperty); }
            set { SetValue(HeaderBackgroundColorProperty, value); }
        }

        public static readonly DependencyProperty RowHoverColorProperty =
            DependencyProperty.Register(
                "RowHoverColor",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(45, 45, 45)));

        public Color RowHoverColor
        {
            get { return (Color)GetValue(RowHoverColorProperty); }
            set { SetValue(RowHoverColorProperty, value); }
        }

        public static readonly DependencyProperty AlternateRow1ColorProperty =
            DependencyProperty.Register(
                "AlternateRow1Color",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(30, 30, 30)));

        public Color AlternateRow1Color
        {
            get { return (Color)GetValue(AlternateRow1ColorProperty); }
            set { SetValue(AlternateRow1ColorProperty, value); }
        }

        public static readonly DependencyProperty AlternateRow2ColorProperty =
            DependencyProperty.Register(
                "AlternateRow2Color",
                typeof(Color),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(Color.FromRgb(53, 53, 53)));

        public Color AlternateRow2Color
        {
            get { return (Color)GetValue(AlternateRow2ColorProperty); }
            set { SetValue(AlternateRow2ColorProperty, value); }
        }
        #endregion
    }
}