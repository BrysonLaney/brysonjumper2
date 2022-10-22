class game{
    new wordclass jumpergame = new wordclass();
    new jumper dave = new jumper();
    public void gamerun(){
        bool run = true;
        jumpergame.setgame();
        dave.createJumper();
        while(run){
            
            dave.printjumper();
            Console.WriteLine("Guess a letter [A-Z]: ");
            if(jumpergame.getguess(Console.ReadKey().KeyChar)){
                if(jumpergame.hiddenword() == jumpergame.getword()){
                    Console.WriteLine("You win!");
                    run = false;
                }
                dave.printjumper();
                Console.WriteLine(jumpergame.hiddenword());
            }
            else{
                dave.removerow();
                dave.printjumper();
                if (dave.getrowcount() == 7) {
                    dave.printjumperdead();
                    run = false;
                }
            }

        }
    }
}