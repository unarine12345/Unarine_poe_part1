using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unarine_poe_part1
{
    public class Program
    {//start of class

        static void Main(string[] args)
        {//start of main method

            //creating instance for the class voice_logo
            //without an object name but a constructor
            new command_logo() { };
            //creating an instance for the class prompt_user
            //with an object name collect_name
            prompt_user collect_name = new prompt_user();
            //calling welcome method
            collect_name.DisplayWelcomeMessage();
            collect_name.asking_name();

            //user and ai chat
            //instance for the class ai_response
            //with an object name chatting chatting
            chats chatting = new chats();

            //get the return name of user
            String name = collect_name.return_name();
            //now starting the chat
            chatting.ai_chats(name);



        }//end of main method

    }// end of class

}//end of name space
