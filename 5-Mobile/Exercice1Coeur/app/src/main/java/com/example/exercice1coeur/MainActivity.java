package com.example.exercice1coeur;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Hashtable;
import java.util.Locale;

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
        alphabet.put('a', new Integer(1));
        alphabet.put('b', new Integer(2));
        alphabet.put('c', new Integer(3));
        alphabet.put('d', new Integer(4));
        alphabet.put('e', new Integer(5));
        alphabet.put('f', new Integer(6));
        alphabet.put('g', new Integer(7));
        alphabet.put('h', new Integer(8));
        alphabet.put('i', new Integer(9));
        alphabet.put('j', new Integer(10));
        alphabet.put('k', new Integer(11));
        alphabet.put('l', new Integer(12));
        alphabet.put('m', new Integer(13));
        alphabet.put('n', new Integer(14));
        alphabet.put('o', new Integer(15));
        alphabet.put('p', new Integer(16));
        alphabet.put('q', new Integer(17));
        alphabet.put('r', new Integer(18));
        alphabet.put('s', new Integer(19));
        alphabet.put('t', new Integer(20));
        alphabet.put('u', new Integer(21));
        alphabet.put('v', new Integer(22));
        alphabet.put('w', new Integer(23));
        alphabet.put('x', new Integer(24));
        alphabet.put('y', new Integer(25));
        alphabet.put('z', new Integer(26));
    }

    public void calcul(View view){
        String p1=prenom1.getText().toString();
        String p2=prenom2.getText().toString();
        p1=p1.toLowerCase();
        p2=p2.toLowerCase();
        Integer somme1=0;
        Integer somme2=0;
        for(int i=0;i<p1.length();i++){
            somme1+=(Integer)alphabet.get(p1.charAt(i));
        }
        for(int i=0;i<p2.length();i++){
            somme2+=(Integer)alphabet.get(p2.charAt(i));
        }
        Integer final1= calcul2(somme1);
        Integer final2=calcul2(somme2);
        Log.d("test","aa"+final1);
        Log.d("test","aa"+final2);
        double f1= final1;
        double f2= final2;
        Log.d("test","aa"+f1);
        Log.d("test","aa"+f2);
        double pourcentage =(f1/f2)*100;
        reponse.setText(prenom1.getText().toString()+" "+prenom2.getText().toString()+" , il y a "+Double.toString(pourcentage)+ " % d'amour entre vous");
    }

    public Integer calcul2(Integer nb){
        while(nb>=10){
            String nbString = Integer.toString(nb);
            Integer somme=0;
            for(int i=0;i<nbString.length();i++){
                somme+=Integer.parseInt(String.valueOf(nbString.charAt(i)));
            }
            nb=somme;
        }
        return nb;
    }

}