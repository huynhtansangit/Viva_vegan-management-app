using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp
{
    class ThongBaoDBChange : IDisposable
    {
        private string connectionString = ConnectDataBase.SessionConnect.getStringConnection();
        private string command;
        private Action Act;
        public ThongBaoDBChange(Action obj, string cmd)
        {
            Act = obj;
            command = cmd;
            // Start listening notification

            try
            {
                SqlDependency.Start(connectionString);
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        public void loadData()
        {
            // Connect to DB, create subscriber
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDependency de = new SqlDependency(cmd);

                    // This event will run when receive message from DB
                    de.OnChange += new OnChangeEventHandler(de_OnChange);

                    // Subcriber
                    cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    // Run action that you want to do on changed
                    Act?.Invoke();
                }
                catch (Exception ex)
                {
                    OptimizedPerformance.showSomeThingWentWrong();
                    OptimizedPerformance.log(ex);
                }
            }
        }

        private void de_OnChange(object sender, SqlNotificationEventArgs e)
        {

            try
            {
                SqlDependency de = sender as SqlDependency;
                de.OnChange -= de_OnChange;
                loadData();
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        public void Dispose()
        {
            // Unregister the notification subscription for the current instance.

            try
            {
                SqlDependency.Stop(connectionString);
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
    }
}
