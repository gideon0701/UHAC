package pentagon.uhealth.Model;

/**
 * Created by Del Mundo on 26 Nov 2017.
 */

public class Requirements {

    private Integer employee_id;
    private String document_label;
    private Integer isRecieved;

    public Requirements() {

    }
    public Requirements(Integer employee_id, String document_label, Integer isRecieved) {
        this.employee_id = employee_id;
        this.document_label = document_label;
        this.isRecieved = isRecieved;
    }
    public Integer getEmployee_id() {
        return employee_id;
    }

    public void setEmployee_id(Integer employee_id) {
        this.employee_id = employee_id;
    }

    public String getDocument_label() {
        return document_label;
    }

    public void setDocument_label(String document_label) {
        this.document_label = document_label;
    }

    public Integer getIsRecieved() {
        return isRecieved;
    }

    public void setIsRecieved(Integer isRecieved) {
        this.isRecieved = isRecieved;
    }
}
