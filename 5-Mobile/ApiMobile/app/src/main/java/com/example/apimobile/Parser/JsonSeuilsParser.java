package com.example.apimobile.Parser;

import android.util.Log;

import com.example.apimobile.Models.Seuils;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

public class JsonSeuilsParser {
    public static List parseSeuils(String json) throws JSONException{
        List seuils = new ArrayList();
        try {
            JSONArray jObj = new JSONArray(json);

            Log.d("TESTJSON", "parseSeuils: "+jObj);
            for(int i=0;i<jObj.length();i++){
                Seuils seuil = new Seuils();
                Log.d("TESTJSON", "parseSeuils: "+jObj.get(i));
                seuil.setSeuilBas(((JSONObject)jObj.get(i)).getDouble("seuilBas"));
                seuil.setSeuilHaut(((JSONObject)jObj.get(i)).getDouble("seuilHaut"));
                //seuil.setDateSeuil(jObj.getString("dateSeuil"));
                seuil.setTemps(((JSONObject)jObj.get(i)).getInt("temps"));
                seuils.add(seuil);
            }
            //Log.d("TESTJSON2", "parseSeuils: "+seuils);
        }
        catch (Exception e){}
        return seuils;
    }
}
