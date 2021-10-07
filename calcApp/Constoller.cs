using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcApp
{
    class Contoller
    {
        private String code;
        private String resultNum;
        private String calcNum;
        private String enteredNum;
        private bool isPushedDot;
        private bool isPushedCodeNow;
        private bool isPushedCodeBefore;
        private bool isPlus;
        private bool isPushedEqual;
        private const String err = "桁数が多すぎます";
        private const int baff = 10;
        private bool isPushedSpecialCode;
        //private List<int> specialCalcs;
        //private const int sqrt = 0;
        //private const int fraction = 1;
        //private const int sqr = 2;
        //private String[] before = { "√(", "1/", "sqr(" };
        //private String[] after = { ")", "", ")" };


        //電卓初期化処理
        public Contoller()
        {
            clear();
        }

        //数値押下処理
        public void enterNum(String inp)
        {
            //直前に計算記号が押されている場合
            if (this.isPushedCodeNow)
            {
                clearEnter();
                this.isPushedCodeNow = false;
            }

            //直前にイコールが押されていた時
            if (this.isPushedEqual)
            {
                clearEnter();
                setResultNum("");
                this.isPushedCodeNow = false;
                this.isPushedCodeBefore = false;
            }

            //入力値が0の場合は入力された数字にする
            if (enteredNum == "0")
            {
                setEnteredNum(inp);
            }
            else
            {
                setEnteredNum(this.enteredNum + inp);
            }
        }

        //小数処理
        public void enterDot(String inp)
        {
            if (isPushedCodeNow)
            {
                clearEnter();
            }
            if (!this.isPushedDot)
            {
                setEnteredNum(this.enteredNum + inp);
                this.isPushedDot = true;
            }
        }

        //enter部分の初期化処理
        public void clearEnter()
        {
            this.enteredNum = "0";
            this.isPushedDot = false;
            this.isPlus = true;
            this.isPushedEqual = false;
            isPushedSpecialCode = false;
            //specialCalcs = new List<int>();

        }

        //clear処理
        public void clear()
        {
            this.code = "";
            this.resultNum = "";
            this.isPushedCodeNow = false;
            this.isPushedCodeBefore = false;
            this.calcNum = "";
            clearEnter();
        }

        //計算符号押下処理
        public void enterCode(String inp)
        {

            //直前にイコールが押されていた時
            if (this.isPushedEqual)
            {
                setResultNum(getEnteredNum());
                clearEnter();
                this.isPushedCodeNow = false;
                this.isPushedCodeBefore = false;
                setEnteredNum(getResultNum());
            }

            //現計算処理内で計算記号が押されていて、直前に計算記号が押されていない時
            if (!this.isPushedCodeNow && this.isPushedCodeBefore)
            {
                this.calcNum = getEnteredNum();
                setResultNum(calc());
                setEnteredNum(getResultNum());
            }
            //一度も押されていない時
            else
            {
                setResultNum(getEnteredNum());
            }
            
            this.code = inp;
            this.isPushedCodeNow = true;
            this.isPushedEqual = false;
            this.isPushedCodeBefore = true;
        }

        //イコール押下処理
        public void enterEqual()
        {
            if (!this.isPushedSpecialCode)
            {
                //計算記号が現計算処理内で押されていた場合
                if (this.isPushedCodeBefore)
                {
                    if (this.isPushedEqual)
                    {
                        setResultNum(getEnteredNum());
                    }
                    else
                    {
                        this.calcNum = getEnteredNum();
                        if (this.calcNum == "")
                        {
                            this.calcNum = getResultNum();
                        }
                    }

                }
                else
                {
                    setResultNum(getEnteredNum());
                }

                setEnteredNum(calc());
            }
            
            this.isPushedEqual = true;
        }

        //1文字削除処理
        public void backEnterNum()
        {
            
            if (isPushedCodeNow) return;

            //表示されている数値が一桁の時
            if ((isPlus && enteredNum.Length - 1 == 0)
                || (!isPlus && enteredNum.Length - 1 == 1))
            {
                setEnteredNum("0");
                isPlus = true;
            }
            //それ以外
            else
                setEnteredNum(enteredNum.Remove(enteredNum.Length - 1));
        }

        //プラスマイナスの変換処理
        public void changePM()
        {
            if (enteredNum == "0") return;
            if (isPlus)
            {
                setEnteredNum(getEnteredNum().Insert(0, "-"));
                isPlus = false;
            }
            else
            {
                setEnteredNum(getEnteredNum().Remove(0,1));
                isPlus = true;
            }
        }

        public void enterSqr()
        {
            Double num;
            if (!Double.TryParse(getEnteredNum(), out num)) return;
            String ans = Math.Pow(num, 2).ToString();
            //setEnteredNum(ans.Substring(0, (ans.Length >= 7) ? 7 : ans.Length));
            setEnteredNum(ans);
            isPushedSpecialCode = true;
            enterEqual();
        }

        public void enterSqrt()
        {
            Double num;
            if (!Double.TryParse(getEnteredNum(), out num)) return;
            String ans = Math.Sqrt(num).ToString();
            setEnteredNum(ans.Substring(0,(ans.Length >= 7) ? 7: ans.Length));
            //Console.WriteLine(this.enteredNum);
            isPushedSpecialCode = true;
            enterEqual();
        }

        public void enterFraction()
        {
            Double num;
            if (!Double.TryParse(getEnteredNum(), out num)) return;
            String ans = (1 / num).ToString();
            setEnteredNum(ans.Substring(0, (ans.Length >= 7) ? 7 : ans.Length));
            isPushedSpecialCode = true;
            enterEqual();
        }

        //計算処理
        public String calc()
        {
            double ans = 0;
            double result, calc;
            if(!Double.TryParse(getResultNum(), out result))return err;
            if(!Double.TryParse(calcNum, out calc))return err;
            switch (this.code)
            {
                case "＋":
                    ans = result + calc;
                    break;
                case "ー":
                    ans = result - calc;
                    break;
                case "×":
                    ans = result * calc;
                    break;
                case "÷":
                    ans = result / calc;
                    break;
                default:
                    ans = Double.Parse(this.getResultNum());
                    break;
            }
            return ans.ToString();
        }

        //ゲッター
        public String getEnteredNum()
        {
            return this.enteredNum;
        }

        public String getResultNum()
        {
            return this.resultNum;
        }

        //途中式出力処理
        public String getFormula()
        {
            
            String oup = "";
            if (getResultNum() == err || getEnteredNum() == err) return oup;

            //左から出力される順番に変数に文字が格納されているか確認し、されているところまでを出力する
            if (getResultNum() != "")
            {
                oup += getResultNum();
                if(this.code != "") {
                    oup += " " + code;
                    oup += (isPushedEqual) ? " " + this.calcNum + " " + "=" : "";
                }
            }
            
            return oup;
            
        }


        //セッター
        private void setEnteredNum(String enteredNum)
        {
            this.enteredNum = (enteredNum.Length >= baff || this.enteredNum == err) 
                ? err : enteredNum;
   
        }

        private void setResultNum(String resultNum)
        {
            if(resultNum.Length >= baff || this.resultNum == err)
            {
                this.resultNum = "";
                this.enteredNum = err;
            }
            this.resultNum = resultNum;
        }

        

    }
}
