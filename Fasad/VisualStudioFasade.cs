using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad
{
    class VisualStudioFasade
    {
        private TextEditor textEditor = new TextEditor();
        private Compiler compiler = new Compiler();
        private CLR clr = new CLR();

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiler.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }
}
