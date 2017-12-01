package pentagon.uhealth;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v4.app.FragmentManager;
import android.support.v7.app.AlertDialog;
import android.util.Log;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;

import pentagon.uhealth.Model.Employee;

public class MainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    Employee employee;

    myStatus myStatusFragment;
    HospitalFragment myHospitalFragment;
    BenefitsFragment myBenefitFragment;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
        Intent i = getIntent();
        employee = (Employee) i.getSerializableExtra("Employee");
        Log.e("MainActivity", employee.getName());

        myStatusFragment = new myStatus().newInstance(employee);
        myHospitalFragment = new HospitalFragment().newInstance(employee);
        myBenefitFragment = new BenefitsFragment().newInstance(employee);


        navigationView.getMenu().performIdentifierAction(R.id.myStatus,0);
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            moveTaskToBack(true);
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_logout) {
            Intent i = new Intent(getApplicationContext(), LoginActivity.class);
            startActivity(i);
            finish();
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        if (id == R.id.myStatus) {

            FragmentManager manager = getSupportFragmentManager();
            manager.beginTransaction().replace(
                    R.id.contentmain,
                    myStatusFragment,
                    myStatusFragment.getTag()
            ).commit();
        } else if (id == R.id.myBenefits) {
            if(employee.getCardStatus().equals("Active")) {
                FragmentManager manager = getSupportFragmentManager();
                manager.beginTransaction().replace(
                        R.id.contentmain,
                        myBenefitFragment,
                        myBenefitFragment.getTag()
                ).commit();
            } else {
                showDialog();
            }


        } else if (id == R.id.searchHospital) {
            if(employee.getCardStatus().equals("Active")) {
                FragmentManager manager = getSupportFragmentManager();
                manager.beginTransaction().replace(
                        R.id.contentmain,
                        myHospitalFragment,
                        myHospitalFragment.getTag()
                ).commit();

            } else {
                showDialog();
            }

        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
    public void showDialog() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setCancelable(false);
        builder.setTitle("Warning");
        builder.setMessage("Your Application is still pending, Please check your requirements");
        builder.setPositiveButton("Okay", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });
        builder.show();
    }
}
