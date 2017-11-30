package pentagon.uhealth;

import android.graphics.drawable.Drawable;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.List;

import pentagon.uhealth.Model.Requirements;

/**
 * Created by Del Mundo on 26 Nov 2017.
 */

public class RequirementsAdapter extends RecyclerView.Adapter<RequirementsAdapter.MyViewHolder> {

    private List<Requirements> requiremntsList;


    public class MyViewHolder extends RecyclerView.ViewHolder {
        public TextView document_label;
        public ImageView status;

        public MyViewHolder(View view) {
            super(view);
            document_label = (TextView) view.findViewById(R.id.req_document);
            status = (ImageView) view.findViewById(R.id.req_status);

        }
    }

    public RequirementsAdapter(List<Requirements> requirementsList) {
        this.requiremntsList = requirementsList;
    }


    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View itemView = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.requirements_row,parent,false);
        return new MyViewHolder(itemView);
    }

    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {

        Requirements requirements = requiremntsList.get(position);
        holder.document_label.setText(requirements.getDocument_label());
        if (requirements.getIsRecieved() == 0) {
            holder.status.setImageResource(android.R.drawable.checkbox_off_background);
        }else {
            holder.status.setImageResource(android.R.drawable.checkbox_on_background);
        }

    }

    @Override
    public int getItemCount() {
        return requiremntsList.size();
    }



}
