﻿using System;

namespace ExtractorSharp.Command.ImgCommand {
    class ConvertFile : ICommand {
        public void Batch(params object[] args) {
            throw new NotImplementedException();
        }

        public bool CanUndo => true;

        public bool Changed => true;

        public string Name => throw new NotImplementedException();

        public void Do(params object[] args) {
            throw new NotImplementedException();
        }

        public void Redo() {
            throw new NotImplementedException();
        }

        public void RunScript(string arg) {
            throw new NotImplementedException();
        }

        public void Undo() {
            throw new NotImplementedException();
        }
    }
}