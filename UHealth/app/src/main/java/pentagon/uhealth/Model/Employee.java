package pentagon.uhealth.Model;

import java.io.Serializable;

/**
 * Created by Del Mundo on 19 Nov 2017.
 */

public class Employee implements Serializable{

    private int id;
    private String HMO_id;
    private String name;
    private String position;
    private String department;
    private String email;
    private String pwd;
    private String usergroup_id;
    private String Contact;
    private String isMarried;
    private String Dependents;
    private String CardExpirationDate;
    private String healthProvider;
    private String withPayable;
    private String cardStatus;
    private String cardBenefits;
    private Integer maximumAmount;
    private Integer amountLeft;

    public Employee(){

    }


    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getHMO_id() {
        return HMO_id;
    }

    public void setHMO_id(String HMO_id) {
        this.HMO_id = HMO_id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPosition() {
        return position;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }

    public String getUsergroup_id() {
        return usergroup_id;
    }

    public void setUsergroup_id(String usergroup_id) {
        this.usergroup_id = usergroup_id;
    }

    public String getContact() {
        return Contact;
    }

    public void setContact(String contact) {
        Contact = contact;
    }

    public String getIsMarried() {
        return isMarried;
    }

    public void setIsMarried(String isMarried) {
        this.isMarried = isMarried;
    }

    public String getDependents() {
        return Dependents;
    }

    public void setDependents(String dependents) {
        Dependents = dependents;
    }

    public String getCardExpirationDate() {
        return CardExpirationDate;
    }

    public void setCardExpirationDate(String cardExpirationDate) {
        CardExpirationDate = cardExpirationDate;
    }

    public String getHealthProvider() {
        return healthProvider;
    }

    public void setHealthProvider(String healthProvider) {
        this.healthProvider = healthProvider;
    }

    public String getWithPayable() {
        return withPayable;
    }

    public void setWithPayable(String withPayable) {
        this.withPayable = withPayable;
    }

    public String getCardStatus() {
        return cardStatus;
    }

    public void setCardStatus(String cardStatus) {
        this.cardStatus = cardStatus;
    }

    public String getCardBenefits() {
        return cardBenefits;
    }

    public void setCardBenefits(String cardBenefits) {
        this.cardBenefits = cardBenefits;
    }

    public Integer getMaximumAmount() {
        return maximumAmount;
    }

    public void setMaximumAmount(Integer maximumAmount) {
        this.maximumAmount = maximumAmount;
    }

    public Integer getAmountLeft() {
        return amountLeft;
    }

    public void setAmountLeft(Integer amountLeft) {
        this.amountLeft = amountLeft;
    }
}
