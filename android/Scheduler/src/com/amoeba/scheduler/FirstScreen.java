package com.amoeba.scheduler;

import android.app.Activity;
import android.os.Bundle;
//import android.widget.ImageView;

public class FirstScreen extends Activity {
    
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        /** Didn't get the difference between what we have under application tag in the Manifest. */
        //ImageView image = (ImageView) findViewById(R.drawable.ic_launcher);
    }
}