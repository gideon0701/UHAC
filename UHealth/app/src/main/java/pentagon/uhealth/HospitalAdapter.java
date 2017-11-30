package pentagon.uhealth;

import android.support.v7.app.AlertDialog;
import android.support.v7.widget.ButtonBarLayout;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.List;

import pentagon.uhealth.Model.Hospital;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

/**
 * Created by Del Mundo on 30 Nov 2017.
 */

public class HospitalAdapter extends RecyclerView.Adapter<HospitalAdapter.MyViewHolder>{

    private List<Hospital> hospitalList;

    public class MyViewHolder extends RecyclerView.ViewHolder {
        public TextView hospitalName,hospitalAddress;
        public Button showDoctors;

        public MyViewHolder(View view) {
            super(view);
            hospitalName = (TextView) view.findViewById(R.id.hosp_name);
            hospitalAddress = (TextView) view.findViewById(R.id.hosp_address);
            showDoctors = (Button) view.findViewById(R.id.hosp_show);
        }

    }

    public  HospitalAdapter(List<Hospital> hospitalList) {
        this.hospitalList = hospitalList;
    }

    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View itemView = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.hospital_row,parent,false);
        return new MyViewHolder(itemView);
    }

    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        final Hospital hospital = hospitalList.get(position);
        final RestService rs = new RestService();

        holder.hospitalName.setText(hospital.getHospitalName());
        holder.hospitalAddress.setText(String.format("Address: %s", hospital.getHospitalAddress()));
        holder.showDoctors.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final View myView = view;
                rs.getService().getAllDoctor(hospital.getHospitalID(), new Callback<String>() {
                    @Override
                    public void success(String s, Response response) {
                        AlertDialog.Builder builder = new AlertDialog.Builder(myView.getContext());
                        builder.setCancelable(true);
                        builder.setTitle("Accredited Doctors");
                        StringBuilder sb = new StringBuilder();
                        try {
                            JSONArray jsnArr = new JSONArray(s);
                            for(int i = 0; i < jsnArr.length(); i++) {
                                JSONObject jsnObj = jsnArr.getJSONObject(i);
                                sb.append(i+1 + ". " + jsnObj.getString("doctorsName"));
                                sb.append("\n");
                                sb.append("Specialization: " + jsnObj.getString("specialization"));
                                sb.append("\n\n");
                            }
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                        builder.setMessage(sb.toString());
                        builder.show();
                    }

                    @Override
                    public void failure(RetrofitError error) {

                    }
                });
            }
        });

    }

    @Override
    public int getItemCount() {
        return hospitalList.size();
    }
}
