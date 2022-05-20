package com.example.intent;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity {

    private static final String EXTRA_REPLY = "renvoie";
    private EditText mReply;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);
        Intent intent = getIntent();
        String message = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        TextView textView = findViewById(R.id.text_message);
        textView.setText(message);

        mReply=findViewById(R.id.edit_text_reponse);
    }

    public void returnReply(View view){
        String renvoie=mReply.getText().toString();
        Intent intent= new Intent();
        intent.putExtra(EXTRA_REPLY,renvoie);
        setResult(RESULT_OK,intent);
        finish();
    }

    public static String getExtraReply(){
        return EXTRA_REPLY;
    }

}