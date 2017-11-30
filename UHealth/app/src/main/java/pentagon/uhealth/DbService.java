package pentagon.uhealth;

import pentagon.uhealth.Model.Employee;
import retrofit.Callback;
import retrofit.http.Body;
import retrofit.http.Field;
import retrofit.http.GET;
import retrofit.http.POST;
import retrofit.http.PUT;
import retrofit.http.Query;

/**
 * Created by Del Mundo on 25 Nov 2017.
 */

public interface DbService {

    //i.e. http://localhost/api/institute/Students
    //Add student record and post content in HTTP request BODY
    @POST("/Home/login")
    public void goLogin(@Query("email") String email,@Query("password") String password, Callback<String> callback);

    @GET("/Home/getMyRequirements")
    public void getMyRequirements(@Query("id") Integer id, Callback<String> callback);

    @GET("/Home/getAllHospital")
    public  void getAllHospital(@Query("provider") String providerName, Callback<String> callback );

    @GET("/Home/getAllDoctors")
    public void getAllDoctor(@Query("hospitalID") Integer hospitalID, Callback<String> callback);
}
