package com.example.listview;

public class UserAccount {
    private String userName;
    private String userType;
    private Boolean active;

    @Override public String toString(){
        return this.userName+"("+this.userType+")";
    }

    public UserAccount(String username,String userType){
        this.userName=username;
        this.userType=userType;
        this.active=true;
    }

    public UserAccount(String username,String userType,Boolean active){
        this.userName=username;
        this.userType=userType;
        this.active=active;
    }

    public Boolean isActive(){
        return this.active;
    }

    public String getUserName() {
        return this.userName;
    }

    public String getUserType() {
        return this.userType;
    }

    public Boolean getActive() {
        return this.active;
    }
}
