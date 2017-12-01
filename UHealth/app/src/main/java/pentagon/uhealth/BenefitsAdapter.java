package pentagon.uhealth;

import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.text.DecimalFormat;
import java.util.List;

import pentagon.uhealth.Model.Benefits;

/**
 * Created by Del Mundo on 1 Dec 2017.
 */

public class BenefitsAdapter extends RecyclerView.Adapter<BenefitsAdapter.MyViewHolder>{
    List<Benefits> benList;

    public class MyViewHolder extends RecyclerView.ViewHolder {
        public TextView type,type2,amount;

        public MyViewHolder(View view) {
            super(view);
            type = (TextView) view.findViewById(R.id.benrow_type);
            type2 = (TextView) view.findViewById(R.id.benrow_type2);
            amount = (TextView) view.findViewById(R.id.benrow_amount);
        }
    }

    public BenefitsAdapter(List<Benefits> benList) {
        this.benList = benList;
    }
    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View itemView = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.benefits_row,parent,false);
        return new MyViewHolder(itemView);
    }

    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        final Benefits benefits = benList.get(position);
        String msg;
        Log.e("BenefitAdapter", benefits.getBenefitsName());
        if(benefits.getBenefitsName().equals("Medical")) {
            msg = "In-Patient Care\nOut-Patient Care";
        } else {
            msg = "Consultation\nOral prophylaxis";
        }
        holder.type.setText(benefits.getBenefitsName());
        holder.type2.setText(msg);
        holder.amount.setText(String.format("Php %s", convertNumber(benefits.getAmountCovered().toString())));
    }

    @Override
    public int getItemCount() {
        return benList.size();
    }

    private String convertNumber(String num) {
        double amount = Double.parseDouble(num);
        DecimalFormat formatter = new DecimalFormat("#,###.00");

        return formatter.format(amount);
    }
}
