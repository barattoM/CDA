package com.example.mondeafpa;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.Random;

public class DisplayDeLance extends AppCompatActivity {

    public int face ;
    public Random rand = new Random();
    TextView textView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_de_lance);
        Intent intent = getIntent();
        face =intent.getIntExtra("int_value",0);
        int de = rand.nextInt(face - 1 + 1) + 1;
        TextView phraseDe = findViewById(R.id.phraseDe);
        phraseDe.setText("Pour un dé à "+face+" faces");
        textView = findViewById(R.id.resultatDe);
        textView.setText(Integer.toString(de));
    }

    public void relanceDe(View view){
        int de = rand.nextInt(face - 1 + 1) + 1;
        textView.setText(Integer.toString(de));
    }

}