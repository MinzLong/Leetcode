public class Solution
{
    private Dictionary<string, List<char>> map = new Dictionary<string, List<char>>();
    private HashSet<string> bad = new HashSet<string>();

    public bool PyramidTransition(string bottom, IList<string> allowed)
    {
        BuildMap(allowed);
        return Dfs(bottom);
    }

    private void BuildMap(IList<string> allowed)
    {
        foreach (var s in allowed)
        {
            string key = s.Substring(0, 2);
            char top = s[2];

            if (!map.ContainsKey(key))
                map[key] = new List<char>();

            map[key].Add(top);
        }
    }

    private bool Dfs(string row)
    {
        if (row.Length == 1) return true;
        if (bad.Contains(row)) return false;

        var candidates = new List<string>();
        BuildNextRows(row, 0, new StringBuilder(), candidates);

        foreach (var next in candidates)
        {
            if (Dfs(next)) return true;
        }

        bad.Add(row);
        return false;
    }

    private void BuildNextRows(string row, int idx, StringBuilder path, List<string> results)
    {
        if (idx == row.Length - 1)
        {
            results.Add(path.ToString());
            return;
        }

        string key = row.Substring(idx, 2);
        if (!map.ContainsKey(key)) return;

        foreach (char c in map[key])
        {
            path.Append(c);
            BuildNextRows(row, idx + 1, path, results);
            path.Length--;
        }
    }
}