namespace RecursionProgram.Models
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch(List<Branch> branchList)
        {
            branches = branchList;
        }

        public Branch()
        {

        }
    }
}