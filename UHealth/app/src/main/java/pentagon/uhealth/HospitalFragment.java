package pentagon.uhealth;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v7.widget.DefaultItemAnimator;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import pentagon.uhealth.Model.Employee;
import pentagon.uhealth.Model.Hospital;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;


/**
 * A simple {@link Fragment} subclass.
 * Use the {@link HospitalFragment#newInstance} factory method to
 * create an instance of this fragment.
 */
public class HospitalFragment extends Fragment {

    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    private Employee employee;
    private List<Hospital> hospitalList;

    private String mParam1;

    RecyclerView recyclerView;
    HospitalAdapter hospitalAdapter;
    RecyclerView.LayoutManager layoutManager;

    public HospitalFragment() {
        // Required empty public constructor
    }

    public static HospitalFragment newInstance(Employee param1) {
        HospitalFragment fragment = new HospitalFragment();
        Bundle args = new Bundle();
        args.putSerializable("Employee", param1);

        fragment.setArguments(args);
        return fragment;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (getArguments() != null) {
            mParam1 = getArguments().getString(ARG_PARAM1);
        }
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_hospital,container,false);

        RestService rs = new RestService();
        hospitalList = new ArrayList<>();
        employee = (Employee) getArguments().getSerializable("Employee");

        recyclerView = (RecyclerView) view.findViewById(R.id.hospital_rv);

        layoutManager = new LinearLayoutManager(getActivity());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setItemAnimator(new DefaultItemAnimator());

        hospitalAdapter = new HospitalAdapter(hospitalList);
        recyclerView.setAdapter(hospitalAdapter);

        rs.getService().getAllHospital(employee.getHealthProvider(), new Callback<String>() {
            @Override
            public void success(String s, Response response) {
                try {
                    JSONArray jsnArr = new JSONArray(s);
                    Log.e("JSON Array: ", "" + jsnArr.length());
                    for (int i = 0; i < jsnArr.length(); i++) {
                        JSONObject jsnObj = jsnArr.getJSONObject(i);
                        Hospital hospital = new Hospital();
                        hospital.setHospitalID(jsnObj.getInt("hospital_id"));
                        hospital.setHospitalName(jsnObj.getString("hospital_name"));
                        hospital.setHospitalAddress(jsnObj.getString("hospital_address"));

                        hospitalList.add(hospital);
                    }

                    hospitalAdapter.notifyDataSetChanged();
                } catch (JSONException e) {
                    e.printStackTrace();
                    Log.e("Error","JSONARRAY");
                }

            }

            @Override
            public void failure(RetrofitError error) {

            }
        });
        return view;
    }

}
