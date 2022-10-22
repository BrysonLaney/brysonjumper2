class wordclass{
    private Random crazy = new Random();
    private List<string> listofwords = new List<string>();
    private List<char> listofguess = new List<char>();
    private List<char> hidden = new List<char>();
    private List<char> splitword = new List<char>();
    private string word;
    public void setgame(){
        listofwords.Add("franke");
        listofwords.Add("joe");
        listofwords.Add("harold");
        word = listofwords[crazy.Next(0, 2)];
        for(int i = 0; i < word.Length; i++){
            hidden.Add('_');
            splitword.Add(word[i]);
        }
    }
    public string getword(){
        return word;
    }
    public bool getguess(char guess){
        
        listofguess.Add(guess);
        if(splitword.IndexOf(guess) != -1){
            return true;
        }
        return false;
    }
    public string hiddenword(){
        string hiddenword = "";
        for(int i = 0; i <word.Length; i++){
            if(listofguess.IndexOf(splitword[i]) != -1){
                hiddenword += splitword[i];
            }
            else{
                hiddenword += "_";
            }
            if(hiddenword == word){
                return word;
            }
        }
        return hiddenword;
    }
}