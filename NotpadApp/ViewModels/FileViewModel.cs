using NotpadApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotpadApp.ViewModels
{
    public class FileViewModel
    {
        public DocumentModel Document { get; set; }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
        }
    }
}
