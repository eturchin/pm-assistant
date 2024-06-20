using Microsoft.Office.Tools.Ribbon;
using System;
using System.Linq;
using MSProject = Microsoft.Office.Interop.MSProject;

namespace ProjectAssignee
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void buttonAssign_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var app = Globals.ThisAddIn.Application;
                var project = app.ActiveProject;

                if (project != null)
                {
                    var resource = project.Resources
                                       .Cast<MSProject.Resource>()
                                       .FirstOrDefault(res => res.Name == "Турчин") ??
                                   project.Resources.Add("Турчин");


                    foreach (MSProject.Task task in project.Tasks)
                    {
                        var taskLowerName = task.Name.ToLower();

                        if (task.Name != null && taskLowerName.Contains("исполнитель"))
                        {
                            task.Assignments.Add(task.ID, resource.ID);
                        }

                    }

                    System.Windows.Forms.MessageBox.Show("Ресурс назначен на задачи со словом 'исполнитель'.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Откройте проект для выполнения этой операции.");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
