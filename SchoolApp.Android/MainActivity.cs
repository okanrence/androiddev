using Android.App;
using Android.Widget;
using Android.OS;
using SchoolApp.Core;
using Android.Content;

namespace SchoolApp.Android
{
    [Activity(Label = "SchoolApp", MainLauncher = true, Icon = "@drawable/icon", Theme = "@values/theme.xml")]
    public class MainActivity : Activity
    {
        private EditText txtName;
        private EditText txtEmail;
        private EditText txtDateOfBirth;
        private EditText txtPhone;
        private EditText txtHomeAddress;
        private EditText txtPassword;
        private EditText txtConfirmPassword;
        private Button btnSubmit;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            FindViews();

            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
          var value =  GetValues();
            var intent = new Intent(this, typeof(ViewDetailsActivity));
            intent.PutExtra("StudentName", value.Name);
            intent.PutExtra("StudentEmail", value.Email);
            StartActivity(intent);

        }

        private void FindViews()
        {
            txtName = FindViewById<EditText>(Resource.Id.txtName);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtHomeAddress = FindViewById<EditText>(Resource.Id.txtHomeAddress);
            txtPhone = FindViewById<EditText>(Resource.Id.txtPhone);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            txtConfirmPassword = FindViewById<EditText>(Resource.Id.txtConfirmPasswird);
            btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
        }

        private Student GetValues()
        {
            var student = new Student
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                HomeAddress = txtHomeAddress.Text,
                Password = txtPassword.Text,
                PhoneNumber = txtPassword.Text,
                StudentID = 1
            };

            return student;
        }


    }
}

