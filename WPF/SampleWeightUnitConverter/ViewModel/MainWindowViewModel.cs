using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWeightUnitConverter {
    public class MainWindowViewModel:ViewModel {
        private double gramValue, poundValue;

        //▲ボタンで呼ばれるコマンド
        public ICommand PoundUnitToGram { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GramToPoundUnit { get; private set;}

        //上のコンボボックスで選択されている値
        public PoundUnit CurrentPoundUnit { get; set;}
        //下のコンボボックスで選択されている値
        public GramUnit CurrentGramUnit { get; set; }

        public double PoundValue { 
            get { return poundValue; } 
            set {
                poundValue = value;
                OnPropertyChanged();//値が変更されたら通知
            } 
        }

        public double GramValue {
            get { return gramValue; }
            set {
                gramValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        //コンストラクタ
        public MainWindowViewModel()
        {
            CurrentPoundUnit = PoundUnit.Units.First();
            CurrentGramUnit = GramUnit.Units.First();

            PoundUnitToGram = new DelegateCommand(() =>
                        GramValue = CurrentGramUnit.FromPoundUnit(CurrentPoundUnit, PoundValue));


            GramToPoundUnit = new DelegateCommand(()=>
                        PoundValue = CurrentPoundUnit.FromGramUnit(CurrentGramUnit, GramValue));
        }
    }
}
