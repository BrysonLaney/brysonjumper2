class jumper{
    private List<string> jumperman = new List<string>();
    public void createJumper(){
        jumperman.Add(" _ _ _ _ _ "); 
        jumperman.Add("");
        jumperman.Add("  ___");
        jumperman.Add(" /   \\");
        jumperman.Add("  ---  ");
        jumperman.Add(" \\   /");
        jumperman.Add("  \\ / ");
        jumperman.Add("    O ");
        jumperman.Add("   /|\\ ");
        jumperman.Add("   / \\");
        jumperman.Add("");
        jumperman.Add("^^^^^^^");
    }
    public void printjumperdead(){
        Console.WriteLine("    x");
        Console.WriteLine("   /|\\ ");
        Console.WriteLine("   / \\");
    }
    public int getrowcount(){
        return jumperman.Count;
    }
    public void printjumper(){
        for(int i = 0; i < jumperman.Count(); i++){
                Console.WriteLine(jumperman[i]);
        }
    }
    public void removerow(){
        jumperman.RemoveAt(2);
    }
}