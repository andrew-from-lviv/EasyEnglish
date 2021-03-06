﻿using System;
using EasyEnglish.Models;

namespace EasyEnglish.ViewModels {
    public class ReviewViewModel : AbstractViewModel {
        public ReviewViewModel(int itemsPerPage, int pageSkip)
            : base(itemsPerPage, pageSkip) { }

        public ReviewViewModel() { }

        public Card ViewCard { get; set; }
        public DateTime? QuestionedAt { get; set; }
        public TimeSpan AnswerTime { get; set; }

        public string ReviewMode { get; set; }
        
        public string MyAnswer { get; set; }
        public bool IsPerfect { get; set; }
        public int? MissIndex { get; set; }

        public string Hint { get; set; }
        public string Blank { get; set; }
        public char? BlankAnswer { get; set; }
    }
}
