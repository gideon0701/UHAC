package pentagon.uhealth;

/**
 * Created by Del Mundo on 25 Nov 2017.
 */

public class RestService {
    //You need to change the IP if you testing environment is not local machine
    //or you may have different URL than we have here
    private static final String URL = "http://myhealthapi20171125114816.azurewebsites.net/api/";
    private retrofit.RestAdapter restAdapter;
    private DbService apiService;

    public RestService()
    {
        restAdapter = new retrofit.RestAdapter.Builder()
                .setEndpoint(URL)
                .setLogLevel(retrofit.RestAdapter.LogLevel.FULL)
                .build();

        apiService = restAdapter.create(DbService.class);
    }

    public  DbService getService()
    {
        return apiService;
    }
}
