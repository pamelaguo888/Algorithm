class DeliveryPlan
    {
        static void Main(string[] args)
        {

            List<List<int>> foregroundAppList = new List<List<int>>();
            foregroundAppList.Add(new List<int>(new int[] { 1, 2 }));
            foregroundAppList.Add(new List<int>(new int[] { 2, 4 }));
            foregroundAppList.Add(new List<int>(new int[] { 3, 6 }));

            List<List<int>> backgroundAppList = new List<List<int>>();
            backgroundAppList.Add(new List<int>(new int[] { 1, 2 }));
            backgroundAppList.Add(new List<int>(new int[] { 2, 3 }));
            backgroundAppList.Add(new List<int>(new int[] { 3, 1 }));
            backgroundAppList.Add(new List<int>(new int[] { 4, 1 }));

            optimalUtilization(7, foregroundAppList, backgroundAppList);
        }
        public static List<List<int>> optimalUtilization(int deviceCapacity,
                                             List<List<int>> foregroundAppList,
                                             List<List<int>> backgroundAppList)
        {
            // WRITE YOUR CODE HERE
            int max = 0;
            List<List<int>> res = new List<List<int>>();
            foreach(List<int> fapp in foregroundAppList)
            {            
                foreach(List<int> bapp in backgroundAppList)
                {
                    int sum = fapp[1] + bapp[1];
                    if (sum <= deviceCapacity && sum >= max)
                    {
                        if(sum > max)
                            res.Clear();
                        res.Add(new List<int>(new int[] { fapp[0], bapp[0] }));
                        max = Math.Max(sum, max);
                    }
                }
            }

            return res;
        }
    }