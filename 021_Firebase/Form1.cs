using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _021_Firebase
{
  public partial class Form1 : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "GrhH4F0XaH46BdrTMVhz2VWTbWN5iBS3XNg4aCuE",
      BasePath = "https://csfirebase-e3e0d-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);
      if (client != null)
        MessageBox.Show("Connection 성공!");
    }

    private async void btnInsert_Click(object sender, EventArgs e)
    {
      // Data 클래스를 만들 것
      var data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      SetResponse response = await 
        client.SetAsync("VP02_Phonebook/" + txtId.Text, data);
      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data Inserted : Id = " + result.Id);

    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtId.Text = "";
      txtSId.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
      FirebaseResponse response = await
        client.GetAsync("VP02_Phonebook/" + txtId.Text);
      Data obj = response.ResultAs<Data>(); 

      txtId.Text = obj.Id;
      txtSId.Text = obj.SId;  
      txtName.Text = obj.Name;  
      txtPhone.Text = obj.Phone;

      MessageBox.Show("Data retrieved successfully!");
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      var data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      FirebaseResponse response = await
        client.UpdateAsync("VP02_Phonebook/" + txtId.Text, data);
      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data Updated at " + result.Id);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      FirebaseResponse response = await
        client.DeleteAsync("VP02_Phonebook/" + txtId.Text);
      MessageBox.Show("Deleted! : id = " + txtId.Text);
      txtId.Text = "";
      txtSId.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
    }

    // 모두 삭제 : 메시지박스에서 확인 필요
    private async void btnDeleteAll_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show(
        "저장된 데이터가 모두 삭제됩니다. 계속할까요?",
        "Warning!", MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

      if (result == DialogResult.No)
        return;

      FirebaseResponse response = await
        client.DeleteAsync("VP02_Phonebook");
      MessageBox.Show("All Data deleted /VP02_Phonebook");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
