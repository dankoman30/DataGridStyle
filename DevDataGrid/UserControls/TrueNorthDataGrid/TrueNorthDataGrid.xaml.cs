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

        #region Font Properties
        // Header Font Properties
        public static readonly DependencyProperty HeaderFontFamilyProperty =
            DependencyProperty.Register(
                "HeaderFontFamily",
                typeof(FontFamily),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new FontFamily("Segoe UI")));

        public FontFamily HeaderFontFamily
        {
            get { return (FontFamily)GetValue(HeaderFontFamilyProperty); }
            set { SetValue(HeaderFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontSizeProperty =
            DependencyProperty.Register(
                "HeaderFontSize",
                typeof(double),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(14.0));

        public double HeaderFontSize
        {
            get { return (double)GetValue(HeaderFontSizeProperty); }
            set { SetValue(HeaderFontSizeProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontWeightProperty =
            DependencyProperty.Register(
                "HeaderFontWeight",
                typeof(FontWeight),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontWeights.SemiBold));

        public FontWeight HeaderFontWeight
        {
            get { return (FontWeight)GetValue(HeaderFontWeightProperty); }
            set { SetValue(HeaderFontWeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontStyleProperty =
            DependencyProperty.Register(
                "HeaderFontStyle",
                typeof(FontStyle),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontStyles.Normal));

        public FontStyle HeaderFontStyle
        {
            get { return (FontStyle)GetValue(HeaderFontStyleProperty); }
            set { SetValue(HeaderFontStyleProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontStretchProperty =
            DependencyProperty.Register(
                "HeaderFontStretch",
                typeof(FontStretch),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontStretches.Normal));

        public FontStretch HeaderFontStretch
        {
            get { return (FontStretch)GetValue(HeaderFontStretchProperty); }
            set { SetValue(HeaderFontStretchProperty, value); }
        }

        // Cell Font Properties
        public static readonly DependencyProperty CellFontFamilyProperty =
            DependencyProperty.Register(
                "CellFontFamily",
                typeof(FontFamily),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(new FontFamily("Segoe UI")));

        public FontFamily CellFontFamily
        {
            get { return (FontFamily)GetValue(CellFontFamilyProperty); }
            set { SetValue(CellFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty CellFontSizeProperty =
            DependencyProperty.Register(
                "CellFontSize",
                typeof(double),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(12.0));

        public double CellFontSize
        {
            get { return (double)GetValue(CellFontSizeProperty); }
            set { SetValue(CellFontSizeProperty, value); }
        }

        public static readonly DependencyProperty CellFontWeightProperty =
            DependencyProperty.Register(
                "CellFontWeight",
                typeof(FontWeight),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontWeights.Normal));

        public FontWeight CellFontWeight
        {
            get { return (FontWeight)GetValue(CellFontWeightProperty); }
            set { SetValue(CellFontWeightProperty, value); }
        }

        public static readonly DependencyProperty CellFontStyleProperty =
            DependencyProperty.Register(
                "CellFontStyle",
                typeof(FontStyle),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontStyles.Normal));

        public FontStyle CellFontStyle
        {
            get { return (FontStyle)GetValue(CellFontStyleProperty); }
            set { SetValue(CellFontStyleProperty, value); }
        }

        public static readonly DependencyProperty CellFontStretchProperty =
            DependencyProperty.Register(
                "CellFontStretch",
                typeof(FontStretch),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(FontStretches.Normal));

        public FontStretch CellFontStretch
        {
            get { return (FontStretch)GetValue(CellFontStretchProperty); }
            set { SetValue(CellFontStretchProperty, value); }
        }

        // Text Alignment Properties
        public static readonly DependencyProperty HeaderTextAlignmentProperty =
            DependencyProperty.Register(
                "HeaderTextAlignment",
                typeof(TextAlignment),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(TextAlignment.Left));

        public TextAlignment HeaderTextAlignment
        {
            get { return (TextAlignment)GetValue(HeaderTextAlignmentProperty); }
            set { SetValue(HeaderTextAlignmentProperty, value); }
        }

        public static readonly DependencyProperty CellTextAlignmentProperty =
            DependencyProperty.Register(
                "CellTextAlignment",
                typeof(TextAlignment),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(TextAlignment.Left));

        public TextAlignment CellTextAlignment
        {
            get { return (TextAlignment)GetValue(CellTextAlignmentProperty); }
            set { SetValue(CellTextAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderHorizontalAlignmentProperty =
            DependencyProperty.Register(
                "HeaderHorizontalAlignment",
                typeof(HorizontalAlignment),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(HorizontalAlignment.Left));

        public HorizontalAlignment HeaderHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(HeaderHorizontalAlignmentProperty); }
            set { SetValue(HeaderHorizontalAlignmentProperty, value); }
        }

        public static readonly DependencyProperty CellHorizontalAlignmentProperty =
            DependencyProperty.Register(
                "CellHorizontalAlignment",
                typeof(HorizontalAlignment),
                typeof(TrueNorthDataGrid),
                new PropertyMetadata(HorizontalAlignment.Left));

        public HorizontalAlignment CellHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(CellHorizontalAlignmentProperty); }
            set { SetValue(CellHorizontalAlignmentProperty, value); }
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