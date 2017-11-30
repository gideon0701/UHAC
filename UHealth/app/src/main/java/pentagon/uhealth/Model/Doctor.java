package pentagon.uhealth.Model;

/**
 * Created by Del Mundo on 30 Nov 2017.
 */

public class Doctor {

    private Integer doctorID;
    private  String doctorsName;
    private String specialization;

    public Doctor() {

    }

    public Doctor(Integer doctorID, String doctorsName, String specialization) {
        this.doctorID = doctorID;
        this.doctorsName = doctorsName;
        this.specialization = specialization;
    }

    public Integer getDoctorID() {
        return doctorID;
    }

    public void setDoctorID(Integer doctorID) {
        this.doctorID = doctorID;
    }

    public String getDoctorsName() {
        return doctorsName;
    }

    public void setDoctorsName(String doctorsName) {
        this.doctorsName = doctorsName;
    }

    public String getSpecialization() {
        return specialization;
    }

    public void setSpecialization(String specialization) {
        this.specialization = specialization;
    }
}
