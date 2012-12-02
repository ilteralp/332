package com.amoeba.scheduler;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

public class AppLogo extends Activity {
	/** Called when the activity is first created. */
	@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.app_logo);
        
        Thread thread = new Thread() {
        	public void run() {
        		try {
        			int timer = 0;
        			while(timer < 5000) {
        				sleep(100);
        				timer = timer + 100;
        			}
        			startActivity(new Intent("com.amoeba.scheduler.CLEARSCREEN"));
        		}
        		catch (InterruptedException e) {
					// TODO: handle exception
        			e.printStackTrace();
				}
        		finally {
        			finish();
        		}
        	}
        };
        thread.start();
	}
}