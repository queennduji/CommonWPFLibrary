using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommonLibrary.CustomUserControls
{
    /// <summary>
    /// Interaction logic for LabelTextControl.xaml
    /// </summary>
    public partial class LabelTextControl : UserControl, IDataErrorInfo
    {
        public LabelTextControl()
        {
            InitializeComponent();
            LayRoot.DataContext = this;
        }

        /// <summary>
        /// Dependency property for the top label text
        /// </summary>
        public string TopLabelText
        {
            get { return (string)GetValue(TopLabelTextProperty); }
            set { SetValue(TopLabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TopLabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TopLabelTextProperty =
            DependencyProperty.Register("TopLabelText", typeof(string), typeof(LabelTextControl), new PropertyMetadata(string.Empty));



        public string LeftLabelText
        {
            get { return (string)GetValue(LeftLabelTextProperty); }
            set { SetValue(LeftLabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftLabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftLabelTextProperty =
            DependencyProperty.Register("LeftLabelText", typeof(string), typeof(LabelTextControl), new PropertyMetadata(String.Empty));

        /// <summary>
        /// Dependency property for the text box
        /// </summary>
        public string InputBoxText
        {
            get { return (string)GetValue(InputBoxTextProperty); }
            set { SetValue(InputBoxTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InputBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InputBoxTextProperty =
            DependencyProperty.Register("InputBoxText", typeof(string), typeof(LabelTextControl), new PropertyMetadata(string.Empty));




        public Visibility LeftLabelVisibility
        {
            get { return (Visibility)GetValue(LeftLabelVisibilityProperty); }
            set { SetValue(LeftLabelVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftLabelVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftLabelVisibilityProperty =
            DependencyProperty.Register("LeftLabelVisibility", typeof(Visibility), typeof(LabelTextControl), new PropertyMetadata(System.Windows.Visibility.Visible));



        public Visibility TopLabelVisibility
        {
            get { return (Visibility)GetValue(TopLabelVisibilityProperty); }
            set { SetValue(TopLabelVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TopLabelVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TopLabelVisibilityProperty =
            DependencyProperty.Register("TopLabelVisibility", typeof(Visibility), typeof(LabelTextControl), new PropertyMetadata(System.Windows.Visibility.Visible));










    }
}
