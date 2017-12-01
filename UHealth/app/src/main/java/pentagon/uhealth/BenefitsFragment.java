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
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;

import pentagon.uhealth.Model.Benefits;
import pentagon.uhealth.Model.Employee;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

public class BenefitsFragment extends Fragment {

    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";
    List<Benefits> benList;
    private Employee employee;

    private String mParam1;
    private String mParam2;

    RecyclerView recyclerView;
    TextView Limit, amountLeft;

    BenefitsAdapter benefitsAdapter;
    RecyclerView.LayoutManager layoutManager;
    public BenefitsFragment() {
        // Required empty public constructor
    }

    public static BenefitsFragment newInstance(Employee param1) {
        BenefitsFragment fragment = new BenefitsFragment();
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
        View view = inflater.inflate(R.layout.fragment_benefits,container,false);
        employee = (Employee) getArguments().getSerializable("Employee");

        RestService rs = new RestService();
        benList = new ArrayList<>();

        recyclerView = (RecyclerView) view.findViewById(R.id.ben_rv);
        Limit = (TextView) view.findViewById(R.id.ben_Limit);
        amountLeft = (TextView) view.findViewById(R.id.ben_AmntLeft);
        Log.e("Curency", " " + employee.getMaximumAmount().toString());
        Limit.setText(String.format("Php %s", convertNumber(employee.getMaximumAmount().toString())));
        amountLeft.setText(String.format("Php %s", convertNumber(employee.getAmountLeft().toString())));

        layoutManager = new LinearLayoutManager(getActivity());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setItemAnimator(new DefaultItemAnimator());

        benefitsAdapter = new BenefitsAdapter(benList);
        recyclerView.setAdapter(benefitsAdapter);

        rs.getService().getMyBenefits(Integer.parseInt(employee.getHMO_id()), new Callback<String>() {
            @Override
            public void success(String s, Response response) {
                try {
                    Log.e("Benefits: ", s);
                    JSONArray jsnArr = new JSONArray(s);
                    for (int i = 0; i < jsnArr.length(); i++) {
                        JSONObject jsnObj = jsnArr.getJSONObject(i);
                        Benefits benefits = new Benefits();
                        benefits.setHmoID(jsnObj.getInt("hmoID"));
                        benefits.setBenefitsName(jsnObj.getString("benefitsName"));
                        benefits.setAmountCovered(jsnObj.getInt("amountCovered"));

                        benList.add(benefits);
                    }

                    benefitsAdapter.notifyDataSetChanged();
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }

            @Override
            public void failure(RetrofitError error) {

            }
        });
        return view;
    }

    private String convertNumber(String num) {
        double amount = Double.parseDouble(num);
        DecimalFormat formatter = new DecimalFormat("#,###.00");

        return formatter.format(amount);
    }
}
