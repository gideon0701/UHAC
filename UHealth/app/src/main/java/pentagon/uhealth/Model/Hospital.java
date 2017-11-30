package pentagon.uhealth.Model;

/**
 * Created by Del Mundo on 19 Nov 2017.
 */

public class Hospital {
    private Integer hospitalID;
    private String healthProvider;
    private String hospitalName;
    private String hospitalAddress;

    public Hospital() {

    }

    public Hospital(Integer hospitalID, String healthProvider, String hospitalName, String hospitalAddress) {
        this.hospitalID = hospitalID;
        this.healthProvider = healthProvider;
        this.hospitalName = hospitalName;
        this.hospitalAddress = hospitalAddress;
    }

    public Integer getHospitalID() {
        return hospitalID;
    }

    public void setHospitalID(Integer hospitalID) {
        this.hospitalID = hospitalID;
    }

    public String getHealthProvider() {
        return healthProvider;
    }

    public void setHealthProvider(String healthProvider) {
        this.healthProvider = healthProvider;
    }

    public String getHospitalName() {
        return hospitalName;
    }

    public void setHospitalName(String hospitalName) {
        this.hospitalName = hospitalName;
    }

    public String getHospitalAddress() {
        return hospitalAddress;
    }

    public void setHospitalAddress(String hospitalAddress) {
        this.hospitalAddress = hospitalAddress;
    }
}