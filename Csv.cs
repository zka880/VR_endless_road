using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class Csv : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        /*
        // ファイル書き出し
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        StreamWriter sw = new StreamWriter(@"saveData.csv", false, Encoding.GetEncoding("Shift_JIS"));
        // ヘッダー出力
        string[] s1 = { "time", "x","y","z" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);

        sw.Close();
        

        // ファイル読み込み
        // 引数説明：第1引数→ファイル読込先, 第2引数→エンコード
        StreamReader sr = new StreamReader(@"saveData.csv", Encoding.GetEncoding("Shift_JIS"));
        string line;
        // 行がnullじゃない間(つまり次の行がある場合は)、処理をする
        while ((line = sr.ReadLine()) != null)
        {
            // コンソールに出力
            Debug.Log(line);
        }
        // StreamReaderを閉じる
        sr.Close();
        */
        //onetimepos = transform.position;
        //time1 = 0;
        //GameObject.Find("CSVoutput").GetComponent<Button>().interactable = true;
    }

    //private Vector3 onetimepos;
    //private float time1;
    private float v;
    private float s;
    public bool saves;
    //private double savetime;
    private  int csvtriggerr;
    public GameObject VRUIenter;
    private string DataName;
    byte filenum_1 = 0;
    byte filenum_10 = 0;
    byte filenum_100 = 0;
    public GameObject PCUIstart;
    public GameObject dataname;
    //public Maxhight maxhight;
    // Update is called once per frame
    void Update()
    {
        //csvtriggerr = GameObject.Find("enter").GetComponent<VRUIcontrol>().csvtrigger;
        //Debug.Log(GameObject.Find("InputField").GetComponent<InputField>().text);
        csvtriggerr = VRUIenter.GetComponent<VRUIcontrol>().csvtrigger;

        if (saves)
        {
           
            if (csvtriggerr == 1)
            {
                //onetimepos = transform.position;
                v = VRUIenter.GetComponent<VRUIcontrol>().vas;
                s = VRUIenter.GetComponent<VRUIcontrol>().sence;
                //StreamWriter sw = new StreamWriter(DataName, true, Encoding.GetEncoding("Shift_JIS"));
                StreamWriter sw = new StreamWriter(DataName, true);
                //string[] onepos = { time1.ToString(), onetimepos.x.ToString(), onetimepos.y.ToString(), onetimepos.z.ToString() };
                string[] n = { s.ToString(), v.ToString() };
                string poslog = string.Join(",", n);
                sw.WriteLine(poslog);
                sw.Flush();
                sw.Close();
                //onetimepos = GameObject.Find("Cube").transform.position;
                //poslog ={ onetimepos.x.ToString() , onetimepos.y.ToString() , onetimepos.z.ToString() };
                //s2 = string.Join(",", poslog);
                //GameObject.Find("enter").GetComponent<VRUIcontrol>().csvtrigger = 0;
                VRUIenter.GetComponent<VRUIcontrol>().csvtrigger = 0;
            }
            //time1 += Time.deltaTime;
            //savetime += Time.deltaTime;
        }
       
    }
    

    public void CSVstart()
    {
        //if (!saves)
        //{
        //maxhight.ismax = true;
            saves = true;
        //GameObject.Find("CSVStart").GetComponent<Button>().interactable = false;
        //GameObject.Find("CSVStop").GetComponent<Button>().interactable = true;
        PCUIstart.GetComponent<Button>().interactable = true ;

        DataName = dataname.GetComponent<InputField>().text + "000.csv";
            while (true)
            {
                if (File.Exists(DataName))
                {
                    filenum_1++;
                    if (filenum_1 > 9)
                    {
                        filenum_10++;
                        filenum_1 = 0;
                        if (filenum_10 > 9)
                        {
                            filenum_100++;
                            filenum_10 = 0;
                        }
                    }
                    DataName = dataname.GetComponent<InputField>().text;
                    DataName += filenum_100;
                    DataName += filenum_10;
                    DataName += filenum_1;
                    DataName += ".csv";
                }
                else
                {
                    break;
                }
            }
            StreamWriter sw = new StreamWriter(DataName, false);
            // ヘッダー出力
            string[] s1 = { "sence", "vas" };
            string s2 = string.Join(",", s1);
            sw.WriteLine(s2);

            sw.Close();
        //}
        /*else
        {
            saves = false;
            GameObject.Find("CSVStart").GetComponent<Button>().interactable = true;
            GameObject.Find("CSVStop").GetComponent<Button>().interactable = false;
        } */  
    }
}