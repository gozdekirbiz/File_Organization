/*GOZDE KIRBIZ 191180053
  Dear teacher, I tried to make the project with Forms. However, when we generate a large number of keys, the program becomes not responding and uses too much RAM. I think it's because of DataGridView. 
  If we generate around 1-50 keys, program works stable. I hope it doesn't matter too much for grading :( Best regars, Gozde.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOrg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            randomKeys();
            for(int i=0;i<randomArr.Length;i++)
            listBox1.Items.Add(randomArr[i]);
        }
        public int findPrime(int num)
        {
            for (int i = num + 1; ; i++)
            {
                var isPrime = true;
                for (int d = 2; d * d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    return i;
                }
            }
        }
        Random rnd = new Random();
        public int[] randomArr;
        public int numberofkey;
        public void randomKeys()
        {
            numberofkey= int.Parse(txtKeys.Text);
            randomArr = new int[numberofkey];
            for (int i = 0; i < numberofkey; i++)
            {
                int key = rnd.Next(1, 900);
                randomArr[i] = key;
            }
            //checking duplicates
            for (int i = 0; i < numberofkey - 1; i++)
            { 
                for (int j = i + 1; j < numberofkey; j++)
                {
                    if (randomArr[i] == randomArr[j])
                        randomKeys();
                }
            }
        }
        double packing;
        public int packingFactor(int n)
        {
            int prime = findPrime(n);
            packing = (Convert.ToDouble(randomArr.Length)/Convert.ToDouble(prime)) * 100;
            return prime;
        }
        int[,] beisch;
        string[,] bstring;
        int sizeoftable;
        public void Beisch()
        {
            sizeoftable = (int)packingFactor(numberofkey);
            beisch= new int[sizeoftable,3]; //0=index 1=value 2=link
            bstring= new string[sizeoftable, 5];
            bool flag = true;
            for(int i=0;i<sizeoftable;i++)
            {
                bstring[i, 0] = i.ToString();
                beisch[i, 0] = i;
                beisch[i, 2] = -1;
            }
            for (int i = 0; i < randomArr.Length; i++)
            {
                int probe = 1;
                int order = randomArr[i] % sizeoftable; //hash fonks
                if(beisch[order,1]==0)
                {
                    beisch[order,1] = randomArr[i];
                    bstring[order, 3] = probe.ToString();
                }
                else if(flag)
                {
                    int traverse = 0;
                    while (beisch[traverse, 1] != 0)
                    {
                        probe++;
                        traverse++;
                    }
                    beisch[traverse, 1] = randomArr[i]; // put the value on corresponding place
                    bstring[traverse, 3] = probe.ToString();
                    beisch[traverse, 2] = beisch[order, 2]; //new key's link shows actual home address' link
                    beisch[order, 2] = beisch[traverse, 0];
                    flag = false;
                }
                else
                {
                    int traverse = sizeoftable-1;
                    while(beisch[traverse,1]!=0)
                    {
                        probe++;
                        traverse--;
                    }
                    beisch[traverse, 1] = randomArr[i];
                    bstring[traverse, 3] = probe.ToString();
                    beisch[traverse,2] = beisch[order,2];
                    beisch[order,2] = beisch[traverse,0];
                    flag = true;
                }
                searchBEISCH(randomArr[i]);
            }
        }
        public int[,] probeBEISCH(int value)
        {
            int[,] probeinfo = new int[1, 3];
            int pCounter = 1;
            int ind = value % sizeoftable;
            if(beisch[ind, 1] == value)
            {
                probeinfo[0, 0] = ind;
                probeinfo[0, 1] = pCounter;
            }
            else
            {
                while (beisch[ind, 1] != value)
                {
                    ind = beisch[ind, 2];
                    pCounter++;
                    if (ind == -1)
                    {
                        probeinfo[0, 2] = -1;
                        break;
                    }
                    if (pCounter > beisch.GetLength(0))
                    {
                        probeinfo[0, 2] = -1;
                        break;
                    }
                    probeinfo[0, 0] = ind;
                    probeinfo[0, 1] = pCounter;
                }
            }
            
            return probeinfo;
        }
        public void searchBEISCH(int value)
        {
            for (int i=0;i<randomArr.Length;i++)
            {
                int[,] pc = new int[1, 2];
                pc = probeBEISCH(randomArr[i]);
                bstring[pc[0, 0], 4] = pc[0, 1].ToString();
            }
            
        }
        int[,] binarytable;
        string[,] binarystring;
        Queue<Node> bfs = new Queue<Node>();
        public void BinaryTreeMethod()
        {
            binarytable = new int[sizeoftable, 2];
            binarystring = new string[sizeoftable, 3];
            for (int i = 0; i < sizeoftable; i++)
            {
                binarystring[i, 0] = i.ToString();
                binarytable[i, 0] = i;
            }
            for (int i = 0; i < randomArr.Length; i++)
            {
                insert(randomArr[i]);
                searchBinary(randomArr[i]);
            }
        }
        public double averageProbe()
        {
            double average = 0;
            int totalprobe = 0;
            for(int i=0;i<=randomArr.Length;i++)
            {
                totalprobe += Convert.ToInt32(bstring[i, 4]);
            }
            average = Convert.ToDouble(totalprobe) / Convert.ToDouble(randomArr.Length);
            return average;
        }
        public int secondHash (int num)
        {
            return (num / sizeoftable) % sizeoftable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Beisch();
            label3.Text = sizeoftable.ToString();
            for (int i = 0; i < beisch.GetLength(0); i++)
            {
               if (beisch[i, 1] == 0)
                    bstring[i, 1] = "   ";
               else
                    bstring[i, 1] = Convert.ToString(beisch[i, 1]);
               if(beisch[i,2]==-1)
                    bstring[i, 2] = "   ";
               else
                    bstring[i, 2] = Convert.ToString(beisch[i, 2]);
            }
            var rowCount = bstring.GetLength(0);
            var rowLength = bstring.GetLength(1);
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "Index";
            dataGridView1.Columns[1].HeaderCell.Value = "Keys";
            dataGridView1.Columns[2].HeaderCell.Value = "Links";
            dataGridView1.Columns[3].HeaderCell.Value = "# of probes to insert";
            dataGridView1.Columns[4].HeaderCell.Value = "# of probes to find";
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                var row = new DataGridViewRow();
                for (int columnIndex = 0; columnIndex < rowLength; columnIndex++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = bstring[rowIndex, columnIndex]
                    });
                }
                dataGridView1.Rows.Add(row);
            }
           
            label10.Text = averageProbe().ToString("0.##");
            BinaryTreeMethod();
            for (int i = 0; i < binarytable.GetLength(0); i++)
            {
                if (binarytable[i, 1] == 0)
                {
                    binarystring[i, 1] = "   ";
                    binarystring[i, 2] = null;
                }
                else
                    binarystring[i, 1] = Convert.ToString(binarytable[i, 1]);
            }
             var rowCount1 = binarystring.GetLength(0);
             var rowLength1 = binarystring.GetLength(1);
             dataGridView2.ColumnCount = 3;
             dataGridView2.Columns[0].HeaderCell.Value = "Index";
             dataGridView2.Columns[1].HeaderCell.Value = "Keys";
             dataGridView2.Columns[2].HeaderCell.Value = "# of probes to find";
             for (int rowIndex = 0; rowIndex < rowCount1; rowIndex++)
             {
                 var row = new DataGridViewRow();
                 for (int columnIndex = 0; columnIndex < rowLength1; columnIndex++)
                 {
                     row.Cells.Add(new DataGridViewTextBoxCell()
                     {
                         Value = binarystring[rowIndex, columnIndex]
                     });
                 }
                 dataGridView2.Rows.Add(row);
             }
           
            label11.Text=averageProbeBinary().ToString("0.##");
            lblPack.Text = packing.ToString("0.##");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtSearch.Text);
            int[,] pc = new int[1, 2];
            int[,] pc1 = new int[1, 2];
            pc = probeBEISCH(value);
            pc1 = probeBinary(value);
            if (pc[0,2]==-1)
            {
                lblFound.Text = "Not found";
                label5.Visible = false;
                label6.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                lblBEISCHindex.Visible = false;
                lblBinaryTreeindex.Visible = false;
                lblBEISCHP.Visible = false;
                lblBinaryP.Visible = false;
            }
            else
            {
                lblFound.Text = "Key is found";
                label5.Visible = true;
                label6.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                lblBEISCHindex.Visible = true;
                lblBinaryTreeindex.Visible = true;
                lblBEISCHP.Visible = true;
                lblBinaryP.Visible = true;
                lblBEISCHP.Text = pc[0, 1].ToString();
                lblBEISCHindex.Text = pc[0, 0].ToString();
                lblBinaryP.Text = pc1[0, 1].ToString();
                lblBinaryTreeindex.Text = pc1[0, 0].ToString();
            }
        }
        public void insert(int key)
        {
            Node root = new Node();
            root.key = key;
            root.ind = key % sizeoftable;
            root.occupy = binarytable[root.ind, 1];
            if(root.occupy==0) // if there is no occupied value then simply put the key
                binarytable[root.ind, 1] = key;
            else // if some value occupied actual home adress
            {
                bfs.Enqueue(root); //i am using a queue to implement algorithm in breadth first manner
                Node n = new Node();
                while (true)
                {
                    n = bfs.Dequeue(); 
                    n.left = add(n.ind, n, 1); //firstly create left node
                    if (n.left.occupy == 0) //if left node's not occupied put the key in here
                    {
                        n = n.left;
                        break;
                    }
                    bfs.Enqueue(n.left); //if left node is occupied then put that node in the queue 
                    n.right = add(n.ind, n, 0);
                    if (n.right.occupy == 0)
                    {
                        n = n.right;
                        break;
                    }
                    bfs.Enqueue(n.right);
                }
                bfs.Clear(); 
                int temp = n.key; //for shifting the keys
                binarytable[n.ind, 1] = n.key;
                while (n != null)
                {
                    if (temp != n.key)
                    {
                        binarytable[n.ind, 1] = n.key;
                        temp = n.key;
                    }
                    n = n.parent;
                }
            }
        }
        Node add(int i,Node p,int control)
        {
            Node n = new Node();
            n.parent = p;
            if (control==1)
                n.key = p.key;
            else
                n.key = p.occupy;
            int neworder = secondHash(n.key);
            n.ind = (neworder + i) % sizeoftable;
            n.occupy = binarytable[n.ind, 1];
            return n;
        }
        public int[,] probeBinary(int value)
        {
            int[,] probeinfo = new int[1, 3];
            int pCounter = 0;
            int ind = value % sizeoftable;
            int atla = secondHash(value);
            while (binarytable[ind, 1] != 0 && pCounter < sizeoftable)
            {
                 pCounter++;
                 if (binarytable[ind, 1] == value)
                 {
                    probeinfo[0, 0] = ind;
                    probeinfo[0, 1] = pCounter;
                    probeinfo[0, 2] = 1;
                    break;
                 }
                 ind = (ind + atla) % sizeoftable;
            }
            return probeinfo;
        }
        public void searchBinary(int value)
        {
            for (int i = 0; i < randomArr.Length; i++)
            {
                int[,] pc = new int[1, 3];
                pc = probeBinary(randomArr[i]);
                binarystring[pc[0, 0], 2] = pc[0, 1].ToString();
            }
        }
        public double averageProbeBinary()
        {
            double average = 0;
            int totalprobe = 0;
            for (int i = 0; i <=randomArr.Length; i++)
            {
                totalprobe += Convert.ToInt32(binarystring[i, 2]);
            }
            average = Convert.ToDouble(totalprobe) / Convert.ToDouble(randomArr.Length);
            return average;
        }
    }
}
