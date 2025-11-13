
using System.Text;

string GetBitRepresentation(int i, int bitCount = 8)
{
    StringBuilder sb = new();
    for (int shift = bitCount - 1; shift >= 0; shift--)
    {
        sb.Append(((i & (1 << shift)) != 0) ? '1' : '0');
    }
    return sb.ToString();
}

StringBuilder sb = new();
for (int i = 0; i < 100; i++)
{

    sb.AppendLine($"{GetBitRepresentation(i)}\t---{i}\t---{i % 3} \t ---- {i % 3 == 1}");
}

File.WriteAllText(@"OUTPUT_PATH/Output.txt", sb.ToString());
