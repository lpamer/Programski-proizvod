using DataAccessLayer.Repositories;
using EntitiesLayer;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class LoginService
    {
        public bool LoginUsernamePassword(string username, string password)
        {
            var employeeRepository = new EmployeeRepository();
            var employee = employeeRepository.GetEmployee(username);

            if(employee != null && employee.password == password)
            {
                return true;
            }
            else { 
                return false; 
            }
            
        }

        public bool AddImageToDatabase(string username, string password, byte[] image)
        {
            var employeeRepository = new EmployeeRepository();
            var employee = employeeRepository.GetEmployee(username);

            if (employee != null && employee.password == password)
            {
                employeeRepository.AddImage(username, image);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginFaceRecognition(string username, byte[] image)
        {
            var employeeRepoistory = new EmployeeRepository();
            var employee = employeeRepoistory.GetEmployee(username);

            if(employee != null)
            {
                var employeeImage = employee.image;

                var matImage1 = Cv2.ImDecode(image, ImreadModes.Color);
                var matImage2 = Cv2.ImDecode(employeeImage, ImreadModes.Color);

                Cv2.CvtColor(matImage1, matImage1, ColorConversionCodes.BGR2GRAY);
                Cv2.CvtColor(matImage2, matImage2, ColorConversionCodes.BGR2GRAY);

                /*HISTOGRAM
                Mat hist1 = new Mat();
                Mat hist2 = new Mat();
                Cv2.CalcHist(new[] { matImage1 }, new int[] { 0 }, null, hist1, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });
                Cv2.CalcHist(new[] { matImage2 }, new int[] { 0 }, null, hist2, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });

                hist1.Normalize(0, hist1.Rows, NormTypes.MinMax);
                hist2.Normalize(0, hist2.Rows, NormTypes.MinMax);

                double histIntersection = Cv2.CompareHist(hist1, hist2, HistCompMethods.Intersect);

                Console.WriteLine($"Histogram Intersection: {histIntersection}");

                double threshold = 100000;
                */

                Mat result = new Mat();
                Cv2.MatchTemplate(matImage1, matImage2, result, TemplateMatchModes.CCoeffNormed);
                Cv2.MinMaxLoc(result, out _, out _, out _, out OpenCvSharp.Point matchLoc);

                
                double tresholdTemplateMatching = 0.6;
                var templateMatchResult = result.Get<float>(matchLoc.Y, matchLoc.X);

                Console.WriteLine($"Template Matching: {templateMatchResult}");


                /*EUCLID
                double euclideanDistance = Cv2.Norm(matImage1, matImage2, NormTypes.L2);

                Console.WriteLine($"Euclidean Distance: {euclideanDistance}");
                */


                if (templateMatchResult > tresholdTemplateMatching)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
