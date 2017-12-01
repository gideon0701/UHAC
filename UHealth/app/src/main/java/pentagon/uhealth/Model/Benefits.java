package pentagon.uhealth.Model;

/**
 * Created by Del Mundo on 1 Dec 2017.
 */

public class Benefits {
    private Integer hmoID;
    private String benefitsName;
    private Integer amountCovered;

    public  Benefits() {

    }

    public  Benefits(Integer hmoID, String benefitsName, Integer amountCovered) {

    }

    public Integer getHmoID() {
        return hmoID;
    }

    public void setHmoID(Integer hmoID) {
        this.hmoID = hmoID;
    }

    public String getBenefitsName() {
        return benefitsName;
    }

    public void setBenefitsName(String benefitsName) {
        this.benefitsName = benefitsName;
    }

    public Integer getAmountCovered() {
        return amountCovered;
    }

    public void setAmountCovered(Integer amountCovered) {
        this.amountCovered = amountCovered;
    }
}
