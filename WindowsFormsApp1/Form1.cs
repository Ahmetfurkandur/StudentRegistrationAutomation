using Business.Abstract;
using Business.Concrete;
using Business.DependecyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Bu Proje Katmanlı mimariyi denediğim ilk proje
        //Referans kaynağım Btk Akademi C# kursu ve youtubedaki entity framework kullanarak login sistemi yapan bir kanal.
        //Umarım faydalı olmuştur :)


        public Form1()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
        }
        private IStudentService _studentService;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }

        private void tbxTcIdentityNoSearch_TextChanged(object sender, EventArgs e)
        {
            //Bu Kod Tc kimlik Numarasına Göre arama yapmanızı sağlar eğer textboxta veri yoksa tüm ürünleri gösterir
            try
            {
                if (String.IsNullOrEmpty(tbxTcIdentityNoSearch.Text))
                {
                    LoadStudents();
                }
                else
                {
                    dgwStudents.DataSource = _studentService.GetStudentsByTcIdentityNo(Int64.Parse(tbxTcIdentityNoSearch.Text));
                }


            }
            catch
            {

            }
        }

        private void tbxStudentNameSearch_TextChanged(object sender, EventArgs e)
        {
            // Bu kodda aynı şekilde isime göre arama yapmanızı sağlar.
            try
            {
                if (String.IsNullOrEmpty(tbxStudentNameSearch.Text))
                {
                    LoadStudents();
                }
                else
                {
                    dgwStudents.DataSource = _studentService.GetStudentsByStudentName(tbxStudentNameSearch.Text);
                }


            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _studentService.Add(new Student
            {
                TcIdentityNo = Convert.ToInt64(tbxTcIdentityNo.Text),
                Name = tbxName.Text,
                Surname = tbxSurname.Text,
                BirthdayDate = Convert.ToDateTime(tbxBirthdayDate.Text),
                ParentName = tbxParentsName.Text,
                ParentSurname = tbxParentsSurname.Text,
                ParentsPhoneNumber = Convert.ToInt64(tbxPhoneNumber.Text)
            });
            LoadStudents();
            MessageBox.Show("Öğrenci Başarıyla Eklendi!");
            
            
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagriddeki Cellere tıkladığınızda degerlere Update işlemindeki textboxlara veri gider.
            //Hata Olursa 101. satırı İncele
            tbxTcIdentityNoUpdate.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
            
            tbxNameUpdate.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
            tbxSurnameUpdate.Text = dgwStudents.CurrentRow.Cells[3].Value.ToString();
            tbxBirthdayDateUpdate.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();
            tbxParentNameUpdate.Text = dgwStudents.CurrentRow.Cells[5].Value.ToString();
            tbxParentsSurnameUpdate.Text = dgwStudents.CurrentRow.Cells[6].Value.ToString();
            tbxParentsPhoneNumberUpdate.Text = dgwStudents.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Güncelleme İşleminin Yapılması.
            _studentService.Update(new Student
            {
                Id = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value),
                TcIdentityNo = Convert.ToInt64(tbxTcIdentityNoUpdate.Text),
                Name = tbxNameUpdate.Text,
                Surname = tbxSurnameUpdate.Text,
                BirthdayDate = Convert.ToDateTime(tbxBirthdayDateUpdate.Text),
                ParentName = tbxParentNameUpdate.Text,
                ParentSurname = tbxParentsSurnameUpdate.Text,
                ParentsPhoneNumber = Convert.ToInt64(tbxParentsPhoneNumberUpdate.Text)
            });
            LoadStudents();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _studentService.Delete(new Student
            {
                Id = Convert.ToInt32( dgwStudents.CurrentRow.Cells[0].Value)
            });
            LoadStudents();
            MessageBox.Show("Öğrenci Başarıyla Silindi!");
        }
    }
}
