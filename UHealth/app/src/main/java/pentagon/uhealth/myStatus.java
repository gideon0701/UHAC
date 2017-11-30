package pentagon.uhealth;

import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.ListFragment;
import android.support.v4.widget.TextViewCompat;
import android.support.v7.widget.DefaultItemAnimator;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;

import pentagon.uhealth.Model.Employee;
import pentagon.uhealth.Model.Requirements;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;


public class myStatus extends Fragment {

    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    private String mParam1;

    private Employee employee;
    private List<Requirements> rqmntsList;

    RecyclerView recyclerView;
    RequirementsAdapter requirementsAdapter;
    RecyclerView.LayoutManager layoutManager;

    public myStatus() {
        // Required empty public constructor
    }

    public static myStatus newInstance(Employee param1) {
        myStatus fragment = new myStatus();
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
        View view = inflater.inflate(R.layout.fragment_my_status,container,false);
        employee = (Employee) getArguments().getSerializable("Employee");
        TextView empName = (TextView) view.findViewById(R.id.myStats_name);
        TextView HMO_id = (TextView) view.findViewById(R.id.myStat_HMOid);
        TextView empID = (TextView) view.findViewById(R.id.myStats_empID);
        TextView provider = (TextView) view.findViewById(R.id.myStats_provider);
        TextView cardStatus = (TextView) view.findViewById(R.id.myStats_status);
        TextView coverage = (TextView) view.findViewById(R.id.myStatus_coverage);
        recyclerView = (RecyclerView) view.findViewById(R.id.rv);
        Log.e("FRAGMENT","IM HERE");

        empName.setText(employee.getName());
        HMO_id.setText(String.format("Hospital ID: %s", employee.getHMO_id()));
        empID.setText(String.format("Your ID: %d",  employee.getId()));
        provider.setText(String.format("Health Provider: %s", employee.getHealthProvider()));
        cardStatus.setText(String.format("HealthCard Status: %s", employee.getCardStatus()));
        coverage.setText(String.format("Card Coverage: %s", employee.getCardBenefits()));

        RestService rs = new RestService();
        rqmntsList = new ArrayList<>();

        layoutManager = new LinearLayoutManager(getActivity());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setItemAnimator(new DefaultItemAnimator());

        requirementsAdapter = new RequirementsAdapter(rqmntsList);
        recyclerView.setAdapter(requirementsAdapter);

        rs.getService().getMyRequirements(employee.getId(), new Callback<String>() {
            @Override
            public void success(String s, Response response) {
                Log.e("success", "" + s);
                try {

                    JSONArray jsnArr = new JSONArray(s);
                    Log.e("JSON Array: ", "" + jsnArr.length());
                    for (int i = 0; i < jsnArr.length(); i++) {
                        JSONObject jsnObj = jsnArr.getJSONObject(i);
                        Requirements rqmnts = new Requirements();
                        rqmnts.setDocument_label(jsnObj.getString("documentLabel"));
                        rqmnts.setIsRecieved(jsnObj.getInt("is_received"));

                        rqmntsList.add(rqmnts);
                    }

                    requirementsAdapter.notifyDataSetChanged();
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
