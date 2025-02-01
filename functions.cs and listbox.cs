Paste in Functions.cs:

public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

(everything after this will be pasted in Form1.cs)

Refresh button Code:

listBox1.Items.Clear();//If i am right, Supported files are .txt and .lua
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");

Listbox Code:

richTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");