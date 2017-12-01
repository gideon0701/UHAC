package pentagon.uhealth;

import pentagon.uhealth.Model.Employee;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import org.json.JSONException;
import org.json.JSONObject;

public class LoginActivity extends AppCompatActivity {
    EditText edit_email,edit_password;
    Button btn_login;
    Employee employee;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        edit_email = (EditText) findViewById(R.id.editText_Email);
        edit_password = (EditText) findViewById(R.id.editText_Password);
        btn_login = (Button) findViewById(R.id.btn_login);


        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                btn_login.setBackgroundResource(R.drawable.loggin_icon);
                btn_login.setEnabled(false);

                RestService rs = new RestService();
                final Employee emp = new Employee();
                String email = edit_email.getText().toString().trim();
                String password = edit_password.getText().toString().trim();
                rs.getService().goLogin(email,password,new Callback<String>() {
                    @Override
                    public void success(String s, Response response) {

                        Log.e("success", "" + s);
                        if (!s.equals("wrong")) {
                            try {
                                JSONObject jsnObjc = new JSONObject(s);
                                emp.setId(jsnObjc.getInt("id"));
                                emp.setName(jsnObjc.getString("name"));
                                emp.setHMO_id(jsnObjc.getString("HMO_id"));
                                emp.setPosition(jsnObjc.getString("position"));
                                emp.setDepartment(jsnObjc.getString("department"));
                                emp.setEmail(jsnObjc.getString("email"));
                                emp.setHealthProvider(jsnObjc.getString("healthProvider"));
                                emp.setCardStatus(jsnObjc.getString("hmoStatus"));
                                emp.setCardBenefits(jsnObjc.getString("hmoBenefits"));
                                emp.setMaximumAmount(jsnObjc.getInt("maximumAmount"));
                                emp.setAmountLeft(jsnObjc.getInt("amountLeft"));

                                Log.e("NAME", "" + emp.getName());
                                Toast.makeText(LoginActivity.this, "Welcome " + emp.getName(), Toast.LENGTH_LONG).show();

                                Intent i = new Intent(getApplicationContext(), MainActivity.class);
                                i.putExtra("Employee",emp);
                                startActivity(i);
                                finish();
                            } catch (JSONException e) {
                                e.printStackTrace();
                                Log.e("FAILED JSON", "FAILEEED");

                            }
                        }else {
                            btn_login.setBackgroundResource(R.drawable.login_icon);
                            btn_login.setEnabled(true);
                            edit_password.setText("");
                            edit_password.setFocusable(true);
                            Toast.makeText(LoginActivity.this,  "Incorrect Email or Password", Toast.LENGTH_SHORT).show();
                        }
                    }

                    @Override
                    public void failure(RetrofitError error) {
                        Log.e("error", "" + error);
                        btn_login.setBackgroundResource(R.drawable.login_icon);
                        btn_login.setEnabled(true);
                        Toast.makeText(LoginActivity.this,"There is a problem on your network", Toast.LENGTH_LONG).show();
                    }
                });
            }
        });

    }


}
