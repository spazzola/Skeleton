using System;

public class clsAccount
{
    private int id;
    private string u_name;
    private string pass;
    private bool exist;
    private DateTime acc_created;

    public clsAccount()
    {
        id = 1;
        u_name = "";
        pass = "";
        exist = true;
        acc_created = new DateTime();
    }

}