package com.amoeba.scheduler;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ImageView;

public class FirstScreen extends Activity {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        ImageView image = (ImageView) findViewById(R.drawable.ic_launcher);
        
    }
}