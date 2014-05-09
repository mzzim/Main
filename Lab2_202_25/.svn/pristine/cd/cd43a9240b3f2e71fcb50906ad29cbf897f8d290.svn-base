//Lab Title: Pedometer 
//Lab Number: 2
package ca.uwaterloo.Lab2_202_25;

import java.util.Arrays;

import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends Activity {

	//Global Variable Declaration
	LineGraphView graph;
	LinearLayout l1;
	TextView textProgTitle;
	TextView textAcc;
	TextView textStepCount;
	
	//Step Counter Variables
	int intStepCount = 0;
	double accSensorMag = 0;
	boolean stateOne = true; //State 1 is the state when the phone is moving up in the rotational motion
	boolean stateTwo = false; //State 2 is the state when the phone is moving down in the rotational motion
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		//Linear Layout Setup
        l1 = (LinearLayout) findViewById(R.id.l1);
        l1.setOrientation(LinearLayout.VERTICAL);
        
		//Graph Set-up
        graph = new LineGraphView(getApplicationContext(), 100, Arrays.asList("x", "y", "z"));
        l1.addView(graph);
        graph.setVisibility(View.VISIBLE);
        
        //Sensor Manager Initiation
        SensorManager sensorManager = (SensorManager) getSystemService(SENSOR_SERVICE);
		
        //Lab Title:
        textProgTitle = (TextView) findViewById(R.id.labelProgTitle);
        textProgTitle.setText("----------------Lab 2: Pedometer---------------");  
        
        //Linear Accelerometer Sensor Initiation
        Sensor linAccSensor = sensorManager.getDefaultSensor(Sensor.TYPE_LINEAR_ACCELERATION);
        
        textAcc = (TextView) findViewById(R.id.labelAcc);
        
        SensorEventListener la = new LinearAccelerometerSensorEventListener(textAcc);
        sensorManager.registerListener(la, linAccSensor, +SensorManager.SENSOR_DELAY_FASTEST);
        
        //Step Counter Label
        textStepCount = (TextView) findViewById(R.id.labelStepCount);
        
        //---------------------------------
        //Button Creation and Action Layout
        //---------------------------------
        final Button button = (Button) findViewById(R.id.btnReset);
        button.setOnClickListener(new View.OnClickListener() {
        	public void onClick(View v) {
        		//Instantiates the step count value to zero when the button is clicked
        		intStepCount = 0;
        	}
        });
	}
	
	//Linear Accelerometer Sensor Event Listener Class
	class LinearAccelerometerSensorEventListener implements SensorEventListener {
		TextView output;
		
		public LinearAccelerometerSensorEventListener(TextView outputView){
			output = outputView;
		}
		
		public void onAccuracyChanged(Sensor s, int i) {}
		
		public void onSensorChanged(SensorEvent se) {
			if (se.sensor.getType() == Sensor.TYPE_LINEAR_ACCELERATION) {
				textAcc.setText(String.format("Linear Accelerometer X Value: %f\n" +
						"Linear Accelerometer Y Value: %f" +
						"\nLinear Accelerometer Z Value: %f", 
						se.values[0], se.values[1], se.values[2]));
			}
			
			float[] afterLowPass = lowpass(se.values, 0.2f, 1);
			graph.addPoint(afterLowPass);
			
			float zCheckValue = afterLowPass[2];
			accSensorMag = Math.sqrt(afterLowPass[0]*afterLowPass[0] + 
					afterLowPass[1]*afterLowPass[1] + afterLowPass[2]*afterLowPass[2]);
			FiniteStateMachine(zCheckValue, accSensorMag);
		}
	}
	
	//Function for lowpass filter that returns coordinate points that pass through low pass filter
	//Passes in values for sensor to be filtered through lowpass
	//REMOVES NOISE
	float[] lowpass(float[] in, float dt, float RC) {
		float[] out = new float[in.length];
		float a = dt / (dt + RC);
		out[0] = 0;
		
		for(int i = 1; i < in.length; i++) {
			out[i] = a*in[i] + (1-a)*out[i-1];
		}
		
		return out;
	}
	
	//Function for highpass filter that returns coordinate points that pass through high pass filter
	//FOLLOWS THE NOISE (to follow how noise affects the data
	//Not really of use in this code, since we don't want to see how noise affects the value.
	float[] highpass(float[] in, float dt, float RC) {
		float[] out = new float[in.length];
		float a = RC / (dt + RC);
		out[0] = 0;
		
		for(int i = 1; i < in.length; i++) {
			out[i] = a*out[i-1] + a*(in[i] - in[i-1]);
		}
		
		return out;
	}
	
	//Finite State Machine
	public void FiniteStateMachine(float zValue, double accSensorMag) {
		//First State of the Finite State Machine
		//This is the first half of the stage of walking, the forward motion
		//If the acceleration value is above threshold, we change the state values so that we can transition to the next state
		if (stateOne == true && stateTwo == false){
			if(zValue > 0.2f && accSensorMag < 0.3d) {
				stateOne = false;
				stateTwo = true;
			}
		}
		
		//Second State of the Finite State Machine
		//This is the second half of the stage of walking, the reverse hand motion
		//If the acceleration value is below the threshold during the dip down, we change the state values so that we can transition to the next state
		if (stateOne == false && stateTwo == true) {
			if (zValue < -0.2f && accSensorMag < 0.3d) {
				stateOne = true;
				stateTwo = false;
				intStepCount++;
			}
		}
		
		//Shows the incremented/not incremented step counter result in a label
		textStepCount.setText(String.format("Step Count: %d", intStepCount));
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}
