package com.example.exercice1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Hashtable;

public class MainActivity extends AppCompatActivity {


    private EditText prenom1;
    private EditText prenom2;
    private TextView reponse;
    private Hashtable alphabet;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        prenom1 = (EditText) findViewById(R.id.Prenom1);
        prenom2 = (EditText) findViewById(R.id.Prenom2);
        reponse = (TextView) findViewById(R.id.reponse);
        alphabet = new Hashtable();
        alphabet.put("a", new Integer(1));
        alphabet.put("b", new Integer(2));
        alphabet.put("c", new Integer(3));
    }

    public void calcul(View view){
        Integer test =(Integer)alphabet.get("a");
        reponse.setText(test);
    }
}