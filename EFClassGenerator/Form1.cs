using EFClassGenerator.Enum;
using EFClassGenerator.Helpers;
using EFClassGenerator.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace EFClassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCodeGeneratorType.DataSource = EnumHelpers.EnumToList<CodeGeneratorTypesEnum>();
        }

        private void ClearResults()
        {
            txtEntityOutput.Text = String.Empty;
            txtTypeConfigurationOutput.Text = String.Empty;
        }

        private void GenerateCodeForHubSpot(List<HubSpotModel> model)
        {
            foreach (var prop in model)
            {
                txtEntityOutput.Text += @$"

                    public {prop.DbColumnType} {prop.DbColumnName} {{get; set;}} // {prop.DbColumnAlias}

                ";

                txtTypeConfigurationOutput.Text += @$"

                    builder.Property(e => e.{prop.DbColumnName})
                        .HasColumnName(""{prop.DbColumnName}"");
                        .HasColumnType(""{prop.DbColumnType}"");

                ";
            }
        }

        private void GenerateCodeForColumnToEntity()
        {
            ClearResults();
            var text = txtInput.Text;
            text = text.Replace("\r\n", "");

            foreach (var prop in text.Split(','))
            {
                txtEntityOutput.Text += @$"

                    public string {prop} {{get; set;}}

                ";

                txtTypeConfigurationOutput.Text += @$"

                    builder.Property(e => e.{prop})
                        .HasColumnName(""{prop}"");
                        .HasColumnType(""string"");

                ";
            }
        }

        private void TryFixJson()
        {
            txtInput.Text = txtInput.Text.Trim();

            if (!txtInput.Text.StartsWith("["))
                txtInput.Text = $"[{txtInput.Text}";

            if (!txtInput.Text.EndsWith("]"))
                txtInput.Text = $"{txtInput.Text}]";
        }

        private void btnGenerateCode(object sender, EventArgs e)
        {
            try
            {
                var cbSelectedValue = (CodeGeneratorTypesEnum)cbCodeGeneratorType.SelectedValue;

                if (cbSelectedValue == CodeGeneratorTypesEnum.JsonToHubSpotCRM)
                {
                    TryFixJson();
                    var jsonObj = JsonConvert.DeserializeObject<List<HubSpotModel>>(txtInput.Text);

                    GenerateCodeForHubSpot(jsonObj);
                }
                else if (cbSelectedValue == CodeGeneratorTypesEnum.ColumnNameToEntity)
                    GenerateCodeForColumnToEntity();
                else
                    throw new Exception("Not implemented");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnCopyClipBoardEntityOutput_Click(object sender, EventArgs e) => Clipboard.SetText(txtEntityOutput.Text);

        private void btnCopyClipBoardTypeConfigurationOutput_Click(object sender, EventArgs e) => Clipboard.SetText(txtTypeConfigurationOutput.Text);

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var cbSelectedValue = (CodeGeneratorTypesEnum)cbCodeGeneratorType.SelectedValue;

            switch (cbSelectedValue)
            {
                case CodeGeneratorTypesEnum.JsonToHubSpotCRM:
                    JsonToHubSpotCRMExample();
                    break;

                case CodeGeneratorTypesEnum.ColumnNameToEntity:
                    ColumnNameToEntity();
                    break;
            }
        }

        private void JsonToHubSpotCRMExample()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Examples\JsonToHubSpotCRM.json");
            txtInput.Text = File.ReadAllText(path);
        }

        private void ColumnNameToEntity()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Examples\ColumnNameToEntity.txt");
            txtInput.Text = File.ReadAllText(path);
        }
    }
}